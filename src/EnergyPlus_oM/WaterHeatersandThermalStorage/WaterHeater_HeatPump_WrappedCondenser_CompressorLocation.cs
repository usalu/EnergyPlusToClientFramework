using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_WrappedCondenser_CompressorLocation
    {
        
        [JsonProperty("Outdoors")]
        Outdoors = 0,
        
        [JsonProperty("Schedule")]
        Schedule = 1,
        
        [JsonProperty("Zone")]
        Zone = 2,
    }
}