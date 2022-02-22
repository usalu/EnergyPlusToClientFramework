namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_NightCycleControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CycleOnAny")]
        CycleOnAny = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CycleOnControlZone")]
        CycleOnControlZone = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="StayOff")]
        StayOff = 3,
    }
}