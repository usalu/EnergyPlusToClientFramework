using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CondensationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Off")]
        Off = 1,
        
        [JsonProperty("SimpleOff")]
        SimpleOff = 2,
        
        [JsonProperty("VariableOff")]
        VariableOff = 3,
    }
}