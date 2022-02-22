namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWallEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ISO15099Windows")]
        ISO15099Windows = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 9,
    }
}