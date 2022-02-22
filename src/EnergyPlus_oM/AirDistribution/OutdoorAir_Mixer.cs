using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("Outdoor air mixer. Node names cannot be duplicated within a single OutdoorAir:Mix" +
                 "er object or across all outdoor air mixers.")]
    [JsonObject("OutdoorAir:Mixer")]
    public class OutdoorAir_Mixer : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Name of Mixed Air Node")]
        [JsonProperty("mixed_air_node_name")]
        public string MixedAirNodeName { get; set; } = "";
        

        [Description("Name of Outdoor Air Stream Node")]
        [JsonProperty("outdoor_air_stream_node_name")]
        public string OutdoorAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Relief Air Stream Node")]
        [JsonProperty("relief_air_stream_node_name")]
        public string ReliefAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Return Air Stream Node")]
        [JsonProperty("return_air_stream_node_name")]
        public string ReturnAirStreamNodeName { get; set; } = "";
    }
}