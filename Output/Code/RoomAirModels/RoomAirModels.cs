namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
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
    
    
    [Description("Selects the type of room air model to be used in a given zone. If no RoomAirModel" +
        "Type object is specified then the default Mixing model (all zone air at the same" +
        " temperature) will be used.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirModelType : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[Description(@"Mixing = Complete mixing air model UserDefined = UserDefined Room Air Temperature Patterns needs RoomAir:TemperaturePattern:UserDefined object referencing this Zone OneNodeDisplacementVentilation = Mundt roomair model for displacement ventilation with single floor air node needs RoomAirSettings:OneNodeDisplacementVentilation object referencing this Zone ThreeNodeDisplacementVentilation = RoomAir modeling using UCSD three-node displacement ventilation model needs RoomAirSettings:ThreeNodeDisplacementVentilation object referencing this Zone CrossVentilation = RoomAir modeling using UCSD two-zone cross ventilation model needs RoomAirSettings:CrossVentilation object referencing this Zone UnderFloorAirDistributionInterior = 2-Node UFAD model for interior zones needs RoomAirSettings:UnderFloorAirDistributionInterior object referencing this Zone UnderFloorAirDistributionExterior = RoomAir modeling using 2-Node UFAD model for exterior zones needs RoomAirSettings:UnderFloorAirDistributionExterior object referencing this Zone AirflowNetwork = RoomAir modeling using AirflowNetwork needs RoomAirSettings:AirflowNetwork object referencing this Zone")]
[JsonProperty(PropertyName="room_air_modeling_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoomAirModelType_RoomAirModelingType RoomAirModelingType { get; set; } = (RoomAirModelType_RoomAirModelingType)Enum.Parse(typeof(RoomAirModelType_RoomAirModelingType), "Mixing");
        

[JsonProperty(PropertyName="air_temperature_coupling_strategy", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoomAirModelType_AirTemperatureCouplingStrategy AirTemperatureCouplingStrategy { get; set; } = (RoomAirModelType_AirTemperatureCouplingStrategy)Enum.Parse(typeof(RoomAirModelType_AirTemperatureCouplingStrategy), "Direct");
    }
    
    public enum RoomAirModelType_RoomAirModelingType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirflowNetwork")]
        AirflowNetwork = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CrossVentilation")]
        CrossVentilation = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Mixing")]
        Mixing = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OneNodeDisplacementVentilation")]
        OneNodeDisplacementVentilation = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ThreeNodeDisplacementVentilation")]
        ThreeNodeDisplacementVentilation = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="UnderFloorAirDistributionExterior")]
        UnderFloorAirDistributionExterior = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="UnderFloorAirDistributionInterior")]
        UnderFloorAirDistributionInterior = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefined")]
        UserDefined = 8,
    }
    
    public enum RoomAirModelType_AirTemperatureCouplingStrategy
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Direct")]
        Direct = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Indirect")]
        Indirect = 2,
    }
    
    [Description("Used to explicitly define temperature patterns that are to be applied to the mean" +
        " air temperature within a thermal zone. Used with RoomAirModelType = UserDefined" +
        ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Availability schedule name for this model. Schedule value > 0 means the model is " +
    "active. Schedule value = 0 means the model is inactive and the zone will be mode" +
    "led as fully mixed (Mixing). If this field is blank, the model is always active." +
    "")]
[JsonProperty(PropertyName="availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("The schedule should contain integer values that correspond to unique Control Inte" +
    "ger fields in one of the RoomAir:TemperaturePattern:* objects.")]
[JsonProperty(PropertyName="pattern_control_schedule_name")]
public string PatternControlScheduleName { get; set; } = "";
    }
    
    [Description("Used to model room air with a fixed temperature gradient in the vertical directio" +
        "n. Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_ConstantGradient : BHoMObject
    {
        

[JsonProperty(PropertyName="room_air_temperature_pattern_constant_gradient_name")]
public string RoomAirTemperaturePatternConstantGradientName { get; set; } = "";
        

[Description("reference this entry in Schedule Name")]
[JsonProperty(PropertyName="control_integer_for_pattern_control_schedule_name")]
public System.Nullable<float> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

[Description("= (Temp at thermostat- Mean Air Temp)")]
[JsonProperty(PropertyName="thermostat_offset")]
public System.Nullable<float> ThermostatOffset { get; set; } = null;
        

[Description("= (Tleaving - Mean Air Temp )")]
[JsonProperty(PropertyName="return_air_offset")]
public System.Nullable<float> ReturnAirOffset { get; set; } = null;
        

[Description("= (Texhaust - Mean Air Temp) deg C")]
[JsonProperty(PropertyName="exhaust_air_offset")]
public System.Nullable<float> ExhaustAirOffset { get; set; } = null;
        

[Description("Slope of temperature change in vertical direction")]
[JsonProperty(PropertyName="temperature_gradient")]
public System.Nullable<float> TemperatureGradient { get; set; } = null;
    }
    
    [Description("Used to model room air with two temperature gradients in the vertical direction. " +
        "Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_TwoGradient : BHoMObject
    {
        

[JsonProperty(PropertyName="room_air_temperature_pattern_two_gradient_name")]
public string RoomAirTemperaturePatternTwoGradientName { get; set; } = "";
        

[Description("reference this entry in Schedule Name")]
[JsonProperty(PropertyName="control_integer_for_pattern_control_schedule_name")]
public System.Nullable<float> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

[Description("= Distance from floor of zone")]
[JsonProperty(PropertyName="thermostat_height")]
public System.Nullable<float> ThermostatHeight { get; set; } = null;
        

[Description("= Distance from floor of zone")]
[JsonProperty(PropertyName="return_air_height")]
public System.Nullable<float> ReturnAirHeight { get; set; } = null;
        

[Description("= Distance from floor of zone")]
[JsonProperty(PropertyName="exhaust_air_height")]
public System.Nullable<float> ExhaustAirHeight { get; set; } = null;
        

[Description("Slope of temperature change in vertical direction")]
[JsonProperty(PropertyName="temperature_gradient_lower_bound")]
public System.Nullable<float> TemperatureGradientLowerBound { get; set; } = null;
        

[Description("Slope of temperature change in vertical direction")]
[JsonProperty(PropertyName="temperature_gradient_upper_bound")]
public System.Nullable<float> TemperatureGradientUpperBound { get; set; } = null;
        

[JsonProperty(PropertyName="gradient_interpolation_mode", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode GradientInterpolationMode { get; set; } = (RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode)Enum.Parse(typeof(RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode), "OutdoorDryBulbTemperature");
        

[JsonProperty(PropertyName="upper_temperature_bound")]
public System.Nullable<float> UpperTemperatureBound { get; set; } = null;
        

[JsonProperty(PropertyName="lower_temperature_bound")]
public System.Nullable<float> LowerTemperatureBound { get; set; } = null;
        

[JsonProperty(PropertyName="upper_heat_rate_bound")]
public System.Nullable<float> UpperHeatRateBound { get; set; } = null;
        

[JsonProperty(PropertyName="lower_heat_rate_bound")]
public System.Nullable<float> LowerHeatRateBound { get; set; } = null;
    }
    
    public enum RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SensibleCoolingLoad")]
        SensibleCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SensibleHeatingLoad")]
        SensibleHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAndOutdoorTemperatureDifference")]
        ZoneAndOutdoorTemperatureDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneDryBulbTemperature")]
        ZoneDryBulbTemperature = 4,
    }
    
    [Description(@"Defines a distribution pattern for air temperatures relative to the current mean air temperature as a function of height. The height, referred to as Zeta, is nondimensional by normalizing with the zone ceiling height. Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_NondimensionalHeight : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("this value should appear in as a schedule value")]
[JsonProperty(PropertyName="control_integer_for_pattern_control_schedule_name")]
public System.Nullable<float> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

[Description("= (Temp at thermostat- Mean Air Temp)")]
[JsonProperty(PropertyName="thermostat_offset")]
public System.Nullable<float> ThermostatOffset { get; set; } = null;
        

[Description("= (Temp leaving - Mean Air Temp ) deg C")]
[JsonProperty(PropertyName="return_air_offset")]
public System.Nullable<float> ReturnAirOffset { get; set; } = null;
        

[Description(@"= (Temp exhaust - Mean Air Temp) deg C the remaining fields have pairs that describe the relative temperature pattern in the vertical direction of a zone Zeta is the nondimensional height (in z-direction). on [0..1] DeltaTai =  (Tai - MAT) in units of deg. C relative deg C on [-10.0 .. 20.0 ]")]
[JsonProperty(PropertyName="exhaust_air_offset")]
public System.Nullable<float> ExhaustAirOffset { get; set; } = null;
        

[JsonProperty(PropertyName="pairs")]
public string Pairs { get; set; } = "";
    }
    
    [Description(@"Defines a distribution pattern for the air temperatures adjacent to individual surfaces. This allows controlling the adjacent air temperature on a surface-by-surface basis rather than by height. This allows modeling different adjacent air temperatures on the opposite sides of the zone. Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_SurfaceMapping : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("reference this entry in schedule")]
[JsonProperty(PropertyName="control_integer_for_pattern_control_schedule_name")]
public System.Nullable<float> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

[Description("= (Temp at thermostat- Mean Air Temp)")]
[JsonProperty(PropertyName="thermostat_offset")]
public System.Nullable<float> ThermostatOffset { get; set; } = null;
        

[Description("= (Tleaving - Mean Air Temp ) deg C")]
[JsonProperty(PropertyName="return_air_offset")]
public System.Nullable<float> ReturnAirOffset { get; set; } = null;
        

[Description("= (Texhaust - Mean Air Temp) deg C")]
[JsonProperty(PropertyName="exhaust_air_offset")]
public System.Nullable<float> ExhaustAirOffset { get; set; } = null;
        

[JsonProperty(PropertyName="surface_deltas")]
public string SurfaceDeltas { get; set; } = "";
    }
    
    [Description("Define an air node for some types of nodal room air models")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="node_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoomAir_Node_NodeType NodeType { get; set; } = (RoomAir_Node_NodeType)Enum.Parse(typeof(RoomAir_Node_NodeType), "Ceiling");
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="height_of_nodal_control_volume_center")]
public System.Nullable<float> HeightOfNodalControlVolumeCenter { get; set; } = null;
        

[JsonProperty(PropertyName="surface_1_name")]
public string Surface1Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_2_name")]
public string Surface2Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_3_name")]
public string Surface3Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_4_name")]
public string Surface4Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_5_name")]
public string Surface5Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_6_name")]
public string Surface6Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_7_name")]
public string Surface7Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_8_name")]
public string Surface8Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_9_name")]
public string Surface9Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_10_name")]
public string Surface10Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_11_name")]
public string Surface11Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_12_name")]
public string Surface12Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_13_name")]
public string Surface13Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_14_name")]
public string Surface14Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_15_name")]
public string Surface15Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_16_name")]
public string Surface16Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_17_name")]
public string Surface17Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_18_name")]
public string Surface18Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_19_name")]
public string Surface19Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_20_name")]
public string Surface20Name { get; set; } = "";
        

[JsonProperty(PropertyName="surface_21_name")]
public string Surface21Name { get; set; } = "";
    }
    
    public enum RoomAir_Node_NodeType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Ceiling")]
        Ceiling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Control")]
        Control = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Floor")]
        Floor = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Inlet")]
        Inlet = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MundtRoom")]
        MundtRoom = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Return")]
        Return = 5,
    }
    
    [Description("The Mundt model for displacement ventilation")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_OneNodeDisplacementVentilation : BHoMObject
    {
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="fraction_of_convective_internal_loads_added_to_floor_air")]
public System.Nullable<float> FractionOfConvectiveInternalLoadsAddedToFloorAir { get; set; } = null;
        

[JsonProperty(PropertyName="fraction_of_infiltration_internal_loads_added_to_floor_air")]
public System.Nullable<float> FractionOfInfiltrationInternalLoadsAddedToFloorAir { get; set; } = null;
    }
    
    [Description("The UCSD model for Displacement Ventilation")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_ThreeNodeDisplacementVentilation : BHoMObject
    {
        

[Description("Name of Zone being described. Any existing zone name")]
[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Distribution of the convective heat gains between the occupied and mixed zones. 0" +
    "<= Accepted Value <= 1. In the DV model 1 means all convective gains in the lowe" +
    "r layer.")]
[JsonProperty(PropertyName="gain_distribution_schedule_name")]
public string GainDistributionScheduleName { get; set; } = "";
        

[Description("Used only in the UCSD displacement ventilation model. Effective number of separat" +
    "e plumes per occupant in the occupied zone. Plumes that merge together in the oc" +
    "cupied zone count as one.")]
[JsonProperty(PropertyName="number_of_plumes_per_occupant")]
public System.Nullable<float> NumberOfPlumesPerOccupant { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Height of thermostat/temperature control sensor above floor")]
[JsonProperty(PropertyName="thermostat_height")]
public System.Nullable<float> ThermostatHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

[Description("Height at which air temperature is calculated for comfort purposes")]
[JsonProperty(PropertyName="comfort_height")]
public System.Nullable<float> ComfortHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

[Description(@"Minimum temperature difference between predicted upper and lower layer temperatures above which DV auxiliary outputs are calculated. These outputs are 'DV Transition Height', 'DV Fraction Min Recommended Flow Rate' 'DV Average Temp Gradient' and 'DV Maximum Temp Gradient'. They are set to negative values when the temperature difference is less than the threshold and the output 'DV Zone Is Mixed' is set to 1")]
[JsonProperty(PropertyName="temperature_difference_threshold_for_reporting")]
public System.Nullable<float> TemperatureDifferenceThresholdForReporting { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
    }
    
    [Description(@"This UCSD Cross Ventilation Room Air Model provides a simple model for heat transfer and vertical temperature profile prediction in cross ventilated rooms. The model distinguishes two regions in the room, the main jet region and the recirculations, and predicts characteristic airflow velocities and average air temperatures. Used with RoomAirModelType = CrossVentilation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_CrossVentilation : BHoMObject
    {
        

[Description("Name of Zone being described. Any existing zone name")]
[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Distribution of the convective heat gains between the jet and recirculation zones" +
    ". 0<= Accepted Value <= 1. In the CV model 1 means all convective gains in the j" +
    "et region.")]
[JsonProperty(PropertyName="gain_distribution_schedule_name")]
public string GainDistributionScheduleName { get; set; } = "";
        

[Description("Required field whenever thermal comfort is predicted defines Air temperature and " +
    "Airflow velocity that will be used in the Fanger model conditions must refer to " +
    "one of the two regions: jet or recirculation")]
[JsonProperty(PropertyName="airflow_region_used_for_thermal_comfort_evaluation", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoomAirSettings_CrossVentilation_AirflowRegionUsedForThermalComfortEvaluation AirflowRegionUsedForThermalComfortEvaluation { get; set; } = (RoomAirSettings_CrossVentilation_AirflowRegionUsedForThermalComfortEvaluation)Enum.Parse(typeof(RoomAirSettings_CrossVentilation_AirflowRegionUsedForThermalComfortEvaluation), "Jet");
    }
    
    public enum RoomAirSettings_CrossVentilation_AirflowRegionUsedForThermalComfortEvaluation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Jet")]
        Jet = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Recirculation")]
        Recirculation = 1,
    }
    
    [Description(@"This Room Air Model is applicable to interior spaces that are served by an underfloor air distribution system. The dominant sources of heat gain should be from people, equipment, and other localized sources located in the occupied part of the room. The model should be used with caution in zones which have large heat gains or losses through exterior walls or windows or which have considerable direct solar gain. Used with RoomAirModelType = UnderFloorAirDistributionInterior.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_UnderFloorAirDistributionInterior : BHoMObject
    {
        

[Description("Name of Zone with underfloor air distribution")]
[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Total number of diffusers in this zone")]
[JsonProperty(PropertyName="number_of_diffusers", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> NumberOfDiffusers { get; set; } = null;
        

[JsonProperty(PropertyName="power_per_plume", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> PowerPerPlume { get; set; } = null;
        

[JsonProperty(PropertyName="design_effective_area_of_diffuser", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> DesignEffectiveAreaOfDiffuser { get; set; } = null;
        

[JsonProperty(PropertyName="diffuser_slot_angle_from_vertical", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> DiffuserSlotAngleFromVertical { get; set; } = null;
        

[Description("Height of thermostat/temperature control sensor above floor")]
[JsonProperty(PropertyName="thermostat_height")]
public System.Nullable<float> ThermostatHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.2", CultureInfo.InvariantCulture);
        

[Description("Height at which air temperature is calculated for comfort purposes")]
[JsonProperty(PropertyName="comfort_height")]
public System.Nullable<float> ComfortHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

[Description(@"Minimum temperature difference between predicted upper and lower layer temperatures above which UFAD auxiliary outputs are calculated. These outputs are 'UF Transition Height' and 'UF Average Temp Gradient'. They are set to zero values when the temperature difference is less than the threshold and the output 'UF Zone Is Mixed' is set to 1")]
[JsonProperty(PropertyName="temperature_difference_threshold_for_reporting")]
public System.Nullable<float> TemperatureDifferenceThresholdForReporting { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="floor_diffuser_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType FloorDiffuserType { get; set; } = (RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType)Enum.Parse(typeof(RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType), "Swirl");
        

[Description("user-specified height above floor of boundary between occupied and upper subzones" +
    "")]
[JsonProperty(PropertyName="transition_height", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> TransitionHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.7", CultureInfo.InvariantCulture);
        

[Description("Coefficient A in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
    "ction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_a", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientA { get; set; } = null;
        

[Description("Coefficient B in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
    "ction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_b", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientB { get; set; } = null;
        

[Description("Coefficient C in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
    "ction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_c", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientC { get; set; } = null;
        

[Description("Coefficient D in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
    "ction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_d", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientD { get; set; } = null;
        

[Description("Coefficient E in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
    "ction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_e", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientE { get; set; } = null;
    }
    
    public enum RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Custom")]
        Custom = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HorizontalSwirl")]
        HorizontalSwirl = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="LinearBarGrille")]
        LinearBarGrille = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Swirl")]
        Swirl = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableArea")]
        VariableArea = 5,
    }
    
    [Description(@"Applicable to exterior spaces that are served by an underfloor air distribution system. The dominant sources of heat gain should be from people, equipment, and other localized sources located in the occupied part of the room, as well as convective gain coming from a warm window. Used with RoomAirModelType = CrossVentilation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_UnderFloorAirDistributionExterior : BHoMObject
    {
        

[Description("Name of Zone being described. Any existing zone name")]
[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="number_of_diffusers_per_zone", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> NumberOfDiffusersPerZone { get; set; } = null;
        

[JsonProperty(PropertyName="power_per_plume", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> PowerPerPlume { get; set; } = null;
        

[JsonProperty(PropertyName="design_effective_area_of_diffuser", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> DesignEffectiveAreaOfDiffuser { get; set; } = null;
        

[JsonProperty(PropertyName="diffuser_slot_angle_from_vertical", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> DiffuserSlotAngleFromVertical { get; set; } = null;
        

[Description("Height of thermostat/temperature control sensor above floor")]
[JsonProperty(PropertyName="thermostat_height")]
public System.Nullable<float> ThermostatHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.2", CultureInfo.InvariantCulture);
        

[Description("Height at which Air temperature is calculated for comfort purposes")]
[JsonProperty(PropertyName="comfort_height")]
public System.Nullable<float> ComfortHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

[Description(@"Minimum temperature difference between upper and lower layer temperatures above which UFAD auxiliary outputs are calculated. These outputs are 'UF Transition Height' and 'UF Average Temp Gradient'. They are set to zero values when the temperature difference is less than the threshold and the output 'UF Zone Is Mixed' is set to 1")]
[JsonProperty(PropertyName="temperature_difference_threshold_for_reporting")]
public System.Nullable<float> TemperatureDifferenceThresholdForReporting { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="floor_diffuser_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType FloorDiffuserType { get; set; } = (RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType)Enum.Parse(typeof(RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType), "Swirl");
        

[Description("User-specified height above floor of boundary between occupied and upper subzones" +
    "")]
[JsonProperty(PropertyName="transition_height", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> TransitionHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.7", CultureInfo.InvariantCulture);
        

[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_a_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientAInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = null;
        

[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_b_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientBInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = null;
        

[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_c_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientCInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = null;
        

[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_d_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientDInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = null;
        

[Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
[JsonProperty(PropertyName="coefficient_e_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> CoefficientEInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = null;
    }
    
    public enum RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Custom")]
        Custom = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HorizontalSwirl")]
        HorizontalSwirl = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="LinearBarGrille")]
        LinearBarGrille = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Swirl")]
        Swirl = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableArea")]
        VariableArea = 5,
    }
    
    [Description("define an air node for some types of nodal air models")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="fraction_of_zone_air_volume")]
public System.Nullable<float> FractionOfZoneAirVolume { get; set; } = null;
        

[JsonProperty(PropertyName="roomair_node_airflownetwork_adjacentsurfacelist_name")]
public string RoomairNodeAirflownetworkAdjacentsurfacelistName { get; set; } = "";
        

[JsonProperty(PropertyName="roomair_node_airflownetwork_internalgains_name")]
public string RoomairNodeAirflownetworkInternalgainsName { get; set; } = "";
        

[JsonProperty(PropertyName="roomair_node_airflownetwork_hvacequipment_name")]
public string RoomairNodeAirflownetworkHvacequipmentName { get; set; } = "";
    }
    
    [Description(null)]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork_AdjacentSurfaceList : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="surfaces")]
public string Surfaces { get; set; } = "";
    }
    
    [Description("define the internal gains that are associated with one particular RoomAir:Node")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork_InternalGains : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="gains")]
public string Gains { get; set; } = "";
    }
    
    [Description("define the zone equipment associated with one particular RoomAir:Node")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork_HVACEquipment : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_fractions")]
public string EquipmentFractions { get; set; } = "";
    }
    
    [Description("RoomAir modeling using Airflow pressure network solver")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_AirflowNetwork : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Name of Zone being described. Any existing zone name")]
[JsonProperty(PropertyName="zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="control_point_roomairflownetwork_node_name")]
public string ControlPointRoomairflownetworkNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="nodes")]
public string Nodes { get; set; } = "";
    }
}
