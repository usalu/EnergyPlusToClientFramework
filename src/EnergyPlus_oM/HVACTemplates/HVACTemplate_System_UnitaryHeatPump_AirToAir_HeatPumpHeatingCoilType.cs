using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SingleSpeedDXHeatPump")]
        SingleSpeedDXHeatPump = 1,
    }
}