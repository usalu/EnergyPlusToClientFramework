using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
{
    public enum Table_Lookup_OutputUnitType
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