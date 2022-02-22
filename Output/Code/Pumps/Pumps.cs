namespace BH.oM.Adapters.EnergyPlus.Pumps
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
    
    
    [Description("This pump model is described in the ASHRAE secondary HVAC toolkit.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pump_VariableSpeed : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("design_maximum_flow_rate")]
public string DesignMaximumFlowRate { get; set; } = "";
        

[Description("default head is 60 feet")]
[JsonProperty("design_pump_head")]
public System.Nullable<float> DesignPumpHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("When autosized the type of scaling factor is chosen in the input field Design Pow" +
    "er Sizing Method")]
[JsonProperty("design_power_consumption")]
public string DesignPowerConsumption { get; set; } = "";
        

[Description("This is the motor efficiency only. When the Design Power Consumption is autosized" +
    " using PowerPerFlowPerPressure, the Design Shaft Power per Unit Flow Rate per Un" +
    "it Head is used in addition to the motor efficiency.")]
[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_of_motor_inefficiencies_to_fluid_stream")]
public System.Nullable<float> FractionOfMotorInefficienciesToFluidStream { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_1_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient1OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_2_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient2OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_3_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient3OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_4_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient4OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("When autosized the scaling factor is the input field Design Minimum Flow Rate Fra" +
    "ction")]
[JsonProperty("design_minimum_flow_rate")]
public string DesignMinimumFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("pump_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Pump_VariableSpeed_PumpControlType PumpControlType { get; set; } = (Pump_VariableSpeed_PumpControlType)Enum.Parse(typeof(Pump_VariableSpeed_PumpControlType), "Continuous");
        

[Description("Modifies the rated flow rate of the pump on a time basis. Default is that the pum" +
    "p is on and runs according to its other operational requirements specified above" +
    ". The schedule is for special pump operations.")]
[JsonProperty("pump_flow_rate_schedule_name")]
public string PumpFlowRateScheduleName { get; set; } = "";
        

[Description(@"This references any single independent variable polynomial curve in order to do pressure vs. flow calculations for this pump. The available types are then: Linear, Quadratic, Cubic, and Quartic The non-dimensional pump pressure relationship is of the following form: (psi = C4*phi^4 + C3*phi^3 + C2*phi^2 + C1*phi + C0) Where the non-dimensional variables are defined as: delP = rho * ((N/60)^2) * (D^2) * psi mdot = rho * (N/60) * (D^3) * phi")]
[JsonProperty("pump_curve_name")]
public string PumpCurveName { get; set; } = "";
        

[Description("\"D\" in above expression in field A6")]
[JsonProperty("impeller_diameter")]
public System.Nullable<float> ImpellerDiameter { get; set; } = null;
        

[JsonProperty("vfd_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Pump_VariableSpeed_VfdControlType VfdControlType { get; set; } = (Pump_VariableSpeed_VfdControlType)Enum.Parse(typeof(Pump_VariableSpeed_VfdControlType), "ManualControl");
        

[Description("Modifies the rpm of the pump on a time basis. Default is that the pump is on and " +
    "runs according to its other operational requirements specified above. The schedu" +
    "le is for special pump operations.")]
[JsonProperty("pump_rpm_schedule_name")]
public string PumpRpmScheduleName { get; set; } = "";
        

[JsonProperty("minimum_pressure_schedule")]
public string MinimumPressureSchedule { get; set; } = "";
        

[JsonProperty("maximum_pressure_schedule")]
public string MaximumPressureSchedule { get; set; } = "";
        

[JsonProperty("minimum_rpm_schedule")]
public string MinimumRpmSchedule { get; set; } = "";
        

[JsonProperty("maximum_rpm_schedule")]
public string MaximumRpmSchedule { get; set; } = "";
        

[Description("optional, if used pump losses transfered to zone as internal gains")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("optional. If zone identified in previous field then this determines the split bet" +
    "ween convection and radiation for the skin losses")]
[JsonProperty("skin_loss_radiative_fraction")]
public System.Nullable<float> SkinLossRadiativeFraction { get; set; } = null;
        

[Description(@"Used to indicate which sizing factor is used to calculate Design Power Consumption. PowerPerFlow indicates that Design Electric Power per Unit Flow Rate is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * scaling factor PowerPerFlowPerPressure indicates that Design Shaft Power per Unit Flow Rate per Unit Head is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * Design Pump Head * scaling factor / Motor Efficiency")]
[JsonProperty("design_power_sizing_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Pump_VariableSpeed_DesignPowerSizingMethod DesignPowerSizingMethod { get; set; } = (Pump_VariableSpeed_DesignPowerSizingMethod)Enum.Parse(typeof(Pump_VariableSpeed_DesignPowerSizingMethod), "PowerPerFlowPerPressure");
        

[Description("Used to size Design Power Consumption from design flow rate")]
[JsonProperty("design_electric_power_per_unit_flow_rate")]
public System.Nullable<float> DesignElectricPowerPerUnitFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("348701.1", CultureInfo.InvariantCulture);
        

[Description("Used to size Design Power Consumption from design flow rate for head and motor ef" +
    "ficiency")]
[JsonProperty("design_shaft_power_per_unit_flow_rate_per_unit_head")]
public System.Nullable<float> DesignShaftPowerPerUnitFlowRatePerUnitHead { get; set; } = (System.Nullable<float>)Single.Parse("1.282051282", CultureInfo.InvariantCulture);
        

[Description("Used to size Design Minimum Flow Rate")]
[JsonProperty("design_minimum_flow_rate_fraction")]
public System.Nullable<float> DesignMinimumFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Pump_VariableSpeed_PumpControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Continuous")]
        Continuous = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Intermittent")]
        Intermittent = 2,
    }
    
    public enum Pump_VariableSpeed_VfdControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ManualControl")]
        ManualControl = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PressureSetpointControl")]
        PressureSetpointControl = 1,
    }
    
    public enum Pump_VariableSpeed_DesignPowerSizingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlow")]
        PowerPerFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
    }
    
    [Description("This pump model is described in the ASHRAE secondary HVAC toolkit.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pump_ConstantSpeed : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("design_flow_rate")]
public string DesignFlowRate { get; set; } = "";
        

[Description("default head is 60 feet")]
[JsonProperty("design_pump_head")]
public System.Nullable<float> DesignPumpHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("When autosized the type of scaling factor is chosen in the input field Design Pow" +
    "er Sizing Method")]
[JsonProperty("design_power_consumption")]
public string DesignPowerConsumption { get; set; } = "";
        

[Description("This is the motor efficiency only. When the Design Power Consumption is autosized" +
    " using PowerPerFlowPerPressure, the Design Shaft Power per Unit Flow Rate per Un" +
    "it Head is used in addition to the motor efficiency.")]
[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_of_motor_inefficiencies_to_fluid_stream")]
public System.Nullable<float> FractionOfMotorInefficienciesToFluidStream { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("pump_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Pump_ConstantSpeed_PumpControlType PumpControlType { get; set; } = (Pump_ConstantSpeed_PumpControlType)Enum.Parse(typeof(Pump_ConstantSpeed_PumpControlType), "Continuous");
        

[Description("Modifies the rated flow rate of the pump on a time basis. Default is that the pum" +
    "p is on and runs according to its other operational requirements specified above" +
    ". The schedule is for special pump operations.")]
[JsonProperty("pump_flow_rate_schedule_name")]
public string PumpFlowRateScheduleName { get; set; } = "";
        

[Description(@"This references any single independent variable polynomial curve in order to do pressure vs. flow calculations for this pump. The available types are then: Linear, Quadratic, Cubic, and Quartic The non-dimensional pump pressure relationship is of the following form: (psi = C4*phi^4 + C3*phi^3 + C2*phi^2 + C1*phi + C0) Where the non-dimensional variables are defined as: delP = rho * ((N/60)^2) * (D^2) * psi mdot = rho * (N/60) * (D^3) * phi")]
[JsonProperty("pump_curve_name")]
public string PumpCurveName { get; set; } = "";
        

[Description("\"D\" in above expression in field A6")]
[JsonProperty("impeller_diameter")]
public System.Nullable<float> ImpellerDiameter { get; set; } = null;
        

[Description("\"N\" in above expression in field A6")]
[JsonProperty("rotational_speed")]
public System.Nullable<float> RotationalSpeed { get; set; } = null;
        

[Description("optional, if used pump losses transfered to zone as internal gains")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("optional. If zone identified in previous field then this determines the split bet" +
    "ween convection and radiation for the skin losses")]
[JsonProperty("skin_loss_radiative_fraction")]
public System.Nullable<float> SkinLossRadiativeFraction { get; set; } = null;
        

[Description(@"Used to indicate which sizing factor is used to calculate Design Power Consumption. PowerPerFlow indicates that Design Electric Power per Unit Flow Rate is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * scaling factor PowerPerFlowPerPressure indicates that Design Shaft Power per Unit Flow Rate per Unit Head is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * Design Pump Head * scaling factor / Motor Efficiency")]
[JsonProperty("design_power_sizing_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Pump_ConstantSpeed_DesignPowerSizingMethod DesignPowerSizingMethod { get; set; } = (Pump_ConstantSpeed_DesignPowerSizingMethod)Enum.Parse(typeof(Pump_ConstantSpeed_DesignPowerSizingMethod), "PowerPerFlowPerPressure");
        

[Description("Used to size Design Power Consumption from design flow rate")]
[JsonProperty("design_electric_power_per_unit_flow_rate")]
public System.Nullable<float> DesignElectricPowerPerUnitFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("348701.1", CultureInfo.InvariantCulture);
        

[Description("Used to size Design Power Consumption from design flow rate for head and motor ef" +
    "ficiency")]
[JsonProperty("design_shaft_power_per_unit_flow_rate_per_unit_head")]
public System.Nullable<float> DesignShaftPowerPerUnitFlowRatePerUnitHead { get; set; } = (System.Nullable<float>)Single.Parse("1.282051282", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Pump_ConstantSpeed_PumpControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Continuous")]
        Continuous = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Intermittent")]
        Intermittent = 2,
    }
    
    public enum Pump_ConstantSpeed_DesignPowerSizingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlow")]
        PowerPerFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
    }
    
    [Description("This pump model is described in the ASHRAE secondary HVAC toolkit. Variable Speed" +
        " Condensate pump for Steam Systems")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pump_VariableSpeed_Condensate : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[Description("this is the volume of steam before condensation, the volume of condensate is much" +
    " lower and calculated from steam density")]
[JsonProperty("design_steam_volume_flow_rate")]
public string DesignSteamVolumeFlowRate { get; set; } = "";
        

[Description("default head is 60 feet")]
[JsonProperty("design_pump_head")]
public System.Nullable<float> DesignPumpHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("When autosized the type of scaling factor is chosen in the input field Design Pow" +
    "er Sizing Method")]
[JsonProperty("design_power_consumption")]
public string DesignPowerConsumption { get; set; } = "";
        

[Description("This is the motor efficiency only. When the Design Power Consumption is autosized" +
    " using PowerPerFlowPerPressure, the Design Shaft Power per Unit Flow Rate per Un" +
    "it Head is used in addition to the motor efficiency.")]
[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_of_motor_inefficiencies_to_fluid_stream")]
public System.Nullable<float> FractionOfMotorInefficienciesToFluidStream { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_1_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient1OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_2_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient2OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_3_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient3OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_4_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient4OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Modifies the rated flow rate of the pump on a time basis. Default is that the pum" +
    "p is on and runs according to its other operational requirements specified above" +
    ". The schedule is for special pump operations.")]
[JsonProperty("pump_flow_rate_schedule_name")]
public string PumpFlowRateScheduleName { get; set; } = "";
        

[Description("optional, if used pump losses transfered to zone as internal gains")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("optional. If zone identified in previous field then this determines the split bet" +
    "ween convection and radiation for the skin losses")]
[JsonProperty("skin_loss_radiative_fraction")]
public System.Nullable<float> SkinLossRadiativeFraction { get; set; } = null;
        

[Description(@"Used to indicate which sizing factor is used to calculate Design Power Consumption. PowerPerFlow indicates that Design Electric Power per Unit Flow Rate is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * scaling factor PowerPerFlowPerPressure indicates that Design Shaft Power per Unit Flow Rate per Unit Head is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * Design Pump Head * scaling factor / Motor Efficiency")]
[JsonProperty("design_power_sizing_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Pump_VariableSpeed_Condensate_DesignPowerSizingMethod DesignPowerSizingMethod { get; set; } = (Pump_VariableSpeed_Condensate_DesignPowerSizingMethod)Enum.Parse(typeof(Pump_VariableSpeed_Condensate_DesignPowerSizingMethod), "PowerPerFlowPerPressure");
        

[Description("Used to size Design Power Consumption from design flow rate")]
[JsonProperty("design_electric_power_per_unit_flow_rate")]
public System.Nullable<float> DesignElectricPowerPerUnitFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("348701.1", CultureInfo.InvariantCulture);
        

[Description("Used to size Design Power Consumption from design flow rate for head and motor ef" +
    "ficiency")]
[JsonProperty("design_shaft_power_per_unit_flow_rate_per_unit_head")]
public System.Nullable<float> DesignShaftPowerPerUnitFlowRatePerUnitHead { get; set; } = (System.Nullable<float>)Single.Parse("1.282051282", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Pump_VariableSpeed_Condensate_DesignPowerSizingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlow")]
        PowerPerFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
    }
    
    [Description("This Headered pump object describes a pump bank with more than 1 pump in parallel" +
        "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeaderedPumps_ConstantSpeed : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[Description("If the field is not autosized set to the flow rate to the total flow when all pum" +
    "ps are running at full load")]
[JsonProperty("total_design_flow_rate")]
public string TotalDesignFlowRate { get; set; } = "";
        

[JsonProperty("number_of_pumps_in_bank")]
public System.Nullable<float> NumberOfPumpsInBank { get; set; } = null;
        

[JsonProperty("flow_sequencing_control_scheme")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HeaderedPumps_ConstantSpeed_FlowSequencingControlScheme FlowSequencingControlScheme { get; set; } = (HeaderedPumps_ConstantSpeed_FlowSequencingControlScheme)Enum.Parse(typeof(HeaderedPumps_ConstantSpeed_FlowSequencingControlScheme), "Sequential");
        

[Description("default head is 60 feet")]
[JsonProperty("design_pump_head")]
public System.Nullable<float> DesignPumpHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("If the field is not autosized set to the power consumed by the pump bank when all" +
    " the pumps are running at nominal flow When autosized the type of scaling factor" +
    " is chosen in the input field Design Power Sizing Method")]
[JsonProperty("design_power_consumption")]
public string DesignPowerConsumption { get; set; } = "";
        

[Description("This is the motor efficiency only. When the Design Power Consumption is autosized" +
    " using PowerPerFlowPerPressure, the Design Shaft Power per Unit Flow Rate per Un" +
    "it Head is used in addition to the motor efficiency.")]
[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_of_motor_inefficiencies_to_fluid_stream")]
public System.Nullable<float> FractionOfMotorInefficienciesToFluidStream { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("pump_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HeaderedPumps_ConstantSpeed_PumpControlType PumpControlType { get; set; } = (HeaderedPumps_ConstantSpeed_PumpControlType)Enum.Parse(typeof(HeaderedPumps_ConstantSpeed_PumpControlType), "Continuous");
        

[Description("Modifies the rated flow rate of the pump on a time basis. Default is that the pum" +
    "p is on and runs according to its other operational requirements specified above" +
    ". The schedule is for special pump operations.")]
[JsonProperty("pump_flow_rate_schedule_name")]
public string PumpFlowRateScheduleName { get; set; } = "";
        

[Description("optional, if used pump losses transfered to zone as internal gains")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("optional. If zone identified in previous field then this determines the split bet" +
    "ween convection and radiation for the skin losses")]
[JsonProperty("skin_loss_radiative_fraction")]
public System.Nullable<float> SkinLossRadiativeFraction { get; set; } = null;
        

[Description(@"Used to indicate which sizing factor is used to calculate Design Power Consumption. PowerPerFlow indicates that Design Electric Power per Unit Flow Rate is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * scaling factor PowerPerFlowPerPressure indicates that Design Shaft Power per Unit Flow Rate per Unit Head is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * Design Pump Head * scaling factor / Motor Efficiency")]
[JsonProperty("design_power_sizing_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HeaderedPumps_ConstantSpeed_DesignPowerSizingMethod DesignPowerSizingMethod { get; set; } = (HeaderedPumps_ConstantSpeed_DesignPowerSizingMethod)Enum.Parse(typeof(HeaderedPumps_ConstantSpeed_DesignPowerSizingMethod), "PowerPerFlowPerPressure");
        

[Description("Used to size Design Power Consumption from design flow rate")]
[JsonProperty("design_electric_power_per_unit_flow_rate")]
public System.Nullable<float> DesignElectricPowerPerUnitFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("348701.1", CultureInfo.InvariantCulture);
        

[Description("Used to size Design Power Consumption from design flow rate for head and motor ef" +
    "ficiency")]
[JsonProperty("design_shaft_power_per_unit_flow_rate_per_unit_head")]
public System.Nullable<float> DesignShaftPowerPerUnitFlowRatePerUnitHead { get; set; } = (System.Nullable<float>)Single.Parse("1.282051282", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum HeaderedPumps_ConstantSpeed_FlowSequencingControlScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Sequential")]
        Sequential = 1,
    }
    
    public enum HeaderedPumps_ConstantSpeed_PumpControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Continuous")]
        Continuous = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Intermittent")]
        Intermittent = 2,
    }
    
    public enum HeaderedPumps_ConstantSpeed_DesignPowerSizingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlow")]
        PowerPerFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
    }
    
    [Description("This Headered pump object describes a pump bank with more than 1 pump in parallel" +
        "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeaderedPumps_VariableSpeed : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[Description("If the field is not autosized set to the flow rate to the total flow when all pum" +
    "ps are running at full load")]
[JsonProperty("total_design_flow_rate")]
public string TotalDesignFlowRate { get; set; } = "";
        

[JsonProperty("number_of_pumps_in_bank")]
public System.Nullable<float> NumberOfPumpsInBank { get; set; } = null;
        

[JsonProperty("flow_sequencing_control_scheme")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HeaderedPumps_VariableSpeed_FlowSequencingControlScheme FlowSequencingControlScheme { get; set; } = (HeaderedPumps_VariableSpeed_FlowSequencingControlScheme)Enum.Parse(typeof(HeaderedPumps_VariableSpeed_FlowSequencingControlScheme), "Sequential");
        

[Description("default head is 60 feet")]
[JsonProperty("design_pump_head")]
public System.Nullable<float> DesignPumpHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("If the field is not autosized set to the power consumed by the pump bank when all" +
    " the pumps are running at nominal flow When autosized the type of scaling factor" +
    " is chosen in the input field Design Power Sizing Method")]
[JsonProperty("design_power_consumption")]
public string DesignPowerConsumption { get; set; } = "";
        

[Description("This is the motor efficiency only. When the Design Power Consumption is autosized" +
    " using PowerPerFlowPerPressure, the Design Shaft Power per Unit Flow Rate per Un" +
    "it Head is used in addition to the motor efficiency.")]
[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_of_motor_inefficiencies_to_fluid_stream")]
public System.Nullable<float> FractionOfMotorInefficienciesToFluidStream { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_1_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient1OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_2_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient2OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_3_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient3OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_4_of_the_part_load_performance_curve")]
public System.Nullable<float> Coefficient4OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This value can be zero and will be defaulted to that if not specified.")]
[JsonProperty("minimum_flow_rate_fraction")]
public System.Nullable<float> MinimumFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("pump_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HeaderedPumps_VariableSpeed_PumpControlType PumpControlType { get; set; } = (HeaderedPumps_VariableSpeed_PumpControlType)Enum.Parse(typeof(HeaderedPumps_VariableSpeed_PumpControlType), "Continuous");
        

[Description("Modifies the rated flow rate of the pump on a time basis. Default is that the pum" +
    "p is on and runs according to its other operational requirements specified above" +
    ". The schedule is for special pump operations.")]
[JsonProperty("pump_flow_rate_schedule_name")]
public string PumpFlowRateScheduleName { get; set; } = "";
        

[Description("optional, if used pump losses transfered to zone as internal gains")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("optional. If zone identified in previous field then this determines the split bet" +
    "ween convection and radiation for the skin losses")]
[JsonProperty("skin_loss_radiative_fraction")]
public System.Nullable<float> SkinLossRadiativeFraction { get; set; } = null;
        

[Description(@"Used to indicate which sizing factor is used to calculate Design Power Consumption. PowerPerFlow indicates that Design Electric Power per Unit Flow Rate is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * scaling factor PowerPerFlowPerPressure indicates that Design Shaft Power per Unit Flow Rate per Unit Head is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * Design Pump Head * scaling factor / Motor Efficiency")]
[JsonProperty("design_power_sizing_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HeaderedPumps_VariableSpeed_DesignPowerSizingMethod DesignPowerSizingMethod { get; set; } = (HeaderedPumps_VariableSpeed_DesignPowerSizingMethod)Enum.Parse(typeof(HeaderedPumps_VariableSpeed_DesignPowerSizingMethod), "PowerPerFlowPerPressure");
        

[Description("Used to size Design Power Consumption from design flow rate")]
[JsonProperty("design_electric_power_per_unit_flow_rate")]
public System.Nullable<float> DesignElectricPowerPerUnitFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("348701.1", CultureInfo.InvariantCulture);
        

[Description("Used to size Design Power Consumption from design flow rate for head and motor ef" +
    "ficiency")]
[JsonProperty("design_shaft_power_per_unit_flow_rate_per_unit_head")]
public System.Nullable<float> DesignShaftPowerPerUnitFlowRatePerUnitHead { get; set; } = (System.Nullable<float>)Single.Parse("1.282051282", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum HeaderedPumps_VariableSpeed_FlowSequencingControlScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Sequential")]
        Sequential = 1,
    }
    
    public enum HeaderedPumps_VariableSpeed_PumpControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Continuous")]
        Continuous = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Intermittent")]
        Intermittent = 2,
    }
    
    public enum HeaderedPumps_VariableSpeed_DesignPowerSizingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlow")]
        PowerPerFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
    }
}
