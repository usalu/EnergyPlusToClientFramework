using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_PackagedVAV_HeatingCoilSetpointResetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
    }
}