using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("Mix N inlet air streams into one (currently 500 per air loop, but extensible). No" +
                 "de names cannot be duplicated within a single zone mixer (AirLoopHVAC:ZoneMixer)" +
                 " list.")]
    [JsonObject("AirLoopHVAC:ZoneMixer")]
    public class AirLoopHVAC_ZoneMixer : BHoMObject
    {
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("nodes")]
        public string Nodes { get; set; } = "";
    }
}