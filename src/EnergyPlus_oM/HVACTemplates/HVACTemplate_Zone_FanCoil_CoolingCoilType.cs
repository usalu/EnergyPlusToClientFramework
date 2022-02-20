using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_FanCoil_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [JsonProperty("HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
    }
}