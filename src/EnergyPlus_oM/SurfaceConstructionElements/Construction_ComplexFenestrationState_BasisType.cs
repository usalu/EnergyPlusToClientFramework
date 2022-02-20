using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum Construction_ComplexFenestrationState_BasisType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LBNLWINDOW")]
        LBNLWINDOW = 1,
        
        [JsonProperty("UserDefined")]
        UserDefined = 2,
    }
}