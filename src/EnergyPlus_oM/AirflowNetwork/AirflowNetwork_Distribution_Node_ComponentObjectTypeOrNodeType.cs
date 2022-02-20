using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_Distribution_Node_ComponentObjectTypeOrNodeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirLoopHVAC:OutdoorAirSystem")]
        AirLoopHVACOutdoorAirSystem = 1,
        
        [JsonProperty("AirLoopHVAC:ZoneMixer")]
        AirLoopHVACZoneMixer = 2,
        
        [JsonProperty("AirLoopHVAC:ZoneSplitter")]
        AirLoopHVACZoneSplitter = 3,
        
        [JsonProperty("OAMixerOutdoorAirStreamNode")]
        OAMixerOutdoorAirStreamNode = 4,
        
        [JsonProperty("Other")]
        Other = 5,
        
        [JsonProperty("OutdoorAir:Node")]
        OutdoorAirNode = 6,
        
        [JsonProperty("OutdoorAir:NodeList")]
        OutdoorAirNodeList = 7,
    }
}