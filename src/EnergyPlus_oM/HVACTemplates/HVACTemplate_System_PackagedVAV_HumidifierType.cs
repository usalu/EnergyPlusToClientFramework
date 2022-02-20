using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_PackagedVAV_HumidifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ElectricSteam")]
        ElectricSteam = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
}