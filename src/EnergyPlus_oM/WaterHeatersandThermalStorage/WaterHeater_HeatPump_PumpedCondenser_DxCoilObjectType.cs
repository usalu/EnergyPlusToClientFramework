using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_PumpedCondenser_DxCoilObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coil:WaterHeating:AirToWaterHeatPump:Pumped")]
        CoilWaterHeatingAirToWaterHeatPumpPumped = 1,
        
        [JsonProperty("Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed")]
        CoilWaterHeatingAirToWaterHeatPumpVariableSpeed = 2,
        
        [JsonProperty("CoilSystem:IntegratedHeatPump:AirSource")]
        CoilSystemIntegratedHeatPumpAirSource = 3,
    }
}