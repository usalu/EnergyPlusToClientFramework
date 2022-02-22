namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
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
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Specifies zone relative humidity setpoint schedules for humidifying and dehumidif" +
        "ying.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_Humidistat : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("hourly schedule values should be in Relative Humidity (percent)")]
[JsonProperty("humidifying_relative_humidity_setpoint_schedule_name")]
public string HumidifyingRelativeHumiditySetpointScheduleName { get; set; } = "";
        

[Description("hourly schedule values should be in Relative Humidity (percent)")]
[JsonProperty("dehumidifying_relative_humidity_setpoint_schedule_name")]
public string DehumidifyingRelativeHumiditySetpointScheduleName { get; set; } = "";
    }
    
    [Description("Define the Thermostat settings for a zone or list of zones. If you use a ZoneList" +
        " in the Zone or ZoneList name field then this definition applies to all the zone" +
        "s in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_Thermostat : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description(@"This schedule contains appropriate control types for thermostat. Control types are integers: 0 - Uncontrolled (floating, no thermostat), 1 = ThermostatSetpoint:SingleHeating, 2 = ThermostatSetpoint:SingleCooling, 3 = ThermostatSetpoint:SingleHeatingOrCooling, 4 = ThermostatSetpoint:DualSetpoint")]
[JsonProperty("control_type_schedule_name")]
public string ControlTypeScheduleName { get; set; } = "";
        

[JsonProperty("control_1_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_Control1ObjectType Control1ObjectType { get; set; } = (ZoneControl_Thermostat_Control1ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_Control1ObjectType), "ThermostatSetpointDualSetpoint");
        

[Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
    "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
    "for the control types")]
[JsonProperty("control_1_name")]
public string Control1Name { get; set; } = "";
        

[JsonProperty("control_2_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_Control2ObjectType Control2ObjectType { get; set; } = (ZoneControl_Thermostat_Control2ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_Control2ObjectType), "ThermostatSetpointDualSetpoint");
        

[Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
    "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
    "for the control types")]
[JsonProperty("control_2_name")]
public string Control2Name { get; set; } = "";
        

[JsonProperty("control_3_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_Control3ObjectType Control3ObjectType { get; set; } = (ZoneControl_Thermostat_Control3ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_Control3ObjectType), "ThermostatSetpointDualSetpoint");
        

[Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
    "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
    "for the control types")]
[JsonProperty("control_3_name")]
public string Control3Name { get; set; } = "";
        

[JsonProperty("control_4_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_Control4ObjectType Control4ObjectType { get; set; } = (ZoneControl_Thermostat_Control4ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_Control4ObjectType), "ThermostatSetpointDualSetpoint");
        

[Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
    "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
    "for the control types")]
[JsonProperty("control_4_name")]
public string Control4Name { get; set; } = "";
        

[Description("This optional choice field provides a temperature difference between cut-out temp" +
    "erature and setpoint. The difference is used to adjust to heating or cooling set" +
    "point based on control types.")]
[JsonProperty("temperature_difference_between_cutout_and_setpoint")]
public System.Nullable<float> TemperatureDifferenceBetweenCutoutAndSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum ZoneControl_Thermostat_Control1ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:DualSetpoint")]
        ThermostatSetpointDualSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleCooling")]
        ThermostatSetpointSingleCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeating")]
        ThermostatSetpointSingleHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeatingOrCooling")]
        ThermostatSetpointSingleHeatingOrCooling = 3,
    }
    
    public enum ZoneControl_Thermostat_Control2ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:DualSetpoint")]
        ThermostatSetpointDualSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleCooling")]
        ThermostatSetpointSingleCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeating")]
        ThermostatSetpointSingleHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeatingOrCooling")]
        ThermostatSetpointSingleHeatingOrCooling = 3,
    }
    
    public enum ZoneControl_Thermostat_Control3ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:DualSetpoint")]
        ThermostatSetpointDualSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleCooling")]
        ThermostatSetpointSingleCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeating")]
        ThermostatSetpointSingleHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeatingOrCooling")]
        ThermostatSetpointSingleHeatingOrCooling = 3,
    }
    
    public enum ZoneControl_Thermostat_Control4ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:DualSetpoint")]
        ThermostatSetpointDualSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleCooling")]
        ThermostatSetpointSingleCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeating")]
        ThermostatSetpointSingleHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeatingOrCooling")]
        ThermostatSetpointSingleHeatingOrCooling = 3,
    }
    
    [Description("This object can be used with the ZoneList option on a thermostat or with one of t" +
        "he zones on that list (but you won\'t be able to use the object list to pick only" +
        " one of those zones. Thermostat names are <Zone Name> <global Thermostat name> i" +
        "nternally.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_Thermostat_OperativeTemperature : BHoMObject
    {
        

[Description("Enter the name of a ZoneControl:Thermostat object. This object modifies a ZoneCon" +
    "trol:Thermostat object to add a radiative fraction.")]
[JsonProperty("thermostat_name")]
public string ThermostatName { get; set; } = "";
        

[JsonProperty("radiative_fraction_input_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_OperativeTemperature_RadiativeFractionInputMode RadiativeFractionInputMode { get; set; } = (ZoneControl_Thermostat_OperativeTemperature_RadiativeFractionInputMode)Enum.Parse(typeof(ZoneControl_Thermostat_OperativeTemperature_RadiativeFractionInputMode), "Constant");
        

[JsonProperty("fixed_radiative_fraction")]
public System.Nullable<float> FixedRadiativeFraction { get; set; } = null;
        

[Description("Schedule values of 0.0 indicate no operative temperature control")]
[JsonProperty("radiative_fraction_schedule_name")]
public string RadiativeFractionScheduleName { get; set; } = "";
        

[Description("the cooling setpoint temperature schedule of the referenced thermostat will be ad" +
    "justed based on the selected adaptive comfort model type")]
[JsonProperty("adaptive_comfort_model_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_OperativeTemperature_AdaptiveComfortModelType AdaptiveComfortModelType { get; set; } = (ZoneControl_Thermostat_OperativeTemperature_AdaptiveComfortModelType)Enum.Parse(typeof(ZoneControl_Thermostat_OperativeTemperature_AdaptiveComfortModelType), "None");
    }
    
    public enum ZoneControl_Thermostat_OperativeTemperature_RadiativeFractionInputMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 1,
    }
    
    public enum ZoneControl_Thermostat_OperativeTemperature_AdaptiveComfortModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH5580PercentUpperLine")]
        AdaptiveASH5580PercentUpperLine = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH5590PercentUpperLine")]
        AdaptiveASH5590PercentUpperLine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH55CentralLine")]
        AdaptiveASH55CentralLine = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251CategoryIIIUpperLine")]
        AdaptiveCEN15251CategoryIIIUpperLine = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251CategoryIIUpperLine")]
        AdaptiveCEN15251CategoryIIUpperLine = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251CategoryIUpperLine")]
        AdaptiveCEN15251CategoryIUpperLine = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251CentralLine")]
        AdaptiveCEN15251CentralLine = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 8,
    }
    
    [Description("If you use a ZoneList in the Zone or ZoneList name field then this definition app" +
        "lies to all the zones in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_Thermostat_ThermalComfort : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("The method used to calculate thermal comfort dry-bulb temperature setpoint for mu" +
    "ltiple people objects in a zone")]
[JsonProperty("averaging_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_ThermalComfort_AveragingMethod AveragingMethod { get; set; } = (ZoneControl_Thermostat_ThermalComfort_AveragingMethod)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_AveragingMethod), "PeopleAverage");
        

[Description("Used only when Averaging Method = SpecificObject in the previous field.")]
[JsonProperty("specific_people_name")]
public string SpecificPeopleName { get; set; } = "";
        

[JsonProperty("minimum_dry_bulb_temperature_setpoint")]
public System.Nullable<float> MinimumDryBulbTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_dry_bulb_temperature_setpoint")]
public System.Nullable<float> MaximumDryBulbTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"The Thermal Comfort Control Type Schedule contains values that are appropriate control types. Thermal Comfort Control types are integers: 0 - Uncontrolled (floating), 1 = ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating 2 = ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling 3 = ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling 4 = ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint")]
[JsonProperty("thermal_comfort_control_type_schedule_name")]
public string ThermalComfortControlTypeScheduleName { get; set; } = "";
        

[JsonProperty("thermal_comfort_control_1_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl1ObjectType ThermalComfortControl1ObjectType { get; set; } = (ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl1ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl1ObjectType), "ThermostatSetpointThermalComfortFangerDualSetpoint");
        

[Description("Control type names are names for individual control type objects. Schedule values" +
    " in these objects list actual setpoint temperatures for the control types")]
[JsonProperty("thermal_comfort_control_1_name")]
public string ThermalComfortControl1Name { get; set; } = "";
        

[JsonProperty("thermal_comfort_control_2_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl2ObjectType ThermalComfortControl2ObjectType { get; set; } = (ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl2ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl2ObjectType), "ThermostatSetpointThermalComfortFangerDualSetpoint");
        

[Description("Control Type names are names for individual control type objects. Schedule values" +
    " in these objects list actual setpoint temperatures for the control types")]
[JsonProperty("thermal_comfort_control_2_name")]
public string ThermalComfortControl2Name { get; set; } = "";
        

[JsonProperty("thermal_comfort_control_3_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl3ObjectType ThermalComfortControl3ObjectType { get; set; } = (ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl3ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl3ObjectType), "ThermostatSetpointThermalComfortFangerDualSetpoint");
        

[Description("Control type names are names for individual control type objects. Schedule values" +
    " in these objects list actual setpoint temperatures for the control types")]
[JsonProperty("thermal_comfort_control_3_name")]
public string ThermalComfortControl3Name { get; set; } = "";
        

[JsonProperty("thermal_comfort_control_4_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl4ObjectType ThermalComfortControl4ObjectType { get; set; } = (ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl4ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl4ObjectType), "ThermostatSetpointThermalComfortFangerDualSetpoint");
        

[Description("Control type names are names for individual control type objects. Schedule values" +
    " in these objects list actual setpoint temperatures for the control types")]
[JsonProperty("thermal_comfort_control_4_name")]
public string ThermalComfortControl4Name { get; set; } = "";
    }
    
    public enum ZoneControl_Thermostat_ThermalComfort_AveragingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ObjectAverage")]
        ObjectAverage = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PeopleAverage")]
        PeopleAverage = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SpecificObject")]
        SpecificObject = 3,
    }
    
    public enum ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl1ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint")]
        ThermostatSetpointThermalComfortFangerDualSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling")]
        ThermostatSetpointThermalComfortFangerSingleCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating")]
        ThermostatSetpointThermalComfortFangerSingleHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling")]
        ThermostatSetpointThermalComfortFangerSingleHeatingOrCooling = 3,
    }
    
    public enum ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl2ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint")]
        ThermostatSetpointThermalComfortFangerDualSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling")]
        ThermostatSetpointThermalComfortFangerSingleCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating")]
        ThermostatSetpointThermalComfortFangerSingleHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling")]
        ThermostatSetpointThermalComfortFangerSingleHeatingOrCooling = 3,
    }
    
    public enum ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl3ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint")]
        ThermostatSetpointThermalComfortFangerDualSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling")]
        ThermostatSetpointThermalComfortFangerSingleCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating")]
        ThermostatSetpointThermalComfortFangerSingleHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling")]
        ThermostatSetpointThermalComfortFangerSingleHeatingOrCooling = 3,
    }
    
    public enum ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl4ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint")]
        ThermostatSetpointThermalComfortFangerDualSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling")]
        ThermostatSetpointThermalComfortFangerSingleCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating")]
        ThermostatSetpointThermalComfortFangerSingleHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling")]
        ThermostatSetpointThermalComfortFangerSingleHeatingOrCooling = 3,
    }
    
    [Description("This object modifies a ZoneControl:Thermostat object to effect temperature contro" +
        "l based on zone air humidity conditions.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_Thermostat_TemperatureAndHumidity : BHoMObject
    {
        

[Description(@"Enter the name of a ZoneControl:Thermostat object whose operation is to be modified to effect temperature control based on zone air humidity conditions. If the ZoneControl: Thermostat object references a ZoneList, simply enter the name of the ZoneControl:Thermostat object and this temperature and humidity thermostat control will be applied to all zones in the ZoneList. If the ZoneControl:Thermostat object references a ZoneList but it is desired that only a single zone within the ZoneList be controlled based on temperature and humidity control, then the name to be put here is <Zone Name> <Thermostat Name> where the Thermostat Name is the the name of the ZoneControl:Thermostat object.")]
[JsonProperty("thermostat_name")]
public string ThermostatName { get; set; } = "";
        

[Description("Schedule values should be in Relative Humidity (percent)")]
[JsonProperty("dehumidifying_relative_humidity_setpoint_schedule_name")]
public string DehumidifyingRelativeHumiditySetpointScheduleName { get; set; } = "";
        

[JsonProperty("dehumidification_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_TemperatureAndHumidity_DehumidificationControlType DehumidificationControlType { get; set; } = (ZoneControl_Thermostat_TemperatureAndHumidity_DehumidificationControlType)Enum.Parse(typeof(ZoneControl_Thermostat_TemperatureAndHumidity_DehumidificationControlType), "Overcool");
        

[JsonProperty("overcool_range_input_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneControl_Thermostat_TemperatureAndHumidity_OvercoolRangeInputMethod OvercoolRangeInputMethod { get; set; } = (ZoneControl_Thermostat_TemperatureAndHumidity_OvercoolRangeInputMethod)Enum.Parse(typeof(ZoneControl_Thermostat_TemperatureAndHumidity_OvercoolRangeInputMethod), "Constant");
        

[Description("Maximum Overcool temperature range for cooling setpoint reduction. Used with Dehu" +
    "midification Control Type = Overcool. A value of 0.0 indicates no zone temperatu" +
    "re overcooling will be provided to gain additional dehumidification.")]
[JsonProperty("overcool_constant_range")]
public System.Nullable<float> OvercoolConstantRange { get; set; } = (System.Nullable<float>)Single.Parse("1.7", CultureInfo.InvariantCulture);
        

[Description("Schedule values of 0.0 indicates no zone temperature overcooling will be provided" +
    " to gain additional dehumidification. Schedule values should be >= 0 and <= 3 (d" +
    "eltaC).")]
[JsonProperty("overcool_range_schedule_name")]
public string OvercoolRangeScheduleName { get; set; } = "";
        

[Description(@"The value of this input field is used to adjust the cooling setpoint temperature (established by the associated ZoneControl:Thermostat object) downward based on the difference between the zone air relative humidity level and the dehumidifying relative humidity setpoint.")]
[JsonProperty("overcool_control_ratio")]
public System.Nullable<float> OvercoolControlRatio { get; set; } = (System.Nullable<float>)Single.Parse("3.6", CultureInfo.InvariantCulture);
    }
    
    public enum ZoneControl_Thermostat_TemperatureAndHumidity_DehumidificationControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Overcool")]
        Overcool = 2,
    }
    
    public enum ZoneControl_Thermostat_TemperatureAndHumidity_OvercoolRangeInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 2,
    }
    
    [Description("Used for a heating only thermostat. The setpoint can be scheduled and varied thro" +
        "ughout the simulation but only heating is allowed with this control type.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_SingleHeating : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("setpoint_temperature_schedule_name")]
public string SetpointTemperatureScheduleName { get; set; } = "";
    }
    
    [Description("Used for a cooling only thermostat. The setpoint can be scheduled and varied thro" +
        "ughout the simulation but only cooling is allowed.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_SingleCooling : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("setpoint_temperature_schedule_name")]
public string SetpointTemperatureScheduleName { get; set; } = "";
    }
    
    [Description("Used for a heating and cooling thermostat with a single setpoint. The setpoint ca" +
        "n be scheduled and varied throughout the simulation for both heating and cooling" +
        ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_SingleHeatingOrCooling : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("setpoint_temperature_schedule_name")]
public string SetpointTemperatureScheduleName { get; set; } = "";
    }
    
    [Description("Used for a heating and cooling thermostat with dual setpoints. The setpoints can " +
        "be scheduled and varied throughout the simulation for both heating and cooling.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_DualSetpoint : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("heating_setpoint_temperature_schedule_name")]
public string HeatingSetpointTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("cooling_setpoint_temperature_schedule_name")]
public string CoolingSetpointTemperatureScheduleName { get; set; } = "";
    }
    
    [Description("Used for heating only thermal comfort control. The PMV setpoint can be scheduled " +
        "and varied throughout the simulation but only heating is allowed with this contr" +
        "ol type.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Schedule values should be Predicted Mean Vote (PMV)")]
[JsonProperty("fanger_thermal_comfort_schedule_name")]
public string FangerThermalComfortScheduleName { get; set; } = "";
    }
    
    [Description("Used for cooling only thermal comfort control. The PMV setpoint can be scheduled " +
        "and varied throughout the simulation but only cooling is allowed with this contr" +
        "ol type.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Schedule values should be Predicted Mean Vote (PMV)")]
[JsonProperty("fanger_thermal_comfort_schedule_name")]
public string FangerThermalComfortScheduleName { get; set; } = "";
    }
    
    [Description("Used for heating and cooling thermal comfort control with a single setpoint. The " +
        "PMV setpoint can be scheduled and varied throughout the simulation for both heat" +
        "ing and cooling.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Schedule values should be Predicted Mean Vote (PMV)")]
[JsonProperty("fanger_thermal_comfort_schedule_name")]
public string FangerThermalComfortScheduleName { get; set; } = "";
    }
    
    [Description("Used for heating and cooling thermal comfort control with dual setpoints. The PMV" +
        " setpoints can be scheduled and varied throughout the simulation for both heatin" +
        "g and cooling.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Schedule values should be Predicted Mean Vote (PMV)")]
[JsonProperty("fanger_thermal_comfort_heating_schedule_name")]
public string FangerThermalComfortHeatingScheduleName { get; set; } = "";
        

[Description("Schedule values should be Predicted Mean Vote (PMV)")]
[JsonProperty("fanger_thermal_comfort_cooling_schedule_name")]
public string FangerThermalComfortCoolingScheduleName { get; set; } = "";
    }
    
    [Description("Define the Thermostat StagedDualSetpoint settings for a zone or list of zones. If" +
        " you use a ZoneList in the Zone or ZoneList name field then this definition appl" +
        "ies to all the zones in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_Thermostat_StagedDualSetpoint : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("Enter the number of the following sets of data for heating temperature offset")]
[JsonProperty("number_of_heating_stages")]
public System.Nullable<float> NumberOfHeatingStages { get; set; } = null;
        

[JsonProperty("heating_temperature_setpoint_schedule_name")]
public string HeatingTemperatureSetpointScheduleName { get; set; } = "";
        

[JsonProperty("heating_throttling_temperature_range")]
public System.Nullable<float> HeatingThrottlingTemperatureRange { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

[Description(@"The heating temperature offset is used to determine heating stage number for multi stage equipment. When the temperature difference of the heating setpoint and the controlled zone temperature at previous time step is less than Stage 1 value and greater than Stage 2 value, the stage number is 1.")]
[JsonProperty("stage_1_heating_temperature_offset")]
public System.Nullable<float> Stage1HeatingTemperatureOffset { get; set; } = null;
        

[Description(@"The heating temperature offset is used to determine heating stage number for multi stage equipment. When the temperature difference of the heating setpoint and the controlled zone temperature at previous time step is less than Stage 2 value and greater than Stage 3 value, the stage number is 2. The value of this field has to be less the value at the previous field.")]
[JsonProperty("stage_2_heating_temperature_offset")]
public System.Nullable<float> Stage2HeatingTemperatureOffset { get; set; } = null;
        

[Description(@"The heating temperature offset is used to determine heating stage number for multi stage equipment. When the temperature difference of the heating setpoint and the controlled zone temperature at previous time step is less than Stage 3 value and greater than Stage 4 value, the stage number is 3. The value of this field has to be less the value at the previous field.")]
[JsonProperty("stage_3_heating_temperature_offset")]
public System.Nullable<float> Stage3HeatingTemperatureOffset { get; set; } = null;
        

[Description(@"The heating temperature offset is used to determine heating stage number for multi stage equipment. When the temperature difference of the heating setpoint and the controlled zone temperature at previous time step is less than Stage 4 value, the stage number is 4. The value of this field has to be less the value at the previous field.")]
[JsonProperty("stage_4_heating_temperature_offset")]
public System.Nullable<float> Stage4HeatingTemperatureOffset { get; set; } = null;
        

[Description("Enter the number of the following sets of data for cooling temperature offset")]
[JsonProperty("number_of_cooling_stages")]
public System.Nullable<float> NumberOfCoolingStages { get; set; } = null;
        

[JsonProperty("cooling_temperature_setpoint_base_schedule_name")]
public string CoolingTemperatureSetpointBaseScheduleName { get; set; } = "";
        

[JsonProperty("cooling_throttling_temperature_range")]
public System.Nullable<float> CoolingThrottlingTemperatureRange { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

[Description(@"The cooling temperature offset is used to determine cooling stage number for multi stage equipment. When the temperature difference of the cooling setpoint and the controlled zone temperature at previous time step is greater than Stage 1 value and less than Stage 2 value, the stage number is 1.")]
[JsonProperty("stage_1_cooling_temperature_offset")]
public System.Nullable<float> Stage1CoolingTemperatureOffset { get; set; } = null;
        

[Description(@"The cooling temperature offset is used to determine cooling stage number for multi stage equipment. When the temperature difference of the cooling setpoint and the controlled zone temperature at previous time step is greater than Stage 2 value and less than Stage 3 value, the stage number is 2. The value of this field has to be greater than the value at the previous field.")]
[JsonProperty("stage_2_cooling_temperature_offset")]
public System.Nullable<float> Stage2CoolingTemperatureOffset { get; set; } = null;
        

[Description(@"The cooling temperature offset is used to determine cooling stage number for multi stage equipment. When the temperature difference of the cooling setpoint and the controlled zone temperature at previous time step is greater than Stage 3 value and less than Stage 4 value, the stage number is 3. The value of this field has to be greater than the value at the previous field.")]
[JsonProperty("stage_3_cooling_temperature_offset")]
public System.Nullable<float> Stage3CoolingTemperatureOffset { get; set; } = null;
        

[Description(@"The cooling temperature offset is used to determine cooling stage number for multi stage equipment. When the temperature difference of the cooling setpoint and the controlled zone temperature at previous time step is greater than Stage 4 value, the stage number is 4. The value of this field has to be greater than the value at the previous field.")]
[JsonProperty("stage_4_cooling_temperature_offset")]
public System.Nullable<float> Stage4CoolingTemperatureOffset { get; set; } = null;
    }
    
    [Description("Used to control a zone to a specified indoor level of CO2 or generic contaminants" +
        ", or to specify minimum CO2 concentration schedule name for a zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_ContaminantController : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Availability schedule name for CO2 controller. Schedule value > 0 means the CO2 c" +
    "ontroller is enabled. If this field is blank, then CO2 controller is always enab" +
    "led.")]
[JsonProperty("carbon_dioxide_control_availability_schedule_name")]
public string CarbonDioxideControlAvailabilityScheduleName { get; set; } = "";
        

[Description("Schedule values should be carbon dioxide concentration in parts per million (ppm)" +
    "")]
[JsonProperty("carbon_dioxide_setpoint_schedule_name")]
public string CarbonDioxideSetpointScheduleName { get; set; } = "";
        

[Description(@"Schedule values should be carbon dioxide concentration in parts per million (ppm) This field is used when the field System Outdoor Air Method = ProportionalControlBasedOnOccupancySchedule or ProportionalControlBasedOnDesignOccupancy, or ProportionalControlBasedOnDesignOARate in Controller:MechanicalVentilation")]
[JsonProperty("minimum_carbon_dioxide_concentration_schedule_name")]
public string MinimumCarbonDioxideConcentrationScheduleName { get; set; } = "";
        

[Description(@"Schedule values should be carbon dioxide concentration in parts per million (ppm) This field is used when the field System Outdoor Air Method = ProportionalControlBasedOnOccupancySchedule or ProportionalControlBasedOnDesignOccupancy or ProportionalControlBasedOnDesignOARate.")]
[JsonProperty("maximum_carbon_dioxide_concentration_schedule_name")]
public string MaximumCarbonDioxideConcentrationScheduleName { get; set; } = "";
        

[Description("Availability schedule name for generic contaminant controller. Schedule value > 0" +
    " means the generic contaminant controller is enabled. If this field is blank, th" +
    "en generic contaminant controller is always enabled.")]
[JsonProperty("generic_contaminant_control_availability_schedule_name")]
public string GenericContaminantControlAvailabilityScheduleName { get; set; } = "";
        

[Description("Schedule values should be generic contaminant concentration in parts per million " +
    "(ppm) This field is used when the field System Outdoor Air Method = IndoorAirQua" +
    "lityProcedureGenericContaminant in Controller:MechanicalVentilation")]
[JsonProperty("generic_contaminant_setpoint_schedule_name")]
public string GenericContaminantSetpointScheduleName { get; set; } = "";
    }
}
