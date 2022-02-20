using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
{
    public enum Table_IndependentVariable_UnitType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Angle")]
        Angle = 1,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 2,
        
        [JsonProperty("Distance")]
        Distance = 3,
        
        [JsonProperty("MassFlow")]
        MassFlow = 4,
        
        [JsonProperty("Power")]
        Power = 5,
        
        [JsonProperty("Temperature")]
        Temperature = 6,
        
        [JsonProperty("VolumetricFlow")]
        VolumetricFlow = 7,
    }
}