using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Meter_Custom_ResourceType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("DistrictCooling")]
        DistrictCooling = 2,
        
        [JsonProperty("DistrictHeating")]
        DistrictHeating = 3,
        
        [JsonProperty("Electricity")]
        Electricity = 4,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 5,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 6,
        
        [JsonProperty("Gasoline")]
        Gasoline = 7,
        
        [JsonProperty("Generic")]
        Generic = 8,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 9,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 10,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 11,
        
        [JsonProperty("Propane")]
        Propane = 12,
        
        [JsonProperty("Steam")]
        Steam = 13,
        
        [JsonProperty("Water")]
        Water = 14,
    }
}