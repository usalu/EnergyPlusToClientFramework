using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Case_AntiSweatHeaterControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("DewpointMethod")]
        DewpointMethod = 2,
        
        [JsonProperty("HeatBalanceMethod")]
        HeatBalanceMethod = 3,
        
        [JsonProperty("Linear")]
        Linear = 4,
        
        [JsonProperty("None")]
        None = 5,
    }
}