using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum OutputControl_Table_Style_ColumnSeparator
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("All")]
        All = 1,
        
        [JsonProperty("Comma")]
        Comma = 2,
        
        [JsonProperty("CommaAndHTML")]
        CommaAndHTML = 3,
        
        [JsonProperty("CommaAndXML")]
        CommaAndXML = 4,
        
        [JsonProperty("Fixed")]
        Fixed = 5,
        
        [JsonProperty("HTML")]
        HTML = 6,
        
        [JsonProperty("Tab")]
        Tab = 7,
        
        [JsonProperty("TabAndHTML")]
        TabAndHTML = 8,
        
        [JsonProperty("XML")]
        XML = 9,
        
        [JsonProperty("XMLandHTML")]
        XMLandHTML = 10,
    }
}