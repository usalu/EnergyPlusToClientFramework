namespace BH.oM.Adapters.EnergyPlus.Economics
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
    using BH.oM.Adapters.EnergyPlus.AirflowNetwork;
    using BH.oM.Adapters.EnergyPlus.Coils;
    using BH.oM.Adapters.EnergyPlus.ComplianceObjects;
    using BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers;
    using BH.oM.Adapters.EnergyPlus.Controllers;
    using BH.oM.Adapters.EnergyPlus.Daylighting;
    using BH.oM.Adapters.EnergyPlus.DemandLimitingControls;
    using BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer;
    using BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications;
    using BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS;
    using BH.oM.Adapters.EnergyPlus.EvaporativeCoolers;
    using BH.oM.Adapters.EnergyPlus.ExteriorEquipment;
    using BH.oM.Adapters.EnergyPlus.ExternalInterface;
    using BH.oM.Adapters.EnergyPlus.Fans;
    using BH.oM.Adapters.EnergyPlus.FluidProperties;
    using BH.oM.Adapters.EnergyPlus.GeneralDataEntry;
    using BH.oM.Adapters.EnergyPlus.HeatRecovery;
    using BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers;
    using BH.oM.Adapters.EnergyPlus.HVACDesignObjects;
    using BH.oM.Adapters.EnergyPlus.HVACTemplates;
    using BH.oM.Adapters.EnergyPlus.HybridModel;
    using BH.oM.Adapters.EnergyPlus.InternalGains;
    using BH.oM.Adapters.EnergyPlus.LocationandClimate;
    using BH.oM.Adapters.EnergyPlus.NodeBranchManagement;
    using BH.oM.Adapters.EnergyPlus.NonZoneEquipment;
    using BH.oM.Adapters.EnergyPlus.OperationalFaults;
    using BH.oM.Adapters.EnergyPlus.OutputReporting;
    using BH.oM.Adapters.EnergyPlus.Parametrics;
    using BH.oM.Adapters.EnergyPlus.PerformanceCurves;
    using BH.oM.Adapters.EnergyPlus.PerformanceTables;
    using BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserLoops;
    using BH.oM.Adapters.EnergyPlus.Pumps;
    using BH.oM.Adapters.EnergyPlus.PythonPluginSystem;
    using BH.oM.Adapters.EnergyPlus.Refrigeration;
    using BH.oM.Adapters.EnergyPlus.RoomAirModels;
    using BH.oM.Adapters.EnergyPlus.Schedules;
    using BH.oM.Adapters.EnergyPlus.SetpointManagers;
    using BH.oM.Adapters.EnergyPlus.SimulationParameters;
    using BH.oM.Adapters.EnergyPlus.SolarCollectors;
    using BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements;
    using BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers;
    using BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces;
    using BH.oM.Adapters.EnergyPlus.UnitaryEquipment;
    using BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels;
    using BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment;
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("If CurrencyType is not specified, it will default to USD and produce $ in the rep" +
        "orts.")]
    [JsonObject("CurrencyType")]
    public class CurrencyType : BHoMObject, IEnergyPlusClass
    {
        

[Description("The commonly used three letter currency code for the units of money for the count" +
    "ry or region. Based on ISO 4217 currency codes. Common currency codes are USD fo" +
    "r $ and EUR for Euros.")]
[JsonProperty("monetary_unit")]
public CurrencyType_MonetaryUnit MonetaryUnit { get; set; } = (CurrencyType_MonetaryUnit)Enum.Parse(typeof(CurrencyType_MonetaryUnit), "AFN");
    }
    
    public enum CurrencyType_MonetaryUnit
    {
        
        [JsonProperty("AFN")]
        AFN = 0,
        
        [JsonProperty("ALL")]
        ALL = 1,
        
        [JsonProperty("ANG")]
        ANG = 2,
        
        [JsonProperty("ARS")]
        ARS = 3,
        
        [JsonProperty("AUD")]
        AUD = 4,
        
        [JsonProperty("AWG")]
        AWG = 5,
        
        [JsonProperty("AZN")]
        AZN = 6,
        
        [JsonProperty("BAM")]
        BAM = 7,
        
        [JsonProperty("BBD")]
        BBD = 8,
        
        [JsonProperty("BGN")]
        BGN = 9,
        
        [JsonProperty("BMD")]
        BMD = 10,
        
        [JsonProperty("BND")]
        BND = 11,
        
        [JsonProperty("BOB")]
        BOB = 12,
        
        [JsonProperty("BRL")]
        BRL = 13,
        
        [JsonProperty("BSD")]
        BSD = 14,
        
        [JsonProperty("BWP")]
        BWP = 15,
        
        [JsonProperty("BYR")]
        BYR = 16,
        
        [JsonProperty("BZD")]
        BZD = 17,
        
        [JsonProperty("CAD")]
        CAD = 18,
        
        [JsonProperty("CHF")]
        CHF = 19,
        
        [JsonProperty("CLP")]
        CLP = 20,
        
        [JsonProperty("CNY")]
        CNY = 21,
        
        [JsonProperty("COP")]
        COP = 22,
        
        [JsonProperty("CRC")]
        CRC = 23,
        
        [JsonProperty("CUP")]
        CUP = 24,
        
        [JsonProperty("CZK")]
        CZK = 25,
        
        [JsonProperty("DKK")]
        DKK = 26,
        
        [JsonProperty("DOP")]
        DOP = 27,
        
        [JsonProperty("EEK")]
        EEK = 28,
        
        [JsonProperty("EGP")]
        EGP = 29,
        
        [JsonProperty("EUR")]
        EUR = 30,
        
        [JsonProperty("FJD")]
        FJD = 31,
        
        [JsonProperty("GBP")]
        GBP = 32,
        
        [JsonProperty("GHC")]
        GHC = 33,
        
        [JsonProperty("GIP")]
        GIP = 34,
        
        [JsonProperty("GTQ")]
        GTQ = 35,
        
        [JsonProperty("GYD")]
        GYD = 36,
        
        [JsonProperty("HKD")]
        HKD = 37,
        
        [JsonProperty("HNL")]
        HNL = 38,
        
        [JsonProperty("HRK")]
        HRK = 39,
        
        [JsonProperty("HUF")]
        HUF = 40,
        
        [JsonProperty("IDR")]
        IDR = 41,
        
        [JsonProperty("ILS")]
        ILS = 42,
        
        [JsonProperty("IMP")]
        IMP = 43,
        
        [JsonProperty("INR")]
        INR = 44,
        
        [JsonProperty("IRR")]
        IRR = 45,
        
        [JsonProperty("ISK")]
        ISK = 46,
        
        [JsonProperty("JEP")]
        JEP = 47,
        
        [JsonProperty("JMD")]
        JMD = 48,
        
        [JsonProperty("JPY")]
        JPY = 49,
        
        [JsonProperty("KGS")]
        KGS = 50,
        
        [JsonProperty("KHR")]
        KHR = 51,
        
        [JsonProperty("KPW")]
        KPW = 52,
        
        [JsonProperty("KRW")]
        KRW = 53,
        
        [JsonProperty("KYD")]
        KYD = 54,
        
        [JsonProperty("KZT")]
        KZT = 55,
        
        [JsonProperty("LAK")]
        LAK = 56,
        
        [JsonProperty("LBP")]
        LBP = 57,
        
        [JsonProperty("LKR")]
        LKR = 58,
        
        [JsonProperty("LRD")]
        LRD = 59,
        
        [JsonProperty("LTL")]
        LTL = 60,
        
        [JsonProperty("LVL")]
        LVL = 61,
        
        [JsonProperty("MKD")]
        MKD = 62,
        
        [JsonProperty("MNT")]
        MNT = 63,
        
        [JsonProperty("MUR")]
        MUR = 64,
        
        [JsonProperty("MXN")]
        MXN = 65,
        
        [JsonProperty("MYR")]
        MYR = 66,
        
        [JsonProperty("MZN")]
        MZN = 67,
        
        [JsonProperty("NAD")]
        NAD = 68,
        
        [JsonProperty("NGN")]
        NGN = 69,
        
        [JsonProperty("NIO")]
        NIO = 70,
        
        [JsonProperty("NOK")]
        NOK = 71,
        
        [JsonProperty("NPR")]
        NPR = 72,
        
        [JsonProperty("NZD")]
        NZD = 73,
        
        [JsonProperty("OMR")]
        OMR = 74,
        
        [JsonProperty("PAB")]
        PAB = 75,
        
        [JsonProperty("PEN")]
        PEN = 76,
        
        [JsonProperty("PHP")]
        PHP = 77,
        
        [JsonProperty("PKR")]
        PKR = 78,
        
        [JsonProperty("PLN")]
        PLN = 79,
        
        [JsonProperty("PYG")]
        PYG = 80,
        
        [JsonProperty("QAR")]
        QAR = 81,
        
        [JsonProperty("RON")]
        RON = 82,
        
        [JsonProperty("RSD")]
        RSD = 83,
        
        [JsonProperty("RUB")]
        RUB = 84,
        
        [JsonProperty("SAR")]
        SAR = 85,
        
        [JsonProperty("SBD")]
        SBD = 86,
        
        [JsonProperty("SCR")]
        SCR = 87,
        
        [JsonProperty("SEK")]
        SEK = 88,
        
        [JsonProperty("SGD")]
        SGD = 89,
        
        [JsonProperty("SHP")]
        SHP = 90,
        
        [JsonProperty("SOS")]
        SOS = 91,
        
        [JsonProperty("SRD")]
        SRD = 92,
        
        [JsonProperty("SVC")]
        SVC = 93,
        
        [JsonProperty("SYP")]
        SYP = 94,
        
        [JsonProperty("THB")]
        THB = 95,
        
        [JsonProperty("TRL")]
        TRL = 96,
        
        [JsonProperty("TRY")]
        TRY = 97,
        
        [JsonProperty("TTD")]
        TTD = 98,
        
        [JsonProperty("TVD")]
        TVD = 99,
        
        [JsonProperty("TWD")]
        TWD = 100,
        
        [JsonProperty("UAH")]
        UAH = 101,
        
        [JsonProperty("USD")]
        USD = 102,
        
        [JsonProperty("UYU")]
        UYU = 103,
        
        [JsonProperty("UZS")]
        UZS = 104,
        
        [JsonProperty("VEF")]
        VEF = 105,
        
        [JsonProperty("VND")]
        VND = 106,
        
        [JsonProperty("XCD")]
        XCD = 107,
        
        [JsonProperty("YER")]
        YER = 108,
        
        [JsonProperty("ZAR")]
        ZAR = 109,
        
        [JsonProperty("ZWD")]
        ZWD = 110,
    }
    
    [Description("Used to perform various modifications to the construction costs to arrive at an e" +
        "stimate for total project costs. This object allows extending the line item mode" +
        "l so that the overall costs of the project will reflect various profit and fees." +
        "")]
    [JsonObject("ComponentCost:Adjustments")]
    public class ComponentCost_Adjustments : BHoMObject, IEnergyPlusClass
    {
        

[Description("based on conditioned floor area for cost not accounted for in current line item c" +
    "ost model")]
[JsonProperty("miscellaneous_cost_per_conditioned_area")]
public System.Nullable<float> MiscellaneousCostPerConditionedArea { get; set; } = null;
        

[JsonProperty("design_and_engineering_fees")]
public System.Nullable<float> DesignAndEngineeringFees { get; set; } = null;
        

[JsonProperty("contractor_fee")]
public System.Nullable<float> ContractorFee { get; set; } = null;
        

[JsonProperty("contingency")]
public System.Nullable<float> Contingency { get; set; } = null;
        

[JsonProperty("permits_bonding_and_insurance")]
public System.Nullable<float> PermitsBondingAndInsurance { get; set; } = null;
        

[JsonProperty("commissioning_fee")]
public System.Nullable<float> CommissioningFee { get; set; } = null;
        

[Description("for use with average data in line item and Misc cost models")]
[JsonProperty("regional_adjustment_factor")]
public System.Nullable<float> RegionalAdjustmentFactor { get; set; } = null;
    }
    
    [Description(@"Used to allow comparing the current cost estimate to the results of a previous estimate for a reference building. This object parallels the ComponentCost:Adjustments object but adds a field for entering the cost line item model result for the reference building. The factors entered in this object are applied to the reference building while the factors listed in the ComponentCost:Adjustments object are applied to the current building model cost estimate.")]
    [JsonObject("ComponentCost:Reference")]
    public class ComponentCost_Reference : BHoMObject, IEnergyPlusClass
    {
        

[Description("should be comparable to the components in current line item cost model")]
[JsonProperty("reference_building_line_item_costs")]
public System.Nullable<float> ReferenceBuildingLineItemCosts { get; set; } = null;
        

[Description("based on conditioned floor area for cost not accounted for in reference line item" +
    " costs")]
[JsonProperty("reference_building_miscellaneous_cost_per_conditioned_area")]
public System.Nullable<float> ReferenceBuildingMiscellaneousCostPerConditionedArea { get; set; } = null;
        

[JsonProperty("reference_building_design_and_engineering_fees")]
public System.Nullable<float> ReferenceBuildingDesignAndEngineeringFees { get; set; } = null;
        

[JsonProperty("reference_building_contractor_fee")]
public System.Nullable<float> ReferenceBuildingContractorFee { get; set; } = null;
        

[JsonProperty("reference_building_contingency")]
public System.Nullable<float> ReferenceBuildingContingency { get; set; } = null;
        

[JsonProperty("reference_building_permits_bonding_and_insurance")]
public System.Nullable<float> ReferenceBuildingPermitsBondingAndInsurance { get; set; } = null;
        

[JsonProperty("reference_building_commissioning_fee")]
public System.Nullable<float> ReferenceBuildingCommissioningFee { get; set; } = null;
        

[Description("for use with average data in line item and Misc cost models")]
[JsonProperty("reference_building_regional_adjustment_factor")]
public System.Nullable<float> ReferenceBuildingRegionalAdjustmentFactor { get; set; } = null;
    }
    
    [Description("Each instance of this object creates a cost line item and will contribute to the " +
        "total for a cost estimate.")]
    [JsonObject("ComponentCost:LineItem")]
    public class ComponentCost_LineItem : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("type")]
public string Type { get; set; } = "";
        

[Description("extend choice-keys as Cases are added to code")]
[JsonProperty("line_item_type")]
public ComponentCost_LineItem_LineItemType LineItemType { get; set; } = (ComponentCost_LineItem_LineItemType)Enum.Parse(typeof(ComponentCost_LineItem_LineItemType), "ChillerElectric");
        

[Description("wildcard \"*\" is acceptable for some components")]
[JsonProperty("item_name")]
public string ItemName { get; set; } = "";
        

[Description("not yet used")]
[JsonProperty("object_end_use_key")]
public string ObjectEndUseKey { get; set; } = "";
        

[JsonProperty("cost_per_each")]
public System.Nullable<float> CostPerEach { get; set; } = null;
        

[JsonProperty("cost_per_area")]
public System.Nullable<float> CostPerArea { get; set; } = null;
        

[JsonProperty("cost_per_unit_of_output_capacity")]
public System.Nullable<float> CostPerUnitOfOutputCapacity { get; set; } = null;
        

[Description("The value is per change in COP.")]
[JsonProperty("cost_per_unit_of_output_capacity_per_cop")]
public System.Nullable<float> CostPerUnitOfOutputCapacityPerCop { get; set; } = null;
        

[JsonProperty("cost_per_volume")]
public System.Nullable<float> CostPerVolume { get; set; } = null;
        

[JsonProperty("cost_per_volume_rate")]
public System.Nullable<float> CostPerVolumeRate { get; set; } = null;
        

[Description("as in for use with UA sizing of Coils")]
[JsonProperty("cost_per_energy_per_temperature_difference")]
public System.Nullable<float> CostPerEnergyPerTemperatureDifference { get; set; } = null;
        

[Description("optional for use with Cost per Each and \"General\" object Type")]
[JsonProperty("quantity")]
public System.Nullable<float> Quantity { get; set; } = null;
    }
    
    public enum ComponentCost_LineItem_LineItemType
    {
        
        [JsonProperty("Chiller:Electric")]
        ChillerElectric = 0,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 1,
        
        [JsonProperty("Coil:DX")]
        CoilDX = 2,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 3,
        
        [JsonProperty("Construction")]
        Construction = 4,
        
        [JsonProperty("Daylighting:Controls")]
        DaylightingControls = 5,
        
        [JsonProperty("General")]
        General = 6,
        
        [JsonProperty("Generator:Photovoltaic")]
        GeneratorPhotovoltaic = 7,
        
        [JsonProperty("Lights")]
        Lights = 8,
        
        [JsonProperty("Shading:Zone:Detailed")]
        ShadingZoneDetailed = 9,
    }
    
    [Description(@"Defines the name of a utility cost tariff, the type of tariff, and other details about the overall tariff. Each other object that is part of the tariff model references the tariff name. See UtilityCost:Charge:Simple, UtilityCost:Charge:Block, UtilityCost:Ratchet, UtilityCost:Qualify, UtilityCost:Variable and UtilityCost:Computation objects.")]
    [JsonObject("UtilityCost:Tariff")]
    public class UtilityCost_Tariff : BHoMObject, IEnergyPlusClass
    {
        

[Description("The name of any standard meter or custom meter or but usually set to either Elect" +
    "ricity:Facility or Gas:Facility")]
[JsonProperty("output_meter_name")]
public string OutputMeterName { get; set; } = "";
        

[Description("A choice that allows several different predefined conversion factors to be used; " +
    "otherwise user defined conversion factors are used as defined in the next two fi" +
    "elds. If left blank m3 is used for water meters and kWh are used for all other m" +
    "eters.")]
[JsonProperty("conversion_factor_choice")]
public UtilityCost_Tariff_ConversionFactorChoice ConversionFactorChoice { get; set; } = (UtilityCost_Tariff_ConversionFactorChoice)Enum.Parse(typeof(UtilityCost_Tariff_ConversionFactorChoice), "CCF");
        

[Description(@"Is a multiplier used to convert energy into the units specified by the utility in their tariff. If left blank it defaults to 1 (no conversion). This field should will be used only if Conversion Factor Choice is set to UserDefined. Within EnergyPlus energy always has units of J (joules). For conversion from J to kWh use the value of 0.0000002778. This is also used for all objects that reference the UtilityCost:Tariff.")]
[JsonProperty("energy_conversion_factor")]
public System.Nullable<float> EnergyConversionFactor { get; set; } = null;
        

[Description(@"Is a multiplier used to convert demand into the units specified by the utility in their tariff. If left blank it defaults to 1 (no conversion). This field should will be used only if Conversion Factor Choice is set to UserDefined. Within EnergyPlus demand always has units of J/s (joules/sec) which equivalent to W (watts). For conversion from W to kW use the value of 0.001. This is also used for all objects that reference the UtilityCost:Tariff.")]
[JsonProperty("demand_conversion_factor")]
public System.Nullable<float> DemandConversionFactor { get; set; } = null;
        

[Description(@"The name of the schedule that defines the time-of-use periods that occur each day. The values for the different variables are: 1 for Peak. 2 for Shoulder. 3 for OffPeak. 4 for MidPeak. The following variables are created automatically if these different periods are used in the schedule and include: TotalEnergy, TotalDemand, PeakEnergy, PeakDemand, ShoulderEnergy, ShoulderDemand, OffPeakEnergy, OffPeakDemand, MidPeakEnergy, MidPeakDemand Some special variables are created that include: PeakExceedsOffPeak, OffPeakExceedsPeak, PeakExceedsMidPeak, MidPeakExceedsPeak, PeakExceedsShoulder, ShoulderExceedsPeak, Others include: PeakAndShoulderEnergy, PeakAndShoulderDemand, PeakAndMidPeakEnergy, PeakAndMidPeakDemand, ShoulderAndOffPeakEnergy, ShoulderAndOffPeakDemand, PeakAndOffPeakEnergy, PeakAndOffPeakDemand, RealTimePriceCosts, AboveCustomerBaseCosts, BelowCustomerBaseCosts, AboveCustomerBaseEnergy, BelowCustomerBaseEnergy")]
[JsonProperty("time_of_use_period_schedule_name")]
public string TimeOfUsePeriodScheduleName { get; set; } = "";
        

[Description(@"The name of a schedule that defines the seasons. The schedule values are: 1 for Winter. 2 for Spring. 3 for Summer. 4 for Autumn. Variables are automatically created if a season schedule is used. These variables are set to 1 within the season and 0 for the months that are not in the season. The variables are: IsWinter, IsNotWinter, IsSpring, IsNotSpring, IsSummer, IsNotSummer, IsAutumn, IsNotAutumn.")]
[JsonProperty("season_schedule_name")]
public string SeasonScheduleName { get; set; } = "";
        

[Description(@"The name of the schedule that defines the billing periods of the year. Normally this entry is allowed to default and a schedule will be internally used that has the breaks between billing periods occurring at the same time as the breaks between months i.e. at midnight prior to the first day of the month. If other billing periods are used such as two month cycles or a single bill for an entire season such as some natural gas companies do in the summer then the month schedule may be used to redefine it. Make sure that the month schedule and season schedule are consistent otherwise an error will be issued.")]
[JsonProperty("month_schedule_name")]
public string MonthScheduleName { get; set; } = "";
        

[Description(@"The determination of demand can vary by utility. Some utilities use the peak instantaneous demand measured but most use a fifteen minute average demand or a one hour average demand. Some gas utilities measure demand as the use during the peak day or peak week.")]
[JsonProperty("demand_window_length")]
public UtilityCost_Tariff_DemandWindowLength DemandWindowLength { get; set; } = (UtilityCost_Tariff_DemandWindowLength)Enum.Parse(typeof(UtilityCost_Tariff_DemandWindowLength), "Day");
        

[Description("The fixed monthly service charge that many utilities have. The entry may be numer" +
    "ic and gets added to the ServiceCharges variable or if a variable name is entere" +
    "d here its values for each month are used.")]
[JsonProperty("monthly_charge_or_variable_name")]
public string MonthlyChargeOrVariableName { get; set; } = "";
        

[Description("The minimum total charge for the tariff or if a variable name is entered here its" +
    " values for each month are used.")]
[JsonProperty("minimum_monthly_charge_or_variable_name")]
public string MinimumMonthlyChargeOrVariableName { get; set; } = "";
        

[Description("Used with real time pricing rates. The name of a schedule that contains the cost " +
    "of energy for that particular time period of the year. Real time rates can be mo" +
    "deled using a charge schedule with the actual real time prices entered in the sc" +
    "hedule.")]
[JsonProperty("real_time_pricing_charge_schedule_name")]
public string RealTimePricingChargeScheduleName { get; set; } = "";
        

[Description("Used with real time pricing rates. The name of a schedule that contains the basel" +
    "ine energy use for the customer. Many real time rates apply the charges as a cre" +
    "dit or debit only to the difference between the baseline use and the actual use." +
    "")]
[JsonProperty("customer_baseline_load_schedule_name")]
public string CustomerBaselineLoadScheduleName { get; set; } = "";
        

[Description(@"The group name of the tariff such as distribution transmission supplier etc. If more than one tariff with the same group name is present and qualifies only the lowest cost tariff is used. Usually the group name field is left blank which results in all tariffs using the same meter variable being compared and the lowest cost one being selected.")]
[JsonProperty("group_name")]
public string GroupName { get; set; } = "";
        

[Description(@"Sets whether the tariff is used for buying selling or both to the utility. This should be allowed to default to buyFromUtility unless a power generation system is included in the building that may generate more power than the building needs during the year")]
[JsonProperty("buy_or_sell")]
public UtilityCost_Tariff_BuyOrSell BuyOrSell { get; set; } = (UtilityCost_Tariff_BuyOrSell)Enum.Parse(typeof(UtilityCost_Tariff_BuyOrSell), "BuyFromUtility");
    }
    
    public enum UtilityCost_Tariff_ConversionFactorChoice
    {
        
        [JsonProperty("CCF")]
        CCF = 0,
        
        [JsonProperty("MCF")]
        MCF = 1,
        
        [JsonProperty("MJ")]
        MJ = 2,
        
        [JsonProperty("MMBtu")]
        MMBtu = 3,
        
        [JsonProperty("Therm")]
        Therm = 4,
        
        [JsonProperty("UserDefined")]
        UserDefined = 5,
        
        [JsonProperty("gal")]
        Gal = 6,
        
        [JsonProperty("kBtu")]
        KBtu = 7,
        
        [JsonProperty("kWh")]
        KWh = 8,
        
        [JsonProperty("kgal")]
        Kgal = 9,
        
        [JsonProperty("m3")]
        M3 = 10,
    }
    
    public enum UtilityCost_Tariff_DemandWindowLength
    {
        
        [JsonProperty("Day")]
        Day = 0,
        
        [JsonProperty("FullHour")]
        FullHour = 1,
        
        [JsonProperty("HalfHour")]
        HalfHour = 2,
        
        [JsonProperty("QuarterHour")]
        QuarterHour = 3,
        
        [JsonProperty("Week")]
        Week = 4,
    }
    
    public enum UtilityCost_Tariff_BuyOrSell
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BuyFromUtility")]
        BuyFromUtility = 1,
        
        [JsonProperty("NetMetering")]
        NetMetering = 2,
        
        [JsonProperty("SellToUtility")]
        SellToUtility = 3,
    }
    
    [Description(@"The qualify object allows only tariffs to be selected based on limits which may apply such as maximum or minimum demand requirements. If the results of the simulation fall outside of the range of qualifications, that tariff is still calculated but the ""Qualified"" entry will say ""No"" and the UtilityCost:Qualify that caused its exclusion is shown. Multiple UtilityCost:Qualify objects can appear for the same tariff and they can be based on any variable.")]
    [JsonObject("UtilityCost:Qualify")]
    public class UtilityCost_Qualify : BHoMObject, IEnergyPlusClass
    {
        

[Description("Displayed in the report if the tariff does not qualify")]
[JsonProperty("utility_cost_qualify_name")]
public string UtilityCostQualifyName { get; set; } = "";
        

[Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Quali" +
    "fy.")]
[JsonProperty("tariff_name")]
public string TariffName { get; set; } = "";
        

[Description("The name of the variable used. For energy and demand the automatically created va" +
    "riables totalEnergy and totalDemand should be used respectively.")]
[JsonProperty("variable_name")]
public string VariableName { get; set; } = "";
        

[JsonProperty("qualify_type")]
public UtilityCost_Qualify_QualifyType QualifyType { get; set; } = (UtilityCost_Qualify_QualifyType)Enum.Parse(typeof(UtilityCost_Qualify_QualifyType), "Maximum");
        

[Description(@"The minimum or maximum value for the qualify. If the variable has values that are less than this value when the qualify type is minimum then the tariff may be disqualified. If the variable has values that are greater than this value when the qualify type is maximum then the tariff may be disqualified.")]
[JsonProperty("threshold_value_or_variable_name")]
public string ThresholdValueOrVariableName { get; set; } = "";
        

[Description("If the UtilityCost:Qualify only applies to a season enter the season name. If thi" +
    "s field is left blank it defaults to Annual.")]
[JsonProperty("season")]
public UtilityCost_Qualify_Season Season { get; set; } = (UtilityCost_Qualify_Season)Enum.Parse(typeof(UtilityCost_Qualify_Season), "Annual");
        

[Description(@"Uses the number in Number of Months in one of two different ways depending on the Threshold  Test. If the Threshold Test is set to Count then the qualification is based on the count of the total number of months per year. If the Threshold Test is set to consecutive then the qualification is based on a consecutive number of months.")]
[JsonProperty("threshold_test")]
public UtilityCost_Qualify_ThresholdTest ThresholdTest { get; set; } = (UtilityCost_Qualify_ThresholdTest)Enum.Parse(typeof(UtilityCost_Qualify_ThresholdTest), "Consecutive");
        

[Description(@"A number from 1 to 12. If no value entered 12 is assumed when the qualify type is minimum and 1 when the qualify type is maximum. This is the number of months that the threshold test applies to determine if the rate qualifies or not. If the season is less than 12 months (if it is not annual) then the value is automatically reduced to the number of months of the season.")]
[JsonProperty("number_of_months")]
public System.Nullable<float> NumberOfMonths { get; set; } = null;
    }
    
    public enum UtilityCost_Qualify_QualifyType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Maximum")]
        Maximum = 1,
        
        [JsonProperty("Minimum")]
        Minimum = 2,
    }
    
    public enum UtilityCost_Qualify_Season
    {
        
        [JsonProperty("Annual")]
        Annual = 0,
        
        [JsonProperty("Fall")]
        Fall = 1,
        
        [JsonProperty("Spring")]
        Spring = 2,
        
        [JsonProperty("Summer")]
        Summer = 3,
        
        [JsonProperty("Winter")]
        Winter = 4,
    }
    
    public enum UtilityCost_Qualify_ThresholdTest
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Consecutive")]
        Consecutive = 1,
        
        [JsonProperty("Count")]
        Count = 2,
    }
    
    [Description(@"UtilityCost:Charge:Simple is one of the most often used objects for tariff calculation. It is used to compute energy and demand charges that are very simple. It may also be used for taxes, surcharges and any other charges that occur on a utility bill. Multiple UtilityCost:Charge:Simple objects may be defined for a single tariff and they will be added together.")]
    [JsonObject("UtilityCost:Charge:Simple")]
    public class UtilityCost_Charge_Simple : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Charge Variable Name This is the name associated with the UtilityCost:Charge:Simple object and will appear in the report. In addition the results of the UtilityCost:Charge:Simple calculation are stored in a variable with the same name. That way the results may be used for further calculation. Spaces are not significant in Charge variable names. They are removed during the utility bill calculation process.")]
[JsonProperty("utility_cost_charge_simple_name")]
public string UtilityCostChargeSimpleName { get; set; } = "";
        

[Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Charg" +
    "e:Simple.")]
[JsonProperty("tariff_name")]
public string TariffName { get; set; } = "";
        

[Description(@"The name of the source used by the UtilityCost:Charge:Simple. This is usually the name of the variable holding the energy or demand but may also be the name of any variable including the subtotal or basis if other charges are based on those. Typical values include totalEnergy totalDemand EnergyCharges DemandCharges ServiceCharges Basis Adjustments Surcharges Subtotal Taxes and Total. If it is a time-of-use rate then peakEnergy peakDemand shoulderEnergy shoulderDemand offPeakEnergy offPeakDemand midPeakEnergy and midPeakDemand. In addition see the Tariff Report to see other native variables that may be available. Also you can create additional user defined variables to model complex tariffs.")]
[JsonProperty("source_variable")]
public string SourceVariable { get; set; } = "";
        

[Description("If this is set to annual the calculations are performed for the UtilityCost:Charg" +
    "e:Simple for the entire year (all months) otherwise it is calculated only for th" +
    "ose months in the season defined.")]
[JsonProperty("season")]
public UtilityCost_Charge_Simple_Season Season { get; set; } = (UtilityCost_Charge_Simple_Season)Enum.Parse(typeof(UtilityCost_Charge_Simple_Season), "Annual");
        

[Description("This field shows where the charge should be added. The reason to enter this field" +
    " appropriately is so that the charge gets reported in a reasonable category. The" +
    " charge automatically gets added to the variable that is the category.")]
[JsonProperty("category_variable_name")]
public UtilityCost_Charge_Simple_CategoryVariableName CategoryVariableName { get; set; } = (UtilityCost_Charge_Simple_CategoryVariableName)Enum.Parse(typeof(UtilityCost_Charge_Simple_CategoryVariableName), "Adjustment");
        

[Description(@"This field contains either a single number or the name of a variable. The number is multiplied with all of the energy or demand or other source that is specified in the source field. If a variable is used then the monthly values of the variable are multiplied against the variable specified in the source field. This field makes it easy to include a simple charge without specifying block sizes. This is a good way to include a tax or cost adjustment.")]
[JsonProperty("cost_per_unit_value_or_variable_name")]
public string CostPerUnitValueOrVariableName { get; set; } = "";
    }
    
    public enum UtilityCost_Charge_Simple_Season
    {
        
        [JsonProperty("Annual")]
        Annual = 0,
        
        [JsonProperty("Fall")]
        Fall = 1,
        
        [JsonProperty("Spring")]
        Spring = 2,
        
        [JsonProperty("Summer")]
        Summer = 3,
        
        [JsonProperty("Winter")]
        Winter = 4,
    }
    
    public enum UtilityCost_Charge_Simple_CategoryVariableName
    {
        
        [JsonProperty("Adjustment")]
        Adjustment = 0,
        
        [JsonProperty("Basis")]
        Basis = 1,
        
        [JsonProperty("DemandCharges")]
        DemandCharges = 2,
        
        [JsonProperty("EnergyCharges")]
        EnergyCharges = 3,
        
        [JsonProperty("NotIncluded")]
        NotIncluded = 4,
        
        [JsonProperty("ServiceCharges")]
        ServiceCharges = 5,
        
        [JsonProperty("Subtotal")]
        Subtotal = 6,
        
        [JsonProperty("Surcharge")]
        Surcharge = 7,
        
        [JsonProperty("Taxes")]
        Taxes = 8,
        
        [JsonProperty("Total")]
        Total = 9,
    }
    
    [Description("Used to compute energy and demand charges (or any other charges) that are structu" +
        "red in blocks of charges. Multiple UtilityCost:Charge:Block objects may be defin" +
        "ed for a single tariff and they will be added together.")]
    [JsonObject("UtilityCost:Charge:Block")]
    public class UtilityCost_Charge_Block : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Charge Variable Name This is the name associated with the UtilityCost:Charge:Block object and will appear in the report. In addition the results of the UtilityCost:Charge:Block are stored in a variable with the same name. That way the results may be used for further calculation.")]
[JsonProperty("utility_cost_charge_block_name")]
public string UtilityCostChargeBlockName { get; set; } = "";
        

[Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Charg" +
    "e:Block.")]
[JsonProperty("tariff_name")]
public string TariffName { get; set; } = "";
        

[Description(@"The name of the source used by the UtilityCost:Charge:Block. This is usually the name of the variable holding the energy or demand but may also be the name of any variable including the subtotal or basis if other charges are based on those. Typical values include totalEnergy totalDemand EnergyCharges DemandCharges ServiceCharges Basis Adjustments Surcharges Subtotal Taxes and Total. If it is a time-of-use rate then peakEnergy peakDemand shoulderEnergy shoulderDemand offPeakEnergy offPeakDemand midPeakEnergy and midPeakDemand. In addition see the Tariff Report to see other native variables that may be available. Also you can create additional user defined variables to model complex tariffs.")]
[JsonProperty("source_variable")]
public string SourceVariable { get; set; } = "";
        

[Description("If this is set to annual the calculations are performed for the UtilityCost:Charg" +
    "e:Block for the entire year (all months) otherwise it is calculated only for tho" +
    "se months in the season defined.")]
[JsonProperty("season")]
public UtilityCost_Charge_Block_Season Season { get; set; } = (UtilityCost_Charge_Block_Season)Enum.Parse(typeof(UtilityCost_Charge_Block_Season), "Annual");
        

[Description("This field shows where the charge should be added. The reason to enter this field" +
    " appropriately is so that the charge gets reported in a reasonable category. The" +
    " charge automatically gets added to the variable that is the category.")]
[JsonProperty("category_variable_name")]
public UtilityCost_Charge_Block_CategoryVariableName CategoryVariableName { get; set; } = (UtilityCost_Charge_Block_CategoryVariableName)Enum.Parse(typeof(UtilityCost_Charge_Block_CategoryVariableName), "Adjustment");
        

[Description(@"If the blocks do not use all of the energy or demand from the source some energy and demand remains then the remaining amount should be assigned to a variable. If no variable is assigned and some amount of energy or demand is not used in the block structure a warning will be issued.")]
[JsonProperty("remaining_into_variable")]
public string RemainingIntoVariable { get; set; } = "";
        

[Description(@"The sizes of the blocks are usually used directly but if a value or a variable is entered here the block sizes entered in the rest of the charge are first multiplied by the entered value prior to being used. This is common for rates that are kWh/kW rates and in that case the variable that holds the monthly total electric demand would be entered. If no value is entered a default value of one is assumed so that the block sizes remain exactly as entered. This field is unusual for the EnergyPlus syntax because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_multiplier_value_or_variable_name")]
public string BlockSizeMultiplierValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_1_value_or_variable_name")]
public string BlockSize1ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_1_cost_per_unit_value_or_variable_name")]
public string Block1CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_2_value_or_variable_name")]
public string BlockSize2ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_2_cost_per_unit_value_or_variable_name")]
public string Block2CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_3_value_or_variable_name")]
public string BlockSize3ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_3_cost_per_unit_value_or_variable_name")]
public string Block3CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_4_value_or_variable_name")]
public string BlockSize4ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_4_cost_per_unit_value_or_variable_name")]
public string Block4CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_5_value_or_variable_name")]
public string BlockSize5ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_5_cost_per_unit_value_or_variable_name")]
public string Block5CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_6_value_or_variable_name")]
public string BlockSize6ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_6_cost_per_unit_value_or_variable_name")]
public string Block6CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_7_value_or_variable_name")]
public string BlockSize7ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_7_cost_per_unit_value_or_variable_name")]
public string Block7CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_8_value_or_variable_name")]
public string BlockSize8ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_8_cost_per_unit_value_or_variable_name")]
public string Block8CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_9_value_or_variable_name")]
public string BlockSize9ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_9_cost_per_unit_value_or_variable_name")]
public string Block9CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_10_value_or_variable_name")]
public string BlockSize10ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_10_cost_per_unit_value_or_variable_name")]
public string Block10CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_11_value_or_variable_name")]
public string BlockSize11ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_11_cost_per_unit_value_or_variable_name")]
public string Block11CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_12_value_or_variable_name")]
public string BlockSize12ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_12_cost_per_unit_value_or_variable_name")]
public string Block12CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_13_value_or_variable_name")]
public string BlockSize13ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_13_cost_per_unit_value_or_variable_name")]
public string Block13CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_14_value_or_variable_name")]
public string BlockSize14ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_14_cost_per_unit_value_or_variable_name")]
public string Block14CostPerUnitValueOrVariableName { get; set; } = "";
        

[Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
[JsonProperty("block_size_15_value_or_variable_name")]
public string BlockSize15ValueOrVariableName { get; set; } = "";
        

[Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
    " can be either a number or a name of a variable.")]
[JsonProperty("block_15_cost_per_unit_value_or_variable_name")]
public string Block15CostPerUnitValueOrVariableName { get; set; } = "";
    }
    
    public enum UtilityCost_Charge_Block_Season
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Annual")]
        Annual = 1,
        
        [JsonProperty("Fall")]
        Fall = 2,
        
        [JsonProperty("Spring")]
        Spring = 3,
        
        [JsonProperty("Summer")]
        Summer = 4,
        
        [JsonProperty("Winter")]
        Winter = 5,
    }
    
    public enum UtilityCost_Charge_Block_CategoryVariableName
    {
        
        [JsonProperty("Adjustment")]
        Adjustment = 0,
        
        [JsonProperty("Basis")]
        Basis = 1,
        
        [JsonProperty("DemandCharges")]
        DemandCharges = 2,
        
        [JsonProperty("EnergyCharges")]
        EnergyCharges = 3,
        
        [JsonProperty("NotIncluded")]
        NotIncluded = 4,
        
        [JsonProperty("ServiceCharges")]
        ServiceCharges = 5,
        
        [JsonProperty("Subtotal")]
        Subtotal = 6,
        
        [JsonProperty("Surcharge")]
        Surcharge = 7,
        
        [JsonProperty("Taxes")]
        Taxes = 8,
        
        [JsonProperty("Total")]
        Total = 9,
    }
    
    [Description(@"Allows the modeling of tariffs that include some type of seasonal ratcheting. Ratchets are most common when used with electric demand charges. A ratchet is when a utility requires that the demand charge for a month with a low demand may be increased to be more consistent with a month that set a higher demand charge.")]
    [JsonObject("UtilityCost:Ratchet")]
    public class UtilityCost_Ratchet : BHoMObject, IEnergyPlusClass
    {
        

[Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Ratch" +
    "et.")]
[JsonProperty("tariff_name")]
public string TariffName { get; set; } = "";
        

[Description(@"When the ratcheted value exceeds the baseline value for a month the ratcheted value is used but when the baseline value is greater then the ratcheted value the baseline value is used. Usually the electric demand charge is used. The baseline source variable can be the results of another ratchet object. This allows utility tariffs that have multiple ratchets to be modeled.")]
[JsonProperty("baseline_source_variable")]
public string BaselineSourceVariable { get; set; } = "";
        

[Description(@"The variable that the ratchet is calculated from. It is often but not always the same as the baseline source variable. The ratcheting calculations using offset and multiplier are using the values from the adjustment source variable. If left blank the adjustment source variable is the same as the baseline source variable.")]
[JsonProperty("adjustment_source_variable")]
public string AdjustmentSourceVariable { get; set; } = "";
        

[Description(@"The name of the season that is being examined. The maximum value for all of the months in the named season is what is used with the multiplier and offset. This is most commonly Summer or Annual. When Monthly is used the adjustment source variable is used directly for all months.")]
[JsonProperty("season_from")]
public UtilityCost_Ratchet_SeasonFrom SeasonFrom { get; set; } = (UtilityCost_Ratchet_SeasonFrom)Enum.Parse(typeof(UtilityCost_Ratchet_SeasonFrom), "Annual");
        

[Description(@"The name of the season when the ratchet would be calculated. This is most commonly Winter. The ratchet only is applied to the months in the named season. The resulting variable for months not in the Season To selection will contain the values as appear in the baseline source variable.")]
[JsonProperty("season_to")]
public UtilityCost_Ratchet_SeasonTo SeasonTo { get; set; } = (UtilityCost_Ratchet_SeasonTo)Enum.Parse(typeof(UtilityCost_Ratchet_SeasonTo), "Annual");
        

[Description(@"Often the ratchet has a clause such as ""the current month demand or 90% of the summer month demand"". For this case a value of 0.9 would be entered here as the multiplier. This value may be left blank if no multiplier is needed and a value of one will be used as a default.")]
[JsonProperty("multiplier_value_or_variable_name")]
public string MultiplierValueOrVariableName { get; set; } = "";
        

[Description(@"A less common strategy is to say that the ratchet must be all demand greater than a value in this case an offset that is added to the demand may be entered here. If entered it is common for the offset value to be negative representing that the demand be reduced. If no value is entered it is assumed to be zero and not affect the ratchet.")]
[JsonProperty("offset_value_or_variable_name")]
public string OffsetValueOrVariableName { get; set; } = "";
    }
    
    public enum UtilityCost_Ratchet_SeasonFrom
    {
        
        [JsonProperty("Annual")]
        Annual = 0,
        
        [JsonProperty("Fall")]
        Fall = 1,
        
        [JsonProperty("Monthly")]
        Monthly = 2,
        
        [JsonProperty("Spring")]
        Spring = 3,
        
        [JsonProperty("Summer")]
        Summer = 4,
        
        [JsonProperty("Winter")]
        Winter = 5,
    }
    
    public enum UtilityCost_Ratchet_SeasonTo
    {
        
        [JsonProperty("Annual")]
        Annual = 0,
        
        [JsonProperty("Fall")]
        Fall = 1,
        
        [JsonProperty("Spring")]
        Spring = 2,
        
        [JsonProperty("Summer")]
        Summer = 3,
        
        [JsonProperty("Winter")]
        Winter = 4,
    }
    
    [Description("Allows for the direct entry of monthly values into a utility tariff variable.")]
    [JsonObject("UtilityCost:Variable")]
    public class UtilityCost_Variable : BHoMObject, IEnergyPlusClass
    {
        

[Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Varia" +
    "ble.")]
[JsonProperty("tariff_name")]
public string TariffName { get; set; } = "";
        

[JsonProperty("variable_type")]
public UtilityCost_Variable_VariableType VariableType { get; set; } = (UtilityCost_Variable_VariableType)Enum.Parse(typeof(UtilityCost_Variable_VariableType), "Dimensionless");
        

[JsonProperty("january_value")]
public System.Nullable<float> JanuaryValue { get; set; } = null;
        

[JsonProperty("february_value")]
public System.Nullable<float> FebruaryValue { get; set; } = null;
        

[JsonProperty("march_value")]
public System.Nullable<float> MarchValue { get; set; } = null;
        

[JsonProperty("april_value")]
public System.Nullable<float> AprilValue { get; set; } = null;
        

[JsonProperty("may_value")]
public System.Nullable<float> MayValue { get; set; } = null;
        

[JsonProperty("june_value")]
public System.Nullable<float> JuneValue { get; set; } = null;
        

[JsonProperty("july_value")]
public System.Nullable<float> JulyValue { get; set; } = null;
        

[JsonProperty("august_value")]
public System.Nullable<float> AugustValue { get; set; } = null;
        

[JsonProperty("september_value")]
public System.Nullable<float> SeptemberValue { get; set; } = null;
        

[JsonProperty("october_value")]
public System.Nullable<float> OctoberValue { get; set; } = null;
        

[JsonProperty("november_value")]
public System.Nullable<float> NovemberValue { get; set; } = null;
        

[JsonProperty("december_value")]
public System.Nullable<float> DecemberValue { get; set; } = null;
    }
    
    public enum UtilityCost_Variable_VariableType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Currency")]
        Currency = 1,
        
        [JsonProperty("Demand")]
        Demand = 2,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 3,
        
        [JsonProperty("Energy")]
        Energy = 4,
    }
    
    [Description(@"The object lists a series of computations that are used to perform the utility bill calculation. The object is only used for complex tariffs that cannot be modeled any other way. For most utility tariffs, UtilityCost:Computation is unnecessary and should be avoided. If UtilityCost:Computation is used, it must contain references to all objects involved in the rate in the order that they should be computed.")]
    [JsonObject("UtilityCost:Computation")]
    public class UtilityCost_Computation : BHoMObject, IEnergyPlusClass
    {
        

[Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Varia" +
    "ble.")]
[JsonProperty("tariff_name")]
public string TariffName { get; set; } = "";
        

[Description("Contain a simple language that describes the steps used in the computation proces" +
    "s similar to a programming language.")]
[JsonProperty("compute_step_1")]
public string ComputeStep1 { get; set; } = "";
        

[JsonProperty("compute_step_2")]
public string ComputeStep2 { get; set; } = "";
        

[JsonProperty("compute_step_3")]
public string ComputeStep3 { get; set; } = "";
        

[JsonProperty("compute_step_4")]
public string ComputeStep4 { get; set; } = "";
        

[JsonProperty("compute_step_5")]
public string ComputeStep5 { get; set; } = "";
        

[JsonProperty("compute_step_6")]
public string ComputeStep6 { get; set; } = "";
        

[JsonProperty("compute_step_7")]
public string ComputeStep7 { get; set; } = "";
        

[JsonProperty("compute_step_8")]
public string ComputeStep8 { get; set; } = "";
        

[JsonProperty("compute_step_9")]
public string ComputeStep9 { get; set; } = "";
        

[JsonProperty("compute_step_10")]
public string ComputeStep10 { get; set; } = "";
        

[JsonProperty("compute_step_11")]
public string ComputeStep11 { get; set; } = "";
        

[JsonProperty("compute_step_12")]
public string ComputeStep12 { get; set; } = "";
        

[JsonProperty("compute_step_13")]
public string ComputeStep13 { get; set; } = "";
        

[JsonProperty("compute_step_14")]
public string ComputeStep14 { get; set; } = "";
        

[JsonProperty("compute_step_15")]
public string ComputeStep15 { get; set; } = "";
        

[JsonProperty("compute_step_16")]
public string ComputeStep16 { get; set; } = "";
        

[JsonProperty("compute_step_17")]
public string ComputeStep17 { get; set; } = "";
        

[JsonProperty("compute_step_18")]
public string ComputeStep18 { get; set; } = "";
        

[JsonProperty("compute_step_19")]
public string ComputeStep19 { get; set; } = "";
        

[JsonProperty("compute_step_20")]
public string ComputeStep20 { get; set; } = "";
        

[JsonProperty("compute_step_21")]
public string ComputeStep21 { get; set; } = "";
        

[JsonProperty("compute_step_22")]
public string ComputeStep22 { get; set; } = "";
        

[JsonProperty("compute_step_23")]
public string ComputeStep23 { get; set; } = "";
        

[JsonProperty("compute_step_24")]
public string ComputeStep24 { get; set; } = "";
        

[JsonProperty("compute_step_25")]
public string ComputeStep25 { get; set; } = "";
        

[JsonProperty("compute_step_26")]
public string ComputeStep26 { get; set; } = "";
        

[JsonProperty("compute_step_27")]
public string ComputeStep27 { get; set; } = "";
        

[JsonProperty("compute_step_28")]
public string ComputeStep28 { get; set; } = "";
        

[JsonProperty("compute_step_29")]
public string ComputeStep29 { get; set; } = "";
        

[JsonProperty("compute_step_30")]
public string ComputeStep30 { get; set; } = "";
    }
    
    [Description(@"Provides inputs related to the overall life-cycle analysis. It establishes many of the assumptions used in computing the present value. It is important that when comparing the results of multiple simulations that the fields in the LifeCycleCost:Parameters objects are the same for all the simulations. When this object is present the tabular report file will contain the Life-Cycle Cost Report.")]
    [JsonObject("LifeCycleCost:Parameters")]
    public class LifeCycleCost_Parameters : BHoMObject, IEnergyPlusClass
    {
        

[Description("The field specifies if the discounting of future costs should be computed as occu" +
    "rring at the end of each year or the middle of each year or the beginning of eac" +
    "h year. The most common discounting convention uses the end of each year.")]
[JsonProperty("discounting_convention")]
public LifeCycleCost_Parameters_DiscountingConvention DiscountingConvention { get; set; } = (LifeCycleCost_Parameters_DiscountingConvention)Enum.Parse(typeof(LifeCycleCost_Parameters_DiscountingConvention), "EndOfYear");
        

[Description(@"This field is used to determine if the analysis should use constant dollars or current dollars which is related to how inflation is treated. If ConstantDollar is selected then the Real Discount Rate input is used and it excludes the rate of inflation. If CurrentDollar is selected then the Nominal Discount Rate input is used and it includes the rate of inflation.")]
[JsonProperty("inflation_approach")]
public LifeCycleCost_Parameters_InflationApproach InflationApproach { get; set; } = (LifeCycleCost_Parameters_InflationApproach)Enum.Parse(typeof(LifeCycleCost_Parameters_InflationApproach), "ConstantDollar");
        

[Description(@"Enter the real discount rate as a decimal. For a 3% rate enter the value 0.03. This input is used when the Inflation Approach is ConstantDollar. The real discount rate reflects the interest rates needed to make current and future expenditures have comparable equivalent values when general inflation is ignored. When Inflation Approach is set to CurrentDollar this input is ignored.")]
[JsonProperty("real_discount_rate")]
public System.Nullable<float> RealDiscountRate { get; set; } = null;
        

[Description(@"Enter the nominal discount rate as a decimal. For a 5% rate enter the value 0.05. This input is used when the Inflation Approach is CurrentDollar. The real discount rate reflects the interest rates needed to make current and future expenditures have comparable equivalent values when general inflation is included. When Inflation Approach is set to ConstantDollar this input is ignored.")]
[JsonProperty("nominal_discount_rate")]
public System.Nullable<float> NominalDiscountRate { get; set; } = null;
        

[Description("Enter the rate of inflation for general goods and services as a decimal. For a 2%" +
    " rate enter the value 0.02.")]
[JsonProperty("inflation")]
public System.Nullable<float> Inflation { get; set; } = null;
        

[Description("Enter the month that is the beginning of study period also known as the beginning" +
    " of the base period.")]
[JsonProperty("base_date_month")]
public LifeCycleCost_Parameters_BaseDateMonth BaseDateMonth { get; set; } = (LifeCycleCost_Parameters_BaseDateMonth)Enum.Parse(typeof(LifeCycleCost_Parameters_BaseDateMonth), "January");
        

[Description("Enter the four digit year that is the beginning of study period such as 2010. The" +
    " study period is also known as the base period.")]
[JsonProperty("base_date_year")]
public System.Nullable<float> BaseDateYear { get; set; } = null;
        

[Description(@"Enter the month that is the beginning of building occupancy. Energy costs computed by EnergyPlus are assumed to occur during the year following the service date. The service date must be the same or later than the Base Date. This field could also be referred to as part of beneficial occupancy date.")]
[JsonProperty("service_date_month")]
public LifeCycleCost_Parameters_ServiceDateMonth ServiceDateMonth { get; set; } = (LifeCycleCost_Parameters_ServiceDateMonth)Enum.Parse(typeof(LifeCycleCost_Parameters_ServiceDateMonth), "January");
        

[Description("Enter the four digit year that is the beginning of occupancy such as 2010.")]
[JsonProperty("service_date_year")]
public System.Nullable<float> ServiceDateYear { get; set; } = null;
        

[Description("Enter the number of years of the study period. It is the number of years that the" +
    " study continues based on the start at the base date. The default value is 25 ye" +
    "ars. Only integers may be used indicating whole years.")]
[JsonProperty("length_of_study_period_in_years")]
public System.Nullable<float> LengthOfStudyPeriodInYears { get; set; } = null;
        

[Description(@"Enter the overall marginal tax rate for the project costs. This does not include energy or water taxes. The tax rate entered should be based on the marginal tax rate for the entity and not the average tax rate. Enter the tax rate results in present value calculations after taxes. Most analyses do not factor in the impact of taxes and assume that all options under consideration have roughly the same tax impact. Due to this many times the tax rate can be left to default to zero and the present value results before taxes are used to make decisions. The value should be entered as a decimal value. For 15% enter 0.15. For an analysis that does not include tax impacts enter 0.0.")]
[JsonProperty("tax_rate")]
public System.Nullable<float> TaxRate { get; set; } = null;
        

[Description("For an analysis that includes income tax impacts this entry describes how capital" +
    " costs are depreciated. Only one depreciation method may be used for an analysis" +
    " and is applied to all capital expenditures.")]
[JsonProperty("depreciation_method")]
public LifeCycleCost_Parameters_DepreciationMethod DepreciationMethod { get; set; } = (LifeCycleCost_Parameters_DepreciationMethod)Enum.Parse(typeof(LifeCycleCost_Parameters_DepreciationMethod), "None");
    }
    
    public enum LifeCycleCost_Parameters_DiscountingConvention
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BeginningOfYear")]
        BeginningOfYear = 1,
        
        [JsonProperty("EndOfYear")]
        EndOfYear = 2,
        
        [JsonProperty("MidYear")]
        MidYear = 3,
    }
    
    public enum LifeCycleCost_Parameters_InflationApproach
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantDollar")]
        ConstantDollar = 1,
        
        [JsonProperty("CurrentDollar")]
        CurrentDollar = 2,
    }
    
    public enum LifeCycleCost_Parameters_BaseDateMonth
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("April")]
        April = 1,
        
        [JsonProperty("August")]
        August = 2,
        
        [JsonProperty("December")]
        December = 3,
        
        [JsonProperty("February")]
        February = 4,
        
        [JsonProperty("January")]
        January = 5,
        
        [JsonProperty("July")]
        July = 6,
        
        [JsonProperty("June")]
        June = 7,
        
        [JsonProperty("March")]
        March = 8,
        
        [JsonProperty("May")]
        May = 9,
        
        [JsonProperty("November")]
        November = 10,
        
        [JsonProperty("October")]
        October = 11,
        
        [JsonProperty("September")]
        September = 12,
    }
    
    public enum LifeCycleCost_Parameters_ServiceDateMonth
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("April")]
        April = 1,
        
        [JsonProperty("August")]
        August = 2,
        
        [JsonProperty("December")]
        December = 3,
        
        [JsonProperty("February")]
        February = 4,
        
        [JsonProperty("January")]
        January = 5,
        
        [JsonProperty("July")]
        July = 6,
        
        [JsonProperty("June")]
        June = 7,
        
        [JsonProperty("March")]
        March = 8,
        
        [JsonProperty("May")]
        May = 9,
        
        [JsonProperty("November")]
        November = 10,
        
        [JsonProperty("October")]
        October = 11,
        
        [JsonProperty("September")]
        September = 12,
    }
    
    public enum LifeCycleCost_Parameters_DepreciationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-10year")]
        ModifiedAcceleratedCostRecoverySystem10year = 1,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-15year")]
        ModifiedAcceleratedCostRecoverySystem15year = 2,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-20year")]
        ModifiedAcceleratedCostRecoverySystem20year = 3,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-3year")]
        ModifiedAcceleratedCostRecoverySystem3year = 4,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-5year")]
        ModifiedAcceleratedCostRecoverySystem5year = 5,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-7year")]
        ModifiedAcceleratedCostRecoverySystem7year = 6,
        
        [JsonProperty("None")]
        None = 7,
        
        [JsonProperty("StraightLine-27year")]
        StraightLine27year = 8,
        
        [JsonProperty("StraightLine-31year")]
        StraightLine31year = 9,
        
        [JsonProperty("StraightLine-39year")]
        StraightLine39year = 10,
        
        [JsonProperty("StraightLine-40year")]
        StraightLine40year = 11,
    }
    
    [Description("Recurring costs are costs that repeat over time on a regular schedule during the " +
        "study period. If costs associated with equipment do repeat but not on a regular " +
        "schedule, use LifeCycleCost:NonrecurringCost objects instead.")]
    [JsonObject("LifeCycleCost:RecurringCosts")]
    public class LifeCycleCost_RecurringCosts : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("category")]
public LifeCycleCost_RecurringCosts_Category Category { get; set; } = (LifeCycleCost_RecurringCosts_Category)Enum.Parse(typeof(LifeCycleCost_RecurringCosts_Category), "Maintenance");
        

[Description("Enter the cost in dollars (or the appropriate monetary unit) for the recurring co" +
    "sts. Enter the cost for each time it occurs. For example if the annual maintenan" +
    "ce cost is 500 dollars enter 500 here.")]
[JsonProperty("cost")]
public System.Nullable<float> Cost { get; set; } = null;
        

[Description("Enter when the costs start. The First Year of Cost is based on the number of year" +
    "s past the Start of Costs. For most maintenance costs the Start of Costs should " +
    "be Service Period.")]
[JsonProperty("start_of_costs")]
public LifeCycleCost_RecurringCosts_StartOfCosts StartOfCosts { get; set; } = (LifeCycleCost_RecurringCosts_StartOfCosts)Enum.Parse(typeof(LifeCycleCost_RecurringCosts_StartOfCosts), "ServicePeriod");
        

[Description(@"This field and the Months From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Costs field) that the costs start to occur. Only integers should be entered representing whole years.")]
[JsonProperty("years_from_start")]
public System.Nullable<float> YearsFromStart { get; set; } = null;
        

[Description(@"This field and the Years From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Costs field) that the costs start to occur. Only integers should be entered representing whole months. The Years From Start (times 12) and Months From Start are added together.")]
[JsonProperty("months_from_start")]
public System.Nullable<float> MonthsFromStart { get; set; } = null;
        

[Description(@"This field and the Repeat Period Months field indicate how much time elapses between re-occurrences of the cost. For costs that occur every year such the Repeat Period Years should be 1 and Repeat Period Months should be 0. Only integers should be entered representing whole years.")]
[JsonProperty("repeat_period_years")]
public System.Nullable<float> RepeatPeriodYears { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This field and the Repeat Period Years field indicate how much time elapses betwe" +
    "en re-occurrences of the cost. Only integers should be entered representing whol" +
    "e years. The Repeat Period Years (times 12) and Repeat Period Months are added t" +
    "ogether.")]
[JsonProperty("repeat_period_months")]
public System.Nullable<float> RepeatPeriodMonths { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the annual escalation rate as a decimal. For a 1% rate enter the value 0.01" +
    ". This input is used when the Inflation Approach is CurrentDollar. When Inflatio" +
    "n Approach is set to ConstantDollar this input is ignored.")]
[JsonProperty("annual_escalation_rate")]
public System.Nullable<float> AnnualEscalationRate { get; set; } = null;
    }
    
    public enum LifeCycleCost_RecurringCosts_Category
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Maintenance")]
        Maintenance = 1,
        
        [JsonProperty("MajorOverhaul")]
        MajorOverhaul = 2,
        
        [JsonProperty("MinorOverhaul")]
        MinorOverhaul = 3,
        
        [JsonProperty("Operation")]
        Operation = 4,
        
        [JsonProperty("OtherOperational")]
        OtherOperational = 5,
        
        [JsonProperty("Repair")]
        Repair = 6,
        
        [JsonProperty("Replacement")]
        Replacement = 7,
    }
    
    public enum LifeCycleCost_RecurringCosts_StartOfCosts
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BasePeriod")]
        BasePeriod = 1,
        
        [JsonProperty("ServicePeriod")]
        ServicePeriod = 2,
    }
    
    [Description("A non-recurring cost happens only once during the study period. For costs that oc" +
        "cur more than once during the study period on a regular schedule, use the LifeCy" +
        "cleCost:RecurringCost object.")]
    [JsonObject("LifeCycleCost:NonrecurringCost")]
    public class LifeCycleCost_NonrecurringCost : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("category")]
public LifeCycleCost_NonrecurringCost_Category Category { get; set; } = (LifeCycleCost_NonrecurringCost_Category)Enum.Parse(typeof(LifeCycleCost_NonrecurringCost_Category), "Construction");
        

[Description(@"Enter the non-recurring cost value. For construction and other capital costs the value entered is typically a positive value. For salvage costs the value entered is typically a negative value which represents the money paid to the investor for the equipment at the end of the study period.")]
[JsonProperty("cost")]
public System.Nullable<float> Cost { get; set; } = null;
        

[Description("Enter when the costs start. The First Year of Cost is based on the number of year" +
    "s past the Start of Costs. For most non-recurring costs the Start of Costs shoul" +
    "d be Base Period which begins at the base month and year.")]
[JsonProperty("start_of_costs")]
public LifeCycleCost_NonrecurringCost_StartOfCosts StartOfCosts { get; set; } = (LifeCycleCost_NonrecurringCost_StartOfCosts)Enum.Parse(typeof(LifeCycleCost_NonrecurringCost_StartOfCosts), "ServicePeriod");
        

[Description(@"This field and the Months From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Cost field) that the costs start to occur. Only integers should be entered representing whole years.")]
[JsonProperty("years_from_start")]
public System.Nullable<float> YearsFromStart { get; set; } = null;
        

[Description(@"This field and the Years From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Cost field) that the costs start to occur. Only integers should be entered representing whole months. The Years From Start (times 12) and Months From Start are added together.")]
[JsonProperty("months_from_start")]
public System.Nullable<float> MonthsFromStart { get; set; } = null;
    }
    
    public enum LifeCycleCost_NonrecurringCost_Category
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Construction")]
        Construction = 1,
        
        [JsonProperty("OtherCapital")]
        OtherCapital = 2,
        
        [JsonProperty("Salvage")]
        Salvage = 3,
    }
    
    public enum LifeCycleCost_NonrecurringCost_StartOfCosts
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BasePeriod")]
        BasePeriod = 1,
        
        [JsonProperty("ServicePeriod")]
        ServicePeriod = 2,
    }
    
    [Description("Life cycle cost escalation factors. The values for this object may be found in th" +
        "e annual supplement to NIST Handbook 135 in Tables Ca-1 to Ca-5 and are included" +
        " in an EnergyPlus dataset file.")]
    [JsonObject("LifeCycleCost:UsePriceEscalation")]
    public class LifeCycleCost_UsePriceEscalation : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"The identifier used for the object. The name usually identifies the location (such as the state or region or country or census area) that the escalations apply to. In addition the name should identify the building class such as residential or commercial or industrial and the use type such as electricity or natural gas or water.")]
[JsonProperty("lcc_price_escalation_name")]
public string LccPriceEscalationName { get; set; } = "";
        

[JsonProperty("resource")]
public LifeCycleCost_UsePriceEscalation_Resource Resource { get; set; } = (LifeCycleCost_UsePriceEscalation_Resource)Enum.Parse(typeof(LifeCycleCost_UsePriceEscalation_Resource), "Coal");
        

[Description("This field and the Escalation Start Month define the time that corresponds to Yea" +
    "r 1 Escalation such as 2010 when the escalation rates are applied. This field an" +
    "d the Escalation Start Month define the time that escalation begins.")]
[JsonProperty("escalation_start_year")]
public System.Nullable<float> EscalationStartYear { get; set; } = null;
        

[Description("This field and the Escalation Start Year define the time that corresponds to Year" +
    " 1 Escalation such as 2010 when the escalation rates are applied. This field and" +
    " the Escalation Start Year define the time that escalation begins.")]
[JsonProperty("escalation_start_month")]
public LifeCycleCost_UsePriceEscalation_EscalationStartMonth EscalationStartMonth { get; set; } = (LifeCycleCost_UsePriceEscalation_EscalationStartMonth)Enum.Parse(typeof(LifeCycleCost_UsePriceEscalation_EscalationStartMonth), "January");
        

[JsonProperty("escalations")]
public string Escalations { get; set; } = "";
    }
    
    public enum LifeCycleCost_UsePriceEscalation_Resource
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("Electricity")]
        Electricity = 2,
        
        [JsonProperty("ElectricityNet")]
        ElectricityNet = 3,
        
        [JsonProperty("ElectricityProduced")]
        ElectricityProduced = 4,
        
        [JsonProperty("ElectricityPurchased")]
        ElectricityPurchased = 5,
        
        [JsonProperty("ElectricitySurplusSold")]
        ElectricitySurplusSold = 6,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 7,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 8,
        
        [JsonProperty("Gasoline")]
        Gasoline = 9,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 10,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 11,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 12,
        
        [JsonProperty("Propane")]
        Propane = 13,
        
        [JsonProperty("Steam")]
        Steam = 14,
        
        [JsonProperty("Water")]
        Water = 15,
    }
    
    public enum LifeCycleCost_UsePriceEscalation_EscalationStartMonth
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("April")]
        April = 1,
        
        [JsonProperty("August")]
        August = 2,
        
        [JsonProperty("December")]
        December = 3,
        
        [JsonProperty("February")]
        February = 4,
        
        [JsonProperty("January")]
        January = 5,
        
        [JsonProperty("July")]
        July = 6,
        
        [JsonProperty("June")]
        June = 7,
        
        [JsonProperty("March")]
        March = 8,
        
        [JsonProperty("May")]
        May = 9,
        
        [JsonProperty("November")]
        November = 10,
        
        [JsonProperty("October")]
        October = 11,
        
        [JsonProperty("September")]
        September = 12,
    }
    
    [Description(@"Used by advanced users to adjust the energy or water use costs for future years. This should not be used for compensating for inflation but should only be used to increase the costs of energy or water based on assumed changes to the actual usage, such as anticipated changes in the future function of the building. The adjustments begin at the start of the service period.")]
    [JsonObject("LifeCycleCost:UseAdjustment")]
    public class LifeCycleCost_UseAdjustment : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("resource")]
public LifeCycleCost_UseAdjustment_Resource Resource { get; set; } = (LifeCycleCost_UseAdjustment_Resource)Enum.Parse(typeof(LifeCycleCost_UseAdjustment_Resource), "Coal");
        

[JsonProperty("multipliers")]
public string Multipliers { get; set; } = "";
    }
    
    public enum LifeCycleCost_UseAdjustment_Resource
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("Electricity")]
        Electricity = 2,
        
        [JsonProperty("ElectricityNet")]
        ElectricityNet = 3,
        
        [JsonProperty("ElectricityProduced")]
        ElectricityProduced = 4,
        
        [JsonProperty("ElectricityPurchased")]
        ElectricityPurchased = 5,
        
        [JsonProperty("ElectricitySurplusSold")]
        ElectricitySurplusSold = 6,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 7,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 8,
        
        [JsonProperty("Gasoline")]
        Gasoline = 9,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 10,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 11,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 12,
        
        [JsonProperty("Propane")]
        Propane = 13,
        
        [JsonProperty("Steam")]
        Steam = 14,
        
        [JsonProperty("Water")]
        Water = 15,
    }
}
