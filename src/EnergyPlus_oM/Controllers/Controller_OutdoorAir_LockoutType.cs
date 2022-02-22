namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_OutdoorAir_LockoutType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LockoutWithCompressor")]
        LockoutWithCompressor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LockoutWithHeating")]
        LockoutWithHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="NoLockout")]
        NoLockout = 3,
    }
}