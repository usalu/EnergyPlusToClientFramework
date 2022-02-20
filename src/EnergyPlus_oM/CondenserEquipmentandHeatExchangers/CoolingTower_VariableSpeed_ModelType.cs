using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum CoolingTower_VariableSpeed_ModelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolToolsCrossFlow")]
        CoolToolsCrossFlow = 1,
        
        [JsonProperty("CoolToolsUserDefined")]
        CoolToolsUserDefined = 2,
        
        [JsonProperty("YorkCalc")]
        YorkCalc = 3,
        
        [JsonProperty("YorkCalcUserDefined")]
        YorkCalcUserDefined = 4,
    }
}