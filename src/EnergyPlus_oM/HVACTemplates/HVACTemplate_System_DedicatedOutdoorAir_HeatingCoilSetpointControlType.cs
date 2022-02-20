using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
    }
}