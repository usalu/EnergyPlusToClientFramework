using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWindowEquationSource
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
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 7,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 8,
        
        [JsonProperty("UserCurve")]
        UserCurve = 9,
    }
}