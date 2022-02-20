using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_OutdoorAir_HeatRecoveryBypassControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BypassWhenOAFlowGreaterThanMinimum")]
        BypassWhenOAFlowGreaterThanMinimum = 1,
        
        [JsonProperty("BypassWhenWithinEconomizerLimits")]
        BypassWhenWithinEconomizerLimits = 2,
    }
}