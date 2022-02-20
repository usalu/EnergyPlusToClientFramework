using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Zone_HeatingDesignAirFlowMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DesignDay")]
        DesignDay = 1,
        
        [JsonProperty("DesignDayWithLimit")]
        DesignDayWithLimit = 2,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 3,
    }
}