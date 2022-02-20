using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_VRF_DefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
}