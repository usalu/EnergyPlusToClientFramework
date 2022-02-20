using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    public enum Curve_CubicLinear_InputUnitTypeForY
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 1,
        
        [JsonProperty("Temperature")]
        Temperature = 2,
    }
}