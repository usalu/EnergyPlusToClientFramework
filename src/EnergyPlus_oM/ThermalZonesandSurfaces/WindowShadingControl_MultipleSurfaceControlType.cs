using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowShadingControl_MultipleSurfaceControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Group")]
        Group = 1,
        
        [JsonProperty("Sequential")]
        Sequential = 2,
    }
}