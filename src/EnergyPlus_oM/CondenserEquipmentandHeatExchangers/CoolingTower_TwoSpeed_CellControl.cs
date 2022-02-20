using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum CoolingTower_TwoSpeed_CellControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximalCell")]
        MaximalCell = 1,
        
        [JsonProperty("MinimalCell")]
        MinimalCell = 2,
    }
}