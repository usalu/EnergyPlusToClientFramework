using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum Construction_ComplexFenestrationState_BasisSymmetryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Axisymmetric")]
        Axisymmetric = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
}