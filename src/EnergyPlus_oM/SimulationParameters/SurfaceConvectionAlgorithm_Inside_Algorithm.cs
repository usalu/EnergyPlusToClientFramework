namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum SurfaceConvectionAlgorithm_Inside_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASTMC1340")]
        ASTMC1340 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CeilingDiffuser")]
        CeilingDiffuser = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Simple")]
        Simple = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="TARP")]
        TARP = 5,
    }
}