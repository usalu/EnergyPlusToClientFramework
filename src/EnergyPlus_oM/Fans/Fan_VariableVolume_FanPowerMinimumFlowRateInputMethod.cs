using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    public enum Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedFlowRate")]
        FixedFlowRate = 1,
        
        [JsonProperty("Fraction")]
        Fraction = 2,
    }
}