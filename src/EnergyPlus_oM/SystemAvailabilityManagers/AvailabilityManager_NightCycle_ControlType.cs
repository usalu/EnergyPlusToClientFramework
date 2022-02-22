namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    public enum AvailabilityManager_NightCycle_ControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CycleOnAny")]
        CycleOnAny = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CycleOnAnyCoolingOrHeatingZone")]
        CycleOnAnyCoolingOrHeatingZone = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CycleOnAnyCoolingZone")]
        CycleOnAnyCoolingZone = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="CycleOnAnyHeatingZone")]
        CycleOnAnyHeatingZone = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="CycleOnAnyHeatingZoneFansOnly")]
        CycleOnAnyHeatingZoneFansOnly = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="CycleOnAnyZoneFansOnly")]
        CycleOnAnyZoneFansOnly = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="CycleOnControlZone")]
        CycleOnControlZone = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="StayOff")]
        StayOff = 8,
    }
}