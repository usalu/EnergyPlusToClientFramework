using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
}