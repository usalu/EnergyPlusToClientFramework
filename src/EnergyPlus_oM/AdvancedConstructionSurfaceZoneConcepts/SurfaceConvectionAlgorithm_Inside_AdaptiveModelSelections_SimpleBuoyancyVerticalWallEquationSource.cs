using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 4,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 5,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 6,
        
        [JsonProperty("UserCurve")]
        UserCurve = 7,
    }
}