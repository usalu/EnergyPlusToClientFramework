using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_VAV_FanPowered_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
}