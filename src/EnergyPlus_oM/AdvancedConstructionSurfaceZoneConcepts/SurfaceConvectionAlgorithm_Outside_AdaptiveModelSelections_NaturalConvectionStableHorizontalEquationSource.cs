namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionStableHorizontalEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 4,
    }
}