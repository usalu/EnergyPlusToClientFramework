using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Tower_ObjectReference_CoolingTowerObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolingTower:SingleSpeed")]
        CoolingTowerSingleSpeed = 1,
        
        [JsonProperty("CoolingTower:TwoSpeed")]
        CoolingTowerTwoSpeed = 2,
        
        [JsonProperty("CoolingTower:VariableSpeed")]
        CoolingTowerVariableSpeed = 3,
    }
}