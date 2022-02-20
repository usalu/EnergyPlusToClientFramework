using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_Water_PerformanceInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NominalCapacity")]
        NominalCapacity = 1,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
}