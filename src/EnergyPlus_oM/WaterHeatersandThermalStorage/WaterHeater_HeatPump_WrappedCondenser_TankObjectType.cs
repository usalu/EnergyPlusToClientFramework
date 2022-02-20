using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_WrappedCondenser_TankObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("WaterHeater:Stratified")]
        WaterHeaterStratified = 1,
    }
}