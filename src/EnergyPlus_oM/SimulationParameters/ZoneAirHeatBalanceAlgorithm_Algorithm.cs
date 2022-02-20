using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ZoneAirHeatBalanceAlgorithm_Algorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AnalyticalSolution")]
        AnalyticalSolution = 1,
        
        [JsonProperty("EulerMethod")]
        EulerMethod = 2,
        
        [JsonProperty("ThirdOrderBackwardDifference")]
        ThirdOrderBackwardDifference = 3,
    }
}