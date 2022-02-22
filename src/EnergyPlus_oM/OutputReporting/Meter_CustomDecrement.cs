using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Used to allow users to combine specific variables and/or meters into \"custom\" met" +
                 "er configurations. To access these meters by name, one must first run a simulati" +
                 "on to generate the RDD/MDD files and names.")]
    [JsonObject("Meter:CustomDecrement")]
    public class Meter_CustomDecrement : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("resource_type")]
        public Meter_CustomDecrement_ResourceType ResourceType { get; set; } = (Meter_CustomDecrement_ResourceType)Enum.Parse(typeof(Meter_CustomDecrement_ResourceType), "Coal");
        

        [JsonProperty("source_meter_name")]
        public string SourceMeterName { get; set; } = "";
        

        [JsonProperty("variable_details")]
        public string VariableDetails { get; set; } = "";
    }
}