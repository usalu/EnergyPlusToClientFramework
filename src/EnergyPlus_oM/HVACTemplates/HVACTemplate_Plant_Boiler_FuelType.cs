using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Boiler_FuelType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("Electricity")]
        Electricity = 2,
        
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