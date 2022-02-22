using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("A supply path can only contain AirLoopHVAC:ZoneSplitter and AirLoopHVAC:SupplyPle" +
                 "num objects which may be in series or parallel.")]
    [JsonObject("AirLoopHVAC:SupplyPath")]
    public class AirLoopHVAC_SupplyPath : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("supply_air_path_inlet_node_name")]
        public string SupplyAirPathInletNodeName { get; set; } = "";
        

        [JsonProperty("components")]
        public string Components { get; set; } = "";
    }
}