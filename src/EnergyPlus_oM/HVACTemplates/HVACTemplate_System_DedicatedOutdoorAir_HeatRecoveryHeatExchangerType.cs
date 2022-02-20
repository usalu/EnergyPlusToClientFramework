using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Plate")]
        Plate = 1,
        
        [JsonProperty("Rotary")]
        Rotary = 2,
    }
}