using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    public enum Curve_Linear_InputUnitTypeForX
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 1,
        
        [JsonProperty("Distance")]
        Distance = 2,
        
        [JsonProperty("MassFlow")]
        MassFlow = 3,
        
        [JsonProperty("Power")]
        Power = 4,
        
        [JsonProperty("Pressure")]
        Pressure = 5,
        
        [JsonProperty("Temperature")]
        Temperature = 6,
        
        [JsonProperty("VolumetricFlow")]
        VolumetricFlow = 7,
    }
}