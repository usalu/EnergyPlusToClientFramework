using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    public enum AvailabilityManager_NightCycle_CyclingRunTimeControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedRunTime")]
        FixedRunTime = 1,
        
        [JsonProperty("Thermostat")]
        Thermostat = 2,
        
        [JsonProperty("ThermostatWithMinimumRunTime")]
        ThermostatWithMinimumRunTime = 3,
    }
}