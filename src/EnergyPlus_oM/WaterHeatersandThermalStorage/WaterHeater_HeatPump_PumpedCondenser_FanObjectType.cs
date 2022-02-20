using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_PumpedCondenser_FanObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
        
        [JsonProperty("Fan:SystemModel")]
        FanSystemModel = 2,
    }
}