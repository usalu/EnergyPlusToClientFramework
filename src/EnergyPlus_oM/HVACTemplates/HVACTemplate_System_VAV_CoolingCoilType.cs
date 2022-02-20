using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_VAV_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
    }
}