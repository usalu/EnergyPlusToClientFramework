namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
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
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description(@"Infiltration is specified as a design level which is modified by a Schedule fraction, temperature difference and wind speed: Infiltration=Idesign * FSchedule * (A + B*|(Tzone-Todb)| + C*WindSpd + D * WindSpd**2) If you use a ZoneList in the Zone or ZoneList name field then this definition applies to all the zones in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneInfiltration_DesignFlowRate : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[JsonProperty(PropertyName="schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of infiltration for this set of attributes Choices: Flow/Zone => Design Flow Rate -- simply enter Design Flow Rate Flow/Area => Flow per Zone Floor Area - Value * Floor Area (zone) = Design Flow Rate Flow/ExteriorArea => Flow per Exterior Surface Area - Value * Exterior Surface Area (zone) = Design Flow Rate Flow/ExteriorWallArea => Flow per Exterior Surface Area - Value * Exterior Wall Surface Area (zone) = Design Flow Rate AirChanges/Hour => Air Changes per Hour - Value * Floor Volume (zone) adjusted for m3/s = Design Volume Flow Rate ""Idesign"" in Equation is the result.")]
[JsonProperty(PropertyName="design_flow_rate_calculation_method", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneInfiltration_DesignFlowRate_DesignFlowRateCalculationMethod DesignFlowRateCalculationMethod { get; set; } = (ZoneInfiltration_DesignFlowRate_DesignFlowRateCalculationMethod)Enum.Parse(typeof(ZoneInfiltration_DesignFlowRate_DesignFlowRateCalculationMethod), "Empty");
        

[JsonProperty(PropertyName="design_flow_rate")]
public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

[JsonProperty(PropertyName="flow_per_zone_floor_area")]
public System.Nullable<float> FlowPerZoneFloorArea { get; set; } = null;
        

[Description("use key Flow/ExteriorArea for all exterior surface area use key Flow/ExteriorWall" +
    "Area to include only exterior wall area")]
[JsonProperty(PropertyName="flow_per_exterior_surface_area")]
public System.Nullable<float> FlowPerExteriorSurfaceArea { get; set; } = null;
        

[JsonProperty(PropertyName="air_changes_per_hour")]
public System.Nullable<float> AirChangesPerHour { get; set; } = null;
        

[Description("\"A\" in Equation")]
[JsonProperty(PropertyName="constant_term_coefficient")]
public System.Nullable<float> ConstantTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("\"B\" in Equation")]
[JsonProperty(PropertyName="temperature_term_coefficient")]
public System.Nullable<float> TemperatureTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("\"C\" in Equation")]
[JsonProperty(PropertyName="velocity_term_coefficient")]
public System.Nullable<float> VelocityTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("\"D\" in Equation")]
[JsonProperty(PropertyName="velocity_squared_term_coefficient")]
public System.Nullable<float> VelocitySquaredTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum ZoneInfiltration_DesignFlowRate_DesignFlowRateCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirChanges/Hour")]
        AirChangesHour = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Area")]
        FlowArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/ExteriorArea")]
        FlowExteriorArea = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/ExteriorWallArea")]
        FlowExteriorWallArea = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 5,
    }
    
    [Description("Infiltration is specified as effective leakage area at 4 Pa, schedule fraction, s" +
        "tack and wind coefficients, and is a function of temperature difference and wind" +
        " speed: Infiltration=FSchedule * (AL /1000) SQRT(Cs*|(Tzone-Todb)| +  Cw*WindSpd" +
        "**2 )")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneInfiltration_EffectiveLeakageArea : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description("\"AL\" in Equation units are cm2 (square centimeters)")]
[JsonProperty(PropertyName="effective_air_leakage_area")]
public System.Nullable<float> EffectiveAirLeakageArea { get; set; } = null;
        

[Description("\"Cs\" in Equation")]
[JsonProperty(PropertyName="stack_coefficient")]
public System.Nullable<float> StackCoefficient { get; set; } = null;
        

[Description("\"Cw\" in Equation")]
[JsonProperty(PropertyName="wind_coefficient")]
public System.Nullable<float> WindCoefficient { get; set; } = null;
    }
    
    [Description("Infiltration is specified as flow coefficient, schedule fraction, stack and wind " +
        "coefficients, and is a function of temperature difference and wind speed: Infilt" +
        "ration=FSchedule * SQRT( (c * Cs*|(Tzone-Todb)|**n)**2 + (c* Cw*(s * WindSpd)**2" +
        "n)**2 )")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneInfiltration_FlowCoefficient : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description("\"c\" in Equation")]
[JsonProperty(PropertyName="flow_coefficient")]
public System.Nullable<float> FlowCoefficient { get; set; } = null;
        

[Description("\"Cs\" in Equation")]
[JsonProperty(PropertyName="stack_coefficient")]
public System.Nullable<float> StackCoefficient { get; set; } = null;
        

[Description("\"n\" in Equation")]
[JsonProperty(PropertyName="pressure_exponent")]
public System.Nullable<float> PressureExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.67", CultureInfo.InvariantCulture);
        

[Description("\"Cw\" in Equation")]
[JsonProperty(PropertyName="wind_coefficient")]
public System.Nullable<float> WindCoefficient { get; set; } = null;
        

[Description("\"s\" in Equation")]
[JsonProperty(PropertyName="shelter_factor")]
public System.Nullable<float> ShelterFactor { get; set; } = null;
    }
    
    [Description(@"Ventilation is specified as a design level which is modified by a schedule fraction, temperature difference and wind speed: Ventilation=Vdesign * Fschedule * (A + B*|(Tzone-Todb)| + C*WindSpd + D * WindSpd**2) If you use a ZoneList in the Zone or ZoneList name field then this definition applies to all the zones in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneVentilation_DesignFlowRate : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[JsonProperty(PropertyName="schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of ventilation for this set of attributes Choices: Flow/Zone => Design Flow Rate -- simply enter Design Flow Rate Flow/Area => Flow Rate per Zone Floor Area - Value * Floor Area (zone) = Design Flow Rate Flow/Person => Flow Rate per Person - Value * #people = Design Flow Rate AirChanges/Hour => Air Changes per Hour - Value * Floor Volume (zone) adjusted for m3/s = Design Volume Flow Rate ""Vdesign"" in Equation is the result.")]
[JsonProperty(PropertyName="design_flow_rate_calculation_method", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod DesignFlowRateCalculationMethod { get; set; } = (ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod)Enum.Parse(typeof(ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod), "Empty");
        

[JsonProperty(PropertyName="design_flow_rate")]
public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

[JsonProperty(PropertyName="flow_rate_per_zone_floor_area")]
public System.Nullable<float> FlowRatePerZoneFloorArea { get; set; } = null;
        

[JsonProperty(PropertyName="flow_rate_per_person")]
public System.Nullable<float> FlowRatePerPerson { get; set; } = null;
        

[JsonProperty(PropertyName="air_changes_per_hour")]
public System.Nullable<float> AirChangesPerHour { get; set; } = null;
        

[JsonProperty(PropertyName="ventilation_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneVentilation_DesignFlowRate_VentilationType VentilationType { get; set; } = (ZoneVentilation_DesignFlowRate_VentilationType)Enum.Parse(typeof(ZoneVentilation_DesignFlowRate_VentilationType), "Natural");
        

[Description("pressure rise across the fan")]
[JsonProperty(PropertyName="fan_pressure_rise")]
public System.Nullable<float> FanPressureRise { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="fan_total_efficiency")]
public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("\"A\" in Equation")]
[JsonProperty(PropertyName="constant_term_coefficient")]
public System.Nullable<float> ConstantTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("\"B\" in Equation")]
[JsonProperty(PropertyName="temperature_term_coefficient")]
public System.Nullable<float> TemperatureTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("\"C\" in Equation")]
[JsonProperty(PropertyName="velocity_term_coefficient")]
public System.Nullable<float> VelocityTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("\"D\" in Equation")]
[JsonProperty(PropertyName="velocity_squared_term_coefficient")]
public System.Nullable<float> VelocitySquaredTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("this is the indoor temperature below which ventilation is shutoff")]
[JsonProperty(PropertyName="minimum_indoor_temperature")]
public System.Nullable<float> MinimumIndoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the indoor temperature versus time below which ventilation" +
    " is shutoff.")]
[JsonProperty(PropertyName="minimum_indoor_temperature_schedule_name")]
public string MinimumIndoorTemperatureScheduleName { get; set; } = "";
        

[Description("this is the indoor temperature above which ventilation is shutoff")]
[JsonProperty(PropertyName="maximum_indoor_temperature")]
public System.Nullable<float> MaximumIndoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the indoor temperature versus time above which ventilation" +
    " is shutoff.")]
[JsonProperty(PropertyName="maximum_indoor_temperature_schedule_name")]
public string MaximumIndoorTemperatureScheduleName { get; set; } = "";
        

[Description(@"This is the temperature differential between indoor and outdoor below which ventilation is shutoff. If ((IndoorTemp - OutdoorTemp) < DeltaTemperature) then ventilation is not allowed. For example, if delta temperature is 2C, ventilation is assumed to be available if the outside air temperature is at least 2C cooler than the zone air temperature. The values for this field can include negative numbers. This allows ventilation to occur even if the outdoor temperature is above the indoor temperature.")]
[JsonProperty(PropertyName="delta_temperature")]
public System.Nullable<float> DeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the temperature differential between indoor and outdoor ve" +
    "rsus time below which ventilation is shutoff.")]
[JsonProperty(PropertyName="delta_temperature_schedule_name")]
public string DeltaTemperatureScheduleName { get; set; } = "";
        

[Description("this is the outdoor temperature below which ventilation is shutoff")]
[JsonProperty(PropertyName="minimum_outdoor_temperature")]
public System.Nullable<float> MinimumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the outdoor temperature versus time below which ventilatio" +
    "n is shutoff.")]
[JsonProperty(PropertyName="minimum_outdoor_temperature_schedule_name")]
public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

[Description("this is the outdoor temperature above which ventilation is shutoff")]
[JsonProperty(PropertyName="maximum_outdoor_temperature")]
public System.Nullable<float> MaximumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the outdoor temperature versus time above which ventilatio" +
    "n is shutoff.")]
[JsonProperty(PropertyName="maximum_outdoor_temperature_schedule_name")]
public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
        

[Description("this is the outdoor wind speed above which ventilation is shutoff")]
[JsonProperty(PropertyName="maximum_wind_speed")]
public System.Nullable<float> MaximumWindSpeed { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
    }
    
    public enum ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirChanges/Hour")]
        AirChangesHour = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Area")]
        FlowArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Person")]
        FlowPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 4,
    }
    
    public enum ZoneVentilation_DesignFlowRate_VentilationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Balanced")]
        Balanced = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Exhaust")]
        Exhaust = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Intake")]
        Intake = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Natural")]
        Natural = 4,
    }
    
    [Description(@"This object is specified as natural ventilation driven by wind and stack effect only: Ventilation Wind = Cw * Opening Area * Schedule * WindSpd Ventilation Stack = Cd * Opening Area * Schedule * SQRT(2*g*DH*(|(Tzone-Todb)|/Tzone)) Total Ventilation = SQRT((Ventilation Wind)^2 + (Ventilation Stack)^2)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneVentilation_WindandStackOpenArea : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("This is the opening area used to calculate stack effect and wind driven ventilati" +
    "on.")]
[JsonProperty(PropertyName="opening_area")]
public System.Nullable<float> OpeningArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the fraction values applied to the opening area given in t" +
    "he previous input field (0.0 - 1.0).")]
[JsonProperty(PropertyName="opening_area_fraction_schedule_name")]
public string OpeningAreaFractionScheduleName { get; set; } = "";
        

[Description(@"This field is used to calculate wind driven ventilation. ""Cw"" in the wind-driven equation and the maximum value is 1.0. When the input is Autocalculate, the program calculates Cw based on an angle between wind direction and effective angle Cw = 0.55 at angle = 0, and Cw = 0.3 at angle=180 Linear interpolation is used to calculate Cw based on the above two values.")]
[JsonProperty(PropertyName="opening_effectiveness", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> OpeningEffectiveness { get; set; } = null;
        

[Description("This field is defined as normal angle of the opening area and is used when input " +
    "field Opening Effectiveness = Autocalculate.")]
[JsonProperty(PropertyName="effective_angle")]
public System.Nullable<float> EffectiveAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This is the height difference between the midpoint of an opening and the neutral " +
    "pressure level. \"DH\" in the stack equation.")]
[JsonProperty(PropertyName="height_difference")]
public System.Nullable<float> HeightDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This is the discharge coefficient used to calculate stack effect. \"Cd\" in the sta" +
    "ck equation and the maximum value is 1.0. When the input is Autocalculate, the f" +
    "ollowing equation is used to calculate the coefficient: Cd = 0.4 + 0.0045*|(Tzon" +
    "e-Todb)|")]
[JsonProperty(PropertyName="discharge_coefficient_for_opening", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> DischargeCoefficientForOpening { get; set; } = null;
        

[Description("This is the indoor temperature below which ventilation is shutoff.")]
[JsonProperty(PropertyName="minimum_indoor_temperature")]
public System.Nullable<float> MinimumIndoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the indoor temperature versus time below which ventilation" +
    " is shutoff.")]
[JsonProperty(PropertyName="minimum_indoor_temperature_schedule_name")]
public string MinimumIndoorTemperatureScheduleName { get; set; } = "";
        

[Description("This is the indoor temperature above which ventilation is shutoff.")]
[JsonProperty(PropertyName="maximum_indoor_temperature")]
public System.Nullable<float> MaximumIndoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the indoor temperature versus time above which ventilation" +
    " is shutoff.")]
[JsonProperty(PropertyName="maximum_indoor_temperature_schedule_name")]
public string MaximumIndoorTemperatureScheduleName { get; set; } = "";
        

[Description("This is the temperature differential between indoor and outdoor below which venti" +
    "lation is shutoff.")]
[JsonProperty(PropertyName="delta_temperature")]
public System.Nullable<float> DeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the temperature differential between indoor and outdoor ve" +
    "rsus time below which ventilation is shutoff.")]
[JsonProperty(PropertyName="delta_temperature_schedule_name")]
public string DeltaTemperatureScheduleName { get; set; } = "";
        

[Description("This is the outdoor temperature below which ventilation is shutoff.")]
[JsonProperty(PropertyName="minimum_outdoor_temperature")]
public System.Nullable<float> MinimumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the outdoor temperature versus time below which ventilatio" +
    "n is shutoff.")]
[JsonProperty(PropertyName="minimum_outdoor_temperature_schedule_name")]
public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

[Description("This is the outdoor temperature above which ventilation is shutoff.")]
[JsonProperty(PropertyName="maximum_outdoor_temperature")]
public System.Nullable<float> MaximumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the outdoor temperature versus time above which ventilatio" +
    "n is shutoff.")]
[JsonProperty(PropertyName="maximum_outdoor_temperature_schedule_name")]
public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
        

[Description("This is the outdoor wind speed above which ventilation is shutoff.")]
[JsonProperty(PropertyName="maximum_wind_speed")]
public System.Nullable<float> MaximumWindSpeed { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
    }
    
    [Description(@"Provide a combined zone outdoor air flow by including interactions between mechanical ventilation, infiltration and duct leakage. This object will combine outdoor flows from all ZoneInfiltration and ZoneVentilation objects in the same zone. Balanced flows will be summed, while unbalanced flows will be added in quadrature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneAirBalance_OutdoorAir : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("None: Only perform simple calculations without using a combined zone outdoor air." +
    " Quadrature: A combined outdoor air is used in the quadrature sum.")]
[JsonProperty(PropertyName="air_balance_method", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneAirBalance_OutdoorAir_AirBalanceMethod AirBalanceMethod { get; set; } = (ZoneAirBalance_OutdoorAir_AirBalanceMethod)Enum.Parse(typeof(ZoneAirBalance_OutdoorAir_AirBalanceMethod), "Quadrature");
        

[JsonProperty(PropertyName="induced_outdoor_air_due_to_unbalanced_duct_leakage")]
public System.Nullable<float> InducedOutdoorAirDueToUnbalancedDuctLeakage { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the fraction values applied to the Induced Outdoor Air giv" +
    "en in the previous input field (0.0 - 1.0).")]
[JsonProperty(PropertyName="induced_outdoor_air_schedule_name")]
public string InducedOutdoorAirScheduleName { get; set; } = "";
    }
    
    public enum ZoneAirBalance_OutdoorAir_AirBalanceMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Quadrature")]
        Quadrature = 2,
    }
    
    [Description(@"ZoneMixing is a simple air exchange from one zone to another. Note that this statement only affects the energy balance of the ""receiving"" zone and will not produce any effect on the ""source"" zone. Mixing statements can be complementary and include multiple zones, but the balancing of flows between zones is left to the user's discretion.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneMixing : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of ventilation for this set of attributes Choices: Flow/Zone => Design Flow Rate -- simply enter Design Flow Rate Flow/Area => Flow Rate per Zone Floor Area - Value * Floor Area (zone) = Design Flow Rate Flow/Person => Flow Rate per Person - Value * #people = Design Flow Rate AirChanges/Hour => Air Changes per Hour - Value * Floor Volume (zone) adjusted for m3/s = Design Volume Flow Rate ""Vdesign"" in Equation is the result.")]
[JsonProperty(PropertyName="design_flow_rate_calculation_method", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneMixing_DesignFlowRateCalculationMethod DesignFlowRateCalculationMethod { get; set; } = (ZoneMixing_DesignFlowRateCalculationMethod)Enum.Parse(typeof(ZoneMixing_DesignFlowRateCalculationMethod), "Empty");
        

[JsonProperty(PropertyName="design_flow_rate")]
public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

[JsonProperty(PropertyName="flow_rate_per_zone_floor_area")]
public System.Nullable<float> FlowRatePerZoneFloorArea { get; set; } = null;
        

[JsonProperty(PropertyName="flow_rate_per_person")]
public System.Nullable<float> FlowRatePerPerson { get; set; } = null;
        

[JsonProperty(PropertyName="air_changes_per_hour")]
public System.Nullable<float> AirChangesPerHour { get; set; } = null;
        

[JsonProperty(PropertyName="source_zone_name")]
public string SourceZoneName { get; set; } = "";
        

[Description("This field contains the constant temperature differential between source and rece" +
    "iving zones below which mixing is shutoff.")]
[JsonProperty(PropertyName="delta_temperature")]
public System.Nullable<float> DeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the temperature differential between source and receiving " +
    "zones versus time below which mixing is shutoff.")]
[JsonProperty(PropertyName="delta_temperature_schedule_name")]
public string DeltaTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the zone dry-bulb temperature versus time below which mixi" +
    "ng is shutoff.")]
[JsonProperty(PropertyName="minimum_zone_temperature_schedule_name")]
public string MinimumZoneTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the zone dry-bulb temperature versus time above which mixi" +
    "ng is shutoff.")]
[JsonProperty(PropertyName="maximum_zone_temperature_schedule_name")]
public string MaximumZoneTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the source zone dry-bulb temperature versus time below whi" +
    "ch mixing is shutoff.")]
[JsonProperty(PropertyName="minimum_source_zone_temperature_schedule_name")]
public string MinimumSourceZoneTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the source zone dry-bulb temperature versus time above whi" +
    "ch mixing is shutoff.")]
[JsonProperty(PropertyName="maximum_source_zone_temperature_schedule_name")]
public string MaximumSourceZoneTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the outdoor temperature versus time below which mixing is " +
    "shutoff.")]
[JsonProperty(PropertyName="minimum_outdoor_temperature_schedule_name")]
public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the outdoor temperature versus time above which mixing is " +
    "shutoff.")]
[JsonProperty(PropertyName="maximum_outdoor_temperature_schedule_name")]
public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
    }
    
    public enum ZoneMixing_DesignFlowRateCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirChanges/Hour")]
        AirChangesHour = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Area")]
        FlowArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Person")]
        FlowPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 4,
    }
    
    [Description("ZoneCrossMixing exchanges an equal amount of air between two zones. Note that thi" +
        "s statement affects the energy balance of both zones.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneCrossMixing : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of ventilation for this set of attributes Choices: Flow/Zone => Design Flow Rate -- simply enter Design Flow Rate Flow/Area => Flow Rate per Zone Floor Area - Value * Floor Area (zone) = Design Flow Rate Flow/Person => Flow Rate per Person - Value * #people = Design Flow Rate AirChanges/Hour => Air Changes per Hour - Value * Floor Volume (zone) adjusted for m3/s = Design Volume Flow Rate ""Vdesign"" in Equation is the result.")]
[JsonProperty(PropertyName="design_flow_rate_calculation_method", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneCrossMixing_DesignFlowRateCalculationMethod DesignFlowRateCalculationMethod { get; set; } = (ZoneCrossMixing_DesignFlowRateCalculationMethod)Enum.Parse(typeof(ZoneCrossMixing_DesignFlowRateCalculationMethod), "Empty");
        

[JsonProperty(PropertyName="design_flow_rate")]
public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

[JsonProperty(PropertyName="flow_rate_per_zone_floor_area")]
public System.Nullable<float> FlowRatePerZoneFloorArea { get; set; } = null;
        

[JsonProperty(PropertyName="flow_rate_per_person")]
public System.Nullable<float> FlowRatePerPerson { get; set; } = null;
        

[JsonProperty(PropertyName="air_changes_per_hour")]
public System.Nullable<float> AirChangesPerHour { get; set; } = null;
        

[JsonProperty(PropertyName="source_zone_name")]
public string SourceZoneName { get; set; } = "";
        

[Description("This field contains the constant temperature differential between source and rece" +
    "iving zones below which cross mixing is shutoff. This value must be greater than" +
    " or equal to zero.")]
[JsonProperty(PropertyName="delta_temperature")]
public System.Nullable<float> DeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This schedule contains the temperature differential between source and receiving " +
    "zones versus time below which cross mixing is shutoff.")]
[JsonProperty(PropertyName="delta_temperature_schedule_name")]
public string DeltaTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the indoor temperature versus time below which cross mixin" +
    "g is shutoff.")]
[JsonProperty(PropertyName="minimum_zone_temperature_schedule_name")]
public string MinimumZoneTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the indoor temperature versus time above which cross mixin" +
    "g is shutoff.")]
[JsonProperty(PropertyName="maximum_zone_temperature_schedule_name")]
public string MaximumZoneTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the source zone dry-bulb temperature versus time below whi" +
    "ch cross mixing is shutoff.")]
[JsonProperty(PropertyName="minimum_source_zone_temperature_schedule_name")]
public string MinimumSourceZoneTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the source zone dry-bulb temperature versus time above whi" +
    "ch cross mixing is shutoff.")]
[JsonProperty(PropertyName="maximum_source_zone_temperature_schedule_name")]
public string MaximumSourceZoneTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the outdoor temperature versus time below which cross mixi" +
    "ng is shutoff.")]
[JsonProperty(PropertyName="minimum_outdoor_temperature_schedule_name")]
public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

[Description("This schedule contains the outdoor temperature versus time above which cross mixi" +
    "ng is shutoff.")]
[JsonProperty(PropertyName="maximum_outdoor_temperature_schedule_name")]
public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
    }
    
    public enum ZoneCrossMixing_DesignFlowRateCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirChanges/Hour")]
        AirChangesHour = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Area")]
        FlowArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Person")]
        FlowPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 4,
    }
    
    [Description(@"Refrigeration Door Mixing is used for an opening between two zones that are at the same elevation but have different air temperatures. In this case, the mixing air flow between the two zones is determined by the density difference between the two zones. This would typically be used between two zones in a refrigerated warehouse that are controlled at different temperatures. It could also be used to model a door to a walk-in refrigerated space if that space were modeled as a zone instead of using the object Refrigeration:WalkIn.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneRefrigerationDoorMixing : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_1_name")]
public string Zone1Name { get; set; } = "";
        

[JsonProperty(PropertyName="zone_2_name")]
public string Zone2Name { get; set; } = "";
        

[Description(@"This schedule defines the fraction of the time the refrigeration door is open For example, if the warehouse is closed at night and there are no door openings between two zones, the value for that time period would be 0. If doors were propped open, the value  over that time period would be 1.0 If the doors were open about 20% of the time, the value over that period would be 0.2 Schedule values must lie between 0 and 1.0")]
[JsonProperty(PropertyName="schedule_name")]
public string ScheduleName { get; set; } = "";
        

[JsonProperty(PropertyName="door_height")]
public System.Nullable<float> DoorHeight { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="door_area")]
public System.Nullable<float> DoorArea { get; set; } = (System.Nullable<float>)Single.Parse("9", CultureInfo.InvariantCulture);
        

[Description("Door protection can reduce the air flow through a refrigeration door The default " +
    "value is \"None\" Choices: \"None\", \"AirCurtain\", and \"StripCurtain\" A strip curtai" +
    "n reduces the air flow more than an air curtain")]
[JsonProperty(PropertyName="door_protection_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneRefrigerationDoorMixing_DoorProtectionType DoorProtectionType { get; set; } = (ZoneRefrigerationDoorMixing_DoorProtectionType)Enum.Parse(typeof(ZoneRefrigerationDoorMixing_DoorProtectionType), "None");
    }
    
    public enum ZoneRefrigerationDoorMixing_DoorProtectionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirCurtain")]
        AirCurtain = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="StripCurtain")]
        StripCurtain = 3,
    }
    
    [Description("Earth Tube is specified as a design level which is modified by a Schedule fractio" +
        "n, temperature difference and wind speed: Earthtube=Edesign * Fschedule * (A + B" +
        "*|(Tzone-Todb)| + C*WindSpd + D * WindSpd**2)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneEarthtube : BHoMObject
    {
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description("\"Edesign\" in Equation")]
[JsonProperty(PropertyName="design_flow_rate")]
public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

[Description("this is the indoor temperature below which the earth tube is shut off")]
[JsonProperty(PropertyName="minimum_zone_temperature_when_cooling")]
public System.Nullable<float> MinimumZoneTemperatureWhenCooling { get; set; } = null;
        

[Description("this is the indoor temperature above which the earth tube is shut off")]
[JsonProperty(PropertyName="maximum_zone_temperature_when_heating")]
public System.Nullable<float> MaximumZoneTemperatureWhenHeating { get; set; } = null;
        

[Description("This is the temperature difference between indoor and outdoor below which the ear" +
    "th tube is shut off")]
[JsonProperty(PropertyName="delta_temperature")]
public System.Nullable<float> DeltaTemperature { get; set; } = null;
        

[JsonProperty(PropertyName="earthtube_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneEarthtube_EarthtubeType EarthtubeType { get; set; } = (ZoneEarthtube_EarthtubeType)Enum.Parse(typeof(ZoneEarthtube_EarthtubeType), "Natural");
        

[Description("pressure rise across the fan")]
[JsonProperty(PropertyName="fan_pressure_rise")]
public System.Nullable<float> FanPressureRise { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="fan_total_efficiency")]
public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="pipe_radius")]
public System.Nullable<float> PipeRadius { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="pipe_thickness")]
public System.Nullable<float> PipeThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="pipe_length")]
public System.Nullable<float> PipeLength { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="pipe_thermal_conductivity")]
public System.Nullable<float> PipeThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("200", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="pipe_depth_under_ground_surface")]
public System.Nullable<float> PipeDepthUnderGroundSurface { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="soil_condition", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneEarthtube_SoilCondition SoilCondition { get; set; } = (ZoneEarthtube_SoilCondition)Enum.Parse(typeof(ZoneEarthtube_SoilCondition), "HeavyAndDamp");
        

[JsonProperty(PropertyName="average_soil_surface_temperature")]
public System.Nullable<float> AverageSoilSurfaceTemperature { get; set; } = null;
        

[JsonProperty(PropertyName="amplitude_of_soil_surface_temperature")]
public System.Nullable<float> AmplitudeOfSoilSurfaceTemperature { get; set; } = null;
        

[JsonProperty(PropertyName="phase_constant_of_soil_surface_temperature")]
public System.Nullable<float> PhaseConstantOfSoilSurfaceTemperature { get; set; } = null;
        

[Description("\"A\" in Equation")]
[JsonProperty(PropertyName="constant_term_flow_coefficient")]
public System.Nullable<float> ConstantTermFlowCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("\"B\" in Equation")]
[JsonProperty(PropertyName="temperature_term_flow_coefficient")]
public System.Nullable<float> TemperatureTermFlowCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("\"C\" in Equation")]
[JsonProperty(PropertyName="velocity_term_flow_coefficient")]
public System.Nullable<float> VelocityTermFlowCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("\"D\" in Equation")]
[JsonProperty(PropertyName="velocity_squared_term_flow_coefficient")]
public System.Nullable<float> VelocitySquaredTermFlowCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum ZoneEarthtube_EarthtubeType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Exhaust")]
        Exhaust = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Intake")]
        Intake = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Natural")]
        Natural = 3,
    }
    
    public enum ZoneEarthtube_SoilCondition
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HeavyAndDamp")]
        HeavyAndDamp = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HeavyAndDry")]
        HeavyAndDry = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeavyAndSaturated")]
        HeavyAndSaturated = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="LightAndDry")]
        LightAndDry = 4,
    }
    
    [Description(@"A cooltower (sometimes referred to as a wind tower or a shower cooling tower) models passive downdraught evaporative cooling (PDEC) that is designed to capture the wind at the top of a tower and cool the outdoor air using water evaporation before delivering it to a space.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneCoolTower_Shower : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty(PropertyName="availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("In case of stand alone tank or underground water, leave this input blank")]
[JsonProperty(PropertyName="water_supply_storage_tank_name")]
public string WaterSupplyStorageTankName { get; set; } = "";
        

[Description("Water flow schedule should be selected when the water flow rate is known. Wind-dr" +
    "iven flow should be selected when the water flow rate is unknown.")]
[JsonProperty(PropertyName="flow_control_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneCoolTower_Shower_FlowControlType FlowControlType { get; set; } = (ZoneCoolTower_Shower_FlowControlType)Enum.Parse(typeof(ZoneCoolTower_Shower_FlowControlType), "WindDrivenFlow");
        

[JsonProperty(PropertyName="pump_flow_rate_schedule_name")]
public string PumpFlowRateScheduleName { get; set; } = "";
        

[JsonProperty(PropertyName="maximum_water_flow_rate")]
public System.Nullable<float> MaximumWaterFlowRate { get; set; } = null;
        

[Description("This field is from either the spray or the wet pad to the top of the outlet.")]
[JsonProperty(PropertyName="effective_tower_height")]
public System.Nullable<float> EffectiveTowerHeight { get; set; } = null;
        

[Description("User have to specify effective area when outlet area is relatively bigger than th" +
    "e cross sectional area of cooltower. If the number of outlet is more than one, a" +
    "ssume the air passes through only one.")]
[JsonProperty(PropertyName="airflow_outlet_area")]
public System.Nullable<float> AirflowOutletArea { get; set; } = null;
        

[JsonProperty(PropertyName="maximum_air_flow_rate")]
public System.Nullable<float> MaximumAirFlowRate { get; set; } = null;
        

[Description("This field is to specify the indoor temperature below which cooltower is shutoff." +
    "")]
[JsonProperty(PropertyName="minimum_indoor_temperature")]
public System.Nullable<float> MinimumIndoorTemperature { get; set; } = null;
        

[JsonProperty(PropertyName="fraction_of_water_loss")]
public System.Nullable<float> FractionOfWaterLoss { get; set; } = null;
        

[JsonProperty(PropertyName="fraction_of_flow_schedule")]
public System.Nullable<float> FractionOfFlowSchedule { get; set; } = null;
        

[JsonProperty(PropertyName="rated_power_consumption")]
public System.Nullable<float> RatedPowerConsumption { get; set; } = null;
    }
    
    public enum ZoneCoolTower_Shower_FlowControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterFlowSchedule")]
        WaterFlowSchedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="WindDrivenFlow")]
        WindDrivenFlow = 2,
    }
    
    [Description("A thermal chimney is a vertical shaft utilizing solar radiation to enhance natura" +
        "l ventilation. It consists of an absorber wall, air gap and glass cover with hig" +
        "h solar transmissivity.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneThermalChimney : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Name of zone that is the thermal chimney")]
[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty(PropertyName="availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty(PropertyName="width_of_the_absorber_wall")]
public System.Nullable<float> WidthOfTheAbsorberWall { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_area_of_air_channel_outlet")]
public System.Nullable<float> CrossSectionalAreaOfAirChannelOutlet { get; set; } = null;
        

[JsonProperty(PropertyName="discharge_coefficient")]
public System.Nullable<float> DischargeCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="zone_1_name")]
public string Zone1Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_1")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet1 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_1")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone1 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_1")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet1 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_2_name")]
public string Zone2Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_2")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet2 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_2")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone2 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_2")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet2 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_3_name")]
public string Zone3Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_3")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet3 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_3")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone3 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_3")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet3 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_4_name")]
public string Zone4Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_4")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet4 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_4")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone4 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_4")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet4 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_5_name")]
public string Zone5Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_5")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet5 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_5")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone5 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_5")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet5 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_6_name")]
public string Zone6Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_6")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet6 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_6")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone6 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_6")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet6 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_7_name")]
public string Zone7Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_7")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet7 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_7")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone7 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_7")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet7 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_8_name")]
public string Zone8Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_8")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet8 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_8")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone8 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_8")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet8 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_9_name")]
public string Zone9Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_9")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet9 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_9")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone9 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_9")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet9 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_10_name")]
public string Zone10Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_10")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet10 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_10")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone10 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_10")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet10 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_11_name")]
public string Zone11Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_11")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet11 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_11")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone11 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_11")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet11 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_12_name")]
public string Zone12Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_12")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet12 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_12")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone12 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_12")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet12 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_13_name")]
public string Zone13Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_13")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet13 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_13")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone13 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_13")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet13 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_14_name")]
public string Zone14Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_14")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet14 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_14")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone14 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_14")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet14 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_15_name")]
public string Zone15Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_15")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet15 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_15")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone15 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_15")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet15 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_16_name")]
public string Zone16Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_16")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet16 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_16")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone16 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_16")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet16 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_17_name")]
public string Zone17Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_17")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet17 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_17")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone17 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_17")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet17 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_18_name")]
public string Zone18Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_18")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet18 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_18")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone18 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_18")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet18 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_19_name")]
public string Zone19Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_19")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet19 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_19")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone19 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_19")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet19 { get; set; } = null;
        

[JsonProperty(PropertyName="zone_20_name")]
public string Zone20Name { get; set; } = "";
        

[JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_20")]
public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet20 { get; set; } = null;
        

[JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_20")]
public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone20 { get; set; } = null;
        

[JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_20")]
public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet20 { get; set; } = null;
    }
}
