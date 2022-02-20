using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_VentilatedSlab_CoilOptionType
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