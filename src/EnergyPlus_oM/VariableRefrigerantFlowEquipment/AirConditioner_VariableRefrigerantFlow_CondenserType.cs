using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    public enum AirConditioner_VariableRefrigerantFlow_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
        
        [JsonProperty("WaterCooled")]
        WaterCooled = 3,
    }
}