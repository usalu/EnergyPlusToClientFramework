using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_PTAC_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
    }
}