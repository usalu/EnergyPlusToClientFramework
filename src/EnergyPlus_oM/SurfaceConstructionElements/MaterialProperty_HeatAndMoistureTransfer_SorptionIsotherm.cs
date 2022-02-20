using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Relationship between moisture content and relative humidity fraction. Has no" +
                 " effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:HeatAndMoistureTransfer:SorptionIsotherm")]
    public class MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm : BHoMObject
    {
        

        [Description("The Material Name that the moisture sorption isotherm will be added to.")]
        [JsonProperty("material_name")]
        public string MaterialName { get; set; } = "";
        

        [Description("Number of data Coordinates")]
        [JsonProperty("number_of_isotherm_coordinates")]
        public System.Nullable<float> NumberOfIsothermCoordinates { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_1")]
        public System.Nullable<float> RelativeHumidityFraction1 { get; set; } = null;
        

        [JsonProperty("moisture_content_1")]
        public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_2")]
        public System.Nullable<float> RelativeHumidityFraction2 { get; set; } = null;
        

        [JsonProperty("moisture_content_2")]
        public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_3")]
        public System.Nullable<float> RelativeHumidityFraction3 { get; set; } = null;
        

        [JsonProperty("moisture_content_3")]
        public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_4")]
        public System.Nullable<float> RelativeHumidityFraction4 { get; set; } = null;
        

        [JsonProperty("moisture_content_4")]
        public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_5")]
        public System.Nullable<float> RelativeHumidityFraction5 { get; set; } = null;
        

        [JsonProperty("moisture_content_5")]
        public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_6")]
        public System.Nullable<float> RelativeHumidityFraction6 { get; set; } = null;
        

        [JsonProperty("moisture_content_6")]
        public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_7")]
        public System.Nullable<float> RelativeHumidityFraction7 { get; set; } = null;
        

        [JsonProperty("moisture_content_7")]
        public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_8")]
        public System.Nullable<float> RelativeHumidityFraction8 { get; set; } = null;
        

        [JsonProperty("moisture_content_8")]
        public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_9")]
        public System.Nullable<float> RelativeHumidityFraction9 { get; set; } = null;
        

        [JsonProperty("moisture_content_9")]
        public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_10")]
        public System.Nullable<float> RelativeHumidityFraction10 { get; set; } = null;
        

        [JsonProperty("moisture_content_10")]
        public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_11")]
        public System.Nullable<float> RelativeHumidityFraction11 { get; set; } = null;
        

        [JsonProperty("moisture_content_11")]
        public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_12")]
        public System.Nullable<float> RelativeHumidityFraction12 { get; set; } = null;
        

        [JsonProperty("moisture_content_12")]
        public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_13")]
        public System.Nullable<float> RelativeHumidityFraction13 { get; set; } = null;
        

        [JsonProperty("moisture_content_13")]
        public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_14")]
        public System.Nullable<float> RelativeHumidityFraction14 { get; set; } = null;
        

        [JsonProperty("moisture_content_14")]
        public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_15")]
        public System.Nullable<float> RelativeHumidityFraction15 { get; set; } = null;
        

        [JsonProperty("moisture_content_15")]
        public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_16")]
        public System.Nullable<float> RelativeHumidityFraction16 { get; set; } = null;
        

        [JsonProperty("moisture_content_16")]
        public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_17")]
        public System.Nullable<float> RelativeHumidityFraction17 { get; set; } = null;
        

        [JsonProperty("moisture_content_17")]
        public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_18")]
        public System.Nullable<float> RelativeHumidityFraction18 { get; set; } = null;
        

        [JsonProperty("moisture_content_18")]
        public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_19")]
        public System.Nullable<float> RelativeHumidityFraction19 { get; set; } = null;
        

        [JsonProperty("moisture_content_19")]
        public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_20")]
        public System.Nullable<float> RelativeHumidityFraction20 { get; set; } = null;
        

        [JsonProperty("moisture_content_20")]
        public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_21")]
        public System.Nullable<float> RelativeHumidityFraction21 { get; set; } = null;
        

        [JsonProperty("moisture_content_21")]
        public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_22")]
        public System.Nullable<float> RelativeHumidityFraction22 { get; set; } = null;
        

        [JsonProperty("moisture_content_22")]
        public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_23")]
        public System.Nullable<float> RelativeHumidityFraction23 { get; set; } = null;
        

        [JsonProperty("moisture_content_23")]
        public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_24")]
        public System.Nullable<float> RelativeHumidityFraction24 { get; set; } = null;
        

        [JsonProperty("moisture_content_24")]
        public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty("relative_humidity_fraction_25")]
        public System.Nullable<float> RelativeHumidityFraction25 { get; set; } = null;
        

        [JsonProperty("moisture_content_25")]
        public System.Nullable<float> MoistureContent25 { get; set; } = null;
    }
}