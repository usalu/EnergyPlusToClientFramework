using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_OutdoorAirUnit_UnitControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NeutralControl")]
        NeutralControl = 1,
        
        [JsonProperty("TemperatureControl")]
        TemperatureControl = 2,
    }
}