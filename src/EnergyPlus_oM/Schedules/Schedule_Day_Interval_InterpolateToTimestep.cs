namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    public enum Schedule_Day_Interval_InterpolateToTimestep
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Average")]
        Average = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Linear")]
        Linear = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="No")]
        No = 3,
    }
}