using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Zone_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
}