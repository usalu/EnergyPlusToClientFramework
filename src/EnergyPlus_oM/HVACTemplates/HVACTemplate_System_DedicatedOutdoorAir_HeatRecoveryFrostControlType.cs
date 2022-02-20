using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType
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