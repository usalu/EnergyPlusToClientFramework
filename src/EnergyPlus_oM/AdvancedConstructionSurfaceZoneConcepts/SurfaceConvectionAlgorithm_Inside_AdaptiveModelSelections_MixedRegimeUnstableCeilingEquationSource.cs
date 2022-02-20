using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableCeilingEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableCeiling")]
        BeausoleilMorrisonMixedUnstableCeiling = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
}