using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_ThermalComfort_AveragingMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ObjectAverage")]
        ObjectAverage = 1,
        
        [JsonProperty("PeopleAverage")]
        PeopleAverage = 2,
        
        [JsonProperty("SpecificObject")]
        SpecificObject = 3,
    }
}