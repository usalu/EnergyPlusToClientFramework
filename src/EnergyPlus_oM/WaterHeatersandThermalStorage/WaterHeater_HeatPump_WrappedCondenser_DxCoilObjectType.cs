using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_WrappedCondenser_DxCoilObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coil:WaterHeating:AirToWaterHeatPump:Wrapped")]
        CoilWaterHeatingAirToWaterHeatPumpWrapped = 1,
    }
}