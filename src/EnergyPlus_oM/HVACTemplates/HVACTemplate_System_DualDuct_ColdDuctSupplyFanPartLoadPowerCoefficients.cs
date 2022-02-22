namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_ColdDuctSupplyFanPartLoadPowerCoefficients
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="InletVaneDampers")]
        InletVaneDampers = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OutletDampers")]
        OutletDampers = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
}