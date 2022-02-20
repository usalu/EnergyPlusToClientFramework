using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneVentilation_DesignFlowRate_VentilationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Balanced")]
        Balanced = 1,
        
        [JsonProperty("Exhaust")]
        Exhaust = 2,
        
        [JsonProperty("Intake")]
        Intake = 3,
        
        [JsonProperty("Natural")]
        Natural = 4,
    }
}