using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Boiler_TemplatePlantLoopType
    {
        
        [JsonProperty("HotWater")]
        HotWater = 0,
        
        [JsonProperty("MixedWater")]
        MixedWater = 1,
    }
}