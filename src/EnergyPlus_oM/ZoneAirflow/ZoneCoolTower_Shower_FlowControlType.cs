using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneCoolTower_Shower_FlowControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("WaterFlowSchedule")]
        WaterFlowSchedule = 1,
        
        [JsonProperty("WindDrivenFlow")]
        WindDrivenFlow = 2,
    }
}