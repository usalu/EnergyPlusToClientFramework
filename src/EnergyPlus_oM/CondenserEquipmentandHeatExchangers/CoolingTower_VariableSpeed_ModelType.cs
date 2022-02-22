namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum CoolingTower_VariableSpeed_ModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolToolsCrossFlow")]
        CoolToolsCrossFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolToolsUserDefined")]
        CoolToolsUserDefined = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="YorkCalc")]
        YorkCalc = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="YorkCalcUserDefined")]
        YorkCalcUserDefined = 4,
    }
}