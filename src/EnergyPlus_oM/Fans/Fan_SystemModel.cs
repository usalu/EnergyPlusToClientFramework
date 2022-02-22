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
}
