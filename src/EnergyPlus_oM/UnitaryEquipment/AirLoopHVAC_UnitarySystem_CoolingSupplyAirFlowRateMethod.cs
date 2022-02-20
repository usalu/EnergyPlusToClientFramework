using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_CoolingSupplyAirFlowRateMethod
    {
        
        [JsonProperty("FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 0,
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [JsonProperty("FractionOfAutosizedCoolingValue")]
        FractionOfAutosizedCoolingValue = 2,
        
        [JsonProperty("None")]
        None = 3,
        
        [JsonProperty("SupplyAirFlowRate")]
        SupplyAirFlowRate = 4,
    }
}