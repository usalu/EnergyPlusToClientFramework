using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum DesignSpecification_OutdoorAir_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirChanges/Hour")]
        AirChangesHour = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("IndoorAirQualityProcedure")]
        IndoorAirQualityProcedure = 5,
        
        [JsonProperty("Maximum")]
        Maximum = 6,
        
        [JsonProperty("ProportionalControlBasedOnDesignOccupancy")]
        ProportionalControlBasedOnDesignOccupancy = 7,
        
        [JsonProperty("ProportionalControlBasedOnOccupancySchedule")]
        ProportionalControlBasedOnOccupancySchedule = 8,
        
        [JsonProperty("Sum")]
        Sum = 9,
    }
}