using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
{
    public enum Table_Lookup_NormalizationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AutomaticWithDivisor")]
        AutomaticWithDivisor = 1,
        
        [JsonProperty("DivisorOnly")]
        DivisorOnly = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
}