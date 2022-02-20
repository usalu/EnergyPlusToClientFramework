using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_VAV_Reheat_ZoneMinimumAirFlowInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("FixedFlowRate")]
        FixedFlowRate = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
    }
}