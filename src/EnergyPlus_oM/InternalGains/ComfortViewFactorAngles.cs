using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Used to specify radiant view factors for thermal comfort calculations.")]
    [JsonObject("ComfortViewFactorAngles")]
    public class ComfortViewFactorAngles : BHoMObject
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("surface_1_name")]
        public string Surface1Name { get; set; } = "";
        

        [JsonProperty("angle_factor_1")]
        public System.Nullable<float> AngleFactor1 { get; set; } = null;
        

        [JsonProperty("surface_2_name")]
        public string Surface2Name { get; set; } = "";
        

        [JsonProperty("angle_factor_2")]
        public System.Nullable<float> AngleFactor2 { get; set; } = null;
        

        [JsonProperty("surface_3_name")]
        public string Surface3Name { get; set; } = "";
        

        [JsonProperty("angle_factor_3")]
        public System.Nullable<float> AngleFactor3 { get; set; } = null;
        

        [JsonProperty("surface_4_name")]
        public string Surface4Name { get; set; } = "";
        

        [JsonProperty("angle_factor_4")]
        public System.Nullable<float> AngleFactor4 { get; set; } = null;
        

        [JsonProperty("surface_5_name")]
        public string Surface5Name { get; set; } = "";
        

        [JsonProperty("angle_factor_5")]
        public System.Nullable<float> AngleFactor5 { get; set; } = null;
        

        [JsonProperty("surface_6_name")]
        public string Surface6Name { get; set; } = "";
        

        [JsonProperty("angle_factor_6")]
        public System.Nullable<float> AngleFactor6 { get; set; } = null;
        

        [JsonProperty("surface_7_name")]
        public string Surface7Name { get; set; } = "";
        

        [JsonProperty("angle_factor_7")]
        public System.Nullable<float> AngleFactor7 { get; set; } = null;
        

        [JsonProperty("surface_8_name")]
        public string Surface8Name { get; set; } = "";
        

        [JsonProperty("angle_factor_8")]
        public System.Nullable<float> AngleFactor8 { get; set; } = null;
        

        [JsonProperty("surface_9_name")]
        public string Surface9Name { get; set; } = "";
        

        [JsonProperty("angle_factor_9")]
        public System.Nullable<float> AngleFactor9 { get; set; } = null;
        

        [JsonProperty("surface_10_name")]
        public string Surface10Name { get; set; } = "";
        

        [JsonProperty("angle_factor_10")]
        public System.Nullable<float> AngleFactor10 { get; set; } = null;
        

        [JsonProperty("surface_11_name")]
        public string Surface11Name { get; set; } = "";
        

        [JsonProperty("angle_factor_11")]
        public System.Nullable<float> AngleFactor11 { get; set; } = null;
        

        [JsonProperty("surface_12_name")]
        public string Surface12Name { get; set; } = "";
        

        [JsonProperty("angle_factor_12")]
        public System.Nullable<float> AngleFactor12 { get; set; } = null;
        

        [JsonProperty("surface_13_name")]
        public string Surface13Name { get; set; } = "";
        

        [JsonProperty("angle_factor_13")]
        public System.Nullable<float> AngleFactor13 { get; set; } = null;
        

        [JsonProperty("surface_14_name")]
        public string Surface14Name { get; set; } = "";
        

        [JsonProperty("angle_factor_14")]
        public System.Nullable<float> AngleFactor14 { get; set; } = null;
        

        [JsonProperty("surface_15_name")]
        public string Surface15Name { get; set; } = "";
        

        [JsonProperty("angle_factor_15")]
        public System.Nullable<float> AngleFactor15 { get; set; } = null;
        

        [JsonProperty("surface_16_name")]
        public string Surface16Name { get; set; } = "";
        

        [JsonProperty("angle_factor_16")]
        public System.Nullable<float> AngleFactor16 { get; set; } = null;
        

        [JsonProperty("surface_17_name")]
        public string Surface17Name { get; set; } = "";
        

        [JsonProperty("angle_factor_17")]
        public System.Nullable<float> AngleFactor17 { get; set; } = null;
        

        [JsonProperty("surface_18_name")]
        public string Surface18Name { get; set; } = "";
        

        [JsonProperty("angle_factor_18")]
        public System.Nullable<float> AngleFactor18 { get; set; } = null;
        

        [JsonProperty("surface_19_name")]
        public string Surface19Name { get; set; } = "";
        

        [JsonProperty("angle_factor_19")]
        public System.Nullable<float> AngleFactor19 { get; set; } = null;
        

        [JsonProperty("surface_20_name")]
        public string Surface20Name { get; set; } = "";
        

        [JsonProperty("angle_factor_20")]
        public System.Nullable<float> AngleFactor20 { get; set; } = null;
    }
}