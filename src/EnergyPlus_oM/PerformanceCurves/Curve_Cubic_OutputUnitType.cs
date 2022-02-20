using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    public enum Curve_Cubic_OutputUnitType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Capacity")]
        Capacity = 1,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 2,
        
        [JsonProperty("Power")]
        Power = 3,
        
        [JsonProperty("Pressure")]
        Pressure = 4,
        
        [JsonProperty("Temperature")]
        Temperature = 5,
    }
}