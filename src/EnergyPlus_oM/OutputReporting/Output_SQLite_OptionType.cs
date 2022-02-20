using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_SQLite_OptionType
    {
        
        [JsonProperty("Simple")]
        Simple = 0,
        
        [JsonProperty("SimpleAndTabular")]
        SimpleAndTabular = 1,
    }
}