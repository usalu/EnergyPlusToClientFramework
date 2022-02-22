namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableHorizontalEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="KaradagChilledCeiling")]
        KaradagChilledCeiling = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 6,
    }
}