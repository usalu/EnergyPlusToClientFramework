using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum Foundation_Kiva_Settings_DeepGroundBoundaryCondition
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Autoselect")]
        Autoselect = 1,
        
        [JsonProperty("GroundWater")]
        GroundWater = 2,
        
        [JsonProperty("ZeroFlux")]
        ZeroFlux = 3,
    }
}