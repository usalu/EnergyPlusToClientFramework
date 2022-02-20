using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum RoofIrrigation_IrrigationModelType
    {
        
        [JsonProperty("Schedule")]
        Schedule = 0,
        
        [JsonProperty("SmartSchedule")]
        SmartSchedule = 1,
    }
}