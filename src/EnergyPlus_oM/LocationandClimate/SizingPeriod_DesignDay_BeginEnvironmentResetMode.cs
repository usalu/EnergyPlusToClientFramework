using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum SizingPeriod_DesignDay_BeginEnvironmentResetMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FullResetAtBeginEnvironment")]
        FullResetAtBeginEnvironment = 1,
        
        [JsonProperty("SuppressAllBeginEnvironmentResets")]
        SuppressAllBeginEnvironmentResets = 2,
    }
}