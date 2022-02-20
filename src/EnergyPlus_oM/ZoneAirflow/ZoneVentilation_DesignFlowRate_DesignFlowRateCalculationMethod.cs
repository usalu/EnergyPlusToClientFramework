using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirChanges/Hour")]
        AirChangesHour = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
    }
}