using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_Unitary_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheatDesuperheater")]
        CoolReheatDesuperheater = 1,
        
        [JsonProperty("CoolReheatHeatingCoil")]
        CoolReheatHeatingCoil = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
}