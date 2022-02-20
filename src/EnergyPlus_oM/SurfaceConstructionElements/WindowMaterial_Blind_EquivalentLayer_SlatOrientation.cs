using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_Blind_EquivalentLayer_SlatOrientation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Horizontal")]
        Horizontal = 1,
        
        [JsonProperty("Vertical")]
        Vertical = 2,
    }
}