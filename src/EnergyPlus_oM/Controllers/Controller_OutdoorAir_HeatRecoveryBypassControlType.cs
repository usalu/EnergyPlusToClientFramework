namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_OutdoorAir_HeatRecoveryBypassControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BypassWhenOAFlowGreaterThanMinimum")]
        BypassWhenOAFlowGreaterThanMinimum = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="BypassWhenWithinEconomizerLimits")]
        BypassWhenWithinEconomizerLimits = 2,
    }
}