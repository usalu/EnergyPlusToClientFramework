using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum Site_GroundDomain_Basement_SimulationTimestep
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Hourly")]
        Hourly = 1,
        
        [JsonProperty("Timestep")]
        Timestep = 2,
    }
}