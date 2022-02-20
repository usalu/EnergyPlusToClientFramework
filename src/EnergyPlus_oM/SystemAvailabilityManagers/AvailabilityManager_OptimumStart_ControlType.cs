using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    public enum AvailabilityManager_OptimumStart_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ControlZone")]
        ControlZone = 1,
        
        [JsonProperty("MaximumofZoneList")]
        MaximumofZoneList = 2,
        
        [JsonProperty("StayOff")]
        StayOff = 3,
    }
}