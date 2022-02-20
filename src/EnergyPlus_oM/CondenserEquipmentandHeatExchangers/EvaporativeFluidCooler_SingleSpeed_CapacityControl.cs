using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum EvaporativeFluidCooler_SingleSpeed_CapacityControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FanCycling")]
        FanCycling = 1,
        
        [JsonProperty("FluidBypass")]
        FluidBypass = 2,
    }
}