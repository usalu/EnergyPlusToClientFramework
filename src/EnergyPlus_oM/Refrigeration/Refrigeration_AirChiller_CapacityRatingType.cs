using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_AirChiller_CapacityRatingType
    {
        
        [JsonProperty("CapacityTotalSpecificConditions")]
        CapacityTotalSpecificConditions = 0,
        
        [JsonProperty("EuropeanSC1NominalWet")]
        EuropeanSC1NominalWet = 1,
        
        [JsonProperty("EuropeanSC1Standard")]
        EuropeanSC1Standard = 2,
        
        [JsonProperty("EuropeanSC2NominalWet")]
        EuropeanSC2NominalWet = 3,
        
        [JsonProperty("EuropeanSC2Standard")]
        EuropeanSC2Standard = 4,
        
        [JsonProperty("EuropeanSC3NominalWet")]
        EuropeanSC3NominalWet = 5,
        
        [JsonProperty("EuropeanSC3Standard")]
        EuropeanSC3Standard = 6,
        
        [JsonProperty("EuropeanSC4NominalWet")]
        EuropeanSC4NominalWet = 7,
        
        [JsonProperty("EuropeanSC4Standard")]
        EuropeanSC4Standard = 8,
        
        [JsonProperty("EuropeanSC5NominalWet")]
        EuropeanSC5NominalWet = 9,
        
        [JsonProperty("EuropeanSC5Standard")]
        EuropeanSC5Standard = 10,
        
        [JsonProperty("FixedLinear")]
        FixedLinear = 11,
        
        [JsonProperty("UnitLoadFactorSensibleOnly")]
        UnitLoadFactorSensibleOnly = 12,
    }
}