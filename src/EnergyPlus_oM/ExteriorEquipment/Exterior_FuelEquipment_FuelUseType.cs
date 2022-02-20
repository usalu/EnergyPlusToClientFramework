using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExteriorEquipment
{
    public enum Exterior_FuelEquipment_FuelUseType
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
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 8,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 9,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 10,
        
        [JsonProperty("Propane")]
        Propane = 11,
        
        [JsonProperty("Steam")]
        Steam = 12,
        
        [JsonProperty("Water")]
        Water = 13,
    }
}