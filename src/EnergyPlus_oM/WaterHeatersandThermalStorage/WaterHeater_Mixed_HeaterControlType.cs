using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_Mixed_HeaterControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Cycle")]
        Cycle = 1,
        
        [JsonProperty("Modulate")]
        Modulate = 2,
    }
}