using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum ThermalStorage_Ice_Detailed_ThawProcessIndicator
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("InsideMelt")]
        InsideMelt = 1,
        
        [JsonProperty("OutsideMelt")]
        OutsideMelt = 2,
    }
}