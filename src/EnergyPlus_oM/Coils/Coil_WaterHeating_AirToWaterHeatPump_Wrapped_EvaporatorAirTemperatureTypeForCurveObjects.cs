using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_WaterHeating_AirToWaterHeatPump_Wrapped_EvaporatorAirTemperatureTypeForCurveObjects
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DryBulbTemperature")]
        DryBulbTemperature = 1,
        
        [JsonProperty("WetBulbTemperature")]
        WetBulbTemperature = 2,
    }
}