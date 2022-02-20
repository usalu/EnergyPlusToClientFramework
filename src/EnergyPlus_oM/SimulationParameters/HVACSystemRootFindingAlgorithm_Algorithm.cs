using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum HVACSystemRootFindingAlgorithm_Algorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Alternation")]
        Alternation = 1,
        
        [JsonProperty("Bisection")]
        Bisection = 2,
        
        [JsonProperty("BisectionThenRegulaFalsi")]
        BisectionThenRegulaFalsi = 3,
        
        [JsonProperty("RegulaFalsi")]
        RegulaFalsi = 4,
        
        [JsonProperty("RegulaFalsiThenBisection")]
        RegulaFalsiThenBisection = 5,
    }
}