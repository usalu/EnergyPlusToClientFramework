using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum Building_Terrain
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("City")]
        City = 1,
        
        [JsonProperty("Country")]
        Country = 2,
        
        [JsonProperty("Ocean")]
        Ocean = 3,
        
        [JsonProperty("Suburbs")]
        Suburbs = 4,
        
        [JsonProperty("Urban")]
        Urban = 5,
    }
}