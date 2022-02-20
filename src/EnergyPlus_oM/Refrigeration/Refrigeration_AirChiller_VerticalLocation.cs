using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_AirChiller_VerticalLocation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Ceiling")]
        Ceiling = 1,
        
        [JsonProperty("Floor")]
        Floor = 2,
        
        [JsonProperty("Middle")]
        Middle = 3,
    }
}