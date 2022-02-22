namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_Scheduled_ControlVariable
    {
        
        [System.Runtime.Serialization.EnumMember(Value="HumidityRatio")]
        HumidityRatio = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlowRate")]
        MassFlowRate = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MaximumHumidityRatio")]
        MaximumHumidityRatio = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MaximumMassFlowRate")]
        MaximumMassFlowRate = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MaximumTemperature")]
        MaximumTemperature = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="MinimumHumidityRatio")]
        MinimumHumidityRatio = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="MinimumMassFlowRate")]
        MinimumMassFlowRate = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="MinimumTemperature")]
        MinimumTemperature = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 8,
    }
}