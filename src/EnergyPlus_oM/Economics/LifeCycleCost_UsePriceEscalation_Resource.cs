using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_UsePriceEscalation_Resource
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("Electricity")]
        Electricity = 2,
        
        [JsonProperty("ElectricityNet")]
        ElectricityNet = 3,
        
        [JsonProperty("ElectricityProduced")]
        ElectricityProduced = 4,
        
        [JsonProperty("ElectricityPurchased")]
        ElectricityPurchased = 5,
        
        [JsonProperty("ElectricitySurplusSold")]
        ElectricitySurplusSold = 6,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 7,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 8,
        
        [JsonProperty("Gasoline")]
        Gasoline = 9,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 10,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 11,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 12,
        
        [JsonProperty("Propane")]
        Propane = 13,
        
        [JsonProperty("Steam")]
        Steam = 14,
        
        [JsonProperty("Water")]
        Water = 15,
    }
}