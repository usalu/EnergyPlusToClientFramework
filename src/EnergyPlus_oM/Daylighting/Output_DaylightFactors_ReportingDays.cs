using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    public enum Output_DaylightFactors_ReportingDays
    {
        
        [JsonProperty("AllShadowCalculationDays")]
        AllShadowCalculationDays = 0,
        
        [JsonProperty("SizingDays")]
        SizingDays = 1,
    }
}