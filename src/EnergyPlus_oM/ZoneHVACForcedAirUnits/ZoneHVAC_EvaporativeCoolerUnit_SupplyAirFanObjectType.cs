using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_EvaporativeCoolerUnit_SupplyAirFanObjectType
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