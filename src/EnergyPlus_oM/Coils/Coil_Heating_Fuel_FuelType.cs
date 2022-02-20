using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_Fuel_FuelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coal")]
        Coal = 1,
        
        [JsonProperty("Diesel")]
        Diesel = 2,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 3,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 4,
        
        [JsonProperty("Gasoline")]
        Gasoline = 5,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 6,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 7,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 8,
        
        [JsonProperty("Propane")]
        Propane = 9,
    }
}