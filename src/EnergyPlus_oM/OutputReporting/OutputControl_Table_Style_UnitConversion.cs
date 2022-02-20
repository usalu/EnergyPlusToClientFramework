using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum OutputControl_Table_Style_UnitConversion
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
    }
}