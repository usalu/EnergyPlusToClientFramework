using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    public enum AvailabilityManager_NightCycle_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnAnyCoolingOrHeatingZone")]
        CycleOnAnyCoolingOrHeatingZone = 2,
        
        [JsonProperty("CycleOnAnyCoolingZone")]
        CycleOnAnyCoolingZone = 3,
        
        [JsonProperty("CycleOnAnyHeatingZone")]
        CycleOnAnyHeatingZone = 4,
        
        [JsonProperty("CycleOnAnyHeatingZoneFansOnly")]
        CycleOnAnyHeatingZoneFansOnly = 5,
        
        [JsonProperty("CycleOnAnyZoneFansOnly")]
        CycleOnAnyZoneFansOnly = 6,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 7,
        
        [JsonProperty("StayOff")]
        StayOff = 8,
    }
}