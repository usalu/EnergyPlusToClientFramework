namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
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
    using BH.oM.Adapters.EnergyPlus.Economics;
    using BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications;
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
    
    
    [Description("Declares EMS variable as a sensor a list of output variables and meters that can " +
        "be reported are available after a run on the report (.rdd) or meter dictionary f" +
        "ile (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_Sensor : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("output_variable_or_output_meter_index_key_name")]
public string OutputVariableOrOutputMeterIndexKeyName { get; set; } = "";
        

[JsonProperty("output_variable_or_output_meter_name")]
public string OutputVariableOrOutputMeterName { get; set; } = "";
    }
    
    [Description("Hardware portion of EMS used to set up actuators in the model")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_Actuator : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("actuated_component_unique_name")]
public string ActuatedComponentUniqueName { get; set; } = "";
        

[JsonProperty("actuated_component_type")]
public string ActuatedComponentType { get; set; } = "";
        

[JsonProperty("actuated_component_control_type")]
public string ActuatedComponentControlType { get; set; } = "";
    }
    
    [Description("Input EMS program. a program needs a name a description of when it should be call" +
        "ed and then lines of program code for EMS Runtime language")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_ProgramCallingManager : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("energyplus_model_calling_point")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint EnergyplusModelCallingPoint { get; set; } = (EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint)Enum.Parse(typeof(EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint), "AfterComponentInputReadIn");
        

[JsonProperty("programs")]
public string Programs { get; set; } = "";
    }
    
    public enum EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AfterComponentInputReadIn")]
        AfterComponentInputReadIn = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AfterNewEnvironmentWarmUpIsComplete")]
        AfterNewEnvironmentWarmUpIsComplete = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AfterPredictorAfterHVACManagers")]
        AfterPredictorAfterHVACManagers = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AfterPredictorBeforeHVACManagers")]
        AfterPredictorBeforeHVACManagers = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginNewEnvironment")]
        BeginNewEnvironment = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginTimestepBeforePredictor")]
        BeginTimestepBeforePredictor = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginZoneTimestepAfterInitHeatBalance")]
        BeginZoneTimestepAfterInitHeatBalance = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginZoneTimestepBeforeInitHeatBalance")]
        BeginZoneTimestepBeforeInitHeatBalance = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginZoneTimestepBeforeSetCurrentWeather")]
        BeginZoneTimestepBeforeSetCurrentWeather = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfSystemSizing")]
        EndOfSystemSizing = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfSystemTimestepAfterHVACReporting")]
        EndOfSystemTimestepAfterHVACReporting = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfSystemTimestepBeforeHVACReporting")]
        EndOfSystemTimestepBeforeHVACReporting = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfZoneSizing")]
        EndOfZoneSizing = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfZoneTimestepAfterZoneReporting")]
        EndOfZoneTimestepAfterZoneReporting = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfZoneTimestepBeforeZoneReporting")]
        EndOfZoneTimestepBeforeZoneReporting = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="InsideHVACSystemIterationLoop")]
        InsideHVACSystemIterationLoop = 15,
        
        [System.Runtime.Serialization.EnumMember(Value="UnitarySystemSizing")]
        UnitarySystemSizing = 16,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefinedComponentModel")]
        UserDefinedComponentModel = 17,
    }
    
    [Description("This input defines an Erl program Each field after the name is a line of EMS Runt" +
        "ime Language")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_Program : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("lines")]
public string Lines { get; set; } = "";
    }
    
    [Description("This input defines an Erl program subroutine Each field after the name is a line " +
        "of EMS Runtime Language")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_Subroutine : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("lines")]
public string Lines { get; set; } = "";
    }
    
    [Description("Declares Erl variable as having global scope No spaces allowed in names used for " +
        "Erl variables")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_GlobalVariable : BHoMObject
    {
        

[JsonProperty("variables")]
public string Variables { get; set; } = "";
    }
    
    [Description("This object sets up an EnergyPlus output variable from an Erl variable")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_OutputVariable : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("must be an acceptable EMS variable")]
[JsonProperty("ems_variable_name")]
public string EmsVariableName { get; set; } = "";
        

[JsonProperty("type_of_data_in_variable")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EnergyManagementSystem_OutputVariable_TypeOfDataInVariable TypeOfDataInVariable { get; set; } = (EnergyManagementSystem_OutputVariable_TypeOfDataInVariable)Enum.Parse(typeof(EnergyManagementSystem_OutputVariable_TypeOfDataInVariable), "Averaged");
        

[JsonProperty("update_frequency")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EnergyManagementSystem_OutputVariable_UpdateFrequency UpdateFrequency { get; set; } = (EnergyManagementSystem_OutputVariable_UpdateFrequency)Enum.Parse(typeof(EnergyManagementSystem_OutputVariable_UpdateFrequency), "SystemTimestep");
        

[Description("optional for global scope variables, required for local scope variables")]
[JsonProperty("ems_program_or_subroutine_name")]
public string EmsProgramOrSubroutineName { get; set; } = "";
        

[Description("optional but will result in dimensionless units for blank EnergyPlus units are st" +
    "andard SI units")]
[JsonProperty("units")]
public string Units { get; set; } = "";
    }
    
    public enum EnergyManagementSystem_OutputVariable_TypeOfDataInVariable
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Averaged")]
        Averaged = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Summed")]
        Summed = 1,
    }
    
    public enum EnergyManagementSystem_OutputVariable_UpdateFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="SystemTimestep")]
        SystemTimestep = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneTimestep")]
        ZoneTimestep = 1,
    }
    
    [Description("This object sets up an EnergyPlus output variable from an Erl variable")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_MeteredOutputVariable : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("must be an acceptable EMS variable, no spaces")]
[JsonProperty("ems_variable_name")]
public string EmsVariableName { get; set; } = "";
        

[JsonProperty("update_frequency")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency UpdateFrequency { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency), "SystemTimestep");
        

[Description("optional for global scope variables, required for local scope variables")]
[JsonProperty("ems_program_or_subroutine_name")]
public string EmsProgramOrSubroutineName { get; set; } = "";
        

[Description("choose the type of fuel, water, electricity, pollution or heat rate that should b" +
    "e metered.")]
[JsonProperty("resource_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EnergyManagementSystem_MeteredOutputVariable_ResourceType ResourceType { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_ResourceType)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_ResourceType), "Coal");
        

[Description("choose a general classification, building (internal services), HVAC (air systems)" +
    ", or plant (hydronic systems), or system")]
[JsonProperty("group_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EnergyManagementSystem_MeteredOutputVariable_GroupType GroupType { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_GroupType)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_GroupType), "Building");
        

[Description("choose how the metered output should be classified for end-use category")]
[JsonProperty("end_use_category")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EnergyManagementSystem_MeteredOutputVariable_EndUseCategory EndUseCategory { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_EndUseCategory)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_EndUseCategory), "Baseboard");
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table. enter a user-defined subcategory for this metered output")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = "";
        

[Description("optional but will result in dimensionless units for blank EnergyPlus units are st" +
    "andard SI units")]
[JsonProperty("units")]
public string Units { get; set; } = "";
    }
    
    public enum EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="SystemTimestep")]
        SystemTimestep = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneTimestep")]
        ZoneTimestep = 1,
    }
    
    public enum EnergyManagementSystem_MeteredOutputVariable_ResourceType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CondensateWaterCollected")]
        CondensateWaterCollected = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictCooling")]
        DistrictCooling = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ElectricityProducedOnSite")]
        ElectricityProducedOnSite = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="EnergyTransfer")]
        EnergyTransfer = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="MainsWaterSupply")]
        MainsWaterSupply = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="OnSiteWaterProduced")]
        OnSiteWaterProduced = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 15,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 16,
        
        [System.Runtime.Serialization.EnumMember(Value="RainWaterCollected")]
        RainWaterCollected = 17,
        
        [System.Runtime.Serialization.EnumMember(Value="SolarAirHeating")]
        SolarAirHeating = 18,
        
        [System.Runtime.Serialization.EnumMember(Value="SolarWaterHeating")]
        SolarWaterHeating = 19,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 20,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterUse")]
        WaterUse = 21,
        
        [System.Runtime.Serialization.EnumMember(Value="WellWaterDrawn")]
        WellWaterDrawn = 22,
    }
    
    public enum EnergyManagementSystem_MeteredOutputVariable_GroupType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Building")]
        Building = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HVAC")]
        HVAC = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Plant")]
        Plant = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="System")]
        System = 3,
    }
    
    public enum EnergyManagementSystem_MeteredOutputVariable_EndUseCategory
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Baseboard")]
        Baseboard = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Boilers")]
        Boilers = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chillers")]
        Chillers = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingCoils")]
        CoolingCoils = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ExteriorEquipment")]
        ExteriorEquipment = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ExteriorLights")]
        ExteriorLights = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Fans")]
        Fans = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatRecovery")]
        HeatRecovery = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatRecoveryForCooling")]
        HeatRecoveryForCooling = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatRecoveryForHeating")]
        HeatRecoveryForHeating = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatRejection")]
        HeatRejection = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingCoils")]
        HeatingCoils = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Humidifier")]
        Humidifier = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="InteriorEquipment")]
        InteriorEquipment = 15,
        
        [System.Runtime.Serialization.EnumMember(Value="InteriorLights")]
        InteriorLights = 16,
        
        [System.Runtime.Serialization.EnumMember(Value="OnSiteGeneration")]
        OnSiteGeneration = 17,
        
        [System.Runtime.Serialization.EnumMember(Value="Pumps")]
        Pumps = 18,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigeration")]
        Refrigeration = 19,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterSystems")]
        WaterSystems = 20,
    }
    
    [Description("This object sets up an EMS trend variable from an Erl variable A trend variable l" +
        "ogs values across timesteps")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_TrendVariable : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("must be a global scope EMS variable")]
[JsonProperty("ems_variable_name")]
public string EmsVariableName { get; set; } = "";
        

[JsonProperty("number_of_timesteps_to_be_logged")]
public System.Nullable<float> NumberOfTimestepsToBeLogged { get; set; } = null;
    }
    
    [Description("Declares EMS variable as an internal data variable")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_InternalVariable : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("internal_data_index_key_name")]
public string InternalDataIndexKeyName { get; set; } = "";
        

[JsonProperty("internal_data_type")]
public string InternalDataType { get; set; } = "";
    }
    
    [Description("Declares EMS variable that identifies a curve or table")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_CurveOrTableIndexVariable : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("curve_or_table_object_name")]
public string CurveOrTableObjectName { get; set; } = "";
    }
    
    [Description("Declares EMS variable that identifies a construction")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_ConstructionIndexVariable : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("construction_object_name")]
public string ConstructionObjectName { get; set; } = "";
    }
}
