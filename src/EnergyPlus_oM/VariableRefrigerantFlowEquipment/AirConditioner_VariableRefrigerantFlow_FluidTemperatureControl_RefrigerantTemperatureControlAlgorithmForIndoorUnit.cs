using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    public enum AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_RefrigerantTemperatureControlAlgorithmForIndoorUnit
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantTemp")]
        ConstantTemp = 1,
        
        [JsonProperty("VariableTemp")]
        VariableTemp = 2,
    }
}