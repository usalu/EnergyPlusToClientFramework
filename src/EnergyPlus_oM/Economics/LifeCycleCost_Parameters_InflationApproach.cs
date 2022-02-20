using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_Parameters_InflationApproach
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantDollar")]
        ConstantDollar = 1,
        
        [JsonProperty("CurrentDollar")]
        CurrentDollar = 2,
    }
}