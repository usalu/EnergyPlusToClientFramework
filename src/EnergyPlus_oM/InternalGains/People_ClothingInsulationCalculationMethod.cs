using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum People_ClothingInsulationCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CalculationMethodSchedule")]
        CalculationMethodSchedule = 1,
        
        [JsonProperty("ClothingInsulationSchedule")]
        ClothingInsulationSchedule = 2,
        
        [JsonProperty("DynamicClothingModelASHRAE55")]
        DynamicClothingModelASHRAE55 = 3,
    }
}