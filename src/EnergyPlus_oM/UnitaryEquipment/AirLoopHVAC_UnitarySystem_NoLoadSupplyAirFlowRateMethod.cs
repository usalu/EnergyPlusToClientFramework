using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_NoLoadSupplyAirFlowRateMethod
    {
        
        [JsonProperty("FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 0,
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [JsonProperty("FlowPerHeatingCapacity")]
        FlowPerHeatingCapacity = 2,
        
        [JsonProperty("FractionOfAutosizedCoolingValue")]
        FractionOfAutosizedCoolingValue = 3,
        
        [JsonProperty("FractionOfAutosizedHeatingValue")]
        FractionOfAutosizedHeatingValue = 4,
        
        [JsonProperty("None")]
        None = 5,
        
        [JsonProperty("SupplyAirFlowRate")]
        SupplyAirFlowRate = 6,
    }
}