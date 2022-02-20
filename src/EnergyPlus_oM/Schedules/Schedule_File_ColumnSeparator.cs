using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    public enum Schedule_File_ColumnSeparator
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Comma")]
        Comma = 1,
        
        [JsonProperty("Semicolon")]
        Semicolon = 2,
        
        [JsonProperty("Space")]
        Space = 3,
        
        [JsonProperty("Tab")]
        Tab = 4,
    }
}