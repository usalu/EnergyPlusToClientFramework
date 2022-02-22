using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("Connects N zone inlet air streams, through zone return plenum, to outlet (current" +
                 "ly 500 per air loop) Node names cannot be duplicated within a single plenum list" +
                 ".")]
    [JsonObject("AirLoopHVAC:ReturnPlenum")]
    public class AirLoopHVAC_ReturnPlenum : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("zone_node_name")]
        public string ZoneNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("induced_air_outlet_node_or_nodelist_name")]
        public string InducedAirOutletNodeOrNodelistName { get; set; } = "";
        

        [JsonProperty("nodes")]
        public string Nodes { get; set; } = "";
    }
}