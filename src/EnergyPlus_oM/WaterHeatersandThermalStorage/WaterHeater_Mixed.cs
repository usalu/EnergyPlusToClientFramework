namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
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
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Water heater with well-mixed, single-node water tank. May be used to model a tank" +
        "less water heater (small tank volume), a hot water storage tank (zero heater cap" +
        "acity), or a heat pump water heater (see WaterHeater:HeatPump:PumpedCondenser.)")]
    [JsonObject("WaterHeater:Mixed")]
    public class WaterHeater_Mixed : BHoMObject
    {
        

[JsonProperty("tank_volume")]
public string TankVolume { get; set; } = (System.String)"0";
        

[JsonProperty("setpoint_temperature_schedule_name")]
public string SetpointTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("deadband_temperature_difference")]
public System.Nullable<float> DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_temperature_limit")]
public System.Nullable<float> MaximumTemperatureLimit { get; set; } = null;
        

[JsonProperty("heater_control_type")]
public EmptyNoYes HeaterControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Cycle");
        

[JsonProperty("heater_maximum_capacity")]
public string HeaterMaximumCapacity { get; set; } = "";
        

[Description("Only used when Heater Control Type is set to Modulate")]
[JsonProperty("heater_minimum_capacity")]
public System.Nullable<float> HeaterMinimumCapacity { get; set; } = null;
        

[Description("Not yet implemented")]
[JsonProperty("heater_ignition_minimum_flow_rate")]
public System.Nullable<float> HeaterIgnitionMinimumFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Not yet implemented")]
[JsonProperty("heater_ignition_delay")]
public System.Nullable<float> HeaterIgnitionDelay { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("heater_fuel_type")]
public EmptyNoYes HeaterFuelType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[JsonProperty("heater_thermal_efficiency")]
public System.Nullable<float> HeaterThermalEfficiency { get; set; } = null;
        

[JsonProperty("part_load_factor_curve_name")]
public string PartLoadFactorCurveName { get; set; } = "";
        

[JsonProperty("off_cycle_parasitic_fuel_consumption_rate")]
public System.Nullable<float> OffCycleParasiticFuelConsumptionRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("off_cycle_parasitic_fuel_type")]
public EmptyNoYes OffCycleParasiticFuelType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[JsonProperty("off_cycle_parasitic_heat_fraction_to_tank")]
public System.Nullable<float> OffCycleParasiticHeatFractionToTank { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("on_cycle_parasitic_fuel_consumption_rate")]
public System.Nullable<float> OnCycleParasiticFuelConsumptionRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("on_cycle_parasitic_fuel_type")]
public EmptyNoYes OnCycleParasiticFuelType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[JsonProperty("on_cycle_parasitic_heat_fraction_to_tank")]
public System.Nullable<float> OnCycleParasiticHeatFractionToTank { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("ambient_temperature_indicator")]
public EmptyNoYes AmbientTemperatureIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[JsonProperty("ambient_temperature_schedule_name")]
public string AmbientTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("ambient_temperature_zone_name")]
public string AmbientTemperatureZoneName { get; set; } = "";
        

[Description("required for Ambient Temperature Indicator=Outdoors")]
[JsonProperty("ambient_temperature_outdoor_air_node_name")]
public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

[JsonProperty("off_cycle_loss_coefficient_to_ambient_temperature")]
public System.Nullable<float> OffCycleLossCoefficientToAmbientTemperature { get; set; } = null;
        

[JsonProperty("off_cycle_loss_fraction_to_zone")]
public System.Nullable<float> OffCycleLossFractionToZone { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("on_cycle_loss_coefficient_to_ambient_temperature")]
public System.Nullable<float> OnCycleLossCoefficientToAmbientTemperature { get; set; } = null;
        

[JsonProperty("on_cycle_loss_fraction_to_zone")]
public System.Nullable<float> OnCycleLossFractionToZone { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Only used if Use Side Node connections are blank")]
[JsonProperty("peak_use_flow_rate")]
public System.Nullable<float> PeakUseFlowRate { get; set; } = null;
        

[Description("Only used if Use Side Node connections are blank")]
[JsonProperty("use_flow_rate_fraction_schedule_name")]
public string UseFlowRateFractionScheduleName { get; set; } = "";
        

[Description("Only used if Use Side Node connections are blank Defaults to water temperatures c" +
    "alculated by Site:WaterMainsTemperature object")]
[JsonProperty("cold_water_supply_temperature_schedule_name")]
public string ColdWaterSupplyTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("use_side_inlet_node_name")]
public string UseSideInletNodeName { get; set; } = "";
        

[JsonProperty("use_side_outlet_node_name")]
public string UseSideOutletNodeName { get; set; } = "";
        

[JsonProperty("use_side_effectiveness")]
public System.Nullable<float> UseSideEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("source_side_inlet_node_name")]
public string SourceSideInletNodeName { get; set; } = "";
        

[JsonProperty("source_side_outlet_node_name")]
public string SourceSideOutletNodeName { get; set; } = "";
        

[JsonProperty("source_side_effectiveness")]
public System.Nullable<float> SourceSideEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("use_side_design_flow_rate")]
public string UseSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("source_side_design_flow_rate")]
public string SourceSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Parameter for autosizing design flow rates for indirectly heated water tanks Time" +
    " required to raise temperature of entire tank from 14.4C to 57.2C")]
[JsonProperty("indirect_water_heating_recovery_time")]
public System.Nullable<float> IndirectWaterHeatingRecoveryTime { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

[Description(@"StorageTank mode always requests flow unless tank is at its Maximum Temperature Limit IndirectHeatPrimarySetpoint mode requests flow whenever primary setpoint calls for heat IndirectHeatAlternateSetpoint mode requests flow whenever alternate indirect setpoint calls for heat")]
[JsonProperty("source_side_flow_control_mode")]
public EmptyNoYes SourceSideFlowControlMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "IndirectHeatPrimarySetpoint");
        

[Description("This field is only used if the previous is set to IndirectHeatAlternateSetpoint")]
[JsonProperty("indirect_alternate_setpoint_temperature_schedule_name")]
public string IndirectAlternateSetpointTemperatureScheduleName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}
