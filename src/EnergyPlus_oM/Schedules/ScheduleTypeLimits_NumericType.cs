using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    public enum ScheduleTypeLimits_NumericType
    {
        
        [JsonProperty("Continuous")]
        Continuous = 0,
        
        [JsonProperty("Discrete")]
        Discrete = 1,
    }
}