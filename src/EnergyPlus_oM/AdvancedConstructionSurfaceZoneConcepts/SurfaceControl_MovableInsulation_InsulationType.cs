using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceControl_MovableInsulation_InsulationType
    {
        
        [JsonProperty("Inside")]
        Inside = 0,
        
        [JsonProperty("Outside")]
        Outside = 1,
    }
}