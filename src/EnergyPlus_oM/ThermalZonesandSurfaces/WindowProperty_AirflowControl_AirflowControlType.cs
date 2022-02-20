using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowProperty_AirflowControl_AirflowControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlwaysOff")]
        AlwaysOff = 1,
        
        [JsonProperty("AlwaysOnAtMaximumFlow")]
        AlwaysOnAtMaximumFlow = 2,
        
        [JsonProperty("ScheduledOnly")]
        ScheduledOnly = 3,
    }
}