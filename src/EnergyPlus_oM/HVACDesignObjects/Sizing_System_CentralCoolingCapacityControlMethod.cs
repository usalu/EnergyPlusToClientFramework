namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_CentralCoolingCapacityControlMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Bypass")]
        Bypass = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OnOff")]
        OnOff = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VAV")]
        VAV = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VT")]
        VT = 4,
    }
}