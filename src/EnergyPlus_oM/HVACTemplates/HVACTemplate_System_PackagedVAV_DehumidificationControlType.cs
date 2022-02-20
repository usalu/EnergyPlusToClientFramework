using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_PackagedVAV_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
}