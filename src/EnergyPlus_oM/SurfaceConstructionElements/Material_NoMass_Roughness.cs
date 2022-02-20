using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum Material_NoMass_Roughness
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