using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    public enum Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coupled")]
        Coupled = 1,
        
        [JsonProperty("Decoupled")]
        Decoupled = 2,
    }
}