using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 3,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 4,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 5,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 6,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 7,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 8,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 9,
        
        [JsonProperty("UserCurve")]
        UserCurve = 10,
    }
}