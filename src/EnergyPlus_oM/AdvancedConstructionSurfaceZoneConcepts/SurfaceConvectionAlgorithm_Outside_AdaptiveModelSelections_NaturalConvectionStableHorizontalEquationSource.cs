using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionStableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 4,
    }
}