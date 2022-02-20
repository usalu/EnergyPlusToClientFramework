using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_ConstantVolume_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [JsonProperty("HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
}