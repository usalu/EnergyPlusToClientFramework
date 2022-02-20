using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Tower_ObjectReference_TemplatePlantLoopType
    {
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 0,
        
        [JsonProperty("MixedWater")]
        MixedWater = 1,
    }
}