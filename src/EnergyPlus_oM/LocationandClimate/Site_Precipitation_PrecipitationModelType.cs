using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum Site_Precipitation_PrecipitationModelType
    {
        
        [JsonProperty("ScheduleAndDesignLevel")]
        ScheduleAndDesignLevel = 0,
    }
}