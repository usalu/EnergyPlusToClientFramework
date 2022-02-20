using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Schedules_KeyField
    {
        
        [JsonProperty("Hourly")]
        Hourly = 0,
        
        [JsonProperty("Timestep")]
        Timestep = 1,
    }
}