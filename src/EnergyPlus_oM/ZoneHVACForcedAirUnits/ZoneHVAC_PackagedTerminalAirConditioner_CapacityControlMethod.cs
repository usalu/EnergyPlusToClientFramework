using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_PackagedTerminalAirConditioner_CapacityControlMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("SingleZoneVAV")]
        SingleZoneVAV = 2,
    }
}