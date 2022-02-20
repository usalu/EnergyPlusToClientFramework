using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_LowTemperatureRadiant_Electric_SetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HalfFlowPower")]
        HalfFlowPower = 1,
        
        [JsonProperty("ZeroFlowPower")]
        ZeroFlowPower = 2,
    }
}