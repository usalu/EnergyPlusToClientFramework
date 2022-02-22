namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserFloorEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BeausoleilMorrisonMixedStableFloor")]
        BeausoleilMorrisonMixedStableFloor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="BeausoleilMorrisonMixedUnstableFloor")]
        BeausoleilMorrisonMixedUnstableFloor = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FisherPedersenCeilingDiffuserFloor")]
        FisherPedersenCeilingDiffuserFloor = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="GoldsteinNovoselacCeilingDiffuserFloor")]
        GoldsteinNovoselacCeilingDiffuserFloor = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 5,
    }
}