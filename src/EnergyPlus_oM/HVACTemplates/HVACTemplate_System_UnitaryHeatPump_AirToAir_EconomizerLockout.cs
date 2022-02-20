using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_EconomizerLockout
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LockoutWithCompressor")]
        LockoutWithCompressor = 1,
        
        [JsonProperty("LockoutWithHeating")]
        LockoutWithHeating = 2,
        
        [JsonProperty("NoLockout")]
        NoLockout = 3,
    }
}