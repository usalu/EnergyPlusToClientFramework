namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowProperty_AirflowControl_AirflowControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AlwaysOff")]
        AlwaysOff = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AlwaysOnAtMaximumFlow")]
        AlwaysOnAtMaximumFlow = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ScheduledOnly")]
        ScheduledOnly = 3,
    }
}