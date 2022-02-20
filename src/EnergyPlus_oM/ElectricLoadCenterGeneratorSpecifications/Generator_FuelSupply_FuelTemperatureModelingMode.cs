using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelSupply_FuelTemperatureModelingMode
    {
        
        [JsonProperty("Scheduled")]
        Scheduled = 0,
        
        [JsonProperty("TemperatureFromAirNode")]
        TemperatureFromAirNode = 1,
    }
}