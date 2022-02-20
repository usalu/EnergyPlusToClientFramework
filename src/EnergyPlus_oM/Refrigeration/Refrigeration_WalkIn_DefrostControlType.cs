using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_WalkIn_DefrostControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("TemperatureTermination")]
        TemperatureTermination = 1,
        
        [JsonProperty("TimeSchedule")]
        TimeSchedule = 2,
    }
}