using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_VariableDictionary_KeyField
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("IDF")]
        IDF = 1,
        
        [JsonProperty("regular")]
        Regular = 2,
    }
}