using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    public enum Schedule_Day_List_InterpolateToTimestep
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Average")]
        Average = 1,
        
        [JsonProperty("Linear")]
        Linear = 2,
        
        [JsonProperty("No")]
        No = 3,
    }
}