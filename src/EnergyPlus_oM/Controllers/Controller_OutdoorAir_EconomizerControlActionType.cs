using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_OutdoorAir_EconomizerControlActionType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MinimumFlowWithBypass")]
        MinimumFlowWithBypass = 1,
        
        [JsonProperty("ModulateFlow")]
        ModulateFlow = 2,
    }
}