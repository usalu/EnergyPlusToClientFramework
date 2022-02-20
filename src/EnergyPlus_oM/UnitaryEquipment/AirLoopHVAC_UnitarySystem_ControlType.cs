using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Load")]
        Load = 1,
        
        [JsonProperty("SetPoint")]
        SetPoint = 2,
        
        [JsonProperty("SingleZoneVAV")]
        SingleZoneVAV = 3,
    }
}