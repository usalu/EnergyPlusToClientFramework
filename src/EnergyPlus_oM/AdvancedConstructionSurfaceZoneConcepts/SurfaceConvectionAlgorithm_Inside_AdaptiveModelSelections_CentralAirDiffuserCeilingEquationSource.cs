namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserCeilingEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BeausoleilMorrisonMixedStableCeiling")]
        BeausoleilMorrisonMixedStableCeiling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="BeausoleilMorrisonMixedUnstableCeiling")]
        BeausoleilMorrisonMixedUnstableCeiling = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FisherPedersenCeilingDiffuserCeiling")]
        FisherPedersenCeilingDiffuserCeiling = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 4,
    }
}