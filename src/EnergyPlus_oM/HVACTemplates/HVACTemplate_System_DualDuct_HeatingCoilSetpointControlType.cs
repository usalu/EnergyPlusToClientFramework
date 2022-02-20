using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_HeatingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coldest")]
        Coldest = 1,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 2,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 3,
        
        [JsonProperty("Scheduled")]
        Scheduled = 4,
    }
}