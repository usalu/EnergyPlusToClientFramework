using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum Material_RoofVegetation_Roughness
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MediumRough")]
        MediumRough = 1,
        
        [JsonProperty("MediumSmooth")]
        MediumSmooth = 2,
        
        [JsonProperty("Rough")]
        Rough = 3,
        
        [JsonProperty("Smooth")]
        Smooth = 4,
        
        [JsonProperty("VeryRough")]
        VeryRough = 5,
        
        [JsonProperty("VerySmooth")]
        VerySmooth = 6,
    }
}