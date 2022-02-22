namespace BH.oM.Adapters.EnergyPlus.Fans
{
    public enum Fan_SystemModel_DesignPowerSizingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlow")]
        PowerPerFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerPerFlowPerPressure")]
        PowerPerFlowPerPressure = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TotalEfficiencyAndPressure")]
        TotalEfficiencyAndPressure = 3,
    }
}