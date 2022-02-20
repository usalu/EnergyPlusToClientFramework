using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum Building_SolarDistribution
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FullExterior")]
        FullExterior = 1,
        
        [JsonProperty("FullExteriorWithReflections")]
        FullExteriorWithReflections = 2,
        
        [JsonProperty("FullInteriorAndExterior")]
        FullInteriorAndExterior = 3,
        
        [JsonProperty("FullInteriorAndExteriorWithReflections")]
        FullInteriorAndExteriorWithReflections = 4,
        
        [JsonProperty("MinimalShadowing")]
        MinimalShadowing = 5,
    }
}