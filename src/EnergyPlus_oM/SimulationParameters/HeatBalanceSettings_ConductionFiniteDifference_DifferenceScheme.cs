using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CrankNicholsonSecondOrder")]
        CrankNicholsonSecondOrder = 1,
        
        [JsonProperty("FullyImplicitFirstOrder")]
        FullyImplicitFirstOrder = 2,
    }
}