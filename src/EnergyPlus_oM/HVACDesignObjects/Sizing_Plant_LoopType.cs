using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Plant_LoopType
    {
        
        [JsonProperty("Condenser")]
        Condenser = 0,
        
        [JsonProperty("Cooling")]
        Cooling = 1,
        
        [JsonProperty("Heating")]
        Heating = 2,
        
        [JsonProperty("Steam")]
        Steam = 3,
    }
}