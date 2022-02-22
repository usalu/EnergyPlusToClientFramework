using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("Water heater with stratified, multi-node water tank. May be used to model a tankl" +
                 "ess water heater (small tank volume), a hot water storage tank (zero heater capa" +
                 "city), or a heat pump water heater (see WaterHeater:HeatPump:*.)")]
    [JsonObject("WaterHeater:Stratified")]
    public class WaterHeater_Stratified : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
        

        [JsonProperty("tank_volume")]
        public string TankVolume { get; set; } = "";
        

        [Description("Height is measured in the axial direction for horizontal cylinders")]
        [JsonProperty("tank_height")]
        public string TankHeight { get; set; } = "";
        

        [JsonProperty("tank_shape")]
        public WaterHeater_Stratified_TankShape TankShape { get; set; } = (WaterHeater_Stratified_TankShape)Enum.Parse(typeof(WaterHeater_Stratified_TankShape), "VerticalCylinder");
        

        [Description("Only used if Tank Shape is Other")]
        [JsonProperty("tank_perimeter")]
        public System.Nullable<float> TankPerimeter { get; set; } = null;
        

        [JsonProperty("maximum_temperature_limit")]
        public System.Nullable<float> MaximumTemperatureLimit { get; set; } = null;
        

        [JsonProperty("heater_priority_control")]
        public WaterHeater_Stratified_HeaterPriorityControl HeaterPriorityControl { get; set; } = (WaterHeater_Stratified_HeaterPriorityControl)Enum.Parse(typeof(WaterHeater_Stratified_HeaterPriorityControl), "MasterSlave");
        

        [JsonProperty("heater_1_setpoint_temperature_schedule_name")]
        public string Heater1SetpointTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("heater_1_deadband_temperature_difference")]
        public System.Nullable<float> Heater1DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("heater_1_capacity")]
        public string Heater1Capacity { get; set; } = "";
        

        [JsonProperty("heater_1_height")]
        public System.Nullable<float> Heater1Height { get; set; } = null;
        

        [JsonProperty("heater_2_setpoint_temperature_schedule_name")]
        public string Heater2SetpointTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("heater_2_deadband_temperature_difference")]
        public System.Nullable<float> Heater2DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("heater_2_capacity")]
        public System.Nullable<float> Heater2Capacity { get; set; } = null;
        

        [JsonProperty("heater_2_height")]
        public System.Nullable<float> Heater2Height { get; set; } = null;
        

        [JsonProperty("heater_fuel_type")]
        public WaterHeater_Stratified_HeaterFuelType HeaterFuelType { get; set; } = (WaterHeater_Stratified_HeaterFuelType)Enum.Parse(typeof(WaterHeater_Stratified_HeaterFuelType), "Coal");
        

        [JsonProperty("heater_thermal_efficiency")]
        public System.Nullable<float> HeaterThermalEfficiency { get; set; } = null;
        

        [JsonProperty("off_cycle_parasitic_fuel_consumption_rate")]
        public System.Nullable<float> OffCycleParasiticFuelConsumptionRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("off_cycle_parasitic_fuel_type")]
        public WaterHeater_Stratified_OffCycleParasiticFuelType OffCycleParasiticFuelType { get; set; } = (WaterHeater_Stratified_OffCycleParasiticFuelType)Enum.Parse(typeof(WaterHeater_Stratified_OffCycleParasiticFuelType), "Coal");
        

        [JsonProperty("off_cycle_parasitic_heat_fraction_to_tank")]
        public System.Nullable<float> OffCycleParasiticHeatFractionToTank { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("off_cycle_parasitic_height")]
        public System.Nullable<float> OffCycleParasiticHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("on_cycle_parasitic_fuel_consumption_rate")]
        public System.Nullable<float> OnCycleParasiticFuelConsumptionRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("on_cycle_parasitic_fuel_type")]
        public WaterHeater_Stratified_OnCycleParasiticFuelType OnCycleParasiticFuelType { get; set; } = (WaterHeater_Stratified_OnCycleParasiticFuelType)Enum.Parse(typeof(WaterHeater_Stratified_OnCycleParasiticFuelType), "Coal");
        

        [JsonProperty("on_cycle_parasitic_heat_fraction_to_tank")]
        public System.Nullable<float> OnCycleParasiticHeatFractionToTank { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("on_cycle_parasitic_height")]
        public System.Nullable<float> OnCycleParasiticHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("ambient_temperature_indicator")]
        public WaterHeater_Stratified_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (WaterHeater_Stratified_AmbientTemperatureIndicator)Enum.Parse(typeof(WaterHeater_Stratified_AmbientTemperatureIndicator), "Outdoors");
        

        [JsonProperty("ambient_temperature_schedule_name")]
        public string AmbientTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("ambient_temperature_zone_name")]
        public string AmbientTemperatureZoneName { get; set; } = "";
        

        [Description("required for Ambient Temperature Indicator=Outdoors")]
        [JsonProperty("ambient_temperature_outdoor_air_node_name")]
        public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty("uniform_skin_loss_coefficient_per_unit_area_to_ambient_temperature")]
        public System.Nullable<float> UniformSkinLossCoefficientPerUnitAreaToAmbientTemperature { get; set; } = null;
        

        [JsonProperty("skin_loss_fraction_to_zone")]
        public System.Nullable<float> SkinLossFractionToZone { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("off_cycle_flue_loss_coefficient_to_ambient_temperature")]
        public System.Nullable<float> OffCycleFlueLossCoefficientToAmbientTemperature { get; set; } = null;
        

        [JsonProperty("off_cycle_flue_loss_fraction_to_zone")]
        public System.Nullable<float> OffCycleFlueLossFractionToZone { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Only used if Use Side Node connections are blank")]
        [JsonProperty("peak_use_flow_rate")]
        public System.Nullable<float> PeakUseFlowRate { get; set; } = null;
        

        [Description("If blank, defaults to 1.0 at all times Only used if use side node connections are" +
                     " blank")]
        [JsonProperty("use_flow_rate_fraction_schedule_name")]
        public string UseFlowRateFractionScheduleName { get; set; } = "";
        

        [Description("Only used if use side node connections are blank Defaults to water temperatures c" +
                     "alculated by Site:WaterMainsTemperature object")]
        [JsonProperty("cold_water_supply_temperature_schedule_name")]
        public string ColdWaterSupplyTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("use_side_inlet_node_name")]
        public string UseSideInletNodeName { get; set; } = "";
        

        [JsonProperty("use_side_outlet_node_name")]
        public string UseSideOutletNodeName { get; set; } = "";
        

        [Description(@"The use side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of use mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The use side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
        [JsonProperty("use_side_effectiveness")]
        public System.Nullable<float> UseSideEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Defaults to bottom of tank")]
        [JsonProperty("use_side_inlet_height")]
        public System.Nullable<float> UseSideInletHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Defaults to top of tank")]
        [JsonProperty("use_side_outlet_height")]
        public string UseSideOutletHeight { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("source_side_inlet_node_name")]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty("source_side_outlet_node_name")]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [Description(@"The source side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of source mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The source side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
        [JsonProperty("source_side_effectiveness")]
        public System.Nullable<float> SourceSideEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Defaults to top of tank")]
        [JsonProperty("source_side_inlet_height")]
        public string SourceSideInletHeight { get; set; } = (System.String)"Autocalculate";
        

        [Description("Defaults to bottom of tank")]
        [JsonProperty("source_side_outlet_height")]
        public System.Nullable<float> SourceSideOutletHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("inlet_mode")]
        public WaterHeater_Stratified_InletMode InletMode { get; set; } = (WaterHeater_Stratified_InletMode)Enum.Parse(typeof(WaterHeater_Stratified_InletMode), "Fixed");
        

        [JsonProperty("use_side_design_flow_rate")]
        public string UseSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("source_side_design_flow_rate")]
        public string SourceSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Parameter for autosizing design flow rates for indirectly heated water tanks time" +
                     " required to raise temperature of entire tank from 14.4C to 57.2C")]
        [JsonProperty("indirect_water_heating_recovery_time")]
        public System.Nullable<float> IndirectWaterHeatingRecoveryTime { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("number_of_nodes")]
        public System.Nullable<float> NumberOfNodes { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("additional_destratification_conductivity")]
        public System.Nullable<float> AdditionalDestratificationConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_1_additional_loss_coefficient")]
        public System.Nullable<float> Node1AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_2_additional_loss_coefficient")]
        public System.Nullable<float> Node2AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_3_additional_loss_coefficient")]
        public System.Nullable<float> Node3AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_4_additional_loss_coefficient")]
        public System.Nullable<float> Node4AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_5_additional_loss_coefficient")]
        public System.Nullable<float> Node5AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_6_additional_loss_coefficient")]
        public System.Nullable<float> Node6AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_7_additional_loss_coefficient")]
        public System.Nullable<float> Node7AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_8_additional_loss_coefficient")]
        public System.Nullable<float> Node8AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_9_additional_loss_coefficient")]
        public System.Nullable<float> Node9AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_10_additional_loss_coefficient")]
        public System.Nullable<float> Node10AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_11_additional_loss_coefficient")]
        public System.Nullable<float> Node11AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("node_12_additional_loss_coefficient")]
        public System.Nullable<float> Node12AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"StorageTank mode always requests flow unless tank is at its Maximum Temperature Limit IndirectHeatPrimarySetpoint mode requests flow whenever primary setpoint for heater 1 calls for heat IndirectHeatAlternateSetpoint mode requests flow whenever alternate indirect setpoint calls for heat")]
        [JsonProperty("source_side_flow_control_mode")]
        public WaterHeater_Stratified_SourceSideFlowControlMode SourceSideFlowControlMode { get; set; } = (WaterHeater_Stratified_SourceSideFlowControlMode)Enum.Parse(typeof(WaterHeater_Stratified_SourceSideFlowControlMode), "IndirectHeatPrimarySetpoint");
        

        [Description("This field is only used if the previous is set to IndirectHeatAlternateSetpoint")]
        [JsonProperty("indirect_alternate_setpoint_temperature_schedule_name")]
        public string IndirectAlternateSetpointTemperatureScheduleName { get; set; } = "";
    }
}