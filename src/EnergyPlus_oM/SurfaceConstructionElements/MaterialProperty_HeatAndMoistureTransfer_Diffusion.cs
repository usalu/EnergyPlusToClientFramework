using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Relationship between water vapor diffusion and relative humidity fraction Ha" +
                 "s no effect with other HeatBalanceAlgorithm solution algorithms")]
    public class MaterialProperty_HeatAndMoistureTransfer_Diffusion : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Moisture Material Name that the moisture properties will be added to.")]
        [JsonProperty("material_name")]
        public string MaterialName { get; set; } = "";
        

        [Description("Water Vapor Diffusion Resistance Factor")]
        [JsonProperty("number_of_data_pairs")]
        public System.Nullable<float> NumberOfDataPairs { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_1")]
        public System.Nullable<float> RelativeHumidityFraction1 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_1")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor1 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_2")]
        public System.Nullable<float> RelativeHumidityFraction2 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_2")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor2 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_3")]
        public System.Nullable<float> RelativeHumidityFraction3 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_3")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor3 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_4")]
        public System.Nullable<float> RelativeHumidityFraction4 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_4")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor4 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_5")]
        public System.Nullable<float> RelativeHumidityFraction5 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_5")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor5 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_6")]
        public System.Nullable<float> RelativeHumidityFraction6 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_6")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor6 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_7")]
        public System.Nullable<float> RelativeHumidityFraction7 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_7")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor7 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_8")]
        public System.Nullable<float> RelativeHumidityFraction8 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_8")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor8 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_9")]
        public System.Nullable<float> RelativeHumidityFraction9 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_9")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor9 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_10")]
        public System.Nullable<float> RelativeHumidityFraction10 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_10")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor10 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_11")]
        public System.Nullable<float> RelativeHumidityFraction11 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_11")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor11 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_12")]
        public System.Nullable<float> RelativeHumidityFraction12 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_12")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor12 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_13")]
        public System.Nullable<float> RelativeHumidityFraction13 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_13")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor13 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_14")]
        public System.Nullable<float> RelativeHumidityFraction14 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_14")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor14 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_15")]
        public System.Nullable<float> RelativeHumidityFraction15 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_15")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor15 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_16")]
        public System.Nullable<float> RelativeHumidityFraction16 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_16")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor16 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_17")]
        public System.Nullable<float> RelativeHumidityFraction17 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_17")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor17 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_18")]
        public System.Nullable<float> RelativeHumidityFraction18 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_18")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor18 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_19")]
        public System.Nullable<float> RelativeHumidityFraction19 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_19")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor19 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_20")]
        public System.Nullable<float> RelativeHumidityFraction20 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_20")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor20 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_21")]
        public System.Nullable<float> RelativeHumidityFraction21 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_21")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor21 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_22")]
        public System.Nullable<float> RelativeHumidityFraction22 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_22")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor22 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_23")]
        public System.Nullable<float> RelativeHumidityFraction23 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_23")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor23 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_24")]
        public System.Nullable<float> RelativeHumidityFraction24 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_24")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor24 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_25")]
        public System.Nullable<float> RelativeHumidityFraction25 { get; set; } = null;
        

        [JsonProperty("water_vapor_diffusion_resistance_factor_25")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor25 { get; set; } = null;
    }
}