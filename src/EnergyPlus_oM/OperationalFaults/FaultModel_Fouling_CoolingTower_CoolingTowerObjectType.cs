namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_Fouling_CoolingTower_CoolingTowerObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:SingleSpeed")]
        CoolingTowerSingleSpeed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:TwoSpeed")]
        CoolingTowerTwoSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:VariableSpeed:MERKEL")]
        CoolingTowerVariableSpeedMERKEL = 2,
    }
}