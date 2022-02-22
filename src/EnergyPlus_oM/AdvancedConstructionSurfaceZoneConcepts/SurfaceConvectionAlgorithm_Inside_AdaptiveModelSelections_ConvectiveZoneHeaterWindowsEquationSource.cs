namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterWindowsEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ISO15099Windows")]
        ISO15099Windows = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 6,
    }
}