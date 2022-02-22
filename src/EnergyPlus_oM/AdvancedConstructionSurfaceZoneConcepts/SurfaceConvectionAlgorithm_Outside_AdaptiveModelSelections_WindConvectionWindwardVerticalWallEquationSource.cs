namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionWindwardVerticalWallEquationSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BlockenWindward")]
        BlockenWindward = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DOE2Windward")]
        DOE2Windward = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="EmmelVertical")]
        EmmelVertical = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="McAdams")]
        McAdams = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Mitchell")]
        Mitchell = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="MoWiTTWindward")]
        MoWiTTWindward = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="NusseltJurges")]
        NusseltJurges = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleCombined")]
        SimpleCombined = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="TARPWindward")]
        TARPWindward = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="UserCurve")]
        UserCurve = 10,
    }
}