using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_DemandControlledVentilationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CO2Setpoint")]
        CO2Setpoint = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("OccupancySchedule")]
        OccupancySchedule = 3,
    }
}