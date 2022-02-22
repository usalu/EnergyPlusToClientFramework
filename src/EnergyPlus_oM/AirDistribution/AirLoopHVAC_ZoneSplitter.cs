using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("Split one air stream into N outlet streams (currently 500 per air loop, but exten" +
                 "sible). Node names cannot be duplicated within a single zone splitter (AirLoopHV" +
                 "AC:ZoneSplitter) list.")]
    [JsonObject("AirLoopHVAC:ZoneSplitter")]
    public class AirLoopHVAC_ZoneSplitter : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("nodes")]
        public string Nodes { get; set; } = "";
    }
}