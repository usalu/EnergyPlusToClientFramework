namespace BH.oM.Adapters.EnergyPlus.Controllers
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
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description(@"Controller for a water coil which is located directly in an air loop branch or outdoor air equipment list. Controls the coil water flow to meet the specified leaving air setpoint(s). Used with Coil:Heating:Water, Coil:Cooling:Water, Coil:Cooling:Water:DetailedGeometry, and CoilSystem:Cooling:Water:HeatexchangerAssisted.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Controller_WaterCoil : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("keys HumidityRatio or TemperatureAndHumidityRatio requires a ZoneControl:Humidist" +
    "at object along with SetpointManager:SingleZone:Humidity:Maximum, SetpointManage" +
    "r:MultiZone:MaximumHumidity:Average, or SetpointManager:Multizone:Humidity:Maxim" +
    "um object")]
[JsonProperty(PropertyName="control_variable", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Controller_WaterCoil_ControlVariable ControlVariable { get; set; } = (Controller_WaterCoil_ControlVariable)Enum.Parse(typeof(Controller_WaterCoil_ControlVariable), "HumidityRatio");
        

[Description("Leave blank to have this automatically selected from coil type. Chilled water coi" +
    "ls should be reverse action Hot water coils should be normal action")]
[JsonProperty(PropertyName="action", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Controller_WaterCoil_Action Action { get; set; } = (Controller_WaterCoil_Action)Enum.Parse(typeof(Controller_WaterCoil_Action), "Normal");
        

[JsonProperty(PropertyName="actuator_variable", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Controller_WaterCoil_ActuatorVariable ActuatorVariable { get; set; } = (Controller_WaterCoil_ActuatorVariable)Enum.Parse(typeof(Controller_WaterCoil_ActuatorVariable), "Flow");
        

[JsonProperty(PropertyName="sensor_node_name")]
public string SensorNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="actuator_node_name")]
public string ActuatorNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="controller_convergence_tolerance", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> ControllerConvergenceTolerance { get; set; } = null;
        

[JsonProperty(PropertyName="maximum_actuated_flow", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> MaximumActuatedFlow { get; set; } = null;
        

[JsonProperty(PropertyName="minimum_actuated_flow")]
public System.Nullable<float> MinimumActuatedFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum Controller_WaterCoil_ControlVariable
    {
        
        [System.Runtime.Serialization.EnumMember(Value="HumidityRatio")]
        HumidityRatio = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureAndHumidityRatio")]
        TemperatureAndHumidityRatio = 2,
    }
    
    public enum Controller_WaterCoil_Action
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Normal")]
        Normal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Reverse")]
        Reverse = 1,
    }
    
    public enum Controller_WaterCoil_ActuatorVariable
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Flow")]
        Flow = 0,
    }
    
    [Description("Controller to set the outdoor air flow rate for an air loop. Control options incl" +
        "ude fixed, proportional, scheduled, economizer, and demand-controlled ventilatio" +
        "n.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Controller_OutdoorAir : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="relief_air_outlet_node_name")]
public string ReliefAirOutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="return_air_node_name")]
public string ReturnAirNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="mixed_air_node_name")]
public string MixedAirNodeName { get; set; } = "";
        

[Description("Outdoor air inlet node entering the first pre-treat component if any")]
[JsonProperty(PropertyName="actuator_node_name")]
public string ActuatorNodeName { get; set; } = "";
        

[Description("If there is a Mechanical Ventilation Controller (Controller:MechanicalVentilation" +
    "), note that this value times the Minimum Outdoor Air Schedule is a hard minimum" +
    " that may override DCV or other advanced OA controls.")]
[JsonProperty(PropertyName="minimum_outdoor_air_flow_rate", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> MinimumOutdoorAirFlowRate { get; set; } = null;
        

[JsonProperty(PropertyName="maximum_outdoor_air_flow_rate", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> MaximumOutdoorAirFlowRate { get; set; } = null;
        

[JsonProperty(PropertyName="economizer_control_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Controller_OutdoorAir_EconomizerControlType EconomizerControlType { get; set; } = (Controller_OutdoorAir_EconomizerControlType)Enum.Parse(typeof(Controller_OutdoorAir_EconomizerControlType), "NoEconomizer");
        

[JsonProperty(PropertyName="economizer_control_action_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Controller_OutdoorAir_EconomizerControlActionType EconomizerControlActionType { get; set; } = (Controller_OutdoorAir_EconomizerControlActionType)Enum.Parse(typeof(Controller_OutdoorAir_EconomizerControlActionType), "ModulateFlow");
        

[Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb economizer " +
    "control type. No input or blank input means this limit is not operative. Limit i" +
    "s applied regardless of economizer control type.")]
[JsonProperty(PropertyName="economizer_maximum_limit_dry_bulb_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDryBulbTemperature { get; set; } = null;
        

[Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control typ" +
    "e. No input or blank input means this limit is not operative Limit is applied re" +
    "gardless of economizer control type.")]
[JsonProperty(PropertyName="economizer_maximum_limit_enthalpy")]
public System.Nullable<float> EconomizerMaximumLimitEnthalpy { get; set; } = null;
        

[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
    "economizer control type. No input or blank input means this limit is not operati" +
    "ve. Limit is applied regardless of economizer control type.")]
[JsonProperty(PropertyName="economizer_maximum_limit_dewpoint_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

[Description(@"Enter the name of a quadratic or cubic curve which defines the maximum outdoor humidity ratio (function of outdoor dry-bulb temperature) for ElectronicEnthalpy economizer control type. No input or blank input means this limit is not operative Limit is applied regardless of economizer control type.")]
[JsonProperty(PropertyName="electronic_enthalpy_limit_curve_name")]
public string ElectronicEnthalpyLimitCurveName { get; set; } = "";
        

[Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control. No i" +
    "nput or blank input means this limit is not operative Limit is applied regardles" +
    "s of economizer control type.")]
[JsonProperty(PropertyName="economizer_minimum_limit_dry_bulb_temperature")]
public System.Nullable<float> EconomizerMinimumLimitDryBulbTemperature { get; set; } = null;
        

[JsonProperty(PropertyName="lockout_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Controller_OutdoorAir_LockoutType LockoutType { get; set; } = (Controller_OutdoorAir_LockoutType)Enum.Parse(typeof(Controller_OutdoorAir_LockoutType), "NoLockout");
        

[JsonProperty(PropertyName="minimum_limit_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Controller_OutdoorAir_MinimumLimitType MinimumLimitType { get; set; } = (Controller_OutdoorAir_MinimumLimitType)Enum.Parse(typeof(Controller_OutdoorAir_MinimumLimitType), "ProportionalMinimum");
        

[Description("Schedule values multiply the minimum outdoor air flow rate")]
[JsonProperty(PropertyName="minimum_outdoor_air_schedule_name")]
public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

[Description("schedule values multiply the design/mixed air flow rate")]
[JsonProperty(PropertyName="minimum_fraction_of_outdoor_air_schedule_name")]
public string MinimumFractionOfOutdoorAirScheduleName { get; set; } = "";
        

[Description("schedule values multiply the design/mixed air flow rate")]
[JsonProperty(PropertyName="maximum_fraction_of_outdoor_air_schedule_name")]
public string MaximumFractionOfOutdoorAirScheduleName { get; set; } = "";
        

[Description("Enter the name of a Controller:MechanicalVentilation object. Optional field for d" +
    "efining outdoor ventilation air based on flow rate per unit floor area and flow " +
    "rate per person. Simplified method of demand-controlled ventilation.")]
[JsonProperty(PropertyName="mechanical_ventilation_controller_name")]
public string MechanicalVentilationControllerName { get; set; } = "";
        

[Description(@"Optional schedule to simulate ""push-button"" type economizer control. Schedule values greater than 0 indicate time-of-day economizer control is enabled. Economizer control may be used with or without the high humidity control option. When used together, high humidity control has priority over economizer control. If the field Economizer Control Type = NoEconomizer, then this option is disabled.")]
[JsonProperty(PropertyName="time_of_day_economizer_control_schedule_name")]
public string TimeOfDayEconomizerControlScheduleName { get; set; } = "";
        

[Description(@"Optional field to enable modified outdoor air flow rates based on zone relative humidity. Select Yes to modify outdoor air flow rate based on a zone humidistat. Select No to disable this feature. If the field Economizer Control Type = NoEconomizer, then this option is disabled.")]
[JsonProperty(PropertyName="high_humidity_control", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes HighHumidityControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Enter the name of the zone where the humidistat is located. This field is only us" +
    "ed when the field High Humidity Control = Yes.")]
[JsonProperty(PropertyName="humidistat_control_zone_name")]
public string HumidistatControlZoneName { get; set; } = "";
        

[Description("Enter the ratio of outdoor air to the maximum outdoor air flow rate when modified" +
    " air flow rates are active based on high indoor humidity. The minimum value must" +
    " be greater than 0. This field is only used when the field High Humidity Control" +
    " = Yes.")]
[JsonProperty(PropertyName="high_humidity_outdoor_air_flow_ratio")]
public System.Nullable<float> HighHumidityOutdoorAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"If No is selected, the outdoor air flow rate is modified any time indoor relative humidity is above the humidistat setpoint. If Yes is selected, the outdoor air flow rate is modified any time the indoor relative humidity is above the humidistat setpoint and the outdoor humidity ratio is less than the indoor humidity ratio. This field is only used when the field High Humidity Control = Yes.")]
[JsonProperty(PropertyName="control_high_indoor_humidity_based_on_outdoor_humidity_ratio", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes ControlHighIndoorHumidityBasedOnOutdoorHumidityRatio { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description(@"BypassWhenWithinEconomizerLimits specifies that heat recovery is active only when the economizer is off because conditions are outside the economizer control limits BypassWhenOAFlowGreaterThanMinimum specifies enhanced economizer controls to allow heat recovery when economizer is active (within limits) but the outdoor air flow rate is at the minimum.")]
[JsonProperty(PropertyName="heat_recovery_bypass_control_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Controller_OutdoorAir_HeatRecoveryBypassControlType HeatRecoveryBypassControlType { get; set; } = (Controller_OutdoorAir_HeatRecoveryBypassControlType)Enum.Parse(typeof(Controller_OutdoorAir_HeatRecoveryBypassControlType), "BypassWhenWithinEconomizerLimits");
    }
    
    public enum Controller_OutdoorAir_EconomizerControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedDryBulb")]
        FixedDryBulb = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="NoEconomizer")]
        NoEconomizer = 8,
    }
    
    public enum Controller_OutdoorAir_EconomizerControlActionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MinimumFlowWithBypass")]
        MinimumFlowWithBypass = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ModulateFlow")]
        ModulateFlow = 2,
    }
    
    public enum Controller_OutdoorAir_LockoutType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LockoutWithCompressor")]
        LockoutWithCompressor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LockoutWithHeating")]
        LockoutWithHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="NoLockout")]
        NoLockout = 3,
    }
    
    public enum Controller_OutdoorAir_MinimumLimitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedMinimum")]
        FixedMinimum = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalMinimum")]
        ProportionalMinimum = 2,
    }
    
    public enum Controller_OutdoorAir_HeatRecoveryBypassControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BypassWhenOAFlowGreaterThanMinimum")]
        BypassWhenOAFlowGreaterThanMinimum = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="BypassWhenWithinEconomizerLimits")]
        BypassWhenWithinEconomizerLimits = 2,
    }
    
    [Description(@"This object is used in conjunction with Controller:OutdoorAir to specify outdoor ventilation air based on outdoor air specified in the DesignSpecification:OutdoorAir object The Controller:OutdoorAir object is associated with a specific air loop, so the outdoor air flow rates specified in Controller:MechanicalVentilation correspond to the zones attached to that specific air loop. Duplicate groups of Zone name, Design Specification Outdoor Air Object Name, and Design Specification Zone Air Distribution Object Name to increase allowable number of entries")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Controller_MechanicalVentilation : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("If this field is blank, the controller uses the values from the associated Contro" +
    "ller:OutdoorAir. Schedule values greater than 0 indicate mechanical ventilation " +
    "is enabled")]
[JsonProperty(PropertyName="availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty(PropertyName="demand_controlled_ventilation", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes DemandControlledVentilation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty(PropertyName="system_outdoor_air_method", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Controller_MechanicalVentilation_SystemOutdoorAirMethod SystemOutdoorAirMethod { get; set; } = (Controller_MechanicalVentilation_SystemOutdoorAirMethod)Enum.Parse(typeof(Controller_MechanicalVentilation_SystemOutdoorAirMethod), "VentilationRateProcedure");
        

[JsonProperty(PropertyName="zone_maximum_outdoor_air_fraction")]
public System.Nullable<float> ZoneMaximumOutdoorAirFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="zone_specifications")]
public string ZoneSpecifications { get; set; } = "";
    }
    
    public enum Controller_MechanicalVentilation_SystemOutdoorAirMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAirQualityProcedure")]
        IndoorAirQualityProcedure = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAirQualityProcedureCombined")]
        IndoorAirQualityProcedureCombined = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAirQualityProcedureGenericContaminant")]
        IndoorAirQualityProcedureGenericContaminant = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnDesignOARate")]
        ProportionalControlBasedOnDesignOARate = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnDesignOccupancy")]
        ProportionalControlBasedOnDesignOccupancy = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnOccupancySchedule")]
        ProportionalControlBasedOnOccupancySchedule = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VentilationRateProcedure")]
        VentilationRateProcedure = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneSum")]
        ZoneSum = 8,
    }
    
    [Description("List controllers in order of control sequence")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_ControllerList : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="controller_1_object_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_ControllerList_Controller1ObjectType Controller1ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller1ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller1ObjectType), "ControllerOutdoorAir");
        

[JsonProperty(PropertyName="controller_1_name")]
public string Controller1Name { get; set; } = "";
        

[JsonProperty(PropertyName="controller_2_object_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_ControllerList_Controller2ObjectType Controller2ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller2ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller2ObjectType), "ControllerOutdoorAir");
        

[JsonProperty(PropertyName="controller_2_name")]
public string Controller2Name { get; set; } = "";
        

[JsonProperty(PropertyName="controller_3_object_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_ControllerList_Controller3ObjectType Controller3ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller3ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller3ObjectType), "ControllerOutdoorAir");
        

[JsonProperty(PropertyName="controller_3_name")]
public string Controller3Name { get; set; } = "";
        

[JsonProperty(PropertyName="controller_4_object_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_ControllerList_Controller4ObjectType Controller4ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller4ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller4ObjectType), "ControllerOutdoorAir");
        

[JsonProperty(PropertyName="controller_4_name")]
public string Controller4Name { get; set; } = "";
        

[JsonProperty(PropertyName="controller_5_object_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_ControllerList_Controller5ObjectType Controller5ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller5ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller5ObjectType), "ControllerOutdoorAir");
        

[JsonProperty(PropertyName="controller_5_name")]
public string Controller5Name { get; set; } = "";
        

[JsonProperty(PropertyName="controller_6_object_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_ControllerList_Controller6ObjectType Controller6ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller6ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller6ObjectType), "ControllerOutdoorAir");
        

[JsonProperty(PropertyName="controller_6_name")]
public string Controller6Name { get; set; } = "";
        

[JsonProperty(PropertyName="controller_7_object_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_ControllerList_Controller7ObjectType Controller7ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller7ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller7ObjectType), "ControllerOutdoorAir");
        

[JsonProperty(PropertyName="controller_7_name")]
public string Controller7Name { get; set; } = "";
        

[JsonProperty(PropertyName="controller_8_object_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_ControllerList_Controller8ObjectType Controller8ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller8ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller8ObjectType), "ControllerOutdoorAir");
        

[JsonProperty(PropertyName="controller_8_name")]
public string Controller8Name { get; set; } = "";
    }
    
    public enum AirLoopHVAC_ControllerList_Controller1ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:WaterCoil")]
        ControllerWaterCoil = 1,
    }
    
    public enum AirLoopHVAC_ControllerList_Controller2ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:WaterCoil")]
        ControllerWaterCoil = 1,
    }
    
    public enum AirLoopHVAC_ControllerList_Controller3ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:WaterCoil")]
        ControllerWaterCoil = 1,
    }
    
    public enum AirLoopHVAC_ControllerList_Controller4ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:WaterCoil")]
        ControllerWaterCoil = 1,
    }
    
    public enum AirLoopHVAC_ControllerList_Controller5ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:WaterCoil")]
        ControllerWaterCoil = 1,
    }
    
    public enum AirLoopHVAC_ControllerList_Controller6ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:WaterCoil")]
        ControllerWaterCoil = 1,
    }
    
    public enum AirLoopHVAC_ControllerList_Controller7ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:WaterCoil")]
        ControllerWaterCoil = 1,
    }
    
    public enum AirLoopHVAC_ControllerList_Controller8ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Controller:WaterCoil")]
        ControllerWaterCoil = 1,
    }
}
