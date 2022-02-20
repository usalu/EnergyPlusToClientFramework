using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_VAV_NightCycleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnAnyZoneFansOnly")]
        CycleOnAnyZoneFansOnly = 2,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 3,
        
        [JsonProperty("StayOff")]
        StayOff = 4,
    }
}