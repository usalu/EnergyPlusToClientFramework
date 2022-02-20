using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_VAV_DamperHeatingAction
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Normal")]
        Normal = 1,
        
        [JsonProperty("Reverse")]
        Reverse = 2,
    }
}