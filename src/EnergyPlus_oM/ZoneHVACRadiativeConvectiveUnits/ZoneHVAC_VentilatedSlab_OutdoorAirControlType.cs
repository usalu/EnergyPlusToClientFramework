using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_VentilatedSlab_OutdoorAirControlType
    {
        
        [JsonProperty("FixedAmount")]
        FixedAmount = 0,
        
        [JsonProperty("FixedTemperature")]
        FixedTemperature = 1,
        
        [JsonProperty("VariablePercent")]
        VariablePercent = 2,
    }
}