using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum Site_WaterMainsTemperature_CalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Correlation")]
        Correlation = 1,
        
        [JsonProperty("CorrelationFromWeatherFile")]
        CorrelationFromWeatherFile = 2,
        
        [JsonProperty("Schedule")]
        Schedule = 3,
    }
}