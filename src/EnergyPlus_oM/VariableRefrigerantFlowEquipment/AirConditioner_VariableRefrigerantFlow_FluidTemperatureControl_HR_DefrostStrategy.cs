using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    public enum AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
}