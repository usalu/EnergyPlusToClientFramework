using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location
    {
        
        [JsonProperty("Inside")]
        Inside = 0,
        
        [JsonProperty("Outside")]
        Outside = 1,
    }
}