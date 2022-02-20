using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_UnitVentilator_CoilOption
    {
        
        [JsonProperty("Cooling")]
        Cooling = 0,
        
        [JsonProperty("Heating")]
        Heating = 1,
        
        [JsonProperty("HeatingAndCooling")]
        HeatingAndCooling = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
}