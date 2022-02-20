using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_AirChiller_DefrostType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotFluid")]
        HotFluid = 2,
        
        [JsonProperty("None")]
        None = 3,
        
        [JsonProperty("OffCycle")]
        OffCycle = 4,
    }
}