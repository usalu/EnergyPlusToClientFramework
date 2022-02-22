namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Table_TimeBins_VariableType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Energy")]
        Energy = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 3,
    }
}