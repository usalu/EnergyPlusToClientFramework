using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolingPriority")]
        CoolingPriority = 1,
        
        [JsonProperty("HeatingPriority")]
        HeatingPriority = 2,
        
        [JsonProperty("LoadPriority")]
        LoadPriority = 3,
        
        [JsonProperty("ZonePriority")]
        ZonePriority = 4,
    }
}