using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_InternalCombustionEngine_FuelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 2,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 3,
        
        [JsonProperty("Gasoline")]
        Gasoline = 4,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 5,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 6,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 7,
        
        [JsonProperty("Propane")]
        Propane = 8,
    }
}