using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_SQLite_UnitConversionForTabularData
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("InchPound")]
        InchPound = 1,
        
        [JsonProperty("JtoGJ")]
        JtoGJ = 2,
        
        [JsonProperty("JtoKWH")]
        JtoKWH = 3,
        
        [JsonProperty("JtoMJ")]
        JtoMJ = 4,
        
        [JsonProperty("None")]
        None = 5,
        
        [JsonProperty("UseOutputControlTableStyle")]
        UseOutputControlTableStyle = 6,
    }
}