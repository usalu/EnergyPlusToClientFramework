using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum Material_RoofVegetation_MoistureDiffusionCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Advanced")]
        Advanced = 1,
        
        [JsonProperty("Simple")]
        Simple = 2,
    }
}