using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_Fouling_CoolingTower_CoolingTowerObjectType
    {
        
        [JsonProperty("CoolingTower:SingleSpeed")]
        CoolingTowerSingleSpeed = 0,
        
        [JsonProperty("CoolingTower:TwoSpeed")]
        CoolingTowerTwoSpeed = 1,
        
        [JsonProperty("CoolingTower:VariableSpeed:MERKEL")]
        CoolingTowerVariableSpeedMERKEL = 2,
    }
}