using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_PumpedCondenser_TankObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("WaterHeater:Mixed")]
        WaterHeaterMixed = 1,
        
        [JsonProperty("WaterHeater:Stratified")]
        WaterHeaterStratified = 2,
    }
}