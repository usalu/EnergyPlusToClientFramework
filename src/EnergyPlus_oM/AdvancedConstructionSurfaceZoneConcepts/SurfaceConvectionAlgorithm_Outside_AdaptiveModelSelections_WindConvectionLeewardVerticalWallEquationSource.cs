namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionLeewardVerticalWallEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DOE2Leeward")]
        DOE2Leeward = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="EmmelVertical")]
        EmmelVertical = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="McAdams")]
        McAdams = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Mitchell")]
        Mitchell = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="MoWiTTLeeward")]
        MoWiTTLeeward = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="NusseltJurges")]
        NusseltJurges = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleCombined")]
        SimpleCombined = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="TARPLeeward")]
        TARPLeeward = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 9,
    }
}