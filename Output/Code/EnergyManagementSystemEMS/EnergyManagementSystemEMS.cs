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
    [JsonObject("EnergyManagementSystem:Sensor")]
    public class EnergyManagementSystem_Sensor : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("output_variable_or_output_meter_index_key_name")]
public string OutputVariableOrOutputMeterIndexKeyName { get; set; } = "";
        

[JsonProperty("output_variable_or_output_meter_name")]
public string OutputVariableOrOutputMeterName { get; set; } = "";
    }
    
    [Description("Hardware portion of EMS used to set up actuators in the model")]
    [JsonObject("EnergyManagementSystem:Actuator")]
    public class EnergyManagementSystem_Actuator : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("actuated_component_unique_name")]
public string ActuatedComponentUniqueName { get; set; } = "";
        

[JsonProperty("actuated_component_type")]
public string ActuatedComponentType { get; set; } = "";
        

[JsonProperty("actuated_component_control_type")]
public string ActuatedComponentControlType { get; set; } = "";
    }
    
    [Description("Input EMS program. a program needs a name a description of when it should be call" +
        "ed and then lines of program code for EMS Runtime language")]
    [JsonObject("EnergyManagementSystem:ProgramCallingManager")]
    public class EnergyManagementSystem_ProgramCallingManager : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("energyplus_model_calling_point")]
public EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint EnergyplusModelCallingPoint { get; set; } = (EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint)Enum.Parse(typeof(EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint), "AfterComponentInputReadIn");
        

[JsonProperty("programs")]
public string Programs { get; set; } = "";
    }
    
    public enum EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint
    {
        
        [JsonProperty("AfterComponentInputReadIn")]
        AfterComponentInputReadIn = 0,
        
        [JsonProperty("AfterNewEnvironmentWarmUpIsComplete")]
        AfterNewEnvironmentWarmUpIsComplete = 1,
        
        [JsonProperty("AfterPredictorAfterHVACManagers")]
        AfterPredictorAfterHVACManagers = 2,
        
        [JsonProperty("AfterPredictorBeforeHVACManagers")]
        AfterPredictorBeforeHVACManagers = 3,
        
        [JsonProperty("BeginNewEnvironment")]
        BeginNewEnvironment = 4,
        
        [JsonProperty("BeginTimestepBeforePredictor")]
        BeginTimestepBeforePredictor = 5,
        
        [JsonProperty("BeginZoneTimestepAfterInitHeatBalance")]
        BeginZoneTimestepAfterInitHeatBalance = 6,
        
        [JsonProperty("BeginZoneTimestepBeforeInitHeatBalance")]
        BeginZoneTimestepBeforeInitHeatBalance = 7,
        
        [JsonProperty("BeginZoneTimestepBeforeSetCurrentWeather")]
        BeginZoneTimestepBeforeSetCurrentWeather = 8,
        
        [JsonProperty("EndOfSystemSizing")]
        EndOfSystemSizing = 9,
        
        [JsonProperty("EndOfSystemTimestepAfterHVACReporting")]
        EndOfSystemTimestepAfterHVACReporting = 10,
        
        [JsonProperty("EndOfSystemTimestepBeforeHVACReporting")]
        EndOfSystemTimestepBeforeHVACReporting = 11,
        
        [JsonProperty("EndOfZoneSizing")]
        EndOfZoneSizing = 12,
        
        [JsonProperty("EndOfZoneTimestepAfterZoneReporting")]
        EndOfZoneTimestepAfterZoneReporting = 13,
        
        [JsonProperty("EndOfZoneTimestepBeforeZoneReporting")]
        EndOfZoneTimestepBeforeZoneReporting = 14,
        
        [JsonProperty("InsideHVACSystemIterationLoop")]
        InsideHVACSystemIterationLoop = 15,
        
        [JsonProperty("UnitarySystemSizing")]
        UnitarySystemSizing = 16,
        
        [JsonProperty("UserDefinedComponentModel")]
        UserDefinedComponentModel = 17,
    }
    
    [Description("This input defines an Erl program Each field after the name is a line of EMS Runt" +
        "ime Language")]
    [JsonObject("EnergyManagementSystem:Program")]
    public class EnergyManagementSystem_Program : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("lines")]
public string Lines { get; set; } = "";
    }
    
    [Description("This input defines an Erl program subroutine Each field after the name is a line " +
        "of EMS Runtime Language")]
    [JsonObject("EnergyManagementSystem:Subroutine")]
    public class EnergyManagementSystem_Subroutine : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("lines")]
public string Lines { get; set; } = "";
    }
    
    [Description("Declares Erl variable as having global scope No spaces allowed in names used for " +
        "Erl variables")]
    [JsonObject("EnergyManagementSystem:GlobalVariable")]
    public class EnergyManagementSystem_GlobalVariable : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("variables")]
public string Variables { get; set; } = "";
    }
    
    [Description("This object sets up an EnergyPlus output variable from an Erl variable")]
    [JsonObject("EnergyManagementSystem:OutputVariable")]
    public class EnergyManagementSystem_OutputVariable : BHoMObject, IEnergyPlusClass
    {
        

[Description("must be an acceptable EMS variable")]
[JsonProperty("ems_variable_name")]
public string EmsVariableName { get; set; } = "";
        

[JsonProperty("type_of_data_in_variable")]
public EnergyManagementSystem_OutputVariable_TypeOfDataInVariable TypeOfDataInVariable { get; set; } = (EnergyManagementSystem_OutputVariable_TypeOfDataInVariable)Enum.Parse(typeof(EnergyManagementSystem_OutputVariable_TypeOfDataInVariable), "Averaged");
        

[JsonProperty("update_frequency")]
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
        
        [JsonProperty("Averaged")]
        Averaged = 0,
        
        [JsonProperty("Summed")]
        Summed = 1,
    }
    
    public enum EnergyManagementSystem_OutputVariable_UpdateFrequency
    {
        
        [JsonProperty("SystemTimestep")]
        SystemTimestep = 0,
        
        [JsonProperty("ZoneTimestep")]
        ZoneTimestep = 1,
    }
    
    [Description("This object sets up an EnergyPlus output variable from an Erl variable")]
    [JsonObject("EnergyManagementSystem:MeteredOutputVariable")]
    public class EnergyManagementSystem_MeteredOutputVariable : BHoMObject, IEnergyPlusClass
    {
        

[Description("must be an acceptable EMS variable, no spaces")]
[JsonProperty("ems_variable_name")]
public string EmsVariableName { get; set; } = "";
        

[JsonProperty("update_frequency")]
public EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency UpdateFrequency { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency), "SystemTimestep");
        

[Description("optional for global scope variables, required for local scope variables")]
[JsonProperty("ems_program_or_subroutine_name")]
public string EmsProgramOrSubroutineName { get; set; } = "";
        

[Description("choose the type of fuel, water, electricity, pollution or heat rate that should b" +
    "e metered.")]
[JsonProperty("resource_type")]
public EnergyManagementSystem_MeteredOutputVariable_ResourceType ResourceType { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_ResourceType)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_ResourceType), "Coal");
        

[Description("choose a general classification, building (internal services), HVAC (air systems)" +
    ", or plant (hydronic systems), or system")]
[JsonProperty("group_type")]
public EnergyManagementSystem_MeteredOutputVariable_GroupType GroupType { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_GroupType)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_GroupType), "Building");
        

[Description("choose how the metered output should be classified for end-use category")]
[JsonProperty("end_use_category")]
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
        
        [JsonProperty("SystemTimestep")]
        SystemTimestep = 0,
        
        [JsonProperty("ZoneTimestep")]
        ZoneTimestep = 1,
    }
    
    public enum EnergyManagementSystem_MeteredOutputVariable_ResourceType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("CondensateWaterCollected")]
        CondensateWaterCollected = 1,
        
        [JsonProperty("Diesel")]
        Diesel = 2,
        
        [JsonProperty("DistrictCooling")]
        DistrictCooling = 3,
        
        [JsonProperty("DistrictHeating")]
        DistrictHeating = 4,
        
        [JsonProperty("Electricity")]
        Electricity = 5,
        
        [JsonProperty("ElectricityProducedOnSite")]
        ElectricityProducedOnSite = 6,
        
        [JsonProperty("EnergyTransfer")]
        EnergyTransfer = 7,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 8,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 9,
        
        [JsonProperty("Gasoline")]
        Gasoline = 10,
        
        [JsonProperty("MainsWaterSupply")]
        MainsWaterSupply = 11,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 12,
        
        [JsonProperty("OnSiteWaterProduced")]
        OnSiteWaterProduced = 13,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 14,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 15,
        
        [JsonProperty("Propane")]
        Propane = 16,
        
        [JsonProperty("RainWaterCollected")]
        RainWaterCollected = 17,
        
        [JsonProperty("SolarAirHeating")]
        SolarAirHeating = 18,
        
        [JsonProperty("SolarWaterHeating")]
        SolarWaterHeating = 19,
        
        [JsonProperty("Steam")]
        Steam = 20,
        
        [JsonProperty("WaterUse")]
        WaterUse = 21,
        
        [JsonProperty("WellWaterDrawn")]
        WellWaterDrawn = 22,
    }
    
    public enum EnergyManagementSystem_MeteredOutputVariable_GroupType
    {
        
        [JsonProperty("Building")]
        Building = 0,
        
        [JsonProperty("HVAC")]
        HVAC = 1,
        
        [JsonProperty("Plant")]
        Plant = 2,
        
        [JsonProperty("System")]
        System = 3,
    }
    
    public enum EnergyManagementSystem_MeteredOutputVariable_EndUseCategory
    {
        
        [JsonProperty("Baseboard")]
        Baseboard = 0,
        
        [JsonProperty("Boilers")]
        Boilers = 1,
        
        [JsonProperty("Chillers")]
        Chillers = 2,
        
        [JsonProperty("Cooling")]
        Cooling = 3,
        
        [JsonProperty("CoolingCoils")]
        CoolingCoils = 4,
        
        [JsonProperty("ExteriorEquipment")]
        ExteriorEquipment = 5,
        
        [JsonProperty("ExteriorLights")]
        ExteriorLights = 6,
        
        [JsonProperty("Fans")]
        Fans = 7,
        
        [JsonProperty("HeatRecovery")]
        HeatRecovery = 8,
        
        [JsonProperty("HeatRecoveryForCooling")]
        HeatRecoveryForCooling = 9,
        
        [JsonProperty("HeatRecoveryForHeating")]
        HeatRecoveryForHeating = 10,
        
        [JsonProperty("HeatRejection")]
        HeatRejection = 11,
        
        [JsonProperty("Heating")]
        Heating = 12,
        
        [JsonProperty("HeatingCoils")]
        HeatingCoils = 13,
        
        [JsonProperty("Humidifier")]
        Humidifier = 14,
        
        [JsonProperty("InteriorEquipment")]
        InteriorEquipment = 15,
        
        [JsonProperty("InteriorLights")]
        InteriorLights = 16,
        
        [JsonProperty("OnSiteGeneration")]
        OnSiteGeneration = 17,
        
        [JsonProperty("Pumps")]
        Pumps = 18,
        
        [JsonProperty("Refrigeration")]
        Refrigeration = 19,
        
        [JsonProperty("WaterSystems")]
        WaterSystems = 20,
    }
    
    [Description("This object sets up an EMS trend variable from an Erl variable A trend variable l" +
        "ogs values across timesteps")]
    [JsonObject("EnergyManagementSystem:TrendVariable")]
    public class EnergyManagementSystem_TrendVariable : BHoMObject, IEnergyPlusClass
    {
        

[Description("must be a global scope EMS variable")]
[JsonProperty("ems_variable_name")]
public string EmsVariableName { get; set; } = "";
        

[JsonProperty("number_of_timesteps_to_be_logged")]
public System.Nullable<float> NumberOfTimestepsToBeLogged { get; set; } = null;
    }
    
    [Description("Declares EMS variable as an internal data variable")]
    [JsonObject("EnergyManagementSystem:InternalVariable")]
    public class EnergyManagementSystem_InternalVariable : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("internal_data_index_key_name")]
public string InternalDataIndexKeyName { get; set; } = "";
        

[JsonProperty("internal_data_type")]
public string InternalDataType { get; set; } = "";
    }
    
    [Description("Declares EMS variable that identifies a curve or table")]
    [JsonObject("EnergyManagementSystem:CurveOrTableIndexVariable")]
    public class EnergyManagementSystem_CurveOrTableIndexVariable : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("curve_or_table_object_name")]
public string CurveOrTableObjectName { get; set; } = "";
    }
    
    [Description("Declares EMS variable that identifies a construction")]
    [JsonObject("EnergyManagementSystem:ConstructionIndexVariable")]
    public class EnergyManagementSystem_ConstructionIndexVariable : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("construction_object_name")]
public string ConstructionObjectName { get; set; } = "";
    }
}
