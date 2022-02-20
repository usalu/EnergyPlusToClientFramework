using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_CompressorRack_HeatRejectionLocation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Outdoors")]
        Outdoors = 1,
        
        [JsonProperty("Zone")]
        Zone = 2,
    }
}