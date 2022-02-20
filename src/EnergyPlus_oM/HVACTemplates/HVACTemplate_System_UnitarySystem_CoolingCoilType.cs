using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitarySystem_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [JsonProperty("HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
        
        [JsonProperty("HeatExchangerAssistedDX")]
        HeatExchangerAssistedDX = 4,
        
        [JsonProperty("MultiSpeedDX")]
        MultiSpeedDX = 5,
        
        [JsonProperty("None")]
        None = 6,
        
        [JsonProperty("SingleSpeedDX")]
        SingleSpeedDX = 7,
        
        [JsonProperty("SingleSpeedDXWaterCooled")]
        SingleSpeedDXWaterCooled = 8,
        
        [JsonProperty("TwoSpeedDX")]
        TwoSpeedDX = 9,
        
        [JsonProperty("TwoStageDX")]
        TwoStageDX = 10,
        
        [JsonProperty("TwoStageHumidityControlDX")]
        TwoStageHumidityControlDX = 11,
    }
}