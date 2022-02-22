namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedLinear")]
        FixedLinear = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoSpeed")]
        TwoSpeed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableSpeed")]
        VariableSpeed = 4,
    }
}