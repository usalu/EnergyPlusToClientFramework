using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_Stratified_InletMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Fixed")]
        Fixed = 1,
        
        [JsonProperty("Seeking")]
        Seeking = 2,
    }
}