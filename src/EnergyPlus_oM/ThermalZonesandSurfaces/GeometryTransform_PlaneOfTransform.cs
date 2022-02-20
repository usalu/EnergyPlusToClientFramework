using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum GeometryTransform_PlaneOfTransform
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("XY")]
        XY = 1,
    }
}