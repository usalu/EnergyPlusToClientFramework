using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum PerformancePrecisionTradeoffs_ZoneRadiantExchangeAlgorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CarrollMRT")]
        CarrollMRT = 1,
        
        [JsonProperty("ScriptF")]
        ScriptF = 2,
    }
}