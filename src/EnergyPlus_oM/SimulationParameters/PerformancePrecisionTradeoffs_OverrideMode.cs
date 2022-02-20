using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum PerformancePrecisionTradeoffs_OverrideMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Advanced")]
        Advanced = 1,
        
        [JsonProperty("Mode01")]
        Mode01 = 2,
        
        [JsonProperty("Mode02")]
        Mode02 = 3,
        
        [JsonProperty("Mode03")]
        Mode03 = 4,
        
        [JsonProperty("Mode04")]
        Mode04 = 5,
        
        [JsonProperty("Mode05")]
        Mode05 = 6,
        
        [JsonProperty("Mode06")]
        Mode06 = 7,
        
        [JsonProperty("Mode07")]
        Mode07 = 8,
        
        [JsonProperty("Normal")]
        Normal = 9,
    }
}