namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
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
    
    
    [Description(@"AirloopHVAC:UnitarySystem is a generic HVAC system type that allows any configuration of coils and/or fan. This object is a replacement of other AirloopHVAC objects. This object can be used in outdoor air systems, outdoor air units, air loops, and as zone equipment if desired.")]
    [JsonObject("AirLoopHVAC:UnitarySystem")]
    public class AirLoopHVAC_UnitarySystem : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Load control requires a Controlling Zone name. SetPoint control requires set points at coil outlet node. SingleZoneVAV also requires a Controlling Zone name and allows load control at low speed fan until the load exceeds capacity or outlet air temperature limits. The fan speed is then increased.")]
[JsonProperty("control_type")]
public AirLoopHVAC_UnitarySystem_ControlType ControlType { get; set; } = (AirLoopHVAC_UnitarySystem_ControlType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_ControlType), "Load");
        

[Description("Used only for Load based control Zone name where thermostat is located. Required " +
    "when Control Type = Load.")]
[JsonProperty("controlling_zone_or_thermostat_location")]
public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

[Description(@"None = meet sensible load only. Required when Control Type = SingleZoneVAV. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with cooling coil type Coil:Cooling:DX:TwoStageWithHumidityControlMode or CoilSystem:Cooling:DX:HeatExchangerAssisted. This control mode either switches the coil mode or allows the heat exchanger to be turned on and off based on the zone dehumidification requirements. A ZoneControl:Humidistat object is also required. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid with all cooling coil types. When a heat exchanger assisted cooling coil is used, the heat exchanger is locked on at all times. A ZoneControl:Humidistat object is also required.")]
[JsonProperty("dehumidification_control_type")]
public AirLoopHVAC_UnitarySystem_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitarySystem_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_DehumidificationControlType), "None");
        

[Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. A schedule value greater than zero (usually 1 is used) indicates that the unit is available to operate as needed. A value less than or equal to zero (usually zero is used) denotes that the unit must be off.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Enter the node name used as the inlet air node for the unitary system.")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[Description("Enter the node name used as the outlet air node for the unitary system.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description(@"Enter the type of supply air fan if included in the unitary system. Fan:ConstantVolume only works with continuous fan operating mode (i.e. supply air fan operating mode schedule values greater than 0). Specify a Fan:SystemModel or a Fan:OnOff object when the Supply Air Fan Operating Mode Schedule Name input field above is left blank. Specify a Fan:SystemModel or a Fan:VariableVolume when modeling VAV systems which used setpoint based control if the fan is included in the unitary system object. The ComponentModel fan type may be substituted for the ConstantVolume or VariableVolume fan types when more detailed fan modeling is required. The variable or constant volume fan may be specified on the branch instead of contained within the unitary system object (i.e., this field may be blank for certain configurations).")]
[JsonProperty("supply_fan_object_type")]
public AirLoopHVAC_UnitarySystem_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_SupplyFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_SupplyFanObjectType), "FanComponentModel");
        

[Description("Enter the name of the supply air fan if included in the unitary system.")]
[JsonProperty("supply_fan_name")]
public string SupplyFanName { get; set; } = "";
        

[Description("Enter the type of supply air fan if included in the unitary system.")]
[JsonProperty("fan_placement")]
public AirLoopHVAC_UnitarySystem_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_UnitarySystem_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_FanPlacement), "BlowThrough");
        

[Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the cooling or heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of cooling or heating coil operation). Provide a schedule with non-zero values when high humidity control is specified. Leaving this schedule name blank will default to constant fan mode for the entire simulation period. This field is not used when set point based control is used where a set point controls the coil. SingleZoneVAV control type is only active when constant fan operating mode is active.")]
[JsonProperty("supply_air_fan_operating_mode_schedule_name")]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[Description("Enter the type of heating coil if included in the unitary system.")]
[JsonProperty("heating_coil_object_type")]
public AirLoopHVAC_UnitarySystem_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_HeatingCoilObjectType), "CoilHeatingDXMultiSpeed");
        

[Description("Enter the name of the heating coil if included in the unitary system.")]
[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[Description("Used to adjust heat pump heating capacity with respect to DX cooling capacity use" +
    "d only for heat pump configurations (i.e., a DX cooling and DX heating coil is u" +
    "sed).")]
[JsonProperty("dx_heating_coil_sizing_ratio")]
public System.Nullable<float> DxHeatingCoilSizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Enter the type of cooling coil if included in the unitary system.")]
[JsonProperty("cooling_coil_object_type")]
public AirLoopHVAC_UnitarySystem_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_CoolingCoilObjectType), "CoilCoolingDX");
        

[Description("Enter the name of the cooling coil if included in the unitary system.")]
[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[Description("If Yes, the DX cooling coil runs as 100% DOAS DX coil. If No, the DX cooling coil" +
    " runs as a regular DX coil. If left blank the default is regular dx coil.")]
[JsonProperty("use_doas_dx_cooling_coil")]
public EmptyNoYes UseDoasDxCoolingCoil { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description(@"When Use DOAS DX Cooling Coil is specified as Yes, Minimum Supply Air Temperature defines the minimum DOAS DX cooling coil leaving air temperature that should be maintained to avoid frost formation. This field is not autosizable when the input for Use DOAS DX Cooling Coil = Yes. When Control Type = SingleZoneVAV, enter the minimum air temperature limit for reduced fan speed.")]
[JsonProperty("minimum_supply_air_temperature")]
public string MinimumSupplyAirTemperature { get; set; } = (System.String)"2";
        

[Description(@"SensibleOnlyLoadControl is selected when thermostat or SingleZoneVAV control is used. LatentOnlyLoadControl is selected when humidistat control is used. LatentWithSensibleLoadControl is selected when thermostat control is used and dehumidification is required only when a sensible load exists. LatentOrSensibleLoadControl is selected when thermostat control is used and dehumidification is required any time the humidistat set point is exceeded.")]
[JsonProperty("latent_load_control")]
public AirLoopHVAC_UnitarySystem_LatentLoadControl LatentLoadControl { get; set; } = (AirLoopHVAC_UnitarySystem_LatentLoadControl)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_LatentLoadControl), "SensibleOnlyLoadControl");
        

[Description(@"Enter the type of supplemental heating or reheat coil if included in the unitary system. Only required if dehumidification control type is ""CoolReheat"". This coil supplements heating mode operation or reheats the supply air during dehumidification mode operation. If set point based control is used the coils operate to meet their respective supply air temperature set point.")]
[JsonProperty("supplemental_heating_coil_object_type")]
public AirLoopHVAC_UnitarySystem_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_SupplementalHeatingCoilObjectType), "CoilHeatingDesuperheater");
        

[Description("Enter the name of the supplemental heating coil if included in the unitary system" +
    ". Only required if dehumidification control type is \"CoolReheat\".")]
[JsonProperty("supplemental_heating_coil_name")]
public string SupplementalHeatingCoilName { get; set; } = "";
        

[Description(@"Enter the method used to determine the cooling supply air volume flow rate. None is used when a cooling coil is not included in the unitary system or this field may be blank. SupplyAirFlowRate is selected when the magnitude of the supply air volume is used. FlowPerFloorArea is selected when the supply air volume flow rate is based on total floor area served by the unitary system. FractionOfAutosizedCoolingValue is selected when the supply air volume is a fraction of the value determined by the simulation. FlowPerCoolingCapacity is selected when the supply air volume is a fraction of the cooling capacity as determined by the simulation.")]
[JsonProperty("cooling_supply_air_flow_rate_method")]
public AirLoopHVAC_UnitarySystem_CoolingSupplyAirFlowRateMethod CoolingSupplyAirFlowRateMethod { get; set; } = (AirLoopHVAC_UnitarySystem_CoolingSupplyAirFlowRateMethod)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_CoolingSupplyAirFlowRateMethod), "FlowPerCoolingCapacity");
        

[Description("Enter the magnitude of the supply air volume flow rate during cooling operation. " +
    "Required field when Cooling Supply Air Flow Rate Method is SupplyAirFlowRate. Th" +
    "is field may be blank if a cooling coil is not included in the unitary system.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the supply air volume flow rate per total floor area fraction. Required fie" +
    "ld when Cooling Supply Air Flow Rate Method is FlowPerFloorArea. This field may " +
    "be blank if a cooling coil is not included in the unitary system.")]
[JsonProperty("cooling_supply_air_flow_rate_per_floor_area")]
public System.Nullable<float> CoolingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description(@"Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate. Required field when Cooling Supply Air Flow Rate Method is FractionOfAutosizedCoolingValue. This field may be blank if a cooling coil is not included in the unitary system.")]
[JsonProperty("cooling_fraction_of_autosized_cooling_supply_air_flow_rate")]
public System.Nullable<float> CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the cooling capacity. Requ" +
    "ired field when Cooling Supply Air Flow Rate Method is FlowPerCoolingCapacity. T" +
    "his field may be blank if a cooling coil is not included in the unitary system.")]
[JsonProperty("cooling_supply_air_flow_rate_per_unit_of_capacity")]
public System.Nullable<float> CoolingSupplyAirFlowRatePerUnitOfCapacity { get; set; } = null;
        

[Description(@"Enter the method used to determine the heating supply air volume flow rate. None is used when a heating coil is not included in the unitary system or this field may be blank. SupplyAirFlowRate is selected when the magnitude of the supply air volume is used. FlowPerFloorArea is selected when the supply air volume flow rate is based on total floor area served by the unitary system. FractionOfAutosizedHeatingValue is selected when the supply air volume is a fraction of the value determined by the simulation. FlowPerHeatingCapacity is selected when the supply air volume is a fraction of the heating capacity as determined by the simulation.")]
[JsonProperty("heating_supply_air_flow_rate_method")]
public AirLoopHVAC_UnitarySystem_HeatingSupplyAirFlowRateMethod HeatingSupplyAirFlowRateMethod { get; set; } = (AirLoopHVAC_UnitarySystem_HeatingSupplyAirFlowRateMethod)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_HeatingSupplyAirFlowRateMethod), "FlowPerFloorArea");
        

[Description("Enter the magnitude of the supply air volume flow rate during heating operation. " +
    "Required field when Heating Supply Air Flow Rate Method is SupplyAirFlowRate. Th" +
    "is field may be blank if a heating coil is not included in the unitary system.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the supply air volume flow rate per total floor area fraction. Required fie" +
    "ld when Heating Supply Air Flow Rate Method is FlowPerFloorArea. This field may " +
    "be blank if a heating coil is not included in the unitary system.")]
[JsonProperty("heating_supply_air_flow_rate_per_floor_area")]
public System.Nullable<float> HeatingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description(@"Enter the supply air volume flow rate as a fraction of the heating supply air flow rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAutosizedHeatingValue. This field may be blank if a heating coil is not included in the unitary system.")]
[JsonProperty("heating_fraction_of_autosized_heating_supply_air_flow_rate")]
public System.Nullable<float> HeatingFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the heating capacity. Requ" +
    "ired field when Heating Supply Air Flow Rate Method is FlowPerHeatingCapacity. T" +
    "his field may be blank if a heating coil is not included in the unitary system.")]
[JsonProperty("heating_supply_air_flow_rate_per_unit_of_capacity")]
public System.Nullable<float> HeatingSupplyAirFlowRatePerUnitOfCapacity { get; set; } = null;
        

[Description(@"Enter the method used to determine the supply air volume flow rate when no cooling or heating is required. None is used when a cooling and heating coil is not included in the unitary system or this field may be blank. SupplyAirFlowRate is selected when the magnitude of the supply air volume is used. FlowPerFloorArea is selected when the supply air volume flow rate is based on total floor area served by the unitary system. FractionOfAutosizedCoolingValue is selected when the supply air volume is a fraction of the cooling value determined by the simulation. FractionOfAutosizedHeatingValue is selected when the supply air volume is a fraction of the heating value determined by the simulation. FlowPerCoolingCapacity is selected when the supply air volume is a fraction of the cooling capacity as determined by the simulation. FlowPerHeatingCapacity is selected when the supply air volume is a fraction of the heating capacity as determined by the simulation.")]
[JsonProperty("no_load_supply_air_flow_rate_method")]
public AirLoopHVAC_UnitarySystem_NoLoadSupplyAirFlowRateMethod NoLoadSupplyAirFlowRateMethod { get; set; } = (AirLoopHVAC_UnitarySystem_NoLoadSupplyAirFlowRateMethod)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_NoLoadSupplyAirFlowRateMethod), "FlowPerCoolingCapacity");
        

[Description("Enter the magnitude of the supply air volume flow rate during when no cooling or " +
    "heating is required. Required field when No Load Supply Air Flow Rate Method is " +
    "SupplyAirFlowRate.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the supply air volume flow rate per total floor area fraction. Required fie" +
    "ld when No Load Supply Air Flow Rate Method is FlowPerFloorArea.")]
[JsonProperty("no_load_supply_air_flow_rate_per_floor_area")]
public System.Nullable<float> NoLoadSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
    "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
    "osizedCoolingValue.")]
[JsonProperty("no_load_fraction_of_autosized_cooling_supply_air_flow_rate")]
public System.Nullable<float> NoLoadFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the heating supply air flo" +
    "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
    "osizedHeatingValue.")]
[JsonProperty("no_load_fraction_of_autosized_heating_supply_air_flow_rate")]
public System.Nullable<float> NoLoadFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the cooling capacity. Requ" +
    "ired field when No Load Supply Air Flow Rate Method is FlowPerCoolingCapacity.")]
[JsonProperty("no_load_supply_air_flow_rate_per_unit_of_capacity_during_cooling_operation")]
public System.Nullable<float> NoLoadSupplyAirFlowRatePerUnitOfCapacityDuringCoolingOperation { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the heating capacity. Requ" +
    "ired field when No Load Supply Air Flow Rate Method is FlowPerHeatingCapacity.")]
[JsonProperty("no_load_supply_air_flow_rate_per_unit_of_capacity_during_heating_operation")]
public System.Nullable<float> NoLoadSupplyAirFlowRatePerUnitOfCapacityDuringHeatingOperation { get; set; } = null;
        

[Description("Enter the maximum supply air temperature leaving the heating coil. When Control T" +
    "ype = SingleZoneVAV, enter the maximum air temperature limit for reduced fan spe" +
    "ed.")]
[JsonProperty("maximum_supply_air_temperature")]
public string MaximumSupplyAirTemperature { get; set; } = (System.String)"80";
        

[Description("Enter the maximum outdoor dry-bulb temperature for supplemental heater operation." +
    "")]
[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

[Description("If this field is blank, outdoor temperature from the weather file is used. If thi" +
    "s field is not blank, the node name specified determines the outdoor temperature" +
    " used for controlling supplemental heater operation.")]
[JsonProperty("outdoor_dry_bulb_temperature_sensor_node_name")]
public string OutdoorDryBulbTemperatureSensorNodeName { get; set; } = "";
        

[Description("Used only for water source heat pump. The maximum on-off cycling rate for the com" +
    "pressor. Suggested value is 2.5 for a typical heat pump.")]
[JsonProperty("maximum_cycling_rate")]
public System.Nullable<float> MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

[Description("Used only for water source heat pump. Time constant for the cooling coil\'s capaci" +
    "ty to reach steady state after startup. Suggested value is 60 for a typical heat" +
    " pump.")]
[JsonProperty("heat_pump_time_constant")]
public System.Nullable<float> HeatPumpTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description("Used only for water source heat pump. The fraction of on-cycle power use to adjus" +
    "t the part load fraction based on the off-cycle power consumption due to crankca" +
    "se heaters, controls, fans, and etc. Suggested value is 0.01 for a typical heat " +
    "pump.")]
[JsonProperty("fraction_of_on_cycle_power_use")]
public System.Nullable<float> FractionOfOnCyclePowerUse { get; set; } = (System.Nullable<float>)Single.Parse("0.01", CultureInfo.InvariantCulture);
        

[Description("Used only for water source heat pump. Programmed time delay for heat pump fan to " +
    "shut off after compressor cycle off. Only required when fan operating mode is cy" +
    "cling. Enter 0 when fan operating mode is continuous.")]
[JsonProperty("heat_pump_fan_delay_time")]
public System.Nullable<float> HeatPumpFanDelayTime { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description("Enter the value of ancillary electric power for controls or other devices consume" +
    "d during the on cycle.")]
[JsonProperty("ancillary_on_cycle_electric_power")]
public System.Nullable<float> AncillaryOnCycleElectricPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the value of ancillary electric power for controls or other devices consume" +
    "d during the off cycle.")]
[JsonProperty("ancillary_off_cycle_electric_power")]
public System.Nullable<float> AncillaryOffCycleElectricPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If non-zero, then the heat recovery inlet and outlet node names must be entered. " +
    "Used for heat recovery to an EnergyPlus plant loop.")]
[JsonProperty("design_heat_recovery_water_flow_rate")]
public System.Nullable<float> DesignHeatRecoveryWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the maximum heat recovery inlet temperature allowed for heat recovery.")]
[JsonProperty("maximum_temperature_for_heat_recovery")]
public System.Nullable<float> MaximumTemperatureForHeatRecovery { get; set; } = (System.Nullable<float>)Single.Parse("80", CultureInfo.InvariantCulture);
        

[Description("Enter the name of the heat recovery water inlet node if plant water loop connecti" +
    "ons are present.")]
[JsonProperty("heat_recovery_water_inlet_node_name")]
public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

[Description("Enter the name of the heat recovery water outlet node if plant water loop connect" +
    "ions are present.")]
[JsonProperty("heat_recovery_water_outlet_node_name")]
public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

[Description("Enter the type of performance specification object used to describe the multispee" +
    "d coil.")]
[JsonProperty("design_specification_multispeed_object_type")]
public AirLoopHVAC_UnitarySystem_DesignSpecificationMultispeedObjectType DesignSpecificationMultispeedObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_DesignSpecificationMultispeedObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_DesignSpecificationMultispeedObjectType), "UnitarySystemPerformanceMultispeed");
        

[Description("Enter the name of the performance specification object used to describe the multi" +
    "speed coil.")]
[JsonProperty("design_specification_multispeed_object_name")]
public string DesignSpecificationMultispeedObjectName { get; set; } = "";
    }
    
    public enum AirLoopHVAC_UnitarySystem_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Load")]
        Load = 1,
        
        [JsonProperty("SetPoint")]
        SetPoint = 2,
        
        [JsonProperty("SingleZoneVAV")]
        SingleZoneVAV = 3,
    }
    
    public enum AirLoopHVAC_UnitarySystem_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("Multimode")]
        Multimode = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum AirLoopHVAC_UnitarySystem_SupplyFanObjectType
    {
        
        [JsonProperty("Fan:ComponentModel")]
        FanComponentModel = 0,
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 1,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 2,
        
        [JsonProperty("Fan:SystemModel")]
        FanSystemModel = 3,
        
        [JsonProperty("Fan:VariableVolume")]
        FanVariableVolume = 4,
    }
    
    public enum AirLoopHVAC_UnitarySystem_FanPlacement
    {
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 0,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 1,
    }
    
    public enum AirLoopHVAC_UnitarySystem_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:MultiSpeed")]
        CoilHeatingDXMultiSpeed = 0,
        
        [JsonProperty("Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 1,
        
        [JsonProperty("Coil:Heating:DX:VariableSpeed")]
        CoilHeatingDXVariableSpeed = 2,
        
        [JsonProperty("Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 3,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 4,
        
        [JsonProperty("Coil:Heating:Electric:MultiStage")]
        CoilHeatingElectricMultiStage = 5,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 6,
        
        [JsonProperty("Coil:Heating:Gas:MultiStage")]
        CoilHeatingGasMultiStage = 7,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 8,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 9,
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:EquationFit")]
        CoilHeatingWaterToAirHeatPumpEquationFit = 10,
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:ParameterEstimation")]
        CoilHeatingWaterToAirHeatPumpParameterEstimation = 11,
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilHeatingWaterToAirHeatPumpVariableSpeedEquationFit = 12,
        
        [JsonProperty("Coil:UserDefined")]
        CoilUserDefined = 13,
    }
    
    public enum AirLoopHVAC_UnitarySystem_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX")]
        CoilCoolingDX = 0,
        
        [JsonProperty("Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 1,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 2,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed:ThermalStorage")]
        CoilCoolingDXSingleSpeedThermalStorage = 3,
        
        [JsonProperty("Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 4,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 5,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 6,
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 7,
        
        [JsonProperty("Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 8,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 9,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:ParameterEstimation")]
        CoilCoolingWaterToAirHeatPumpParameterEstimation = 10,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilCoolingWaterToAirHeatPumpVariableSpeedEquationFit = 11,
        
        [JsonProperty("Coil:UserDefined")]
        CoilUserDefined = 12,
        
        [JsonProperty("CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 13,
        
        [JsonProperty("CoilSystem:Cooling:Water:HeatExchangerAssisted")]
        CoilSystemCoolingWaterHeatExchangerAssisted = 14,
    }
    
    public enum AirLoopHVAC_UnitarySystem_LatentLoadControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LatentOnlyLoadControl")]
        LatentOnlyLoadControl = 1,
        
        [JsonProperty("LatentOrSensibleLoadControl")]
        LatentOrSensibleLoadControl = 2,
        
        [JsonProperty("LatentWithSensibleLoadControl")]
        LatentWithSensibleLoadControl = 3,
        
        [JsonProperty("SensibleOnlyLoadControl")]
        SensibleOnlyLoadControl = 4,
    }
    
    public enum AirLoopHVAC_UnitarySystem_SupplementalHeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 0,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 1,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 2,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 3,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 4,
        
        [JsonProperty("Coil:UserDefined")]
        CoilUserDefined = 5,
    }
    
    public enum AirLoopHVAC_UnitarySystem_CoolingSupplyAirFlowRateMethod
    {
        
        [JsonProperty("FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 0,
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [JsonProperty("FractionOfAutosizedCoolingValue")]
        FractionOfAutosizedCoolingValue = 2,
        
        [JsonProperty("None")]
        None = 3,
        
        [JsonProperty("SupplyAirFlowRate")]
        SupplyAirFlowRate = 4,
    }
    
    public enum AirLoopHVAC_UnitarySystem_HeatingSupplyAirFlowRateMethod
    {
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 0,
        
        [JsonProperty("FlowPerHeatingCapacity")]
        FlowPerHeatingCapacity = 1,
        
        [JsonProperty("FractionOfAutosizedHeatingValue")]
        FractionOfAutosizedHeatingValue = 2,
        
        [JsonProperty("None")]
        None = 3,
        
        [JsonProperty("SupplyAirFlowRate")]
        SupplyAirFlowRate = 4,
    }
    
    public enum AirLoopHVAC_UnitarySystem_NoLoadSupplyAirFlowRateMethod
    {
        
        [JsonProperty("FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 0,
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [JsonProperty("FlowPerHeatingCapacity")]
        FlowPerHeatingCapacity = 2,
        
        [JsonProperty("FractionOfAutosizedCoolingValue")]
        FractionOfAutosizedCoolingValue = 3,
        
        [JsonProperty("FractionOfAutosizedHeatingValue")]
        FractionOfAutosizedHeatingValue = 4,
        
        [JsonProperty("None")]
        None = 5,
        
        [JsonProperty("SupplyAirFlowRate")]
        SupplyAirFlowRate = 6,
    }
    
    public enum AirLoopHVAC_UnitarySystem_DesignSpecificationMultispeedObjectType
    {
        
        [JsonProperty("UnitarySystemPerformance:Multispeed")]
        UnitarySystemPerformanceMultispeed = 0,
    }
    
    [Description(@"The UnitarySystemPerformance object is used to specify the air flow ratio at each operating speed. This object is primarily used for multispeed DX and water coils to allow operation at alternate flow rates different from those specified in the coil object.")]
    [JsonObject("UnitarySystemPerformance:Multispeed")]
    public class UnitarySystemPerformance_Multispeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Used only for Multi speed coils Enter the number of the following sets of data fo" +
    "r air flow rates.")]
[JsonProperty("number_of_speeds_for_heating")]
public System.Nullable<float> NumberOfSpeedsForHeating { get; set; } = null;
        

[Description("Used only for Multi speed coils Enter the number of the following sets of data fo" +
    "r air flow rates.")]
[JsonProperty("number_of_speeds_for_cooling")]
public System.Nullable<float> NumberOfSpeedsForCooling { get; set; } = null;
        

[Description(@"Controls coil operation during each HVAC timestep. This choice does not apply to speed 1 operation. Yes = operate at the highest speed possible without exceeding the current load. No = allow operation at the average of two adjacent speeds to match the current load.")]
[JsonProperty("single_mode_operation")]
public EmptyNoYes SingleModeOperation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Used to define the no load operating air flow rate when the system fan is specifi" +
    "ed to operate continuously.")]
[JsonProperty("no_load_supply_air_flow_rate_ratio")]
public System.Nullable<float> NoLoadSupplyAirFlowRateRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("flow_ratios")]
public string FlowRatios { get; set; } = "";
    }
    
    [Description("Unitary system, heating-only with constant volume supply fan (continuous or cycli" +
        "ng) and heating coil (gas, electric, hot water, or steam). Identical to AirLoopH" +
        "VAC:UnitaryHeatOnly.")]
    [JsonObject("AirLoopHVAC:Unitary:Furnace:HeatOnly")]
    public class AirLoopHVAC_Unitary_Furnace_HeatOnly : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("furnace_air_inlet_node_name")]
public string FurnaceAirInletNodeName { get; set; } = "";
        

[JsonProperty("furnace_air_outlet_node_name")]
public string FurnaceAirOutletNodeName { get; set; } = "";
        

[Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of heating coil operation). Leaving this schedule name blank will default to cycling fan mode for the entire simulation period.")]
[JsonProperty("supply_air_fan_operating_mode_schedule_name")]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("maximum_supply_air_temperature")]
public string MaximumSupplyAirTemperature { get; set; } = (System.String)"80";
        

[Description("This value should be > 0 and <= than the fan air flow rate.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = "";
        

[JsonProperty("controlling_zone_or_thermostat_location")]
public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

[Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. fan operat" +
    "ing mode schedule values are greater than 0).")]
[JsonProperty("supply_fan_object_type")]
public AirLoopHVAC_Unitary_Furnace_HeatOnly_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatOnly_SupplyFanObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatOnly_SupplyFanObjectType), "FanConstantVolume");
        

[JsonProperty("supply_fan_name")]
public string SupplyFanName { get; set; } = "";
        

[JsonProperty("fan_placement")]
public AirLoopHVAC_Unitary_Furnace_HeatOnly_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatOnly_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatOnly_FanPlacement), "BlowThrough");
        

[Description("works with gas, electric, hot water and steam heating coils")]
[JsonProperty("heating_coil_object_type")]
public AirLoopHVAC_Unitary_Furnace_HeatOnly_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatOnly_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatOnly_HeatingCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
    }
    
    public enum AirLoopHVAC_Unitary_Furnace_HeatOnly_SupplyFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
    }
    
    public enum AirLoopHVAC_Unitary_Furnace_HeatOnly_FanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum AirLoopHVAC_Unitary_Furnace_HeatOnly_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
    
    [Description(@"Unitary system, heating and cooling with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, heating coil (gas, electric, hot water, or steam), and optional reheat coil for dehumidification control. Identical to AirLoopHVAC:UnitaryHeatCool.")]
    [JsonObject("AirLoopHVAC:Unitary:Furnace:HeatCool")]
    public class AirLoopHVAC_Unitary_Furnace_HeatCool : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. A schedule value greater than zero (usually 1 is used) indicates that the unit is available to operate as needed. A value less than or equal to zero (usually zero is used) denotes that the unit must be off.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("furnace_air_inlet_node_name")]
public string FurnaceAirInletNodeName { get; set; } = "";
        

[JsonProperty("furnace_air_outlet_node_name")]
public string FurnaceAirOutletNodeName { get; set; } = "";
        

[Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the cooling or heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of cooling or heating coil operation). Provide a schedule with non-zero values when high humidity control is specified. Leaving this schedule name blank will default to cycling fan mode for the entire simulation period.")]
[JsonProperty("supply_air_fan_operating_mode_schedule_name")]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("maximum_supply_air_temperature")]
public string MaximumSupplyAirTemperature { get; set; } = (System.String)"80";
        

[Description("Must be less than or equal to the fan\'s maximum flow rate.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = "";
        

[Description("Must be less than or equal to the fan\'s maximum flow fate.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = "";
        

[Description(@"Must be less than or equal to the fan's maximum flow rate. Only used when fan operating mode is continuous (disregarded for cycling fan mode). This air flow rate is used when no heating or cooling is required (i.e., the DX coil compressor and heating coil are off). If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[JsonProperty("controlling_zone_or_thermostat_location")]
public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

[Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. supply air" +
    " fan operating mode schedule values not equal to 0).")]
[JsonProperty("supply_fan_object_type")]
public AirLoopHVAC_Unitary_Furnace_HeatCool_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_SupplyFanObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_SupplyFanObjectType), "FanConstantVolume");
        

[JsonProperty("supply_fan_name")]
public string SupplyFanName { get; set; } = "";
        

[JsonProperty("fan_placement")]
public AirLoopHVAC_Unitary_Furnace_HeatCool_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_FanPlacement), "BlowThrough");
        

[Description("works with gas, electric, hot water and steam heating coils")]
[JsonProperty("heating_coil_object_type")]
public AirLoopHVAC_Unitary_Furnace_HeatCool_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_HeatingCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[Description("Only works with DX cooling coil types")]
[JsonProperty("cooling_coil_object_type")]
public AirLoopHVAC_Unitary_Furnace_HeatCool_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[Description(@"None = meet sensible load only Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with cooling coil type CoilSystem:Cooling:DX:HeatExchangerAssisted. This control mode allows the heat exchanger to be turned on and off based on the zone dehumidification requirements. A ZoneControl:Humidistat object is also required. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid with all cooling coil types. When a heat exchanger assisted cooling coil is used, the heat exchanger is locked on at all times. A ZoneControl:Humidistat object is also required.")]
[JsonProperty("dehumidification_control_type")]
public AirLoopHVAC_Unitary_Furnace_HeatCool_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_DehumidificationControlType), "None");
        

[Description("Only required if dehumidification control type is \"CoolReheat\" works with gas, el" +
    "ectric, hot water and steam heating coils")]
[JsonProperty("reheat_coil_object_type")]
public AirLoopHVAC_Unitary_Furnace_HeatCool_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_ReheatCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_ReheatCoilObjectType), "CoilHeatingDesuperheater");
        

[Description("Only required if dehumidification control type is \"CoolReheat\"")]
[JsonProperty("reheat_coil_name")]
public string ReheatCoilName { get; set; } = "";
    }
    
    public enum AirLoopHVAC_Unitary_Furnace_HeatCool_SupplyFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
    }
    
    public enum AirLoopHVAC_Unitary_Furnace_HeatCool_FanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum AirLoopHVAC_Unitary_Furnace_HeatCool_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
    
    public enum AirLoopHVAC_Unitary_Furnace_HeatCool_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 1,
        
        [JsonProperty("CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 2,
    }
    
    public enum AirLoopHVAC_Unitary_Furnace_HeatCool_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("Multimode")]
        Multimode = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum AirLoopHVAC_Unitary_Furnace_HeatCool_ReheatCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 0,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 1,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 2,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 3,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 4,
    }
    
    [Description("Unitary system, heating-only with constant volume supply fan (continuous or cycli" +
        "ng) and heating coil (gas, electric, hot water, or steam). Identical to AirLoopH" +
        "VAC:Unitary:Furnace:HeatOnly.")]
    [JsonObject("AirLoopHVAC:UnitaryHeatOnly")]
    public class AirLoopHVAC_UnitaryHeatOnly : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("unitary_system_air_inlet_node_name")]
public string UnitarySystemAirInletNodeName { get; set; } = "";
        

[JsonProperty("unitary_system_air_outlet_node_name")]
public string UnitarySystemAirOutletNodeName { get; set; } = "";
        

[Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of heating coil operation). Leaving this schedule name blank will default to cycling fan mode for the entire simulation period.")]
[JsonProperty("supply_air_fan_operating_mode_schedule_name")]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("maximum_supply_air_temperature")]
public string MaximumSupplyAirTemperature { get; set; } = (System.String)"80";
        

[Description("This value should be > 0 and <= than the fan air flow rate.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = "";
        

[JsonProperty("controlling_zone_or_thermostat_location")]
public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

[Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. fan operat" +
    "ing mode schedule values are greater than 0).")]
[JsonProperty("supply_fan_object_type")]
public AirLoopHVAC_UnitaryHeatOnly_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatOnly_SupplyFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatOnly_SupplyFanObjectType), "FanConstantVolume");
        

[JsonProperty("supply_fan_name")]
public string SupplyFanName { get; set; } = "";
        

[JsonProperty("fan_placement")]
public AirLoopHVAC_UnitaryHeatOnly_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatOnly_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatOnly_FanPlacement), "BlowThrough");
        

[Description("works with gas, electric, hot water and steam heating coils")]
[JsonProperty("heating_coil_object_type")]
public AirLoopHVAC_UnitaryHeatOnly_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatOnly_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatOnly_HeatingCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
    }
    
    public enum AirLoopHVAC_UnitaryHeatOnly_SupplyFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
    }
    
    public enum AirLoopHVAC_UnitaryHeatOnly_FanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatOnly_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
    
    [Description(@"Unitary system, heating and cooling with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, heating coil (gas, electric, hot water, or steam), and optional reheat coil for dehumidification control. Identical to AirLoopHVAC:Unitary:Furnace:HeatCool.")]
    [JsonObject("AirLoopHVAC:UnitaryHeatCool")]
    public class AirLoopHVAC_UnitaryHeatCool : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("unitary_system_air_inlet_node_name")]
public string UnitarySystemAirInletNodeName { get; set; } = "";
        

[JsonProperty("unitary_system_air_outlet_node_name")]
public string UnitarySystemAirOutletNodeName { get; set; } = "";
        

[Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the cooling or heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of cooling or heating coil operation). Provide a schedule with non-zero values when high humidity control is specified. Leaving this schedule name blank will default to cycling fan mode for the entire simulation period.")]
[JsonProperty("supply_air_fan_operating_mode_schedule_name")]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("maximum_supply_air_temperature")]
public string MaximumSupplyAirTemperature { get; set; } = (System.String)"80";
        

[Description("Must be less than or equal to the fan\'s maximum flow rate.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = "";
        

[Description("Must be less than or equal to the fan\'s maximum flow rate.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = "";
        

[Description(@"Must be less than or equal to the fan's maximum flow rate. Only used when fan operating mode is continuous (disregarded for cycling fan mode). This air flow rate is used when no heating or cooling is required (i.e., the DX coil compressor and heating coil are off). If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[JsonProperty("controlling_zone_or_thermostat_location")]
public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

[Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. supply air" +
    " fan operating mode schedule values not equal to 0).")]
[JsonProperty("supply_fan_object_type")]
public AirLoopHVAC_UnitaryHeatCool_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_SupplyFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_SupplyFanObjectType), "FanConstantVolume");
        

[JsonProperty("supply_fan_name")]
public string SupplyFanName { get; set; } = "";
        

[JsonProperty("fan_placement")]
public AirLoopHVAC_UnitaryHeatCool_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatCool_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_FanPlacement), "BlowThrough");
        

[Description("works with gas, electric, hot water and steam heating coils")]
[JsonProperty("heating_coil_object_type")]
public AirLoopHVAC_UnitaryHeatCool_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_HeatingCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[Description("Only works with DX cooling coil types or Coil:Cooling:DX:VariableSpeed.")]
[JsonProperty("cooling_coil_object_type")]
public AirLoopHVAC_UnitaryHeatCool_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[Description(@"None = meet sensible load only Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with cooling coil type CoilSystem:Cooling:DX:HeatExchangerAssisted. This control mode allows the heat exchanger to be turned on and off based on the zone dehumidification requirements. A ZoneControl:Humidistat object is also required. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid with all cooling coil types. When a heat exchanger assisted Cooling coil is used, the heat exchanger is locked on at all times. A ZoneControl:Humidistat object is also required.")]
[JsonProperty("dehumidification_control_type")]
public AirLoopHVAC_UnitaryHeatCool_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_DehumidificationControlType), "None");
        

[Description("Only required if dehumidification control type is \"CoolReheat\" works with gas, el" +
    "ectric, desuperheating, hot water and steam heating coils")]
[JsonProperty("reheat_coil_object_type")]
public AirLoopHVAC_UnitaryHeatCool_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_ReheatCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_ReheatCoilObjectType), "CoilHeatingDesuperheater");
        

[Description("Only required if dehumidification control type is \"CoolReheat\"")]
[JsonProperty("reheat_coil_name")]
public string ReheatCoilName { get; set; } = "";
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_SupplyFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_FanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 1,
        
        [JsonProperty("CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("Multimode")]
        Multimode = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_ReheatCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 0,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 1,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 2,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 3,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 4,
    }
    
    [Description("Unitary heat pump system, heating and cooling, single-speed with supply fan, dire" +
        "ct expansion (DX) cooling coil, DX heating coil (air-to-air heat pump), and supp" +
        "lemental heating coil (gas, electric, hot water, or steam).")]
    [JsonObject("AirLoopHVAC:UnitaryHeatPump:AirToAir")]
    public class AirLoopHVAC_UnitaryHeatPump_AirToAir : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. A schedule value greater than zero (usually 1 is used) indicates that the unit is available to operate as needed. A value less than or equal to zero (usually zero is used) denotes that the unit must be off.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Must be less than or equal to the fan\'s maximum flow rate.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = "";
        

[Description("Must be less than or equal to the fan\'s maximum flow rate.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = "";
        

[Description(@"Must be less than or equal to the fan's maximum flow rate. Only used when fan operating mode is continuous (disregarded for cycling fan mode). This air flow rate is used when no heating or cooling is required (i.e., the DX coil compressor and supplemental heating coil are off). If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[JsonProperty("controlling_zone_or_thermostat_location")]
public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

[Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. fan operat" +
    "ing mode schedule values are greater than 0 or the fan operating mode schedule n" +
    "ame field is left blank).")]
[JsonProperty("supply_air_fan_object_type")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplyAirFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplyAirFanObjectType), "FanConstantVolume");
        

[Description("Needs to match in the fan object")]
[JsonProperty("supply_air_fan_name")]
public string SupplyAirFanName { get; set; } = "";
        

[Description("Only works with Coil:Heating:DX:SingleSpeed or Coil:Heating:DX:VariableSpeed or C" +
    "oilSystem:IntegratedHeatPump:AirSource")]
[JsonProperty("heating_coil_object_type")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_HeatingCoilObjectType), "CoilHeatingDXSingleSpeed");
        

[Description("Needs to match in the DX heating coil object")]
[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[Description("Only works with Coil:Cooling:DX:SingleSpeed or CoilSystem:Cooling:DX:HeatExchange" +
    "rAssisted or Coil:Cooling:DX:VariableSpeed or CoilSystem:IntegratedHeatPump:AirS" +
    "ource")]
[JsonProperty("cooling_coil_object_type")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

[Description("Needs to match in the DX cooling coil object")]
[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[Description("works with gas, electric, hot water and steam heating coils")]
[JsonProperty("supplemental_heating_coil_object_type")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

[Description("Needs to match in the supplemental heating coil object")]
[JsonProperty("supplemental_heating_coil_name")]
public string SupplementalHeatingCoilName { get; set; } = "";
        

[JsonProperty("maximum_supply_air_temperature_from_supplemental_heater")]
public string MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = "";
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

[JsonProperty("fan_placement")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_FanPlacement), "BlowThrough");
        

[Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the cooling or heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of cooling or heating coil operation). Leaving this schedule name blank will default to cycling fan mode for the entire simulation period.")]
[JsonProperty("supply_air_fan_operating_mode_schedule_name")]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[Description(@"None = meet sensible load only Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with cooling coil type CoilSystem:Cooling:DX:HeatExchangerAssisted. This control mode allows the heat exchanger to be turned on and off based on the zone dehumidification requirements. A ZoneControl:Humidistat object is also required. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid with all cooling coil types. When a heat exchanger assisted Cooling coil is used, the heat exchanger is locked on at all times. A ZoneControl:Humidistat object is also required.")]
[JsonProperty("dehumidification_control_type")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_DehumidificationControlType), "None");
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplyAirFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Heating:DX:VariableSpeed")]
        CoilHeatingDXVariableSpeed = 1,
        
        [JsonProperty("CoilSystem:IntegratedHeatPump:AirSource")]
        CoilSystemIntegratedHeatPumpAirSource = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 1,
        
        [JsonProperty("CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 2,
        
        [JsonProperty("CoilSystem:IntegratedHeatPump:AirSource")]
        CoilSystemIntegratedHeatPumpAirSource = 3,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_FanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("Multimode")]
        Multimode = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    [Description(@"Unitary heat pump system, heating and cooling, single-speed with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, DX heating coil (water-to-air heat pump), and supplemental heating coil (gas, electric, hot water, or steam).")]
    [JsonObject("AirLoopHVAC:UnitaryHeatPump:WaterToAir")]
    public class AirLoopHVAC_UnitaryHeatPump_WaterToAir : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("This value should be > 0 and <= than the fan air flow rate.")]
[JsonProperty("supply_air_flow_rate")]
public string SupplyAirFlowRate { get; set; } = "";
        

[JsonProperty("controlling_zone_or_thermostat_location")]
public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

[Description("Only works with On/Off Fan")]
[JsonProperty("supply_air_fan_object_type")]
public AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplyAirFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplyAirFanObjectType), "FanOnOff");
        

[Description("Needs to match Fan:OnOff object")]
[JsonProperty("supply_air_fan_name")]
public string SupplyAirFanName { get; set; } = "";
        

[JsonProperty("heating_coil_object_type")]
public AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatingCoilObjectType), "CoilHeatingWaterToAirHeatPumpEquationFit");
        

[Description("Needs to match in the water-to-air heat pump heating coil object")]
[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[JsonProperty("heating_convergence")]
public System.Nullable<float> HeatingConvergence { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_object_type")]
public AirLoopHVAC_UnitaryHeatPump_WaterToAir_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_CoolingCoilObjectType), "CoilCoolingWaterToAirHeatPumpEquationFit");
        

[Description("Needs to match in the water-to-air heat pump cooling coil object")]
[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[JsonProperty("cooling_convergence")]
public System.Nullable<float> CoolingConvergence { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[Description("The maximum on-off cycling rate for the compressor Suggested value is 2.5 for a t" +
    "ypical heat pump")]
[JsonProperty("maximum_cycling_rate")]
public System.Nullable<float> MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

[Description("Time constant for the cooling coil\'s capacity to reach steady state after startup" +
    " Suggested value is 60 for a typical heat pump")]
[JsonProperty("heat_pump_time_constant")]
public System.Nullable<float> HeatPumpTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description("The fraction of on-cycle power use to adjust the part load fraction based on the " +
    "off-cycle power consumption due to crankcase heaters, controls, fans, and etc. S" +
    "uggested value is 0.01 for a typical heat pump")]
[JsonProperty("fraction_of_on_cycle_power_use")]
public System.Nullable<float> FractionOfOnCyclePowerUse { get; set; } = (System.Nullable<float>)Single.Parse("0.01", CultureInfo.InvariantCulture);
        

[Description("Programmed time delay for heat pump fan to shut off after compressor cycle off. O" +
    "nly required when fan operating mode is cycling Enter 0 when fan operating mode " +
    "is continuous")]
[JsonProperty("heat_pump_fan_delay_time")]
public System.Nullable<float> HeatPumpFanDelayTime { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description("works with gas, electric, hot water and steam heating coils")]
[JsonProperty("supplemental_heating_coil_object_type")]
public AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

[Description("Needs to match in the supplemental heating coil object")]
[JsonProperty("supplemental_heating_coil_name")]
public string SupplementalHeatingCoilName { get; set; } = "";
        

[JsonProperty("maximum_supply_air_temperature_from_supplemental_heater")]
public string MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = "";
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

[JsonProperty("outdoor_dry_bulb_temperature_sensor_node_name")]
public string OutdoorDryBulbTemperatureSensorNodeName { get; set; } = "";
        

[JsonProperty("fan_placement")]
public AirLoopHVAC_UnitaryHeatPump_WaterToAir_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_FanPlacement), "BlowThrough");
        

[Description(@"Enter the name of a schedule that controls fan operation. Schedule values of 0 denote cycling fan operation (fan cycles with cooling or heating coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this field is left blank.")]
[JsonProperty("supply_air_fan_operating_mode_schedule_name")]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint. as" +
    " required to meet the humidity setpoint. Valid only with Coil:Cooling:WaterToAir" +
    "HeatPump:EquationFit or Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit" +
    "")]
[JsonProperty("dehumidification_control_type")]
public AirLoopHVAC_UnitaryHeatPump_WaterToAir_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_DehumidificationControlType), "None");
        

[Description(@"used only when the heat pump coils are of the type WaterToAirHeatPump:EquationFit Constant results in 100% water flow regardless of compressor PLR Cycling results in water flow that matches compressor PLR ConstantOnDemand results in 100% water flow whenever the coil is on, but is 0% whenever the coil has no load")]
[JsonProperty("heat_pump_coil_water_flow_mode")]
public AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatPumpCoilWaterFlowMode HeatPumpCoilWaterFlowMode { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatPumpCoilWaterFlowMode)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatPumpCoilWaterFlowMode), "Cycling");
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplyAirFanObjectType
    {
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 0,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:EquationFit")]
        CoilHeatingWaterToAirHeatPumpEquationFit = 0,
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:ParameterEstimation")]
        CoilHeatingWaterToAirHeatPumpParameterEstimation = 1,
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilHeatingWaterToAirHeatPumpVariableSpeedEquationFit = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_WaterToAir_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 0,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:ParameterEstimation")]
        CoilCoolingWaterToAirHeatPumpParameterEstimation = 1,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilCoolingWaterToAirHeatPumpVariableSpeedEquationFit = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplementalHeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_WaterToAir_FanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_WaterToAir_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatPumpCoilWaterFlowMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("ConstantOnDemand")]
        ConstantOnDemand = 2,
        
        [JsonProperty("Cycling")]
        Cycling = 3,
    }
    
    [Description(@"Unitary system, heating and cooling with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, heating coil (gas, electric, hot water, steam, or DX air-to-air heat pump) and bypass damper for variable volume flow to terminal units. Used with AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat or AirTerminal:SingleDuct:VAV:HeatAndCool:NoReheat.")]
    [JsonObject("AirLoopHVAC:UnitaryHeatCool:VAVChangeoverBypass")]
    public class AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Enter the availability schedule name. Schedule values of zero denote system is Off. Non-zero schedule values denote system is available to operate.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Enter the system air flow rate during cooling operation or specify autosize.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the system air flow rate during heating operation or specify autosize.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = "";
        

[Description(@"Only used when the supply air fan operating mode is continuous (see field Supply air fan operating mode schedule name). This system air flow rate is used when no heating or cooling is required and the coils are off. If this field is left blank or zero, the system air flow rate from the previous on cycle (either cooling or heating) is used.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the outdoor air flow rate during cooling operation or specify autosize.")]
[JsonProperty("cooling_outdoor_air_flow_rate")]
public string CoolingOutdoorAirFlowRate { get; set; } = "";
        

[Description("Enter the outdoor air flow rate during heating operation or specify autosize.")]
[JsonProperty("heating_outdoor_air_flow_rate")]
public string HeatingOutdoorAirFlowRate { get; set; } = "";
        

[Description(@"Only used when the supply air fan operating mode is continuous (see field Supply air fan operating mode schedule name). This outdoor air flow rate is used when no heating or cooling is required and the coils are off. If this field is left blank or zero, the outdoor air flow rate from the previous on cycle (either cooling or heating) is used.")]
[JsonProperty("no_load_outdoor_air_flow_rate")]
public string NoLoadOutdoorAirFlowRate { get; set; } = "";
        

[Description("Enter the name of a schedule that contains multipliers for the outdoor air flow r" +
    "ates. Schedule values must be from 0 to 1. If field is left blank, model assumes" +
    " multiplier is 1 for the entire simulation period.")]
[JsonProperty("outdoor_air_flow_rate_multiplier_schedule_name")]
public string OutdoorAirFlowRateMultiplierScheduleName { get; set; } = "";
        

[Description("Enter the name of the unitary system\'s air inlet node.")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[Description("Enter the name of the bypass duct mixer node. This name should be the name of the" +
    " return air node for the outdoor air mixer associated with this system. This nod" +
    "e name must be different from the air inlet node name.")]
[JsonProperty("bypass_duct_mixer_node_name")]
public string BypassDuctMixerNodeName { get; set; } = "";
        

[Description(@"Enter the name of the bypass duct splitter node. This splitter air node is the outlet node of the last component in this unitary system. For blow through fan placement, the splitter air node is the outlet node of the heating coil. For draw through fan placement, the splitter node is the outlet node of the supply air fan.")]
[JsonProperty("bypass_duct_splitter_node_name")]
public string BypassDuctSplitterNodeName { get; set; } = "";
        

[Description("Enter the name of the unitary system\'s air outlet node.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("currently only one type OutdoorAir:Mixer object is available.")]
[JsonProperty("outdoor_air_mixer_object_type")]
public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType OutdoorAirMixerObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType), "OutdoorAirMixer");
        

[Description("Enter the name of the outdoor air mixer used with this unitary system.")]
[JsonProperty("outdoor_air_mixer_name")]
public string OutdoorAirMixerName { get; set; } = "";
        

[Description("Specify the type of supply air fan used in this unitary system.")]
[JsonProperty("supply_air_fan_object_type")]
public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType), "FanConstantVolume");
        

[Description("Enter the name of the supply air fan used in this unitary system.")]
[JsonProperty("supply_air_fan_name")]
public string SupplyAirFanName { get; set; } = "";
        

[Description("Specify supply air fan placement as either blow through or draw through. BlowThro" +
    "ugh means the supply air fan is located before the cooling coil. DrawThrough mea" +
    "ns the supply air fan is located after the heating coil.")]
[JsonProperty("supply_air_fan_placement")]
public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement), "BlowThrough");
        

[Description(@"Enter the name of a schedule to control the supply air fan. Schedule Name values of zero mean that the supply air fan will cycle off if there is no cooling or heating load in any of the zones being served by this system. Non-zero schedule values mean that the supply air fan will operate continuously even if there is no cooling or heating load in any of the zones being served. If this field is left blank, the supply air fan will operate continuously for the entire simulation period.")]
[JsonProperty("supply_air_fan_operating_mode_schedule_name")]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[Description("Specify the type of cooling coil used in this unitary system.")]
[JsonProperty("cooling_coil_object_type")]
public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

[Description("Enter the name of the cooling coil used in this unitary system.")]
[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[Description("works with DX, gas, electric, hot water and steam heating coils Specify the type " +
    "of heating coil used in this unitary system.")]
[JsonProperty("heating_coil_object_type")]
public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType), "CoilHeatingDXSingleSpeed");
        

[Description("Enter the name of the heating coil used in this unitary system.")]
[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[Description(@"CoolingPriority = system provides cooling if any zone requires cooling. HeatingPriority = system provides heating if any zone requires heating. ZonePriority = system controlled based on the total number of zones requiring cooling or heating (highest number of zones in cooling or heating determines the system's operating mode). LoadPriority = system provides cooling or heating based on total zone loads.")]
[JsonProperty("priority_control_mode")]
public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode PriorityControlMode { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode), "ZonePriority");
        

[Description("Specify the minimum outlet air temperature allowed for this unitary system during" +
    " cooling operation. This value should be less than the maximum outlet air temper" +
    "ature during heating operation.")]
[JsonProperty("minimum_outlet_air_temperature_during_cooling_operation")]
public System.Nullable<float> MinimumOutletAirTemperatureDuringCoolingOperation { get; set; } = (System.Nullable<float>)Single.Parse("8", CultureInfo.InvariantCulture);
        

[Description("Specify the maximum outlet air temperature allowed for this unitary system during" +
    " heating operation. This value should be greater than the minimum outlet air tem" +
    "perature during cooling operation.")]
[JsonProperty("maximum_outlet_air_temperature_during_heating_operation")]
public System.Nullable<float> MaximumOutletAirTemperatureDuringHeatingOperation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"None = meet sensible load only. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with Coil:Cooling:DX:TwoStageWithHumidityControlMode. CoolReheat = cool beyond the Dry-Bulb temperature setpoint as required to meet the humidity setpoint. Valid only with Coil:Cooling:DX:TwoStageWithHumidityControlMode. For all dehumidification controls, the max humidity setpoint on this unitary system's air outlet node is used. This must be set using ZoneControl:Humidistat and SetpointManager:SingleZone:Humidity:Maximum, SetpointManager:MultiZone:Humidity:Maximum or SetpointManager:MultiZone:MaximumHumidity:Average objects.")]
[JsonProperty("dehumidification_control_type")]
public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType), "None");
        

[Description("Enter the name of the bypass duct node connected to a plenum or mixer. This field" +
    " is required when this HVAC System is connected to a plenum or mixer. This is a " +
    "different node name than that entered in the Bypass Duct Splitter Node Name fiel" +
    "d.")]
[JsonProperty("plenum_or_mixer_inlet_node_name")]
public string PlenumOrMixerInletNodeName { get; set; } = "";
        

[Description("This is the minimum amount of time the unit operates in cooling or heating mode b" +
    "efore changing modes.")]
[JsonProperty("minimum_runtime_before_operating_mode_change")]
public System.Nullable<float> MinimumRuntimeBeforeOperatingModeChange { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType
    {
        
        [JsonProperty("OutdoorAir:Mixer")]
        OutdoorAirMixer = 0,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
        
        [JsonProperty("Fan:SystemModel")]
        FanSystemModel = 2,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement
    {
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 0,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 1,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 1,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 2,
        
        [JsonProperty("CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 3,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Heating:DX:VariableSpeed")]
        CoilHeatingDXVariableSpeed = 1,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 2,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 3,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 4,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 5,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolingPriority")]
        CoolingPriority = 1,
        
        [JsonProperty("HeatingPriority")]
        HeatingPriority = 2,
        
        [JsonProperty("LoadPriority")]
        LoadPriority = 3,
        
        [JsonProperty("ZonePriority")]
        ZonePriority = 4,
    }
    
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("Multimode")]
        Multimode = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    [Description(@"Unitary system, heating and cooling, multi-speed with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, heating coil (DX air-to-air heat pump, gas, electric, hot water, or steam), and supplemental heating coil (gas, electric, hot water, or steam).")]
    [JsonObject("AirLoopHVAC:UnitaryHeatPump:AirToAir:MultiSpeed")]
    public class AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("controlling_zone_or_thermostat_location")]
public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

[Description("Select the type of supply air fan used in this unitary system.")]
[JsonProperty("supply_air_fan_object_type")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanObjectType), "FanConstantVolume");
        

[Description("Enter the name of the supply air fan used in this unitary system.")]
[JsonProperty("supply_air_fan_name")]
public string SupplyAirFanName { get; set; } = "";
        

[Description(@"Select supply air fan placement as either BlowThrough or DrawThrough. BlowThrough means the supply air fan is located before the cooling coil. DrawThrough means the supply air fan is located after the heating coil but before the optional supplemental heating coil.")]
[JsonProperty("supply_air_fan_placement")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanPlacement), "BlowThrough");
        

[Description(@"Enter the name of a schedule to control the supply air fan. Schedule values of zero mean that the supply air fan will cycle off if there is no cooling or heating load in the control zone. Non-zero schedule values mean that the supply air fan will operate continuously even if there is no cooling or heating load in the control zone. If this field is left blank, the supply air fan will operate continuously for the entire simulation period.")]
[JsonProperty("supply_air_fan_operating_mode_schedule_name")]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[Description("Multi Speed DX, Electric, Gas, and Single speed Water and Steam coils")]
[JsonProperty("heating_coil_object_type")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_HeatingCoilObjectType), "CoilHeatingDXMultiSpeed");
        

[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[Description("Needs to match the corresponding minimum outdoor temperature defined in the DX he" +
    "ating coil object.")]
[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

[Description("Only works with Coil:Cooling:DX:MultiSpeed")]
[JsonProperty("cooling_coil_object_type")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_CoolingCoilObjectType), "CoilCoolingDXMultiSpeed");
        

[Description("Needs to match in the DX Cooling Coil object")]
[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[Description("works with gas, electric, hot water and steam heating coils")]
[JsonProperty("supplemental_heating_coil_object_type")]
public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

[Description("Needs to match in the supplemental heating coil object")]
[JsonProperty("supplemental_heating_coil_name")]
public string SupplementalHeatingCoilName { get; set; } = "";
        

[JsonProperty("maximum_supply_air_temperature_from_supplemental_heater")]
public string MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = "";
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

[JsonProperty("auxiliary_on_cycle_electric_power")]
public System.Nullable<float> AuxiliaryOnCycleElectricPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("auxiliary_off_cycle_electric_power")]
public System.Nullable<float> AuxiliaryOffCycleElectricPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If non-zero, then the heat recovery inlet and outlet node names must be entered. " +
    "Used for heat recovery to an EnergyPlus plant loop.")]
[JsonProperty("design_heat_recovery_water_flow_rate")]
public System.Nullable<float> DesignHeatRecoveryWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_temperature_for_heat_recovery")]
public System.Nullable<float> MaximumTemperatureForHeatRecovery { get; set; } = (System.Nullable<float>)Single.Parse("80", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_recovery_water_inlet_node_name")]
public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

[JsonProperty("heat_recovery_water_outlet_node_name")]
public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

[Description(@"Only used when the supply air fan operating mode is continuous (see field Supply Air Fan Operating Mode Schedule Name). This air flow rate is used when no heating or cooling is required and the coils are off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the number of the following sets of data for air flow rates. If Heating Coi" +
    "l Object Type is Coil:Heating:Water or Coil:Heating:Steam, this field should be " +
    "1.")]
[JsonProperty("number_of_speeds_for_heating")]
public System.Nullable<float> NumberOfSpeedsForHeating { get; set; } = null;
        

[Description("Enter the number of the following sets of data for air flow rates.")]
[JsonProperty("number_of_speeds_for_cooling")]
public System.Nullable<float> NumberOfSpeedsForCooling { get; set; } = null;
        

[Description("Enter the operating supply air flow rate during heating operation or specify auto" +
    "size.")]
[JsonProperty("heating_speed_1_supply_air_flow_rate")]
public string HeatingSpeed1SupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the operating supply air flow rate during heating operation or specify auto" +
    "size.")]
[JsonProperty("heating_speed_2_supply_air_flow_rate")]
public string HeatingSpeed2SupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the operating supply air flow rate during heating operation or specify auto" +
    "size.")]
[JsonProperty("heating_speed_3_supply_air_flow_rate")]
public string HeatingSpeed3SupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the operating supply air flow rate during heating operation or specify auto" +
    "size.")]
[JsonProperty("heating_speed_4_supply_air_flow_rate")]
public string HeatingSpeed4SupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the operating supply air flow rate during cooling operation or specify auto" +
    "size.")]
[JsonProperty("cooling_speed_1_supply_air_flow_rate")]
public string CoolingSpeed1SupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the operating supply air flow rate during cooling operation or specify auto" +
    "size.")]
[JsonProperty("cooling_speed_2_supply_air_flow_rate")]
public string CoolingSpeed2SupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the operating supply air flow rate during cooling operation or specify auto" +
    "size.")]
[JsonProperty("cooling_speed_3_supply_air_flow_rate")]
public string CoolingSpeed3SupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the operating supply air flow rate during cooling operation or specify auto" +
    "size.")]
[JsonProperty("cooling_speed_4_supply_air_flow_rate")]
public string CoolingSpeed4SupplyAirFlowRate { get; set; } = "";
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanPlacement
    {
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 0,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 1,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:MultiSpeed")]
        CoilHeatingDXMultiSpeed = 0,
        
        [JsonProperty("Coil:Heating:Electric:MultiStage")]
        CoilHeatingElectricMultiStage = 1,
        
        [JsonProperty("Coil:Heating:Gas:MultiStage")]
        CoilHeatingGasMultiStage = 2,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 3,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 4,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 0,
    }
    
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplementalHeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
}
