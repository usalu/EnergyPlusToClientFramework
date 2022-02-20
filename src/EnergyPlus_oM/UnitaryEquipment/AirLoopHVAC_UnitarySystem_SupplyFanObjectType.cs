using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_SupplyFanObjectType
    {
        
        [JsonProperty("Fan:ComponentModel")]
        FanComponentModel = 0,
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 1,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 2,
        
        [JsonProperty("Fan:SystemModel")]
        FanSystemModel = 3,
        
        [JsonProperty("Fan:VariableVolume")]
        FanVariableVolume = 4,
    }
}