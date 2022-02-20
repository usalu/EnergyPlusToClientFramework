using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Relationship between liquid transport coefficient and moisture content Has n" +
                 "o effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:HeatAndMoistureTransfer:Redistribution")]
    public class MaterialProperty_HeatAndMoistureTransfer_Redistribution : BHoMObject
    {
        

        [Description("Moisture Material Name that the moisture properties will be added to.")]
        [JsonProperty("material_name")]
        public string MaterialName { get; set; } = "";
        

        [Description("number of data points")]
        [JsonProperty("number_of_redistribution_points")]
        public System.Nullable<float> NumberOfRedistributionPoints { get; set; } = null;
        

        [JsonProperty("moisture_content_1")]
        public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_1")]
        public System.Nullable<float> LiquidTransportCoefficient1 { get; set; } = null;
        

        [JsonProperty("moisture_content_2")]
        public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_2")]
        public System.Nullable<float> LiquidTransportCoefficient2 { get; set; } = null;
        

        [JsonProperty("moisture_content_3")]
        public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_3")]
        public System.Nullable<float> LiquidTransportCoefficient3 { get; set; } = null;
        

        [JsonProperty("moisture_content_4")]
        public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_4")]
        public System.Nullable<float> LiquidTransportCoefficient4 { get; set; } = null;
        

        [JsonProperty("moisture_content_5")]
        public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_5")]
        public System.Nullable<float> LiquidTransportCoefficient5 { get; set; } = null;
        

        [JsonProperty("moisture_content_6")]
        public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_6")]
        public System.Nullable<float> LiquidTransportCoefficient6 { get; set; } = null;
        

        [JsonProperty("moisture_content_7")]
        public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_7")]
        public System.Nullable<float> LiquidTransportCoefficient7 { get; set; } = null;
        

        [JsonProperty("moisture_content_8")]
        public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_8")]
        public System.Nullable<float> LiquidTransportCoefficient8 { get; set; } = null;
        

        [JsonProperty("moisture_content_9")]
        public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_9")]
        public System.Nullable<float> LiquidTransportCoefficient9 { get; set; } = null;
        

        [JsonProperty("moisture_content_10")]
        public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_10")]
        public System.Nullable<float> LiquidTransportCoefficient10 { get; set; } = null;
        

        [JsonProperty("moisture_content_11")]
        public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_11")]
        public System.Nullable<float> LiquidTransportCoefficient11 { get; set; } = null;
        

        [JsonProperty("moisture_content_12")]
        public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_12")]
        public System.Nullable<float> LiquidTransportCoefficient12 { get; set; } = null;
        

        [JsonProperty("moisture_content_13")]
        public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_13")]
        public System.Nullable<float> LiquidTransportCoefficient13 { get; set; } = null;
        

        [JsonProperty("moisture_content_14")]
        public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_14")]
        public System.Nullable<float> LiquidTransportCoefficient14 { get; set; } = null;
        

        [JsonProperty("moisture_content_15")]
        public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_15")]
        public System.Nullable<float> LiquidTransportCoefficient15 { get; set; } = null;
        

        [JsonProperty("moisture_content_16")]
        public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_16")]
        public System.Nullable<float> LiquidTransportCoefficient16 { get; set; } = null;
        

        [JsonProperty("moisture_content_17")]
        public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_17")]
        public System.Nullable<float> LiquidTransportCoefficient17 { get; set; } = null;
        

        [JsonProperty("moisture_content_18")]
        public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_18")]
        public System.Nullable<float> LiquidTransportCoefficient18 { get; set; } = null;
        

        [JsonProperty("moisture_content_19")]
        public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_19")]
        public System.Nullable<float> LiquidTransportCoefficient19 { get; set; } = null;
        

        [JsonProperty("moisture_content_20")]
        public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_20")]
        public System.Nullable<float> LiquidTransportCoefficient20 { get; set; } = null;
        

        [JsonProperty("moisture_content_21")]
        public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_21")]
        public System.Nullable<float> LiquidTransportCoefficient21 { get; set; } = null;
        

        [JsonProperty("moisture_content_22")]
        public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_22")]
        public System.Nullable<float> LiquidTransportCoefficient22 { get; set; } = null;
        

        [JsonProperty("moisture_content_23")]
        public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_23")]
        public System.Nullable<float> LiquidTransportCoefficient23 { get; set; } = null;
        

        [JsonProperty("moisture_content_24")]
        public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_24")]
        public System.Nullable<float> LiquidTransportCoefficient24 { get; set; } = null;
        

        [JsonProperty("moisture_content_25")]
        public System.Nullable<float> MoistureContent25 { get; set; } = null;
        

        [JsonProperty("liquid_transport_coefficient_25")]
        public System.Nullable<float> LiquidTransportCoefficient25 { get; set; } = null;
    }
}