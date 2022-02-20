using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_DualDuct_VAV_OutdoorAir_PerPersonVentilationRateMode
    {
        
        [JsonProperty("CurrentOccupancy")]
        CurrentOccupancy = 0,
        
        [JsonProperty("DesignOccupancy")]
        DesignOccupancy = 1,
    }
}