using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_VAV_HeatAndCool_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
}