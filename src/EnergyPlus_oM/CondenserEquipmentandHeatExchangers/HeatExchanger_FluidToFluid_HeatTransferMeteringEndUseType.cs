using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FreeCooling")]
        FreeCooling = 1,
        
        [JsonProperty("HeatRecovery")]
        HeatRecovery = 2,
        
        [JsonProperty("HeatRecoveryForCooling")]
        HeatRecoveryForCooling = 3,
        
        [JsonProperty("HeatRecoveryForHeating")]
        HeatRecoveryForHeating = 4,
        
        [JsonProperty("HeatRejection")]
        HeatRejection = 5,
        
        [JsonProperty("LoopToLoop")]
        LoopToLoop = 6,
    }
}