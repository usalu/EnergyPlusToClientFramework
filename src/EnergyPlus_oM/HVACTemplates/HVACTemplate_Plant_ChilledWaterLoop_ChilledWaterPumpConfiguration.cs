namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPumpConfiguration
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantPrimaryNoSecondary")]
        ConstantPrimaryNoSecondary = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantPrimaryVariableSecondary")]
        ConstantPrimaryVariableSecondary = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VariablePrimaryNoSecondary")]
        VariablePrimaryNoSecondary = 3,
    }
}