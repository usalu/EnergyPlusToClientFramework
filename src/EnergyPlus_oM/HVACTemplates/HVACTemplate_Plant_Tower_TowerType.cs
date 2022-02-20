using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Tower_TowerType
    {
        
        [JsonProperty("SingleSpeed")]
        SingleSpeed = 0,
        
        [JsonProperty("TwoSpeed")]
        TwoSpeed = 1,
    }
}