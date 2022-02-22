namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableTiltedEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ISO15099Windows")]
        ISO15099Windows = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
}