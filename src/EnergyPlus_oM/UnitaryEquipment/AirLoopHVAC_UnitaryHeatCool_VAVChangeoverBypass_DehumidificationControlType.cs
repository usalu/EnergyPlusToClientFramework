using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("Multimode")]
        Multimode = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
}