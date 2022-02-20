using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    public enum OutputControl_IlluminanceMap_Style_ColumnSeparator
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Comma")]
        Comma = 1,
        
        [JsonProperty("Fixed")]
        Fixed = 2,
        
        [JsonProperty("Tab")]
        Tab = 3,
    }
}