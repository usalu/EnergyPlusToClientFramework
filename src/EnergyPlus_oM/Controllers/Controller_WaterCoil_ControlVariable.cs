using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_WaterCoil_ControlVariable
    {
        
        [JsonProperty("HumidityRatio")]
        HumidityRatio = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
        
        [JsonProperty("TemperatureAndHumidityRatio")]
        TemperatureAndHumidityRatio = 2,
    }
}