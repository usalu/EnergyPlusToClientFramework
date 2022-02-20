using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_ChilledWaterLoop_PumpControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Continuous")]
        Continuous = 1,
        
        [JsonProperty("Intermittent")]
        Intermittent = 2,
    }
}