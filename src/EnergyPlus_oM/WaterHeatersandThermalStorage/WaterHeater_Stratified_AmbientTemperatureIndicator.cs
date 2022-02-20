using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_Stratified_AmbientTemperatureIndicator
    {
        
        [JsonProperty("Outdoors")]
        Outdoors = 0,
        
        [JsonProperty("Schedule")]
        Schedule = 1,
        
        [JsonProperty("Zone")]
        Zone = 2,
    }
}