using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_PumpedCondenser_ParasiticHeatRejectionLocation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Outdoors")]
        Outdoors = 1,
        
        [JsonProperty("Zone")]
        Zone = 2,
    }
}