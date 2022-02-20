using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum Chiller_EngineDriven_FuelType
    {
        
        [JsonProperty("Diesel")]
        Diesel = 0,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 1,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 2,
        
        [JsonProperty("Gasoline")]
        Gasoline = 3,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 4,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 5,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 6,
        
        [JsonProperty("Propane")]
        Propane = 7,
    }
}