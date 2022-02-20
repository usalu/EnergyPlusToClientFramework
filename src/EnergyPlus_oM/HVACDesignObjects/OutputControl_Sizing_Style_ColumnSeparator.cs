using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum OutputControl_Sizing_Style_ColumnSeparator
    {
        
        [JsonProperty("Comma")]
        Comma = 0,
        
        [JsonProperty("Fixed")]
        Fixed = 1,
        
        [JsonProperty("Tab")]
        Tab = 2,
    }
}