using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_OutdoorAir_LockoutType
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