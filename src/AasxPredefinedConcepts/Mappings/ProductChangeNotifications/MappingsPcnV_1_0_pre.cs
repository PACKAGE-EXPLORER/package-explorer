﻿/*
Copyright (c) 2018-2023 Festo SE & Co. KG <https://www.festo.com/net/de_de/Forms/web/contact_international>
Author: Michael Hoffmeister

This source code is licensed under the Apache License 2.0 (see LICENSE.txt).

This source code may use other Open Source software components (see LICENSE.txt).
*/

using AasCore.Aas3_0;
using AasxIntegrationBase;
using AasxPredefinedConcepts.AssetInterfacesDescription;
using AdminShellNS;
using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using Aas = AasCore.Aas3_0;

// These classes were serialized by "export predefined concepts"
// and shall allow to automatically de-serialize AAS elements structures
// into C# classes.

namespace AasxPredefinedConcepts.ProductChangeNotifications.V_1_0_pre
{
    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/Record/List/1/0")]
    public class CD_RecordsOfPcn
    {
        [AasConcept(Cd = "0173-10029#01-XFB002#001", Card = AasxPredefinedCardinality.ZeroToMany)]
        public List<CD_Record> Record = new List<CD_Record>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB002#001")]
    public class CD_Record
    {
        [AasConcept(Cd = "0173-10029#01-XFB003#001", Card = AasxPredefinedCardinality.One)]
        public CD_Manufacturer Manufacturer = new CD_Manufacturer();

        [AasConcept(Cd = "0173-10029#02-ABC507#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public string ManufacturerChangeID;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/PcnType/1/0", Card = AasxPredefinedCardinality.One)]
        public string PcnType;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/LifeCycleData/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_LifeCycleData LifeCycleData = null;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ReasonOfChange/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_ReasonsOfChange ReasonsOfChange = null;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ItemCategory/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_ItemCategories ItemCategories = null;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/AffectedPartNumber/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_AffectedPartNumbers AffectedPartNumbers = null;

        [AasConcept(Cd = "0173-1#02-ABF814#002", Card = AasxPredefinedCardinality.ZeroToOne)]
        public List<ILangStringTextType> PcnReasonComment = null;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/PcnChangeInformation/1/0", Card = AasxPredefinedCardinality.One)]
        public CD_PcnChangeInformation PcnChangeInformation = new CD_PcnChangeInformation();

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/AdditionalInformation/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_AdditionalInformations AdditionalInformations = null;

        [AasConcept(Cd = "0173-1#02-ABF816#002", Card = AasxPredefinedCardinality.One)]
        public string DateOfRecord;

        [AasConcept(Cd = "0173-10029#01-XFB006#001", Card = AasxPredefinedCardinality.One)]
        public CD_ItemOfChange ItemOfChange = new CD_ItemOfChange();

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/RecommendedItem/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_RecommendedItems RecommendedItems = null;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB003#001")]
    public class CD_Manufacturer
    {
        [AasConcept(Cd = "0173-1#02-AAO677#003", Card = AasxPredefinedCardinality.One)]
        public List<ILangStringTextType> ManufacturerName = new List<ILangStringTextType>();

        [AasConcept(Cd = "0173-1#02-AAQ832#005", Card = AasxPredefinedCardinality.One)]
        public CD_Address AdressInformation = new CD_Address();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-1#02-AAQ832#005")]
    public class CD_Address
    {

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/LifeCycleData/List/1/0")]
    public class CD_LifeCycleData
    {
        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/LifeCycleData/Milestone/1/0", Card = AasxPredefinedCardinality.ZeroToMany)]
        public List<CD_LifeCycleMilestone> Milestone = new List<CD_LifeCycleMilestone>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/LifeCycleData/Milestone/1/0")]
    public class CD_LifeCycleMilestone
    {
        [AasConcept(Cd = "0173-10029#02-ABC548#001", Card = AasxPredefinedCardinality.One)]
        public string MilestoneClassification;

        [AasConcept(Cd = " 0173-1#02-ABF815#002", Card = AasxPredefinedCardinality.One)]
        public string DateOfValidity;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ReasonOfChange/List/1/0")]
    public class CD_ReasonsOfChange
    {
        [AasConcept(Cd = "0173-10029#01-XFB005#001", Card = AasxPredefinedCardinality.ZeroToMany)]
        public List<CD_ReasonOfChange> ReasonOfChange = new List<CD_ReasonOfChange>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB005#001")]
    public class CD_ReasonOfChange
    {
        [AasConcept(Cd = "0173-1#02-ABF813#002", Card = AasxPredefinedCardinality.One)]
        public string ReasonClassificationSystem;

        [AasConcept(Cd = "0173-1#02-AAR710#002", Card = AasxPredefinedCardinality.ZeroToOne)]
        public string VersionOfClassificationSystem;

        [AasConcept(Cd = "0173-10029#02-ABC727#001", Card = AasxPredefinedCardinality.One)]
        public string ReasonId;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ItemCategory/List/1/0")]
    public class CD_ItemCategories
    {
        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ItemCategory/1/0", Card = AasxPredefinedCardinality.ZeroToMany)]
        public List<CD_ItemCategory> ItemCategory = new List<CD_ItemCategory>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ItemCategory/1/0")]
    public class CD_ItemCategory
    {
        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ItemCategory/ItemClassificationSystem/1/0", Card = AasxPredefinedCardinality.One)]
        public string ItemClassificationSystem;

        [AasConcept(Cd = "0173-1#02-AAR710#002", Card = AasxPredefinedCardinality.ZeroToOne)]
        public string VersionOfClassificationSystem;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ItemCategory/ItemCategory/1/0", Card = AasxPredefinedCardinality.One)]
        public string ItemCategory;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/AffectedPartNumber/List/1/0")]
    public class CD_AffectedPartNumbers
    {
        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/AffectedPartNumber/1/0", Card = AasxPredefinedCardinality.ZeroToMany)]
        public List<string> AffectedPartNumber = new List<string>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/PcnChangeInformation/1/0")]
    public class CD_PcnChangeInformation
    {
        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/PcnChangeInformation/ChangeTitle/1/0",
            Card = AasxPredefinedCardinality.One)]
        public List<ILangStringTextType> ChangeTitle = new List<ILangStringTextType>();

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/PcnChangeInformation/ChangeDetail/1/0",
            Card = AasxPredefinedCardinality.One)]
        public List<ILangStringTextType> ChangeDetail = new List<ILangStringTextType>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/AdditionalInformation/List/1/0")]
    public class CD_AdditionalInformations
    {
        [AasConcept(Cd = "0173-1#01-ADN356#009",
            Card = AasxPredefinedCardinality.ZeroToMany)]
        public List<AasClassMapperFile> AdditionalInformation = new List<AasClassMapperFile>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB006#001")]
    public class CD_ItemOfChange
    {
        [AasConcept(Cd = "0173-1#02-AAU731#001", Card = AasxPredefinedCardinality.One)]
        public List<ILangStringTextType> ManufacturerProductFamily = new List<ILangStringTextType>();

        [AasConcept(Cd = "0173-1#02-AAW338#001", Card = AasxPredefinedCardinality.One)]
        public List<ILangStringTextType> ManufacturerProductDesignation = new List<ILangStringTextType>();

        [AasConcept(Cd = "0173-1#02-AAO227#002", Card = AasxPredefinedCardinality.ZeroToOne)]
        public List<ILangStringTextType> OrderCodeOfManufacturer = null;

        [AasConcept(Cd = "0173-10029#02-ABF978#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public AasClassMapperHintedReference ManufacturerAssetID = null;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ProductClassification/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_ProductClassifications ProductClassifications = null;

        [AasConcept(Cd = "0173-1#02-AAN270#002", Card = AasxPredefinedCardinality.ZeroToOne)]
        public string HardwareVersion;

        [AasConcept(Cd = "0173-1#02-BAF551#003", Card = AasxPredefinedCardinality.ZeroToOne)]
        public uint? RemainingAmountAvailable;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/TechnicalData_Changes/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_TechnicalData_Changes TechnicalData_Changes = null;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/TechnicalData_CurrentState/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_TechnicalData_CurrentState TechnicalData_CurrentState = null;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ProductClassification/List/1/0")]
    public class CD_ProductClassifications
    {
        [AasConcept(Cd = "0173-10029#01-XFB007#001", Card = AasxPredefinedCardinality.ZeroToMany)]
        public List<CD_ProductClassification> ProductClassification = new List<CD_ProductClassification>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB007#001")]
    public class CD_ProductClassification
    {
        [AasConcept(Cd = "0173-1#02-AAR709#002", Card = AasxPredefinedCardinality.One)]
        public string ClassificationSystem;

        [AasConcept(Cd = "0173-1#02-AAR710#002", Card = AasxPredefinedCardinality.One)]
        public string VersionOfClassificationSystem;

        [AasConcept(Cd = "0173-10029#02-ABF979#001", Card = AasxPredefinedCardinality.One)]
        public string ProductClassId;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/TechnicalData_Changes/List/1/0")]
    public class CD_TechnicalData_Changes
    {
        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/TechnicalData_Changes/Change/1/0", Card = AasxPredefinedCardinality.ZeroToMany)]
        public List<CD_SingleChange> SingleChange = new List<CD_SingleChange>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/TechnicalData_Changes/Change/1/0")]
    public class CD_SingleChange
    {
        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/TechnicalData_Changes/Origin_of_Change/1/0", Card = AasxPredefinedCardinality.One)]
        public AasClassMapperHintedReference Origin_of_change = new AasClassMapperHintedReference();

        [AasConcept(Cd = "0173-10029#02-ABC727#001", Card = AasxPredefinedCardinality.One)]
        public string ReasonId;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/TechnicalData_CurrentState/List/1/0")]
    public class CD_TechnicalData_CurrentState
    {
        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/RecommendedItem/List/1/0")]
    public class CD_RecommendedItems
    {
        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/RecommendedItem/1/0", Card = AasxPredefinedCardinality.ZeroToMany)]
        public List<CD_RecommendedItem> RecommendedItem = new List<CD_RecommendedItem>();

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/RecommendedItem/1/0")]
    public class CD_RecommendedItem
    {
        [AasConcept(Cd = "0173-1#02-AAU731#001", Card = AasxPredefinedCardinality.One)]
        public List<ILangStringTextType> ManufacturerProductFamily = new List<ILangStringTextType>();

        [AasConcept(Cd = "0173-1#02-AAW338#001", Card = AasxPredefinedCardinality.One)]
        public List<ILangStringTextType> ManufacturerProductDesignation = new List<ILangStringTextType>();

        [AasConcept(Cd = "0173-1#02-AAO227#002", Card = AasxPredefinedCardinality.ZeroToOne)]
        public List<ILangStringTextType> OrderCodeOfManufacturer = new List<ILangStringTextType>();

        [AasConcept(Cd = "0173-10029#02-ABF978#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public AasClassMapperHintedReference ManufacturerAssetID = null;

        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/ProductClassification/List/1/0", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_ProductClassifications ProductClassifications = null;

        [AasConcept(Cd = "0173-10029#01-XFB008#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_TechnicalData_Fit TechnicalData_Fit = null;

        [AasConcept(Cd = "0173-10029#01-XFB009#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_TechnicalData_Form TechnicalData_Form = null;

        [AasConcept(Cd = "0173-10029#01-XFB010#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_TechnicalData_Function TechnicalData_Function = null;

        [AasConcept(Cd = "0173-10029#01-XFB011#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_TechnicalData_Other TechnicalData_Other = null;

        [AasConcept(Cd = "0173-1#02-AAO280#003", Card = AasxPredefinedCardinality.ZeroToOne)]
        public string Incotermcode;

        [AasConcept(Cd = "0173-10029#02-ABF982#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public int? DeliveryTimeClassOtherRegion;

        [AasConcept(Cd = "0173-10029#02-ABF981#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public int? DeliveryTimeClassSameRegion;

        [AasConcept(Cd = "0173-10029#01-XFB012#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_ConformityDeclarations ConformityDeclarations = null;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB008#001")]
    public class CD_TechnicalData_Fit
    {
        [AasConcept(Cd = "0173-10029#02-ABF980#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public float? TargetEstimate;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB009#001")]
    public class CD_TechnicalData_Form
    {
        [AasConcept(Cd = "0173-10029#02-ABF980#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public float? TargetEstimate;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB010#001")]
    public class CD_TechnicalData_Function
    {
        [AasConcept(Cd = "0173-10029#02-ABF980#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public float? TargetEstimate;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB011#001")]
    public class CD_TechnicalData_Other
    {
        [AasConcept(Cd = "0173-10029#02-ABF980#001", Card = AasxPredefinedCardinality.ZeroToOne)]
        public float? TargetEstimate;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "0173-10029#01-XFB012#001")]
    public class CD_ConformityDeclarations
    {
        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }

    [AasConcept(Cd = "https://admin-shell.io/idta/AssetInterfacesDescription/1/0/Submodel")]
    public class CD_ProductChangeNotifications
    {
        [AasConcept(Cd = "http://admin-shell.io/VDMA/Fluidics/ProductChangeNotification/Record/List/1/0",
            Card = AasxPredefinedCardinality.ZeroToOne)]
        public CD_RecordsOfPcn Records = null;

        // auto-generated informations
        public AasClassMapperInfo __Info__ = null;
    }
}

