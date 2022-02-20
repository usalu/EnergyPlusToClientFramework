using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_NightCycleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 2,
        
        [JsonProperty("StayOff")]
        StayOff = 3,
    }
}