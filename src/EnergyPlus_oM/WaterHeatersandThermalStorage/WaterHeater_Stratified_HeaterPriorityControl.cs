using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_Stratified_HeaterPriorityControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MasterSlave")]
        MasterSlave = 1,
        
        [JsonProperty("Simultaneous")]
        Simultaneous = 2,
    }
}