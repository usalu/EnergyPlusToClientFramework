namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_EnvironmentalImpactFactors_ReportingFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Annual")]
        Annual = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Daily")]
        Daily = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Environment")]
        Environment = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Monthly")]
        Monthly = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="RunPeriod")]
        RunPeriod = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 6,
    }
}