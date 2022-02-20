using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneRefrigerationDoorMixing_DoorProtectionType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCurtain")]
        AirCurtain = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("StripCurtain")]
        StripCurtain = 3,
    }
}