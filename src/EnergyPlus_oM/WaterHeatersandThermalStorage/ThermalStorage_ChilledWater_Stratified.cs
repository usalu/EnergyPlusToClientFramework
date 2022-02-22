using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("Chilled water storage with a stratified, multi-node tank. The chilled water is \"u" +
                 "sed\" by drawing from the \"Use Side\" of the water tank. The tank is indirectly ch" +
                 "arged by circulating cold water through the \"Source Side\" of the water tank.")]
    [JsonObject("ThermalStorage:ChilledWater:Stratified")]
    public class ThermalStorage_ChilledWater_Stratified : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("tank_volume")]
        public System.Nullable<float> TankVolume { get; set; } = null;
        

        [Description("Height is measured in the axial direction for horizontal cylinders")]
        [JsonProperty("tank_height")]
        public System.Nullable<float> TankHeight { get; set; } = null;
        

        [JsonProperty("tank_shape")]
        public ThermalStorage_ChilledWater_Stratified_TankShape TankShape { get; set; } = (ThermalStorage_ChilledWater_Stratified_TankShape)Enum.Parse(typeof(ThermalStorage_ChilledWater_Stratified_TankShape), "VerticalCylinder");
        

        [Description("Only used if Tank Shape is Other")]
        [JsonProperty("tank_perimeter")]
        public System.Nullable<float> TankPerimeter { get; set; } = null;
        

        [JsonProperty("setpoint_temperature_schedule_name")]
        public string SetpointTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("deadband_temperature_difference")]
        public System.Nullable<float> DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("temperature_sensor_height")]
        public System.Nullable<float> TemperatureSensorHeight { get; set; } = null;
        

        [JsonProperty("minimum_temperature_limit")]
        public System.Nullable<float> MinimumTemperatureLimit { get; set; } = null;
        

        [JsonProperty("nominal_cooling_capacity")]
        public System.Nullable<float> NominalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("ambient_temperature_indicator")]
        public ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator)Enum.Parse(typeof(ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator), "Outdoors");
        

        [JsonProperty("ambient_temperature_schedule_name")]
        public string AmbientTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("ambient_temperature_zone_name")]
        public string AmbientTemperatureZoneName { get; set; } = "";
        

        [Description("required for Ambient Temperature Indicator=Outdoors")]
        [JsonProperty("ambient_temperature_outdoor_air_node_name")]
        public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty("uniform_skin_loss_coefficient_per_unit_area_to_ambient_temperature")]
        public System.Nullable<float> UniformSkinLossCoefficientPerUnitAreaToAmbientTemperature { get; set; } = null;
        

        [JsonProperty("use_side_inlet_node_name")]
        public string UseSideInletNodeName { get; set; } = "";
        

        [JsonProperty("use_side_outlet_node_name")]
        public string UseSideOutletNodeName { get; set; } = "";
        

        [Description(@"The use side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of use mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The use side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
        [JsonProperty("use_side_heat_transfer_effectiveness")]
        public System.Nullable<float> UseSideHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Availability schedule name for use side. Schedule value > 0 means the system is a" +
                     "vailable. If this field is blank, the system is always available.")]
        [JsonProperty("use_side_availability_schedule_name")]
        public string UseSideAvailabilityScheduleName { get; set; } = "";
        

        [Description("Defaults to top of tank")]
        [JsonProperty("use_side_inlet_height")]
        public string UseSideInletHeight { get; set; } = (System.String)"Autocalculate";
        

        [Description("Defaults to bottom of tank")]
        [JsonProperty("use_side_outlet_height")]
        public System.Nullable<float> UseSideOutletHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("use_side_design_flow_rate")]
        public string UseSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("source_side_inlet_node_name")]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty("source_side_outlet_node_name")]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [Description(@"The source side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of source mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The source side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
        [JsonProperty("source_side_heat_transfer_effectiveness")]
        public System.Nullable<float> SourceSideHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Availability schedule name for use side. Schedule value > 0 means the system is a" +
                     "vailable. If this field is blank, the system is always available.")]
        [JsonProperty("source_side_availability_schedule_name")]
        public string SourceSideAvailabilityScheduleName { get; set; } = "";
        

        [Description("Defaults to bottom of tank")]
        [JsonProperty("source_side_inlet_height")]
        public System.Nullable<float> SourceSideInletHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Defaults to top of tank")]
        [JsonProperty("source_side_outlet_height")]
        public string SourceSideOutletHeight { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("source_side_design_flow_rate")]
        public string SourceSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Parameter for autosizing design flow rates for indirectly cooled water tanks time" +
                     " required to lower temperature of entire tank from 14.4C to 9.0C")]
        [JsonProperty("tank_recovery_time")]
        public System.Nullable<float> TankRecoveryTime { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

        [JsonProperty("inlet_mode")]
        public ThermalStorage_ChilledWater_Stratified_InletMode InletMode { get; set; } = (ThermalStorage_ChilledWater_Stratified_InletMode)Enum.Parse(typeof(ThermalStorage_ChilledWater_Stratified_InletMode), "Fixed");
        

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
    }
}