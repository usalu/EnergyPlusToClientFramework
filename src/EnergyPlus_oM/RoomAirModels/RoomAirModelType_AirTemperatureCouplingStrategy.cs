using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAirModelType_AirTemperatureCouplingStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Direct")]
        Direct = 1,
        
        [JsonProperty("Indirect")]
        Indirect = 2,
    }
}