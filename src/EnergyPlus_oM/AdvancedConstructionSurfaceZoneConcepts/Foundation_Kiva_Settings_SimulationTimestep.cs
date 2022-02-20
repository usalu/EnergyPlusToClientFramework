using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum Foundation_Kiva_Settings_SimulationTimestep
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Hourly")]
        Hourly = 1,
        
        [JsonProperty("Timestep")]
        Timestep = 2,
    }
}