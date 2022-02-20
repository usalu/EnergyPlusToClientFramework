using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_ExteriorNaturalVentedCavity_RoughnessOfExteriorSurface
    {
        
        [JsonProperty("MediumRough")]
        MediumRough = 0,
        
        [JsonProperty("MediumSmooth")]
        MediumSmooth = 1,
        
        [JsonProperty("Rough")]
        Rough = 2,
        
        [JsonProperty("Smooth")]
        Smooth = 3,
        
        [JsonProperty("VeryRough")]
        VeryRough = 4,
        
        [JsonProperty("VerySmooth")]
        VerySmooth = 5,
    }
}