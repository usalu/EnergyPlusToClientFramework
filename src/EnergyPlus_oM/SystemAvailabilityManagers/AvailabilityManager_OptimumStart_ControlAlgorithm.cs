namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    public enum AvailabilityManager_OptimumStart_ControlAlgorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASHRAE")]
        AdaptiveASHRAE = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveTemperatureGradient")]
        AdaptiveTemperatureGradient = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantStartTime")]
        ConstantStartTime = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantTemperatureGradient")]
        ConstantTemperatureGradient = 4,
    }
}