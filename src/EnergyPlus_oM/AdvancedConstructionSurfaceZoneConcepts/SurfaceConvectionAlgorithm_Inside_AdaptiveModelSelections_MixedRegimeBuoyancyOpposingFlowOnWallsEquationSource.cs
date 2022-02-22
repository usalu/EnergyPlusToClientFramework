namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 7,
    }
}