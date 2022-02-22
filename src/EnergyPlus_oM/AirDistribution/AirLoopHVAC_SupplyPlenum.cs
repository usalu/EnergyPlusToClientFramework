using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("Connects 1 zone inlet air stream, through zone supply plenum, to one or more outl" +
                 "ets. Node names cannot be duplicated within a single supply plenum list.")]
    [JsonObject("AirLoopHVAC:SupplyPlenum")]
    public class AirLoopHVAC_SupplyPlenum : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("zone_node_name")]
        public string ZoneNodeName { get; set; } = "";
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("nodes")]
        public string Nodes { get; set; } = "";
    }
}