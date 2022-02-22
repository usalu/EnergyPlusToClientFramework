using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("A supply path can only contain AirLoopHVAC:ZoneSplitter and AirLoopHVAC:SupplyPle" +
                 "num objects which may be in series or parallel.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_SupplyPath : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("supply_air_path_inlet_node_name")]
        public string SupplyAirPathInletNodeName { get; set; } = "";
        

        [JsonProperty("components")]
        public string Components { get; set; } = "";
    }
}