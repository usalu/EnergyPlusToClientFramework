using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_Sizing_DesignMode
    {
        
        [JsonProperty("PeakDraw")]
        PeakDraw = 0,
        
        [JsonProperty("PerFloorArea")]
        PerFloorArea = 1,
        
        [JsonProperty("PerPerson")]
        PerPerson = 2,
        
        [JsonProperty("PerSolarCollectorArea")]
        PerSolarCollectorArea = 3,
        
        [JsonProperty("PerUnit")]
        PerUnit = 4,
        
        [JsonProperty("ResidentialHUD-FHAMinimum")]
        ResidentialHUDFHAMinimum = 5,
    }
}