namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Tower_ObjectReference_CoolingTowerObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:SingleSpeed")]
        CoolingTowerSingleSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:TwoSpeed")]
        CoolingTowerTwoSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:VariableSpeed")]
        CoolingTowerVariableSpeed = 3,
    }
}