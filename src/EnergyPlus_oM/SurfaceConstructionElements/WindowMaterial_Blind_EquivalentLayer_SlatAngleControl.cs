using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_Blind_EquivalentLayer_SlatAngleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlockBeamSolar")]
        BlockBeamSolar = 1,
        
        [JsonProperty("FixedSlatAngle")]
        FixedSlatAngle = 2,
        
        [JsonProperty("MaximizeSolar")]
        MaximizeSolar = 3,
    }
}