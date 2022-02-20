using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_PackagedVAV_SizingOption
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coincident")]
        Coincident = 1,
        
        [JsonProperty("NonCoincident")]
        NonCoincident = 2,
    }
}