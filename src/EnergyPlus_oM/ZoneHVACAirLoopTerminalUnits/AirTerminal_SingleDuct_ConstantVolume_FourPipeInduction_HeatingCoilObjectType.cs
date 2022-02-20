using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 0,
    }
}