using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum PhotovoltaicPerformance_Simple_ConversionEfficiencyInputMode
    {
        
        [JsonProperty("Fixed")]
        Fixed = 0,
        
        [JsonProperty("Scheduled")]
        Scheduled = 1,
    }
}