namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_SystemConfigurationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DualFanConstantVolume")]
        DualFanConstantVolume = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DualFanVariableVolume")]
        DualFanVariableVolume = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SingleFanConstantVolume")]
        SingleFanConstantVolume = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SingleFanVariableVolume")]
        SingleFanVariableVolume = 4,
    }
}