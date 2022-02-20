using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_CoolingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
        
        [JsonProperty("Warmest")]
        Warmest = 4,
    }
}