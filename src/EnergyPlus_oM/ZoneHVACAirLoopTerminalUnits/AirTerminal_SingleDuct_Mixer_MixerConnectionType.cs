using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_Mixer_MixerConnectionType
    {
        
        [JsonProperty("InletSide")]
        InletSide = 0,
        
        [JsonProperty("SupplySide")]
        SupplySide = 1,
    }
}