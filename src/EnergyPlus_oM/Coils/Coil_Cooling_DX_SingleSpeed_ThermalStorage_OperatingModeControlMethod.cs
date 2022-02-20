using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_OperatingModeControlMethod
    {
        
        [JsonProperty("EMSControlled")]
        EMSControlled = 0,
        
        [JsonProperty("ScheduledModes")]
        ScheduledModes = 1,
    }
}