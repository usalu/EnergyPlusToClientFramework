namespace BH.oM.Adapters.EnergyPlus.Fans
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
    
    
    [Description(@"Versatile simple fan that can be used in variable air volume, constant volume, on-off cycling, two-speed or multi-speed applications. Performance at different flow rates, or speed levels, is determined using separate performance curve or table or prescribed power fractions at discrete speed levels for two-speed or multi-speed fans.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_SystemModel : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Availability schedule name for this fan. Schedule value > 0 means the fan is avai" +
    "lable. If this field is blank, the fan is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("design_maximum_air_flow_rate")]
public string DesignMaximumAirFlowRate { get; set; } = "";
        

[JsonProperty("speed_control_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Fan_SystemModel_SpeedControlMethod SpeedControlMethod { get; set; } = (Fan_SystemModel_SpeedControlMethod)Enum.Parse(typeof(Fan_SystemModel_SpeedControlMethod), "Discrete");
        

[JsonProperty("electric_power_minimum_flow_rate_fraction")]
public System.Nullable<float> ElectricPowerMinimumFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("design_pressure_rise")]
public System.Nullable<float> DesignPressureRise { get; set; } = null;
        

[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
[JsonProperty("motor_in_air_stream_fraction")]
public System.Nullable<float> MotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Fan power consumption at maximum air flow rate. If autosized the method used to s" +
    "cale power is chosen in the following field")]
[JsonProperty("design_electric_power_consumption")]
public string DesignElectricPowerConsumption { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_power_sizing_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Fan_SystemModel_DesignPowerSizingMethod DesignPowerSizingMethod { get; set; } = (Fan_SystemModel_DesignPowerSizingMethod)Enum.Parse(typeof(Fan_SystemModel_DesignPowerSizingMethod), "PowerPerFlowPerPressure");
        

[JsonProperty("electric_power_per_unit_flow_rate")]
public System.Nullable<float> ElectricPowerPerUnitFlowRate { get; set; } = null;
        

[JsonProperty("electric_power_per_unit_flow_rate_per_unit_pressure")]
public System.Nullable<float> ElectricPowerPerUnitFlowRatePerUnitPressure { get; set; } = (System.Nullable<float>)Single.Parse("1.66667", CultureInfo.InvariantCulture);
        

[JsonProperty("fan_total_efficiency")]
public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description(@"independent variable is normalized flow rate, current flow divided by Design Maximum Air Flow Rate. dependent variable is modification factor multiplied by Design Power Consumption. This field is required if Speed Control Method is set to Continuous or if the Number of Speeds is greater than 1 and Speed Electric Power Fraction fields are not used.")]
[JsonProperty("electric_power_function_of_flow_fraction_curve_name")]
public string ElectricPowerFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("Total system fan pressure rise at the fan when in night mode using AvailabilityMa" +
    "nager:NightVentilation")]
[JsonProperty("night_ventilation_mode_pressure_rise")]
public System.Nullable<float> NightVentilationModePressureRise { get; set; } = null;
        

[Description("Fraction of Design Maximum Air Flow Rate to use when in night mode using Availabi" +
    "lityManager:NightVentilation")]
[JsonProperty("night_ventilation_mode_flow_fraction")]
public System.Nullable<float> NightVentilationModeFlowFraction { get; set; } = null;
        

[Description("optional, if used fan motor heat losses that not added to air stream are transfer" +
    "red to zone as internal gains")]
[JsonProperty("motor_loss_zone_name")]
public string MotorLossZoneName { get; set; } = "";
        

[Description("optional. If zone identified in previous field then this determines the split bet" +
    "ween convection and radiation for the fan motor\'s skin losses")]
[JsonProperty("motor_loss_radiative_fraction")]
public System.Nullable<float> MotorLossRadiativeFraction { get; set; } = null;
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[Description(@"number of different speed levels available when Speed Control Method is set to Discrete Speed need to be arranged in increasing order in remaining field sets. If set to 1, or omitted, and Speed Control Method is Discrete then constant fan speed is the design maximum.")]
[JsonProperty("number_of_speeds")]
public System.Nullable<float> NumberOfSpeeds { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_fractions")]
public string SpeedFractions { get; set; } = "";
    }
    
    public enum Fan_SystemModel_SpeedControlMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Continuous")]
        Continuous = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Discrete")]
        Discrete = 2,
    }
    
    public enum Fan_SystemModel_DesignPowerSizingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlow")]
        PowerPerFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TotalEfficiencyAndPressure")]
        TotalEfficiencyAndPressure = 3,
    }
    
    [Description("Constant volume fan that is intended to operate continuously based on a time sche" +
        "dule. This fan will not cycle on and off based on cooling/heating load or other " +
        "control signals.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_ConstantVolume : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("fan_total_efficiency")]
public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("pressure_rise")]
public System.Nullable<float> PressureRise { get; set; } = null;
        

[JsonProperty("maximum_flow_rate")]
public string MaximumFlowRate { get; set; } = "";
        

[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
[JsonProperty("motor_in_airstream_fraction")]
public System.Nullable<float> MotorInAirstreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    [Description("Variable air volume fan where the electric power input varies according to a perf" +
        "ormance curve as a function of flow fraction.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_VariableVolume : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("fan_total_efficiency")]
public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("pressure_rise")]
public System.Nullable<float> PressureRise { get; set; } = null;
        

[JsonProperty("maximum_flow_rate")]
public string MaximumFlowRate { get; set; } = "";
        

[JsonProperty("fan_power_minimum_flow_rate_input_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod FanPowerMinimumFlowRateInputMethod { get; set; } = (Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod)Enum.Parse(typeof(Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod), "Fraction");
        

[JsonProperty("fan_power_minimum_flow_fraction")]
public System.Nullable<float> FanPowerMinimumFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

[JsonProperty("fan_power_minimum_air_flow_rate")]
public System.Nullable<float> FanPowerMinimumAirFlowRate { get; set; } = null;
        

[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
[JsonProperty("motor_in_airstream_fraction")]
public System.Nullable<float> MotorInAirstreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("all Fan Power Coefficients should not be 0.0 or no fan power will be consumed. Fa" +
    "n Power Coefficents are specified as function of full flow rate/power Equation:")]
[JsonProperty("fan_power_coefficient_1")]
public System.Nullable<float> FanPowerCoefficient1 { get; set; } = null;
        

[JsonProperty("fan_power_coefficient_2")]
public System.Nullable<float> FanPowerCoefficient2 { get; set; } = null;
        

[JsonProperty("fan_power_coefficient_3")]
public System.Nullable<float> FanPowerCoefficient3 { get; set; } = null;
        

[JsonProperty("fan_power_coefficient_4")]
public System.Nullable<float> FanPowerCoefficient4 { get; set; } = null;
        

[JsonProperty("fan_power_coefficient_5")]
public System.Nullable<float> FanPowerCoefficient5 { get; set; } = null;
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedFlowRate")]
        FixedFlowRate = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Fraction")]
        Fraction = 2,
    }
    
    [Description("Constant volume fan that is intended to cycle on and off based on cooling/heating" +
        " load or other control signals. This fan can also operate continuously like Fan:" +
        "ConstantVolume.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_OnOff : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("fan_total_efficiency")]
public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.6", CultureInfo.InvariantCulture);
        

[JsonProperty("pressure_rise")]
public System.Nullable<float> PressureRise { get; set; } = null;
        

[JsonProperty("maximum_flow_rate")]
public string MaximumFlowRate { get; set; } = "";
        

[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
[JsonProperty("motor_in_airstream_fraction")]
public System.Nullable<float> MotorInAirstreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("fan_power_ratio_function_of_speed_ratio_curve_name")]
public string FanPowerRatioFunctionOfSpeedRatioCurveName { get; set; } = "";
        

[JsonProperty("fan_efficiency_ratio_function_of_speed_ratio_curve_name")]
public string FanEfficiencyRatioFunctionOfSpeedRatioCurveName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    [Description("Models a fan that exhausts air from a zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_ZoneExhaust : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("fan_total_efficiency")]
public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.6", CultureInfo.InvariantCulture);
        

[JsonProperty("pressure_rise")]
public System.Nullable<float> PressureRise { get; set; } = null;
        

[JsonProperty("maximum_flow_rate")]
public System.Nullable<float> MaximumFlowRate { get; set; } = null;
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[Description("If field is used, then when fan runs the exhausted air flow rate is controlled to" +
    " be the scheduled fraction times the Maximum Flow Rate")]
[JsonProperty("flow_fraction_schedule_name")]
public string FlowFractionScheduleName { get; set; } = "";
        

[Description("Control if fan is to be interlocked with HVAC system Availability Managers or not" +
    ".")]
[JsonProperty("system_availability_manager_coupling_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode SystemAvailabilityManagerCouplingMode { get; set; } = (Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode)Enum.Parse(typeof(Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode), "Coupled");
        

[Description("If field is used, the exhaust fan will not run if the zone temperature is lower t" +
    "han this limit")]
[JsonProperty("minimum_zone_temperature_limit_schedule_name")]
public string MinimumZoneTemperatureLimitScheduleName { get; set; } = "";
        

[Description("Used to control fan\'s impact on flow at the return air node. Enter the portion of" +
    " the exhaust that is balanced by simple airflows.")]
[JsonProperty("balanced_exhaust_fraction_schedule_name")]
public string BalancedExhaustFractionScheduleName { get; set; } = "";
    }
    
    public enum Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coupled")]
        Coupled = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Decoupled")]
        Decoupled = 2,
    }
    
    [Description(@"Specifies an alternate set of performance parameters for a fan. These alternate parameters are used when a system manager (such as AvailabilityManager:NightVentilation) sets a specified flow rate. May be used with Fan:ConstantVolume, Fan:VariableVolume and Fan:ComponentModel. If the fan model senses that a fixed flow rate has been set, it will use these alternate performance parameters. It is assumed that the fan will run at a fixed speed in the alternate mode.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FanPerformance_NightVentilation : BHoMObject
    {
        

[JsonProperty("fan_name")]
public string FanName { get; set; } = "";
        

[JsonProperty("fan_total_efficiency")]
public System.Nullable<float> FanTotalEfficiency { get; set; } = null;
        

[JsonProperty("pressure_rise")]
public System.Nullable<float> PressureRise { get; set; } = null;
        

[JsonProperty("maximum_flow_rate")]
public string MaximumFlowRate { get; set; } = "";
        

[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = null;
        

[Description("0.0 means fan motor outside of airstream 1.0 means fan motor inside of airstream")]
[JsonProperty("motor_in_airstream_fraction")]
public System.Nullable<float> MotorInAirstreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    [Description("A detailed fan type for constant-air-volume (CAV) and variable-air-volume (VAV) s" +
        "ystems. It includes inputs that describe the air-distribution system as well as " +
        "the fan, drive belt (if used), motor, and variable-frequency-drive (if used).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_ComponentModel : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("maximum_flow_rate")]
public string MaximumFlowRate { get; set; } = "";
        

[JsonProperty("minimum_flow_rate")]
public string MinimumFlowRate { get; set; } = "";
        

[Description("Applied to specified or autosized max fan airflow")]
[JsonProperty("fan_sizing_factor")]
public System.Nullable<float> FanSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Diameter of wheel outer circumference")]
[JsonProperty("fan_wheel_diameter")]
public System.Nullable<float> FanWheelDiameter { get; set; } = null;
        

[Description("Area at fan outlet plane for determining discharge velocity pressure")]
[JsonProperty("fan_outlet_area")]
public System.Nullable<float> FanOutletArea { get; set; } = null;
        

[Description("Maximum ratio between power delivered to air and fan shaft input power Determined" +
    " from fan performance data")]
[JsonProperty("maximum_fan_static_efficiency")]
public System.Nullable<float> MaximumFanStaticEfficiency { get; set; } = null;
        

[Description("Euler number (Eu) determined from fan performance data")]
[JsonProperty("euler_number_at_maximum_fan_static_efficiency")]
public System.Nullable<float> EulerNumberAtMaximumFanStaticEfficiency { get; set; } = null;
        

[Description("Corresponds to maximum ratio between fan airflow and fan shaft rotational speed f" +
    "or specified fan wheel diameter Determined from fan performance data")]
[JsonProperty("maximum_dimensionless_fan_airflow")]
public System.Nullable<float> MaximumDimensionlessFanAirflow { get; set; } = null;
        

[Description("Ratio of motor pulley diameter to fan pulley diameter")]
[JsonProperty("motor_fan_pulley_ratio")]
public string MotorFanPulleyRatio { get; set; } = (System.String)"1";
        

[Description("Maximum torque transmitted by belt")]
[JsonProperty("belt_maximum_torque")]
public string BeltMaximumTorque { get; set; } = "";
        

[Description("Applied to specified or autosized max torque transmitted by belt")]
[JsonProperty("belt_sizing_factor")]
public System.Nullable<float> BeltSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Region 1 to 2 curve transition for belt normalized efficiency")]
[JsonProperty("belt_fractional_torque_transition")]
public System.Nullable<float> BeltFractionalTorqueTransition { get; set; } = (System.Nullable<float>)Single.Parse("0.167", CultureInfo.InvariantCulture);
        

[Description("Maximum rotational speed of fan motor shaft")]
[JsonProperty("motor_maximum_speed")]
public System.Nullable<float> MotorMaximumSpeed { get; set; } = null;
        

[Description("Maximum power input to drive belt by motor")]
[JsonProperty("maximum_motor_output_power")]
public string MaximumMotorOutputPower { get; set; } = "";
        

[Description("Applied to specified or autosized motor output power")]
[JsonProperty("motor_sizing_factor")]
public System.Nullable<float> MotorSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("0.0 means motor outside air stream 1.0 means motor inside air stream")]
[JsonProperty("motor_in_airstream_fraction")]
public System.Nullable<float> MotorInAirstreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Efficiency depends on fraction of full-load motor speed Efficiency depends on  fr" +
    "action of full-load motor input power If field blank, then assumes constant VFD " +
    "efficiency (0.97)")]
[JsonProperty("vfd_efficiency_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Fan_ComponentModel_VfdEfficiencyType VfdEfficiencyType { get; set; } = (Fan_ComponentModel_VfdEfficiencyType)Enum.Parse(typeof(Fan_ComponentModel_VfdEfficiencyType), "Power");
        

[Description("Maximum power input to motor by VFD")]
[JsonProperty("maximum_vfd_output_power")]
public string MaximumVfdOutputPower { get; set; } = "";
        

[Description("Applied to specified or autosized VFD output power")]
[JsonProperty("vfd_sizing_factor")]
public System.Nullable<float> VfdSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Pressure rise depends on volumetric flow, system resistances, system leakage, and" +
    " duct static pressure set point")]
[JsonProperty("fan_pressure_rise_curve_name")]
public string FanPressureRiseCurveName { get; set; } = "";
        

[Description("Function of fan volumetric flow Minimum and maximum fan airflows correspond respe" +
    "ctively to minimum and maximum duct static pressure set points")]
[JsonProperty("duct_static_pressure_reset_curve_name")]
public string DuctStaticPressureResetCurveName { get; set; } = "";
        

[Description("xfan <= 0 Curve should have maximum of 1.0")]
[JsonProperty("normalized_fan_static_efficiency_curve_name_non_stall_region")]
public string NormalizedFanStaticEfficiencyCurveNameNonStallRegion { get; set; } = "";
        

[Description("xfan > 0 Curve should have maximum of 1.0")]
[JsonProperty("normalized_fan_static_efficiency_curve_name_stall_region")]
public string NormalizedFanStaticEfficiencyCurveNameStallRegion { get; set; } = "";
        

[Description("xspd <= 0 Curve should have maximum of 1.0")]
[JsonProperty("normalized_dimensionless_airflow_curve_name_non_stall_region")]
public string NormalizedDimensionlessAirflowCurveNameNonStallRegion { get; set; } = "";
        

[Description("xspd > 0 Curve should have maximum of 1.0")]
[JsonProperty("normalized_dimensionless_airflow_curve_name_stall_region")]
public string NormalizedDimensionlessAirflowCurveNameStallRegion { get; set; } = "";
        

[Description("Determines maximum fan drive belt efficiency in log space as function of xbelt,ma" +
    "x Curve should have minimum of -4.6 and maximum of 0.0 If field blank, assumes o" +
    "utput of curve is always 1.0")]
[JsonProperty("maximum_belt_efficiency_curve_name")]
public string MaximumBeltEfficiencyCurveName { get; set; } = "";
        

[Description("Region 1 (0 <= xbelt < xbelt,trans) Curve should have minimum > 0.0 and maximum o" +
    "f 1.0 If field blank, assumes output of curve is always 1.0 in Region 1")]
[JsonProperty("normalized_belt_efficiency_curve_name_region_1")]
public string NormalizedBeltEfficiencyCurveNameRegion1 { get; set; } = "";
        

[Description("Region 2 (xbelt,trans <= xbelt <= 1) Curve should have minimum > 0.0 and maximum " +
    "of 1.0 If field blank, assumes output of curve is always 1.0 in Region 2")]
[JsonProperty("normalized_belt_efficiency_curve_name_region_2")]
public string NormalizedBeltEfficiencyCurveNameRegion2 { get; set; } = "";
        

[Description("Determines normalized drive belt efficiency Region 3 (xbelt > 1) Curve should hav" +
    "e minimum > 0.0 and maximum of 1.0 If field blank, assumes output of curve is al" +
    "ways 1.0 in Region 3")]
[JsonProperty("normalized_belt_efficiency_curve_name_region_3")]
public string NormalizedBeltEfficiencyCurveNameRegion3 { get; set; } = "";
        

[Description("Curve should have minimum > 0.0 and maximum of 1.0 If field blank, assumes output" +
    " of curve is always 1.0")]
[JsonProperty("maximum_motor_efficiency_curve_name")]
public string MaximumMotorEfficiencyCurveName { get; set; } = "";
        

[Description("Curve should have minimum > 0.0 and maximum of 1.0 If field blank, assumes output" +
    " of curve is always 1.0")]
[JsonProperty("normalized_motor_efficiency_curve_name")]
public string NormalizedMotorEfficiencyCurveName { get; set; } = "";
        

[Description("Determines VFD efficiency as function of motor load or speed fraction Curve shoul" +
    "d have minimum > 0.0 and maximum of 1.0 If field blank, assumes constant VFD eff" +
    "iciency (0.97)")]
[JsonProperty("vfd_efficiency_curve_name")]
public string VfdEfficiencyCurveName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Fan_ComponentModel_VfdEfficiencyType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Speed")]
        Speed = 1,
    }
}
