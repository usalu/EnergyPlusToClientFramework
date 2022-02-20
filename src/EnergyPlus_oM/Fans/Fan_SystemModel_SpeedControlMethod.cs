using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    public enum Fan_SystemModel_SpeedControlMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Continuous")]
        Continuous = 1,
        
        [JsonProperty("Discrete")]
        Discrete = 2,
    }
}