using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    public enum AirConditioner_VariableRefrigerantFlow_HeatingPerformanceCurveOutdoorTemperatureType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DryBulbTemperature")]
        DryBulbTemperature = 1,
        
        [JsonProperty("WetBulbTemperature")]
        WetBulbTemperature = 2,
    }
}