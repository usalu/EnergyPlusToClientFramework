using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections
{
    public enum ZoneHVAC_EquipmentList_LoadDistributionScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SequentialLoad")]
        SequentialLoad = 1,
        
        [JsonProperty("SequentialUniformPLR")]
        SequentialUniformPLR = 2,
        
        [JsonProperty("UniformLoad")]
        UniformLoad = 3,
        
        [JsonProperty("UniformPLR")]
        UniformPLR = 4,
    }
}