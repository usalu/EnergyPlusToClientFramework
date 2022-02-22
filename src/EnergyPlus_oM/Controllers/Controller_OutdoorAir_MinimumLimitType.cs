namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_OutdoorAir_MinimumLimitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedMinimum")]
        FixedMinimum = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalMinimum")]
        ProportionalMinimum = 2,
    }
}