using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_PackagedVAV_CoolingCoilSetpointResetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [JsonProperty("Warmest")]
        Warmest = 3,
        
        [JsonProperty("WarmestTemperatureFirst")]
        WarmestTemperatureFirst = 4,
    }
}