namespace BH.oM.Adapters.EnergyPlus.Fans
{
    public enum Fan_SystemModel_SpeedControlMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Continuous")]
        Continuous = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Discrete")]
        Discrete = 2,
    }
}