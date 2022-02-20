using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum FenestrationSurface_Detailed_SurfaceType
    {
        
        [JsonProperty("Door")]
        Door = 0,
        
        [JsonProperty("GlassDoor")]
        GlassDoor = 1,
        
        [JsonProperty("TubularDaylightDiffuser")]
        TubularDaylightDiffuser = 2,
        
        [JsonProperty("TubularDaylightDome")]
        TubularDaylightDome = 3,
        
        [JsonProperty("Window")]
        Window = 4,
    }
}