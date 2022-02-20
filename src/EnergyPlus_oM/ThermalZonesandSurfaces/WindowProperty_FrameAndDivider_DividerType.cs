using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowProperty_FrameAndDivider_DividerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DividedLite")]
        DividedLite = 1,
        
        [JsonProperty("Suspended")]
        Suspended = 2,
    }
}