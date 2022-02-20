using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_FanObjectType
    {
        
        [JsonProperty("Fan:SystemModel")]
        FanSystemModel = 0,
        
        [JsonProperty("Fan:VariableVolume")]
        FanVariableVolume = 1,
    }
}