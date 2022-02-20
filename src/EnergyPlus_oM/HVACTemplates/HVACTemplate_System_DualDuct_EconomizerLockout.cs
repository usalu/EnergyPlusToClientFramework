using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_EconomizerLockout
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NoLockout")]
        NoLockout = 1,
    }
}