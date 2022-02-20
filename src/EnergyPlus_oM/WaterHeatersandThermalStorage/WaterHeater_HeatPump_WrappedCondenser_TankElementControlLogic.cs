using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_WrappedCondenser_TankElementControlLogic
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MutuallyExclusive")]
        MutuallyExclusive = 1,
        
        [JsonProperty("Simultaneous")]
        Simultaneous = 2,
    }
}