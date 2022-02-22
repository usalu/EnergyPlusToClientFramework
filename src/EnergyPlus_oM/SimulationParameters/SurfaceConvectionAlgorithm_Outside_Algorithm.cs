namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum SurfaceConvectionAlgorithm_Outside_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DOE-2")]
        DOE2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MoWiTT")]
        MoWiTT = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleCombined")]
        SimpleCombined = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="TARP")]
        TARP = 5,
    }
}