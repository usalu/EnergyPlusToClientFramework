using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_VAV_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
}