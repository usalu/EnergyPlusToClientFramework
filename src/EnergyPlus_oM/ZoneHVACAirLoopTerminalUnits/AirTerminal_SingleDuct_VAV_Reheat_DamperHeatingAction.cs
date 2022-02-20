using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_VAV_Reheat_DamperHeatingAction
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Normal")]
        Normal = 1,
        
        [JsonProperty("Reverse")]
        Reverse = 2,
        
        [JsonProperty("ReverseWithLimits")]
        ReverseWithLimits = 3,
    }
}