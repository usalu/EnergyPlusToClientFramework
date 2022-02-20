using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Plant_CoincidentSizingFactorMode
    {
        
        [JsonProperty("GlobalCoolingSizingFactor")]
        GlobalCoolingSizingFactor = 0,
        
        [JsonProperty("GlobalHeatingSizingFactor")]
        GlobalHeatingSizingFactor = 1,
        
        [JsonProperty("LoopComponentSizingFactor")]
        LoopComponentSizingFactor = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
}