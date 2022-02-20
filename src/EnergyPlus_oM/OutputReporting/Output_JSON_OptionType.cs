using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_JSON_OptionType
    {
        
        [JsonProperty("TimeSeries")]
        TimeSeries = 0,
        
        [JsonProperty("TimeSeriesAndTabular")]
        TimeSeriesAndTabular = 1,
    }
}