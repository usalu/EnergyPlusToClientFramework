using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_OutdoorAir_MinimumLimitType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedMinimum")]
        FixedMinimum = 1,
        
        [JsonProperty("ProportionalMinimum")]
        ProportionalMinimum = 2,
    }
}