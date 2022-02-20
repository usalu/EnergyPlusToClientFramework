using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneInfiltration_DesignFlowRate_DesignFlowRateCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirChanges/Hour")]
        AirChangesHour = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/ExteriorArea")]
        FlowExteriorArea = 3,
        
        [JsonProperty("Flow/ExteriorWallArea")]
        FlowExteriorWallArea = 4,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 5,
    }
}