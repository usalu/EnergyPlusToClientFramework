using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description("quad-tuples of inlet, outlet, control, and zone nodes for multiple different outd" +
                 "oor air systems attached to same collector")]
    [JsonObject("SolarCollector:UnglazedTranspired:Multisystem")]
    public class SolarCollector_UnglazedTranspired_Multisystem : BHoMObject
    {
        

        [Description("Enter the name of a SolarCollector:UnglazedTranspired object.")]
        [JsonProperty("solar_collector_name")]
        public string SolarCollectorName { get; set; } = "";
        

        [JsonProperty("systems")]
        public string Systems { get; set; } = "";
    }
}