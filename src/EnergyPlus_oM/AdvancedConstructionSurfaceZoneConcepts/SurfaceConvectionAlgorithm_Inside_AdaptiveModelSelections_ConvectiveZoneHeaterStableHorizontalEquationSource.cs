using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 3,
    }
}