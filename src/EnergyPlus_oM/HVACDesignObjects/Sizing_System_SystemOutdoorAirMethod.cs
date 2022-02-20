using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_SystemOutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("VentilationRateProcedure")]
        VentilationRateProcedure = 1,
        
        [JsonProperty("ZoneSum")]
        ZoneSum = 2,
    }
}