using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_Steam_CoilControlType
    {
        
        [JsonProperty("TemperatureSetpointControl")]
        TemperatureSetpointControl = 0,
        
        [JsonProperty("ZoneLoadControl")]
        ZoneLoadControl = 1,
    }
}