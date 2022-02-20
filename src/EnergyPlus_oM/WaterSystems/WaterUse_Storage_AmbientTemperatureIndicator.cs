using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    public enum WaterUse_Storage_AmbientTemperatureIndicator
    {
        
        [JsonProperty("Outdoors")]
        Outdoors = 0,
        
        [JsonProperty("Schedule")]
        Schedule = 1,
        
        [JsonProperty("Zone")]
        Zone = 2,
    }
}