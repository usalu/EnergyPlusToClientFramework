namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableHorizontalEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 5,
    }
}