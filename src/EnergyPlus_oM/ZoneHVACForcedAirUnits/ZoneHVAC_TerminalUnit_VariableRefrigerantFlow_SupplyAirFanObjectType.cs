using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
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