using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum CoolingTower_VariableSpeed_EvaporationLossMode
    {
        
        [JsonProperty("LossFactor")]
        LossFactor = 0,
        
        [JsonProperty("SaturatedExit")]
        SaturatedExit = 1,
    }
}