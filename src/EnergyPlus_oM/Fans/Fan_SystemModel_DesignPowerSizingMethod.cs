using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    public enum Fan_SystemModel_DesignPowerSizingMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("PowerPerFlow")]
        PowerPerFlow = 1,
        
        [JsonProperty("PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
        
        [JsonProperty("TotalEfficiencyAndPressure")]
        TotalEfficiencyAndPressure = 3,
    }
}