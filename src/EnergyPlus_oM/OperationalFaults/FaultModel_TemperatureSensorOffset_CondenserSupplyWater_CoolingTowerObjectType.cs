using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType
    {
        
        [JsonProperty("CoolingTower:SingleSpeed")]
        CoolingTowerSingleSpeed = 0,
        
        [JsonProperty("CoolingTower:TwoSpeed")]
        CoolingTowerTwoSpeed = 1,
        
        [JsonProperty("CoolingTower:VariableSpeed")]
        CoolingTowerVariableSpeed = 2,
        
        [JsonProperty("CoolingTower:VariableSpeed:MERKEL")]
        CoolingTowerVariableSpeedMERKEL = 3,
    }
}