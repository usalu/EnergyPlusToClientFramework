using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_PackagedVAV_MinimumOutdoorAirControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedMinimum")]
        FixedMinimum = 1,
        
        [JsonProperty("ProportionalMinimum")]
        ProportionalMinimum = 2,
    }
}