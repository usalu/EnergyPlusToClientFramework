using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Qualify_QualifyType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Maximum")]
        Maximum = 1,
        
        [JsonProperty("Minimum")]
        Minimum = 2,
    }
}