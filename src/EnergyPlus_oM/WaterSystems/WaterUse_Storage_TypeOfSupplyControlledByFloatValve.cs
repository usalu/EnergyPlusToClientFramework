using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    public enum WaterUse_Storage_TypeOfSupplyControlledByFloatValve
    {
        
        [JsonProperty("GroundwaterWell")]
        GroundwaterWell = 0,
        
        [JsonProperty("Mains")]
        Mains = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("OtherTank")]
        OtherTank = 3,
    }
}