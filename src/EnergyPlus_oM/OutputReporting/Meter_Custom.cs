using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"Used to allow users to combine specific variables and/or meters into ""custom"" meter configurations. To access these meters by name, one must first run a simulation to generate the RDD/MDD files and names. A Meter:Custom cannot reference another Meter:Custom.")]
    [JsonObject("Meter:Custom")]
    public class Meter_Custom : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("resource_type")]
        public Meter_Custom_ResourceType ResourceType { get; set; } = (Meter_Custom_ResourceType)Enum.Parse(typeof(Meter_Custom_ResourceType), "Coal");
        

        [JsonProperty("variable_details")]
        public string VariableDetails { get; set; } = "";
    }
}