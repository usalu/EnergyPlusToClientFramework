using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingHeatedWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("AwbiHattonHeatedWall")]
        AwbiHattonHeatedWall = 3,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 4,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 5,
        
        [JsonProperty("KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 6,
        
        [JsonProperty("UserCurve")]
        UserCurve = 7,
    }
}