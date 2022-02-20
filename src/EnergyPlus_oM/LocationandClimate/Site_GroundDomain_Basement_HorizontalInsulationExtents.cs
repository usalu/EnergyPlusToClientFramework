using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum Site_GroundDomain_Basement_HorizontalInsulationExtents
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Full")]
        Full = 1,
        
        [JsonProperty("Perimeter")]
        Perimeter = 2,
    }
}