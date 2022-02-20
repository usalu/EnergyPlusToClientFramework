using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Pumps
{
    public enum HeaderedPumps_ConstantSpeed_DesignPowerSizingMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("PowerPerFlow")]
        PowerPerFlow = 1,
        
        [JsonProperty("PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
    }
}