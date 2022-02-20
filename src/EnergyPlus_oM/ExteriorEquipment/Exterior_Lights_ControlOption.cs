using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExteriorEquipment
{
    public enum Exterior_Lights_ControlOption
    {
        
        [JsonProperty("AstronomicalClock")]
        AstronomicalClock = 0,
        
        [JsonProperty("ScheduleNameOnly")]
        ScheduleNameOnly = 1,
    }
}