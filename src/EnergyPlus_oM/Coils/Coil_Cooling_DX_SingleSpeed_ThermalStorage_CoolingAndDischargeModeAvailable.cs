using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndDischargeModeAvailable
    {
        
        [JsonProperty("No")]
        No = 0,
        
        [JsonProperty("Yes")]
        Yes = 1,
    }
}