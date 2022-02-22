namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_WindTurbine_PowerControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedSpeedFixedPitch")]
        FixedSpeedFixedPitch = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedSpeedVariablePitch")]
        FixedSpeedVariablePitch = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableSpeedFixedPitch")]
        VariableSpeedFixedPitch = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableSpeedVariablePitch")]
        VariableSpeedVariablePitch = 4,
    }
}