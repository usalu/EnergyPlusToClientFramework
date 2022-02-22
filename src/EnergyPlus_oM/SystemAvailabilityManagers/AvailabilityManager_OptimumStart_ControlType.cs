namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    public enum AvailabilityManager_OptimumStart_ControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ControlZone")]
        ControlZone = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MaximumofZoneList")]
        MaximumofZoneList = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="StayOff")]
        StayOff = 3,
    }
}