using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description(@"Used only if Wind Pressure Coefficient (WPC) Type = INPUT in the AirflowNetwork:SimulationControl object. The number of WPC numeric inputs must correspond to the number of wind direction inputs in the AirflowNetwork:Multizone:WindPressureCoefficientArray object.")]
    [JsonObject("AirflowNetwork:MultiZone:WindPressureCoefficientValues")]
    public class AirflowNetwork_MultiZone_WindPressureCoefficientValues : BHoMObject
    {
        

        [Description("Enter the name of the AirflowNetwork:Multizone:WindPressureCoefficientArray objec" +
                     "t.")]
        [JsonProperty("airflownetwork_multizone_windpressurecoefficientarray_name")]
        public string AirflownetworkMultizoneWindpressurecoefficientarrayName { get; set; } = "";
        

        [Description("Enter the WPC Value corresponding to the 1st wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_1")]
        public System.Nullable<float> WindPressureCoefficientValue1 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 2nd wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_2")]
        public System.Nullable<float> WindPressureCoefficientValue2 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 3rd wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_3")]
        public System.Nullable<float> WindPressureCoefficientValue3 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 4th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_4")]
        public System.Nullable<float> WindPressureCoefficientValue4 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 5th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_5")]
        public System.Nullable<float> WindPressureCoefficientValue5 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 6th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_6")]
        public System.Nullable<float> WindPressureCoefficientValue6 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 7th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_7")]
        public System.Nullable<float> WindPressureCoefficientValue7 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 8th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_8")]
        public System.Nullable<float> WindPressureCoefficientValue8 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 9th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_9")]
        public System.Nullable<float> WindPressureCoefficientValue9 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 10th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_10")]
        public System.Nullable<float> WindPressureCoefficientValue10 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 11th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_11")]
        public System.Nullable<float> WindPressureCoefficientValue11 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 12th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_12")]
        public System.Nullable<float> WindPressureCoefficientValue12 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 13th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_13")]
        public System.Nullable<float> WindPressureCoefficientValue13 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 14th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_14")]
        public System.Nullable<float> WindPressureCoefficientValue14 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 15th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_15")]
        public System.Nullable<float> WindPressureCoefficientValue15 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 16th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_16")]
        public System.Nullable<float> WindPressureCoefficientValue16 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 17th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_17")]
        public System.Nullable<float> WindPressureCoefficientValue17 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 18th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_18")]
        public System.Nullable<float> WindPressureCoefficientValue18 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 19th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_19")]
        public System.Nullable<float> WindPressureCoefficientValue19 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 20th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_20")]
        public System.Nullable<float> WindPressureCoefficientValue20 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 21st wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_21")]
        public System.Nullable<float> WindPressureCoefficientValue21 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 22nd wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_22")]
        public System.Nullable<float> WindPressureCoefficientValue22 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 23rd wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_23")]
        public System.Nullable<float> WindPressureCoefficientValue23 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 24th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_24")]
        public System.Nullable<float> WindPressureCoefficientValue24 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 25th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_25")]
        public System.Nullable<float> WindPressureCoefficientValue25 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 26th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_26")]
        public System.Nullable<float> WindPressureCoefficientValue26 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 27th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_27")]
        public System.Nullable<float> WindPressureCoefficientValue27 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 28th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_28")]
        public System.Nullable<float> WindPressureCoefficientValue28 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 29th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_29")]
        public System.Nullable<float> WindPressureCoefficientValue29 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 30th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_30")]
        public System.Nullable<float> WindPressureCoefficientValue30 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 31st wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_31")]
        public System.Nullable<float> WindPressureCoefficientValue31 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 32nd wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_32")]
        public System.Nullable<float> WindPressureCoefficientValue32 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 33rd wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_33")]
        public System.Nullable<float> WindPressureCoefficientValue33 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 34th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_34")]
        public System.Nullable<float> WindPressureCoefficientValue34 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 35th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_35")]
        public System.Nullable<float> WindPressureCoefficientValue35 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 36th wind direction.")]
        [JsonProperty("wind_pressure_coefficient_value_36")]
        public System.Nullable<float> WindPressureCoefficientValue36 { get; set; } = null;
    }
}