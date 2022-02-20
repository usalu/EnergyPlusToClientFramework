using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeWindowEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 1,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
    }
}