using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_EnvironmentalImpactFactors_ReportingFrequency
    {
        
        [JsonProperty("Annual")]
        Annual = 0,
        
        [JsonProperty("Daily")]
        Daily = 1,
        
        [JsonProperty("Environment")]
        Environment = 2,
        
        [JsonProperty("Hourly")]
        Hourly = 3,
        
        [JsonProperty("Monthly")]
        Monthly = 4,
        
        [JsonProperty("RunPeriod")]
        RunPeriod = 5,
        
        [JsonProperty("Timestep")]
        Timestep = 6,
    }
}