using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_ComplexShade_LayerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BSDF")]
        BSDF = 1,
        
        [JsonProperty("OtherShadingType")]
        OtherShadingType = 2,
        
        [JsonProperty("Perforated")]
        Perforated = 3,
        
        [JsonProperty("VenetianHorizontal")]
        VenetianHorizontal = 4,
        
        [JsonProperty("VenetianVertical")]
        VenetianVertical = 5,
        
        [JsonProperty("Woven")]
        Woven = 6,
    }
}