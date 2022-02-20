using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
{
    public enum Table_IndependentVariable_InterpolationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Cubic")]
        Cubic = 1,
        
        [JsonProperty("Linear")]
        Linear = 2,
    }
}