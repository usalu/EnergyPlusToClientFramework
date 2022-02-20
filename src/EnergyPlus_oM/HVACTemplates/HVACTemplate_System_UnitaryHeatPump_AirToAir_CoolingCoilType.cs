using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SingleSpeedDX")]
        SingleSpeedDX = 1,
    }
}