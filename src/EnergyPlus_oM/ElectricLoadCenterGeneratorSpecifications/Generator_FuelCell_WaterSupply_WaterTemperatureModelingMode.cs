using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_WaterSupply_WaterTemperatureModelingMode
    {
        
        [JsonProperty("MainsWaterTemperature")]
        MainsWaterTemperature = 0,
        
        [JsonProperty("TemperatureFromAirNode")]
        TemperatureFromAirNode = 1,
        
        [JsonProperty("TemperatureFromSchedule")]
        TemperatureFromSchedule = 2,
        
        [JsonProperty("TemperatureFromWaterNode")]
        TemperatureFromWaterNode = 3,
    }
}