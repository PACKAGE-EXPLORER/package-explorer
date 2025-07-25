﻿/*
Copyright (c) 2018-2023 Festo SE & Co. KG <https://www.festo.com/net/de_de/Forms/web/contact_international>
Author: Michael Hoffmeister

This source code is licensed under the Apache License 2.0 (see LICENSE.txt).

This source code may use other Open Source software components (see LICENSE.txt).
*/
using AdminShellNS;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Extensions
{
    //TODO (jtikekar, 0000-00-00): remove or seperate
    public static class ExtendLangStringSet
    {
        // dead-csharp off
        //public static string GetDefaultString(this List<ILangStringTextType> langStringSet, string defaultLang = null)
        //{
        //    return ExtendLangString.GetDefaultStringGen(langStringSet, defaultLang);
        //// start
        //if (defaultLang == null)
        //    defaultLang = "en"; //Default Lang in old implementation is en

        //string res = null;

        //// search
        //foreach (var langString in langStringSet)
        //    if (langString.Language.Equals(defaultLang, StringComparison.OrdinalIgnoreCase))
        //        res = langString.Text;

        //if (res == null && langStringSet.Count > 0)
        //    res = langStringSet[0].Text;

        //// found?
        //return res;
        //}
        // dead-csharp on
        public static List<T> Create<T>(string language, string text) where T : IAbstractLangString, new()
        {
            return new List<T> { new T { Language = language, Text = text } };
        }

        public static List<ILangStringNameType> CreateLangStringNameType(string language, string text)
        {
            return new List<ILangStringNameType> { new LangStringNameType(language, text) };
        }

        public static List<ILangStringTextType> CreateLangStringTextType(string language, string text)
        {
            return new List<ILangStringTextType> { new LangStringTextType(language, text) };
        }

        public static List<ILangStringPreferredNameTypeIec61360> CreateManyPreferredNamesFromStringArray(string[] s)
        {
            if (s == null)
                return null;
            var r = new List<ILangStringPreferredNameTypeIec61360>();
            var i = 0;
            while ((i + 1) < s.Length)
            {
                r.Add(new LangStringPreferredNameTypeIec61360(s[i], s[i + 1]));
                i += 2;
            }
            return r;
        }
        public static List<ILangStringDefinitionTypeIec61360> CreateManyDefinitionFromStringArray(string[] s)
        {
            if (s == null)
                return null;
            var r = new List<ILangStringDefinitionTypeIec61360>();
            var i = 0;
            while ((i + 1) < s.Length)
            {
                r.Add(new LangStringDefinitionTypeIec61360(s[i], s[i + 1]));
                i += 2;
            }
            return r;
        }

        public static List<ILangStringTextType> Set(this List<ILangStringTextType> lss, string lang, string text)
        {
            foreach (var ls in lss)
                if (ls.Language.Trim().ToLower() == lang?.Trim().ToLower())
                {
                    ls.Text = text;
                    return lss;
                }
            lss.Add(new LangStringTextType(lang, text));
            return lss;
        }

        public static List<ILangStringTextType> ConvertFromV20(
            this List<ILangStringTextType> langStringSet,
            AasxCompatibilityModels.AdminShellV20.LangStringSet sourceLangStrings)
        {

            if (sourceLangStrings.langString != null && sourceLangStrings.langString.Count != 0)
            {
                langStringSet = new List<ILangStringTextType>();
                foreach (var sourceLangString in sourceLangStrings.langString)
                {
                    var langString = new LangStringTextType(sourceLangString.lang, sourceLangString.str);
                    langStringSet.Add(langString);
                }
            }
            return langStringSet;
        }

        /// <summary>
        /// If <c>input</c> has a trailing '@xx' code, the 'xx' will be returned and the
        /// <c>input</c> is shortened. Else: returns <c>null</c>.
        /// </summary>
        public static string GetOneTrailingLanguage(ref string input)
        {
            if (input?.HasContent() != true)
                return null;
            int p = input.LastIndexOf('@');
            if (p < 0 && input.Length <= p + 1)
                return null;
            var res = input.Substring(p+1);
            input = input.Substring(0, p);
            return res;
        }

        public static List<T> Parse<T>(string cell,
            Func<string, string, T> createLs) where T : class
        {
            // access
            if (cell == null || createLs == null)
                return null;

            // iterative approach
            var res = new List<T>();
            while (true)
            {
                // trivial case and finite end
                if (!cell.Contains("@"))
                {
                    if (cell.Trim() != "")
                    {
                        res.Add(createLs(AdminShellUtil.GetDefaultLngIso639(), cell));
                    }
                    break;
                }

                // OK, pick the next couple
                var m = Regex.Match(cell, @"(.*?)@(\w+)", RegexOptions.Singleline);
                if (!m.Success)
                {
                    // take emergency exit?
                    res.Add(createLs("??", cell));
                }

                // use the match and shorten cell ..
                res.Add(createLs(m.Groups[2].ToString(), m.Groups[1].ToString().Trim()));
                cell = cell.Substring(m.Index + m.Length);
            }

            return res;
        }

        public static void Add<T>(this List<T> list, string language, string text) where T : IAbstractLangString
        {
            if (list == null)
            {
                list = new List<T>();
            }
            if (typeof(T).IsAssignableFrom(typeof(ILangStringTextType)))
            {
                (list as List<ILangStringTextType>)
                    .Add(new LangStringTextType(language, text));
            }
            else if (typeof(T).IsAssignableFrom(typeof(ILangStringNameType)))
            {
                (list as List<ILangStringNameType>)
                    .Add(new LangStringNameType(language, text));
            }
            else if (typeof(T).IsAssignableFrom(typeof(ILangStringPreferredNameTypeIec61360)))
            {
                (list as List<ILangStringPreferredNameTypeIec61360>)
                    .Add(new LangStringPreferredNameTypeIec61360(language, text));
            }
            else if (typeof(T).IsAssignableFrom(typeof(ILangStringShortNameTypeIec61360)))
            {
                (list as List<ILangStringShortNameTypeIec61360>)
                    .Add(new LangStringShortNameTypeIec61360(language, text));
            }
            else if (typeof(T).IsAssignableFrom(typeof(ILangStringDefinitionTypeIec61360)))
            {
                (list as List<ILangStringDefinitionTypeIec61360>)
                    .Add(new LangStringDefinitionTypeIec61360(language, text));
            }
        }
    }
}
