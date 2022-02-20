using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_VentilatedSlab_SystemConfigurationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SeriesSlabs")]
        SeriesSlabs = 1,
        
        [JsonProperty("SlabAndZone")]
        SlabAndZone = 2,
        
        [JsonProperty("SlabOnly")]
        SlabOnly = 3,
    }
}