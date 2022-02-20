using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_DualDuct_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 3,
    }
}