namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableCeilingEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="BeausoleilMorrisonMixedStableCeiling")]
        BeausoleilMorrisonMixedStableCeiling = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 4,
    }
}