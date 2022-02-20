using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_LowTemperatureRadiant_Electric_TemperatureControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [JsonProperty("MeanRadiantTemperature")]
        MeanRadiantTemperature = 2,
        
        [JsonProperty("OperativeTemperature")]
        OperativeTemperature = 3,
        
        [JsonProperty("OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 4,
        
        [JsonProperty("OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 5,
        
        [JsonProperty("SurfaceFaceTemperature")]
        SurfaceFaceTemperature = 6,
        
        [JsonProperty("SurfaceInteriorTemperature")]
        SurfaceInteriorTemperature = 7,
    }
}