using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SingleSpeedDXHeatPump")]
        SingleSpeedDXHeatPump = 1,
    }
}