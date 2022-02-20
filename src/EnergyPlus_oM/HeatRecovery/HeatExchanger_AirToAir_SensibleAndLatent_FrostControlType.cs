using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    public enum HeatExchanger_AirToAir_SensibleAndLatent_FrostControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ExhaustAirRecirculation")]
        ExhaustAirRecirculation = 1,
        
        [JsonProperty("ExhaustOnly")]
        ExhaustOnly = 2,
        
        [JsonProperty("MinimumExhaustTemperature")]
        MinimumExhaustTemperature = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
}