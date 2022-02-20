using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheatDesuperheater")]
        CoolReheatDesuperheater = 1,
        
        [JsonProperty("CoolReheatHeatingCoil")]
        CoolReheatHeatingCoil = 2,
        
        [JsonProperty("Multimode")]
        Multimode = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
}