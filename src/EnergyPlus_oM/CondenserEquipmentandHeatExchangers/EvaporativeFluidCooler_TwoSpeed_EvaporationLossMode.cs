using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum EvaporativeFluidCooler_TwoSpeed_EvaporationLossMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LossFactor")]
        LossFactor = 1,
        
        [JsonProperty("SaturatedExit")]
        SaturatedExit = 2,
    }
}