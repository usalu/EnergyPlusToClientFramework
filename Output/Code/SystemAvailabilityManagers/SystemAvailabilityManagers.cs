namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
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
    
    
    [Description("Determines the availability of a loop or system: whether it is on or off. Schedul" +
        "e overrides fan/pump schedule.")]
    [JsonObject("AvailabilityManager:Scheduled")]
    public class AvailabilityManager_Scheduled : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
    }
    
    [Description("Determines the availability of a loop or system: only controls the turn on action" +
        ". Schedule overrides fan/pump schedule.")]
    [JsonObject("AvailabilityManager:ScheduledOn")]
    public class AvailabilityManager_ScheduledOn : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
    }
    
    [Description("Determines the availability of a loop or system: only controls the turn off actio" +
        "n. Schedule overrides fan/pump schedule.")]
    [JsonObject("AvailabilityManager:ScheduledOff")]
    public class AvailabilityManager_ScheduledOff : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
    }
    
    [Description("Determines the optimal start of HVAC systems before occupancy.")]
    [JsonObject("AvailabilityManager:OptimumStart")]
    public class AvailabilityManager_OptimumStart : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("applicability_schedule_name")]
public string ApplicabilityScheduleName { get; set; } = "";
        

[JsonProperty("fan_schedule_name")]
public string FanScheduleName { get; set; } = "";
        

[JsonProperty("control_type")]
public AvailabilityManager_OptimumStart_ControlType ControlType { get; set; } = (AvailabilityManager_OptimumStart_ControlType)Enum.Parse(typeof(AvailabilityManager_OptimumStart_ControlType), "ControlZone");
        

[JsonProperty("control_zone_name")]
public string ControlZoneName { get; set; } = "";
        

[JsonProperty("zone_list_name")]
public string ZoneListName { get; set; } = "";
        

[Description("this is the maximum number of hours that a system can start before occupancy")]
[JsonProperty("maximum_value_for_optimum_start_time")]
public System.Nullable<float> MaximumValueForOptimumStartTime { get; set; } = (System.Nullable<float>)Single.Parse("6", CultureInfo.InvariantCulture);
        

[JsonProperty("control_algorithm")]
public AvailabilityManager_OptimumStart_ControlAlgorithm ControlAlgorithm { get; set; } = (AvailabilityManager_OptimumStart_ControlAlgorithm)Enum.Parse(typeof(AvailabilityManager_OptimumStart_ControlAlgorithm), "AdaptiveASHRAE");
        

[JsonProperty("constant_temperature_gradient_during_cooling")]
public System.Nullable<float> ConstantTemperatureGradientDuringCooling { get; set; } = null;
        

[JsonProperty("constant_temperature_gradient_during_heating")]
public System.Nullable<float> ConstantTemperatureGradientDuringHeating { get; set; } = null;
        

[JsonProperty("initial_temperature_gradient_during_cooling")]
public System.Nullable<float> InitialTemperatureGradientDuringCooling { get; set; } = null;
        

[JsonProperty("initial_temperature_gradient_during_heating")]
public System.Nullable<float> InitialTemperatureGradientDuringHeating { get; set; } = null;
        

[Description("this is the number of hours before occupancy for a system")]
[JsonProperty("constant_start_time")]
public System.Nullable<float> ConstantStartTime { get; set; } = null;
        

[Description("this is the number of days that their actual temperature gradients will be used i" +
    "n the AdaptiveTemperatureGradient method")]
[JsonProperty("number_of_previous_days")]
public System.Nullable<float> NumberOfPreviousDays { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
    
    public enum AvailabilityManager_OptimumStart_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ControlZone")]
        ControlZone = 1,
        
        [JsonProperty("MaximumofZoneList")]
        MaximumofZoneList = 2,
        
        [JsonProperty("StayOff")]
        StayOff = 3,
    }
    
    public enum AvailabilityManager_OptimumStart_ControlAlgorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AdaptiveASHRAE")]
        AdaptiveASHRAE = 1,
        
        [JsonProperty("AdaptiveTemperatureGradient")]
        AdaptiveTemperatureGradient = 2,
        
        [JsonProperty("ConstantStartTime")]
        ConstantStartTime = 3,
        
        [JsonProperty("ConstantTemperatureGradient")]
        ConstantTemperatureGradient = 4,
    }
    
    [Description("Determines the availability of a loop or system: whether it is on or off. Dependi" +
        "ng on zone temperatures, overrides Schedules and forces system Fans on.")]
    [JsonObject("AvailabilityManager:NightCycle")]
    public class AvailabilityManager_NightCycle : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("applicability_schedule_name")]
public string ApplicabilityScheduleName { get; set; } = "";
        

[JsonProperty("fan_schedule_name")]
public string FanScheduleName { get; set; } = "";
        

[Description("When AvailabilityManager:NightCycle is used in the zone component availability ma" +
    "nager assignment list, the key choices for Control Type would only be StayOff an" +
    "d CycleOnControlZone")]
[JsonProperty("control_type")]
public AvailabilityManager_NightCycle_ControlType ControlType { get; set; } = (AvailabilityManager_NightCycle_ControlType)Enum.Parse(typeof(AvailabilityManager_NightCycle_ControlType), "StayOff");
        

[JsonProperty("thermostat_tolerance")]
public System.Nullable<float> ThermostatTolerance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cycling_run_time_control_type")]
public AvailabilityManager_NightCycle_CyclingRunTimeControlType CyclingRunTimeControlType { get; set; } = (AvailabilityManager_NightCycle_CyclingRunTimeControlType)Enum.Parse(typeof(AvailabilityManager_NightCycle_CyclingRunTimeControlType), "FixedRunTime");
        

[JsonProperty("cycling_run_time")]
public System.Nullable<float> CyclingRunTime { get; set; } = (System.Nullable<float>)Single.Parse("3600", CultureInfo.InvariantCulture);
        

[Description("When AvailabilityManager:NightCycle is used in the zone component availability ma" +
    "nager assignment list, the Control Zone Name should be the name of the zone in w" +
    "hich the zone component is.")]
[JsonProperty("control_zone_or_zone_list_name")]
public string ControlZoneOrZoneListName { get; set; } = "";
        

[JsonProperty("cooling_control_zone_or_zone_list_name")]
public string CoolingControlZoneOrZoneListName { get; set; } = "";
        

[JsonProperty("heating_control_zone_or_zone_list_name")]
public string HeatingControlZoneOrZoneListName { get; set; } = "";
        

[JsonProperty("heating_zone_fans_only_zone_or_zone_list_name")]
public string HeatingZoneFansOnlyZoneOrZoneListName { get; set; } = "";
    }
    
    public enum AvailabilityManager_NightCycle_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnAnyCoolingOrHeatingZone")]
        CycleOnAnyCoolingOrHeatingZone = 2,
        
        [JsonProperty("CycleOnAnyCoolingZone")]
        CycleOnAnyCoolingZone = 3,
        
        [JsonProperty("CycleOnAnyHeatingZone")]
        CycleOnAnyHeatingZone = 4,
        
        [JsonProperty("CycleOnAnyHeatingZoneFansOnly")]
        CycleOnAnyHeatingZoneFansOnly = 5,
        
        [JsonProperty("CycleOnAnyZoneFansOnly")]
        CycleOnAnyZoneFansOnly = 6,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 7,
        
        [JsonProperty("StayOff")]
        StayOff = 8,
    }
    
    public enum AvailabilityManager_NightCycle_CyclingRunTimeControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedRunTime")]
        FixedRunTime = 1,
        
        [JsonProperty("Thermostat")]
        Thermostat = 2,
        
        [JsonProperty("ThermostatWithMinimumRunTime")]
        ThermostatWithMinimumRunTime = 3,
    }
    
    [Description("Overrides fan/pump schedules depending on temperature difference between two node" +
        "s.")]
    [JsonObject("AvailabilityManager:DifferentialThermostat")]
    public class AvailabilityManager_DifferentialThermostat : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("hot_node_name")]
public string HotNodeName { get; set; } = "";
        

[JsonProperty("cold_node_name")]
public string ColdNodeName { get; set; } = "";
        

[JsonProperty("temperature_difference_on_limit")]
public System.Nullable<float> TemperatureDifferenceOnLimit { get; set; } = null;
        

[Description("Defaults to Temperature Difference On Limit.")]
[JsonProperty("temperature_difference_off_limit")]
public System.Nullable<float> TemperatureDifferenceOffLimit { get; set; } = null;
    }
    
    [Description("Overrides fan/pump schedules depending on temperature at sensor node.")]
    [JsonObject("AvailabilityManager:HighTemperatureTurnOff")]
    public class AvailabilityManager_HighTemperatureTurnOff : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("sensor_node_name")]
public string SensorNodeName { get; set; } = "";
        

[JsonProperty("temperature")]
public System.Nullable<float> Temperature { get; set; } = null;
    }
    
    [Description("Overrides fan/pump schedules depending on temperature at sensor node.")]
    [JsonObject("AvailabilityManager:HighTemperatureTurnOn")]
    public class AvailabilityManager_HighTemperatureTurnOn : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("sensor_node_name")]
public string SensorNodeName { get; set; } = "";
        

[JsonProperty("temperature")]
public System.Nullable<float> Temperature { get; set; } = null;
    }
    
    [Description("Overrides fan/pump schedules depending on temperature at sensor node.")]
    [JsonObject("AvailabilityManager:LowTemperatureTurnOff")]
    public class AvailabilityManager_LowTemperatureTurnOff : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("sensor_node_name")]
public string SensorNodeName { get; set; } = "";
        

[JsonProperty("temperature")]
public System.Nullable<float> Temperature { get; set; } = null;
        

[Description("If blank, defaults to always active")]
[JsonProperty("applicability_schedule_name")]
public string ApplicabilityScheduleName { get; set; } = "";
    }
    
    [Description("Overrides fan/pump schedules depending on temperature at sensor node.")]
    [JsonObject("AvailabilityManager:LowTemperatureTurnOn")]
    public class AvailabilityManager_LowTemperatureTurnOn : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("sensor_node_name")]
public string SensorNodeName { get; set; } = "";
        

[JsonProperty("temperature")]
public System.Nullable<float> Temperature { get; set; } = null;
    }
    
    [Description("depending on zone and outdoor conditions overrides fan schedule to do precooling " +
        "with outdoor air")]
    [JsonObject("AvailabilityManager:NightVentilation")]
    public class AvailabilityManager_NightVentilation : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("applicability_schedule_name")]
public string ApplicabilityScheduleName { get; set; } = "";
        

[JsonProperty("fan_schedule_name")]
public string FanScheduleName { get; set; } = "";
        

[Description("One zone temperature must be above this scheduled temperature for night ventilati" +
    "on to be enabled")]
[JsonProperty("ventilation_temperature_schedule_name")]
public string VentilationTemperatureScheduleName { get; set; } = "";
        

[Description("The outdoor air temperature minus the control zone temperature must be greater th" +
    "an the ventilation delta T")]
[JsonProperty("ventilation_temperature_difference")]
public System.Nullable<float> VentilationTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("Night ventilation is disabled if any conditioned zone served by the system falls " +
    "below this temperature")]
[JsonProperty("ventilation_temperature_low_limit")]
public System.Nullable<float> VentilationTemperatureLowLimit { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[Description("the fraction (could be > 1) of the design system Flow Rate at which night ventila" +
    "tion will be done")]
[JsonProperty("night_venting_flow_fraction")]
public System.Nullable<float> NightVentingFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("When AvailabilityManager:NightVentilation is used in the zone component availabil" +
    "ity manager assignment list, the Control Zone Name should be the name of the zon" +
    "e in which the zone component is.")]
[JsonProperty("control_zone_name")]
public string ControlZoneName { get; set; } = "";
    }
    
    [Description(@"Depending on zone and outdoor conditions overrides window/door opening controls to maximize natural ventilation and turn off an HVAC system when ventilation control conditions are met. This object (zone ventilation object name) has not been instrumented to work with global Zone or Zone List names option for Ventilation:DesignFlowRate. In order to use, you must enter the single <Ventilation:DesignFlowRate> name in that field. If it is a part of a global ventilation assignment the name will be <Zone Name> <global Ventilation:DesignFlowRate> name. Currently, hybrid ventilation manager is restricted to one per zone. It can either be applied through the air loop or directly to the zone. If hybrid ventilation manager is applied to an air loop and one of the zones served by that air loop also has hybrid ventilation manager, then zone hybrid ventilation manager is disabled.")]
    [JsonObject("AvailabilityManager:HybridVentilation")]
    public class AvailabilityManager_HybridVentilation : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an AirLoopHVAC or HVACTemplate:System:* object. If this field i" +
    "s left blank, hybrid ventilation managers will be simulated for zone equipment c" +
    "ontrol")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[Description("the zone name should be a zone where a thermostat or humidistat is located served" +
    " by an air primary loop.")]
[JsonProperty("control_zone_name")]
public string ControlZoneName { get; set; } = "";
        

[Description(@"The Ventilation control mode contains appropriate integer control types. 0 - uncontrolled (Natural ventilation and HVAC system are controlled by themselves) 1 = Temperature control 2 = Enthalpy control 3 = Dewpoint control 4 = Outdoor ventilation air control 5 = Operative temperature control with 80% adaptive comfort acceptability limits 6 = Operative temperature control with 90% adaptive comfort acceptability limits 7 = Carbon dioxide control")]
[JsonProperty("ventilation_control_mode_schedule_name")]
public string VentilationControlModeScheduleName { get; set; } = "";
        

[Description("If Yes, ventilation is shutoff when there is rain If No, there is no rain control" +
    "")]
[JsonProperty("use_weather_file_rain_indicators")]
public EmptyNoYes UseWeatherFileRainIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("this is the wind speed above which ventilation is shutoff")]
[JsonProperty("maximum_wind_speed")]
public System.Nullable<float> MaximumWindSpeed { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
        

[Description("this is the outdoor temperature below which ventilation is shutoff")]
[JsonProperty("minimum_outdoor_temperature")]
public System.Nullable<float> MinimumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

[Description("this is the outdoor temperature above which ventilation is shutoff")]
[JsonProperty("maximum_outdoor_temperature")]
public System.Nullable<float> MaximumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

[Description("this is the outdoor Enthalpy below which ventilation is shutoff")]
[JsonProperty("minimum_outdoor_enthalpy")]
public System.Nullable<float> MinimumOutdoorEnthalpy { get; set; } = null;
        

[Description("this is the outdoor Enthalpy above which ventilation is shutoff")]
[JsonProperty("maximum_outdoor_enthalpy")]
public System.Nullable<float> MaximumOutdoorEnthalpy { get; set; } = null;
        

[Description("this is the outdoor temperature below which ventilation is shutoff Applicable onl" +
    "y if Ventilation Control Mode = 3")]
[JsonProperty("minimum_outdoor_dewpoint")]
public System.Nullable<float> MinimumOutdoorDewpoint { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

[Description("this is the outdoor dewpoint above which ventilation is shutoff Applicable only i" +
    "f Ventilation Control Mode = 3")]
[JsonProperty("maximum_outdoor_dewpoint")]
public System.Nullable<float> MaximumOutdoorDewpoint { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

[Description("Used only if Ventilation Control Mode = 4")]
[JsonProperty("minimum_outdoor_ventilation_air_schedule_name")]
public string MinimumOutdoorVentilationAirScheduleName { get; set; } = "";
        

[Description("linear curve = a + b*WS quadratic curve = a + b*WS + c*WS**2 WS = wind speed (m/s" +
    ")")]
[JsonProperty("opening_factor_function_of_wind_speed_curve_name")]
public string OpeningFactorFunctionOfWindSpeedCurveName { get; set; } = "";
        

[Description("The schedule is used to incorporate operation of AirflowNetwork large opening obj" +
    "ects and HVAC system operation.")]
[JsonProperty("airflownetwork_control_type_schedule_name")]
public string AirflownetworkControlTypeScheduleName { get; set; } = "";
        

[Description("The schedule is used to incorporate operation of simple airflow objects and HVAC " +
    "system operation. The simple airflow objects are Ventilation and Mixing only")]
[JsonProperty("simple_airflow_control_type_schedule_name")]
public string SimpleAirflowControlTypeScheduleName { get; set; } = "";
        

[Description(@"This field has not been instrumented to work with global Zone or Zone List names option for Ventilation:DesignFlowRate. In order to use, you must enter the single <Ventilation:DesignFlowRate> name in this field. If it is a part of a global ventilation assignment the name will be <Zone Name> <global Ventilation:DesignFlowRate> name. The other ZoneVentilation:* and ZoneMixing objects controlled in the same AirLoopHVAC will work in the same way as this ventilation object.")]
[JsonProperty("zoneventilation_object_name")]
public string ZoneventilationObjectName { get; set; } = "";
        

[Description("Minimum operation time when HVAC system is forced on.")]
[JsonProperty("minimum_hvac_operation_time")]
public System.Nullable<float> MinimumHvacOperationTime { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Minimum ventilation time when natural ventilation is forced on.")]
[JsonProperty("minimum_ventilation_time")]
public System.Nullable<float> MinimumVentilationTime { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description(@"Defines the applicable managers used for an AirLoopHVAC or PlantLoop. The priority of availability managers is based on a set of rules and are specific to the type of loop. The output from each availability manager is an availability status flag: NoAction, ForceOff, CycleOn, or CycleOnZoneFansOnly (used only for air loops).")]
    [JsonObject("AvailabilityManagerAssignmentList")]
    public class AvailabilityManagerAssignmentList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("managers")]
public string Managers { get; set; } = "";
    }
}
