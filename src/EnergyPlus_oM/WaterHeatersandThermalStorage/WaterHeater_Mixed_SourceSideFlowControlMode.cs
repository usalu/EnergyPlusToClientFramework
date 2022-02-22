namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_Mixed_SourceSideFlowControlMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IndirectHeatAlternateSetpoint")]
        IndirectHeatAlternateSetpoint = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="IndirectHeatPrimarySetpoint")]
        IndirectHeatPrimarySetpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="StorageTank")]
        StorageTank = 3,
    }
}