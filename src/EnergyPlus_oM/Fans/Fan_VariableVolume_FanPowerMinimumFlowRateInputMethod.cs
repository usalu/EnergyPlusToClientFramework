namespace BH.oM.Adapters.EnergyPlus.Fans
{
    public enum Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedFlowRate")]
        FixedFlowRate = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Fraction")]
        Fraction = 2,
    }
}