using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_Glazing_EquivalentLayer_OpticalDataType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Spectral")]
        Spectral = 1,
        
        [JsonProperty("SpectralAverage")]
        SpectralAverage = 2,
    }
}