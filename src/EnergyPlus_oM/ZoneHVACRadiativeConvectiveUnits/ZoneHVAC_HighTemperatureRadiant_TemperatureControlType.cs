using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_HighTemperatureRadiant_TemperatureControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [JsonProperty("MeanAirTemperatureSetpoint")]
        MeanAirTemperatureSetpoint = 2,
        
        [JsonProperty("MeanRadiantTemperature")]
        MeanRadiantTemperature = 3,
        
        [JsonProperty("MeanRadiantTemperatureSetpoint")]
        MeanRadiantTemperatureSetpoint = 4,
        
        [JsonProperty("OperativeTemperature")]
        OperativeTemperature = 5,
        
        [JsonProperty("OperativeTemperatureSetpoint")]
        OperativeTemperatureSetpoint = 6,
    }
}