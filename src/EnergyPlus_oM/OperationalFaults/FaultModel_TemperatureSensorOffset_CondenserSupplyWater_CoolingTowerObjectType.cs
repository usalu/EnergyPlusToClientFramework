namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:SingleSpeed")]
        CoolingTowerSingleSpeed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:TwoSpeed")]
        CoolingTowerTwoSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:VariableSpeed")]
        CoolingTowerVariableSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingTower:VariableSpeed:MERKEL")]
        CoolingTowerVariableSpeedMERKEL = 3,
    }
}