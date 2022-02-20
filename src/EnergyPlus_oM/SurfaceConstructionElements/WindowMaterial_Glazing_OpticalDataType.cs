using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_Glazing_OpticalDataType
    {
        
        [JsonProperty("BSDF")]
        BSDF = 0,
        
        [JsonProperty("Spectral")]
        Spectral = 1,
        
        [JsonProperty("SpectralAndAngle")]
        SpectralAndAngle = 2,
        
        [JsonProperty("SpectralAverage")]
        SpectralAverage = 3,
    }
}