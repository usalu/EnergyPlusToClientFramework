using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_NumberOfCircuits
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CalculateFromCircuitLength")]
        CalculateFromCircuitLength = 1,
        
        [JsonProperty("OnePerSurface")]
        OnePerSurface = 2,
    }
}