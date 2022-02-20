using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolHeatedFloorEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("AwbiHattonHeatedFloor")]
        AwbiHattonHeatedFloor = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
}