using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_Parameters_DiscountingConvention
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BeginningOfYear")]
        BeginningOfYear = 1,
        
        [JsonProperty("EndOfYear")]
        EndOfYear = 2,
        
        [JsonProperty("MidYear")]
        MidYear = 3,
    }
}