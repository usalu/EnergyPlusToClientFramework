using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Variable_VariableType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Currency")]
        Currency = 1,
        
        [JsonProperty("Demand")]
        Demand = 2,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 3,
        
        [JsonProperty("Energy")]
        Energy = 4,
    }
}