using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_UnitVentilator_OutdoorAirControlType
    {
        
        [JsonProperty("FixedAmount")]
        FixedAmount = 0,
        
        [JsonProperty("FixedTemperature")]
        FixedTemperature = 1,
        
        [JsonProperty("VariablePercent")]
        VariablePercent = 2,
    }
}