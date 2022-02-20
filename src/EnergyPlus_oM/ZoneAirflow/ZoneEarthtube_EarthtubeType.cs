using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneEarthtube_EarthtubeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Exhaust")]
        Exhaust = 1,
        
        [JsonProperty("Intake")]
        Intake = 2,
        
        [JsonProperty("Natural")]
        Natural = 3,
    }
}