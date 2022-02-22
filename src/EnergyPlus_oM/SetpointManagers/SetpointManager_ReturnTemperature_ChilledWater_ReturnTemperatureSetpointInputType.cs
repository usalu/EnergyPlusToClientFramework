namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_ReturnTemperature_ChilledWater_ReturnTemperatureSetpointInputType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ReturnTemperatureSetpoint")]
        ReturnTemperatureSetpoint = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 2,
    }
}