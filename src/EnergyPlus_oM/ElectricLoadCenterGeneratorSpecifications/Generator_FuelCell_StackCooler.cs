using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("This object is optional and is used to define details needed to model the stack c" +
                 "ooler on PEMFC.")]
    [JsonObject("Generator:FuelCell:StackCooler")]
    public class Generator_FuelCell_StackCooler : BHoMObject
    {
        

        [JsonProperty("heat_recovery_water_inlet_node_name")]
        public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("heat_recovery_water_outlet_node_name")]
        public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("nominal_stack_temperature")]
        public System.Nullable<float> NominalStackTemperature { get; set; } = null;
        

        [JsonProperty("actual_stack_temperature")]
        public System.Nullable<float> ActualStackTemperature { get; set; } = null;
        

        [JsonProperty("coefficient_r0")]
        public System.Nullable<float> CoefficientR0 { get; set; } = null;
        

        [JsonProperty("coefficient_r1")]
        public System.Nullable<float> CoefficientR1 { get; set; } = null;
        

        [JsonProperty("coefficient_r2")]
        public System.Nullable<float> CoefficientR2 { get; set; } = null;
        

        [JsonProperty("coefficient_r3")]
        public System.Nullable<float> CoefficientR3 { get; set; } = null;
        

        [JsonProperty("stack_coolant_flow_rate")]
        public System.Nullable<float> StackCoolantFlowRate { get; set; } = null;
        

        [JsonProperty("stack_cooler_u_factor_times_area_value")]
        public System.Nullable<float> StackCoolerUFactorTimesAreaValue { get; set; } = null;
        

        [JsonProperty("fs_cogen_adjustment_factor")]
        public System.Nullable<float> FsCogenAdjustmentFactor { get; set; } = null;
        

        [JsonProperty("stack_cogeneration_exchanger_area")]
        public System.Nullable<float> StackCogenerationExchangerArea { get; set; } = null;
        

        [JsonProperty("stack_cogeneration_exchanger_nominal_flow_rate")]
        public System.Nullable<float> StackCogenerationExchangerNominalFlowRate { get; set; } = null;
        

        [JsonProperty("stack_cogeneration_exchanger_nominal_heat_transfer_coefficient")]
        public System.Nullable<float> StackCogenerationExchangerNominalHeatTransferCoefficient { get; set; } = null;
        

        [JsonProperty("stack_cogeneration_exchanger_nominal_heat_transfer_coefficient_exponent")]
        public System.Nullable<float> StackCogenerationExchangerNominalHeatTransferCoefficientExponent { get; set; } = null;
        

        [JsonProperty("stack_cooler_pump_power")]
        public System.Nullable<float> StackCoolerPumpPower { get; set; } = null;
        

        [JsonProperty("stack_cooler_pump_heat_loss_fraction")]
        public System.Nullable<float> StackCoolerPumpHeatLossFraction { get; set; } = null;
        

        [JsonProperty("stack_air_cooler_fan_coefficient_f0")]
        public System.Nullable<float> StackAirCoolerFanCoefficientF0 { get; set; } = null;
        

        [JsonProperty("stack_air_cooler_fan_coefficient_f1")]
        public System.Nullable<float> StackAirCoolerFanCoefficientF1 { get; set; } = null;
        

        [JsonProperty("stack_air_cooler_fan_coefficient_f2")]
        public System.Nullable<float> StackAirCoolerFanCoefficientF2 { get; set; } = null;
    }
}