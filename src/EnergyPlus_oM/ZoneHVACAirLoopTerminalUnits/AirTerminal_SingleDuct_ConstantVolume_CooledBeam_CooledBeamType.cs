using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_ConstantVolume_CooledBeam_CooledBeamType
    {
        
        [JsonProperty("Active")]
        Active = 0,
        
        [JsonProperty("Passive")]
        Passive = 1,
    }
}