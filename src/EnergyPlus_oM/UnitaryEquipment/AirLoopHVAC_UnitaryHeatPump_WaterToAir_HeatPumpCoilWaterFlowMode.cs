using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatPumpCoilWaterFlowMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("ConstantOnDemand")]
        ConstantOnDemand = 2,
        
        [JsonProperty("Cycling")]
        Cycling = 3,
    }
}