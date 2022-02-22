namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    public enum Humidifier_Steam_Gas_InletWaterTemperatureOption
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedInletWaterTemperature")]
        FixedInletWaterTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableInletWaterTemperature")]
        VariableInletWaterTemperature = 2,
    }
}