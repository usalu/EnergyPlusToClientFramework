using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType
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
        
        [JsonProperty("None")]
        None = 5,
        
        [JsonProperty("TwoSpeedDX")]
        TwoSpeedDX = 6,
        
        [JsonProperty("TwoStageDX")]
        TwoStageDX = 7,
        
        [JsonProperty("TwoStageHumidityControlDX")]
        TwoStageHumidityControlDX = 8,
    }
}