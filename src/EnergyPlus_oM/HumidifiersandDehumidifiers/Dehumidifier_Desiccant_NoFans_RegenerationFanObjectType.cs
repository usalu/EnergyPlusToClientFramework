using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    public enum Dehumidifier_Desiccant_NoFans_RegenerationFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:SystemModel")]
        FanSystemModel = 1,
        
        [JsonProperty("Fan:VariableVolume")]
        FanVariableVolume = 2,
    }
}