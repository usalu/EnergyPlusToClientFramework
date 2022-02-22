namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_CoolingLimit
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LimitCapacity")]
        LimitCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LimitFlowRate")]
        LimitFlowRate = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="LimitFlowRateAndCapacity")]
        LimitFlowRateAndCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="NoLimit")]
        NoLimit = 4,
    }
}