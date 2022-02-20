using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    public enum EnergyManagementSystem_MeteredOutputVariable_ResourceType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("CondensateWaterCollected")]
        CondensateWaterCollected = 1,
        
        [JsonProperty("Diesel")]
        Diesel = 2,
        
        [JsonProperty("DistrictCooling")]
        DistrictCooling = 3,
        
        [JsonProperty("DistrictHeating")]
        DistrictHeating = 4,
        
        [JsonProperty("Electricity")]
        Electricity = 5,
        
        [JsonProperty("ElectricityProducedOnSite")]
        ElectricityProducedOnSite = 6,
        
        [JsonProperty("EnergyTransfer")]
        EnergyTransfer = 7,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 8,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 9,
        
        [JsonProperty("Gasoline")]
        Gasoline = 10,
        
        [JsonProperty("MainsWaterSupply")]
        MainsWaterSupply = 11,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 12,
        
        [JsonProperty("OnSiteWaterProduced")]
        OnSiteWaterProduced = 13,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 14,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 15,
        
        [JsonProperty("Propane")]
        Propane = 16,
        
        [JsonProperty("RainWaterCollected")]
        RainWaterCollected = 17,
        
        [JsonProperty("SolarAirHeating")]
        SolarAirHeating = 18,
        
        [JsonProperty("SolarWaterHeating")]
        SolarWaterHeating = 19,
        
        [JsonProperty("Steam")]
        Steam = 20,
        
        [JsonProperty("WaterUse")]
        WaterUse = 21,
        
        [JsonProperty("WellWaterDrawn")]
        WellWaterDrawn = 22,
    }
}