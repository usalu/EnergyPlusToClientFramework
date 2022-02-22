namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    public enum Dehumidifier_Desiccant_NoFans_RegenerationFanObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:SystemModel")]
        FanSystemModel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:VariableVolume")]
        FanVariableVolume = 2,
    }
}