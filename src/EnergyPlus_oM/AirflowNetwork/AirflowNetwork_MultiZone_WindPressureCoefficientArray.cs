using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description(@"Used only if Wind Pressure Coefficient (WPC) Type = Input in the AirflowNetwork:SimulationControl object. Number of WPC Values in the corresponding AirflowNetwork:MultiZone:WindPressureCoefficientValues object must be the same as the number of wind directions specified for this AirflowNetwork:MultiZone:WindPressureCoefficientArray object.")]
    [JsonObject("AirflowNetwork:MultiZone:WindPressureCoefficientArray")]
    public class AirflowNetwork_MultiZone_WindPressureCoefficientArray : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the wind direction corresponding to the 1st WPC Array value.")]
        [JsonProperty("wind_direction_1")]
        public System.Nullable<float> WindDirection1 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 2nd WPC Array value.")]
        [JsonProperty("wind_direction_2")]
        public System.Nullable<float> WindDirection2 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 3rd WPC Array value.")]
        [JsonProperty("wind_direction_3")]
        public System.Nullable<float> WindDirection3 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 4th WPC Array value.")]
        [JsonProperty("wind_direction_4")]
        public System.Nullable<float> WindDirection4 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 5th WPC Array value.")]
        [JsonProperty("wind_direction_5")]
        public System.Nullable<float> WindDirection5 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 6th WPC Array value.")]
        [JsonProperty("wind_direction_6")]
        public System.Nullable<float> WindDirection6 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 7th WPC Array value.")]
        [JsonProperty("wind_direction_7")]
        public System.Nullable<float> WindDirection7 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 8th WPC Array value.")]
        [JsonProperty("wind_direction_8")]
        public System.Nullable<float> WindDirection8 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 9th WPC Array value.")]
        [JsonProperty("wind_direction_9")]
        public System.Nullable<float> WindDirection9 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 10th WPC Array value.")]
        [JsonProperty("wind_direction_10")]
        public System.Nullable<float> WindDirection10 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 11th WPC Array value.")]
        [JsonProperty("wind_direction_11")]
        public System.Nullable<float> WindDirection11 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 12th WPC Array value.")]
        [JsonProperty("wind_direction_12")]
        public System.Nullable<float> WindDirection12 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 13th WPC Array value.")]
        [JsonProperty("wind_direction_13")]
        public System.Nullable<float> WindDirection13 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 14th WPC Array value.")]
        [JsonProperty("wind_direction_14")]
        public System.Nullable<float> WindDirection14 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 15th WPC Array value.")]
        [JsonProperty("wind_direction_15")]
        public System.Nullable<float> WindDirection15 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 16th WPC Array value.")]
        [JsonProperty("wind_direction_16")]
        public System.Nullable<float> WindDirection16 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 17th WPC Array value.")]
        [JsonProperty("wind_direction_17")]
        public System.Nullable<float> WindDirection17 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 18th WPC Array value.")]
        [JsonProperty("wind_direction_18")]
        public System.Nullable<float> WindDirection18 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 19th WPC Array value.")]
        [JsonProperty("wind_direction_19")]
        public System.Nullable<float> WindDirection19 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 20th WPC Array value.")]
        [JsonProperty("wind_direction_20")]
        public System.Nullable<float> WindDirection20 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 21st WPC Array value.")]
        [JsonProperty("wind_direction_21")]
        public System.Nullable<float> WindDirection21 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 22nd WPC Array value.")]
        [JsonProperty("wind_direction_22")]
        public System.Nullable<float> WindDirection22 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 23rd WPC Array value.")]
        [JsonProperty("wind_direction_23")]
        public System.Nullable<float> WindDirection23 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 24th WPC Array value.")]
        [JsonProperty("wind_direction_24")]
        public System.Nullable<float> WindDirection24 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 25th WPC Array value.")]
        [JsonProperty("wind_direction_25")]
        public System.Nullable<float> WindDirection25 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 26th WPC Array value.")]
        [JsonProperty("wind_direction_26")]
        public System.Nullable<float> WindDirection26 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 27th WPC Array value.")]
        [JsonProperty("wind_direction_27")]
        public System.Nullable<float> WindDirection27 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 28th WPC Array value.")]
        [JsonProperty("wind_direction_28")]
        public System.Nullable<float> WindDirection28 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 29th WPC Array value.")]
        [JsonProperty("wind_direction_29")]
        public System.Nullable<float> WindDirection29 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 30th WPC Array value.")]
        [JsonProperty("wind_direction_30")]
        public System.Nullable<float> WindDirection30 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 31st WPC Array value.")]
        [JsonProperty("wind_direction_31")]
        public System.Nullable<float> WindDirection31 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 32nd WPC Array value.")]
        [JsonProperty("wind_direction_32")]
        public System.Nullable<float> WindDirection32 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 33rd WPC Array value.")]
        [JsonProperty("wind_direction_33")]
        public System.Nullable<float> WindDirection33 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 34th WPC Array value.")]
        [JsonProperty("wind_direction_34")]
        public System.Nullable<float> WindDirection34 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 35th WPC Array value.")]
        [JsonProperty("wind_direction_35")]
        public System.Nullable<float> WindDirection35 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 36th WPC Array value.")]
        [JsonProperty("wind_direction_36")]
        public System.Nullable<float> WindDirection36 { get; set; } = null;
    }
}