using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum CoolingTower_VariableSpeed_BlowdownCalculationMode
    {
        
        [JsonProperty("ConcentrationRatio")]
        ConcentrationRatio = 0,
        
        [JsonProperty("ScheduledRate")]
        ScheduledRate = 1,
    }
}