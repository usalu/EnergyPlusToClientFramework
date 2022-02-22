namespace BH.oM.Adapters.EnergyPlus.Pumps
{
    public enum HeaderedPumps_ConstantSpeed_DesignPowerSizingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlow")]
        PowerPerFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
    }
}