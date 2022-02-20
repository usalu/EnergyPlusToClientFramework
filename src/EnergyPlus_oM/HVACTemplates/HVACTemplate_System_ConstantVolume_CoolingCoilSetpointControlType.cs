using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_ConstantVolume_CoolingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ControlZone")]
        ControlZone = 1,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 2,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 3,
        
        [JsonProperty("Scheduled")]
        Scheduled = 4,
        
        [JsonProperty("Warmest")]
        Warmest = 5,
    }
}