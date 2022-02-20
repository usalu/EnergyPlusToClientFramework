using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 3,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 4,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 5,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 6,
        
        [JsonProperty("UserCurve")]
        UserCurve = 7,
    }
}