using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Output from EnergyPlus can be written to JSON format files.")]
    [JsonObject("Output:JSON")]
    public class Output_JSON : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("option_type")]
        public Output_JSON_OptionType OptionType { get; set; } = (Output_JSON_OptionType)Enum.Parse(typeof(Output_JSON_OptionType), "TimeSeries");
        

        [JsonProperty("output_json")]
        public EmptyNoYes OutputJson { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_cbor")]
        public EmptyNoYes OutputCbor { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("output_messagepack")]
        public EmptyNoYes OutputMessagepack { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
}