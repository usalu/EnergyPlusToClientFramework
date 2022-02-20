using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum BuildingSurface_Detailed_SurfaceType
    {
        
        [JsonProperty("Ceiling")]
        Ceiling = 0,
        
        [JsonProperty("Floor")]
        Floor = 1,
        
        [JsonProperty("Roof")]
        Roof = 2,
        
        [JsonProperty("Wall")]
        Wall = 3,
    }
}