using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Meter_Cumulative_ReportingFrequency
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Annual")]
        Annual = 1,
        
        [JsonProperty("Daily")]
        Daily = 2,
        
        [JsonProperty("Detailed")]
        Detailed = 3,
        
        [JsonProperty("Environment")]
        Environment = 4,
        
        [JsonProperty("Hourly")]
        Hourly = 5,
        
        [JsonProperty("Monthly")]
        Monthly = 6,
        
        [JsonProperty("RunPeriod")]
        RunPeriod = 7,
        
        [JsonProperty("Timestep")]
        Timestep = 8,
    }
}