using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum GlobalGeometryRules_VertexEntryDirection
    {
        
        [JsonProperty("Clockwise")]
        Clockwise = 0,
        
        [JsonProperty("Counterclockwise")]
        Counterclockwise = 1,
    }
}