using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Describes the exhaust gas heat exchanger subsystem of a fuel cell power generator" +
                 " used to recovery thermal energy")]
    public class Generator_FuelCell_ExhaustGasToWaterHeatExchanger : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("heat_recovery_water_inlet_node_name")]
        public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("heat_recovery_water_outlet_node_name")]
        public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("heat_recovery_water_maximum_flow_rate")]
        public System.Nullable<float> HeatRecoveryWaterMaximumFlowRate { get; set; } = null;
        

        [JsonProperty("exhaust_outlet_air_node_name")]
        public string ExhaustOutletAirNodeName { get; set; } = "";
        

        [JsonProperty("heat_exchanger_calculation_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_ExhaustGasToWaterHeatExchanger_HeatExchangerCalculationMethod HeatExchangerCalculationMethod { get; set; } = (Generator_FuelCell_ExhaustGasToWaterHeatExchanger_HeatExchangerCalculationMethod)Enum.Parse(typeof(Generator_FuelCell_ExhaustGasToWaterHeatExchanger_HeatExchangerCalculationMethod), "Condensing");
        

        [JsonProperty("method_1_heat_exchanger_effectiveness")]
        public System.Nullable<float> Method1HeatExchangerEffectiveness { get; set; } = null;
        

        [JsonProperty("method_2_parameter_hxs0")]
        public System.Nullable<float> Method2ParameterHxs0 { get; set; } = null;
        

        [JsonProperty("method_2_parameter_hxs1")]
        public System.Nullable<float> Method2ParameterHxs1 { get; set; } = null;
        

        [JsonProperty("method_2_parameter_hxs2")]
        public System.Nullable<float> Method2ParameterHxs2 { get; set; } = null;
        

        [JsonProperty("method_2_parameter_hxs3")]
        public System.Nullable<float> Method2ParameterHxs3 { get; set; } = null;
        

        [JsonProperty("method_2_parameter_hxs4")]
        public System.Nullable<float> Method2ParameterHxs4 { get; set; } = null;
        

        [JsonProperty("method_3_h0gas_coefficient")]
        public System.Nullable<float> Method3H0gasCoefficient { get; set; } = null;
        

        [JsonProperty("method_3_ndotgasref_coefficient")]
        public System.Nullable<float> Method3NdotgasrefCoefficient { get; set; } = null;
        

        [JsonProperty("method_3_n_coefficient")]
        public System.Nullable<float> Method3NCoefficient { get; set; } = null;
        

        [JsonProperty("method_3_gas_area")]
        public System.Nullable<float> Method3GasArea { get; set; } = null;
        

        [JsonProperty("method_3_h0_water_coefficient")]
        public System.Nullable<float> Method3H0WaterCoefficient { get; set; } = null;
        

        [JsonProperty("method_3_n_dot_water_ref_coefficient")]
        public System.Nullable<float> Method3NDotWaterRefCoefficient { get; set; } = null;
        

        [JsonProperty("method_3_m_coefficient")]
        public System.Nullable<float> Method3MCoefficient { get; set; } = null;
        

        [JsonProperty("method_3_water_area")]
        public System.Nullable<float> Method3WaterArea { get; set; } = null;
        

        [JsonProperty("method_3_f_adjustment_factor")]
        public System.Nullable<float> Method3FAdjustmentFactor { get; set; } = null;
        

        [JsonProperty("method_4_hxl1_coefficient")]
        public System.Nullable<float> Method4Hxl1Coefficient { get; set; } = null;
        

        [JsonProperty("method_4_hxl2_coefficient")]
        public System.Nullable<float> Method4Hxl2Coefficient { get; set; } = null;
        

        [JsonProperty("method_4_condensation_threshold")]
        public System.Nullable<float> Method4CondensationThreshold { get; set; } = null;
    }
}