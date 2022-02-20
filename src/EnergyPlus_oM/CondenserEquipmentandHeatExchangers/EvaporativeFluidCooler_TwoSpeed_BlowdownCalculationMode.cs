using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum EvaporativeFluidCooler_TwoSpeed_BlowdownCalculationMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConcentrationRatio")]
        ConcentrationRatio = 1,
        
        [JsonProperty("ScheduledRate")]
        ScheduledRate = 2,
    }
}