using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    public enum SolarCollector_IntegralCollectorStorage_BottomSurfaceBoundaryConditionsType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AmbientAir")]
        AmbientAir = 1,
        
        [JsonProperty("OtherSideConditionsModel")]
        OtherSideConditionsModel = 2,
    }
}