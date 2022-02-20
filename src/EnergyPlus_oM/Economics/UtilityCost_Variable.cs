using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Allows for the direct entry of monthly values into a utility tariff variable.")]
    [JsonObject("UtilityCost:Variable")]
    public class UtilityCost_Variable : BHoMObject
    {
        

        [Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Varia" +
                     "ble.")]
        [JsonProperty("tariff_name")]
        public string TariffName { get; set; } = "";
        

        [JsonProperty("variable_type")]
        public EmptyNoYes VariableType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("january_value")]
        public System.Nullable<float> JanuaryValue { get; set; } = null;
        

        [JsonProperty("february_value")]
        public System.Nullable<float> FebruaryValue { get; set; } = null;
        

        [JsonProperty("march_value")]
        public System.Nullable<float> MarchValue { get; set; } = null;
        

        [JsonProperty("april_value")]
        public System.Nullable<float> AprilValue { get; set; } = null;
        

        [JsonProperty("may_value")]
        public System.Nullable<float> MayValue { get; set; } = null;
        

        [JsonProperty("june_value")]
        public System.Nullable<float> JuneValue { get; set; } = null;
        

        [JsonProperty("july_value")]
        public System.Nullable<float> JulyValue { get; set; } = null;
        

        [JsonProperty("august_value")]
        public System.Nullable<float> AugustValue { get; set; } = null;
        

        [JsonProperty("september_value")]
        public System.Nullable<float> SeptemberValue { get; set; } = null;
        

        [JsonProperty("october_value")]
        public System.Nullable<float> OctoberValue { get; set; } = null;
        

        [JsonProperty("november_value")]
        public System.Nullable<float> NovemberValue { get; set; } = null;
        

        [JsonProperty("december_value")]
        public System.Nullable<float> DecemberValue { get; set; } = null;
    }
}