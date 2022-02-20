using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_UnitHeater_SupplyAirFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
        
        [JsonProperty("Fan:SystemModel")]
        FanSystemModel = 2,
        
        [JsonProperty("Fan:VariableVolume")]
        FanVariableVolume = 3,
    }
}