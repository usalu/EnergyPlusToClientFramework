using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum GlobalGeometryRules_CoordinateSystem
    {
        
        [JsonProperty("Relative")]
        Relative = 0,
        
        [JsonProperty("World")]
        World = 1,
    }
}