using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum ElectricEquipment_ITE_AirCooled_AirInletConnectionType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AdjustedSupply")]
        AdjustedSupply = 1,
        
        [JsonProperty("RoomAirModel")]
        RoomAirModel = 2,
        
        [JsonProperty("ZoneAirNode")]
        ZoneAirNode = 3,
    }
}