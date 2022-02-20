using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_VariableDictionary_SortOption
    {
        
        [JsonProperty("Name")]
        Name = 0,
        
        [JsonProperty("Unsorted")]
        Unsorted = 1,
    }
}