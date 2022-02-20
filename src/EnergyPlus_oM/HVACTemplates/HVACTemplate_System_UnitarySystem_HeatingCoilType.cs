using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitarySystem_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("MultiSpeedDXHeatPumpAirSource")]
        MultiSpeedDXHeatPumpAirSource = 4,
        
        [JsonProperty("MultiStageElectric")]
        MultiStageElectric = 5,
        
        [JsonProperty("MultiStageGas")]
        MultiStageGas = 6,
        
        [JsonProperty("None")]
        None = 7,
        
        [JsonProperty("SingleSpeedDXHeatPumpAirSource")]
        SingleSpeedDXHeatPumpAirSource = 8,
        
        [JsonProperty("SingleSpeedDXHeatPumpWaterSource")]
        SingleSpeedDXHeatPumpWaterSource = 9,
    }
}