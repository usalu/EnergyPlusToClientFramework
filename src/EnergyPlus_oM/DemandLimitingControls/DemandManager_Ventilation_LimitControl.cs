namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    public enum DemandManager_Ventilation_LimitControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FixedRate")]
        FixedRate = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Off")]
        Off = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ReductionRatio")]
        ReductionRatio = 2,
    }
}