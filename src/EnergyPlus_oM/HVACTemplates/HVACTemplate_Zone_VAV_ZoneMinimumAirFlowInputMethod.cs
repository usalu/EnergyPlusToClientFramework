using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_VAV_ZoneMinimumAirFlowInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("FixedFlowRate")]
        FixedFlowRate = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
    }
}