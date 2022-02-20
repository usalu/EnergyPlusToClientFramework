using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Charge_Simple_CategoryVariableName
    {
        
        [JsonProperty("Adjustment")]
        Adjustment = 0,
        
        [JsonProperty("Basis")]
        Basis = 1,
        
        [JsonProperty("DemandCharges")]
        DemandCharges = 2,
        
        [JsonProperty("EnergyCharges")]
        EnergyCharges = 3,
        
        [JsonProperty("NotIncluded")]
        NotIncluded = 4,
        
        [JsonProperty("ServiceCharges")]
        ServiceCharges = 5,
        
        [JsonProperty("Subtotal")]
        Subtotal = 6,
        
        [JsonProperty("Surcharge")]
        Surcharge = 7,
        
        [JsonProperty("Taxes")]
        Taxes = 8,
        
        [JsonProperty("Total")]
        Total = 9,
    }
}