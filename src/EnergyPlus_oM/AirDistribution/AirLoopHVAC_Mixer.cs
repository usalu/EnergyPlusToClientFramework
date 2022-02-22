using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description(@"Mix N inlet air streams from Relief Air Stream Node in OutdoorAir:Mixer objects served by AirLoopHVAC objects listed in AirLoopHVAC:DedicatedOutdoorAirSystem into one (currently 10 as default, but extensible). Node names cannot be duplicated within a single mixer list.")]
    [JsonObject("AirLoopHVAC:Mixer")]
    public class AirLoopHVAC_Mixer : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("nodes")]
        public string Nodes { get; set; } = "";
    }
}