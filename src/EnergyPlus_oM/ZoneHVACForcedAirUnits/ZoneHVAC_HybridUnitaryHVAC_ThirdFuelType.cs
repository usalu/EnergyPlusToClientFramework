using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_HybridUnitaryHVAC_ThirdFuelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coal")]
        Coal = 1,
        
        [JsonProperty("Diesel")]
        Diesel = 2,
        
        [JsonProperty("DistrictCooling")]
        DistrictCooling = 3,
        
        [JsonProperty("DistrictHeating")]
        DistrictHeating = 4,
        
        [JsonProperty("Electricity")]
        Electricity = 5,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 6,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 7,
        
        [JsonProperty("Gasoline")]
        Gasoline = 8,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 9,
        
        [JsonProperty("None")]
        None = 10,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 11,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 12,
        
        [JsonProperty("Propane")]
        Propane = 13,
        
        [JsonProperty("Steam")]
        Steam = 14,
    }
}