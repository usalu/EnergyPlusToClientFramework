using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum GlobalGeometryRules_DaylightingReferencePointCoordinateSystem
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Relative")]
        Relative = 1,
        
        [JsonProperty("World")]
        World = 2,
    }
}