namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AwbiHattonHeatedWall")]
        AwbiHattonHeatedWall = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ISO15099Windows")]
        ISO15099Windows = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 7,
    }
}