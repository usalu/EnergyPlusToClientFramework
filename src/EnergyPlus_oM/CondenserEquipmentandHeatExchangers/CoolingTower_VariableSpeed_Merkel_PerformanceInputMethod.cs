using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum CoolingTower_VariableSpeed_Merkel_PerformanceInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NominalCapacity")]
        NominalCapacity = 1,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
}