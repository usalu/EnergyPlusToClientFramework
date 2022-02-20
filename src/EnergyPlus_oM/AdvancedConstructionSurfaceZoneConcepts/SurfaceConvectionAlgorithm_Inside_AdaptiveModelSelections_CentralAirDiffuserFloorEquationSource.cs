using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserFloorEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BeausoleilMorrisonMixedStableFloor")]
        BeausoleilMorrisonMixedStableFloor = 1,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableFloor")]
        BeausoleilMorrisonMixedUnstableFloor = 2,
        
        [JsonProperty("FisherPedersenCeilingDiffuserFloor")]
        FisherPedersenCeilingDiffuserFloor = 3,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserFloor")]
        GoldsteinNovoselacCeilingDiffuserFloor = 4,
        
        [JsonProperty("UserCurve")]
        UserCurve = 5,
    }
}