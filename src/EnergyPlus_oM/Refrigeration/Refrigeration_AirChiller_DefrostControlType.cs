using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_AirChiller_DefrostControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("TemperatureTermination")]
        TemperatureTermination = 1,
        
        [JsonProperty("TimeSchedule")]
        TimeSchedule = 2,
    }
}