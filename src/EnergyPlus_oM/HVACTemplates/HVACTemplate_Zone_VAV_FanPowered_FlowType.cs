using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_VAV_FanPowered_FlowType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Parallel")]
        Parallel = 1,
        
        [JsonProperty("ParallelFromPlenum")]
        ParallelFromPlenum = 2,
        
        [JsonProperty("Series")]
        Series = 3,
        
        [JsonProperty("SeriesFromPlenum")]
        SeriesFromPlenum = 4,
    }
}