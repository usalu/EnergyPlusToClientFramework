using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_MechanicalVentilation_SystemOutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("IndoorAirQualityProcedure")]
        IndoorAirQualityProcedure = 1,
        
        [JsonProperty("IndoorAirQualityProcedureCombined")]
        IndoorAirQualityProcedureCombined = 2,
        
        [JsonProperty("IndoorAirQualityProcedureGenericContaminant")]
        IndoorAirQualityProcedureGenericContaminant = 3,
        
        [JsonProperty("ProportionalControlBasedOnDesignOARate")]
        ProportionalControlBasedOnDesignOARate = 4,
        
        [JsonProperty("ProportionalControlBasedOnDesignOccupancy")]
        ProportionalControlBasedOnDesignOccupancy = 5,
        
        [JsonProperty("ProportionalControlBasedOnOccupancySchedule")]
        ProportionalControlBasedOnOccupancySchedule = 6,
        
        [JsonProperty("VentilationRateProcedure")]
        VentilationRateProcedure = 7,
        
        [JsonProperty("ZoneSum")]
        ZoneSum = 8,
    }
}