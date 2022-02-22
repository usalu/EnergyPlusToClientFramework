namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_WalkIn_DefrostControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureTermination")]
        TemperatureTermination = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TimeSchedule")]
        TimeSchedule = 2,
    }
}