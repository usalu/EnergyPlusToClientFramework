using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType
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