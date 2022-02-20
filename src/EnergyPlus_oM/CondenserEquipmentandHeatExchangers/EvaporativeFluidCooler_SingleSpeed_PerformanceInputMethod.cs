using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum EvaporativeFluidCooler_SingleSpeed_PerformanceInputMethod
    {
        
        [JsonProperty("StandardDesignCapacity")]
        StandardDesignCapacity = 0,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 1,
        
        [JsonProperty("UserSpecifiedDesignCapacity")]
        UserSpecifiedDesignCapacity = 2,
    }
}