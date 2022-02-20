using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_SystemConfigurationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DualFanConstantVolume")]
        DualFanConstantVolume = 1,
        
        [JsonProperty("DualFanVariableVolume")]
        DualFanVariableVolume = 2,
        
        [JsonProperty("SingleFanConstantVolume")]
        SingleFanConstantVolume = 3,
        
        [JsonProperty("SingleFanVariableVolume")]
        SingleFanVariableVolume = 4,
    }
}