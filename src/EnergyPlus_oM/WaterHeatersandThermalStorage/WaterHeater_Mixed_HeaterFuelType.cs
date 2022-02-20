using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_Mixed_HeaterFuelType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("DistrictHeating")]
        DistrictHeating = 2,
        
        [JsonProperty("Electricity")]
        Electricity = 3,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 4,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 5,
        
        [JsonProperty("Gasoline")]
        Gasoline = 6,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 7,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 8,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 9,
        
        [JsonProperty("Propane")]
        Propane = 10,
        
        [JsonProperty("Steam")]
        Steam = 11,
    }
}