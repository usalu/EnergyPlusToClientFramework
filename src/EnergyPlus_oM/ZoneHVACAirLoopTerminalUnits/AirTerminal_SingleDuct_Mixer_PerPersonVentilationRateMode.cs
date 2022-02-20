using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_Mixer_PerPersonVentilationRateMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CurrentOccupancy")]
        CurrentOccupancy = 1,
        
        [JsonProperty("DesignOccupancy")]
        DesignOccupancy = 2,
    }
}