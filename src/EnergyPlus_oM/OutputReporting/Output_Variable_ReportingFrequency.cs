namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Variable_ReportingFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Annual")]
        Annual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Daily")]
        Daily = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Detailed")]
        Detailed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Environment")]
        Environment = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Monthly")]
        Monthly = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="RunPeriod")]
        RunPeriod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 8,
    }
}