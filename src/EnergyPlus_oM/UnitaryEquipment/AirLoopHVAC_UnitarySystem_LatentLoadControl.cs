namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_LatentLoadControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LatentOnlyLoadControl")]
        LatentOnlyLoadControl = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LatentOrSensibleLoadControl")]
        LatentOrSensibleLoadControl = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="LatentWithSensibleLoadControl")]
        LatentWithSensibleLoadControl = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SensibleOnlyLoadControl")]
        SensibleOnlyLoadControl = 4,
    }
}