using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_HeatingSupplyAirFlowRateMethod
    {
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 0,
        
        [JsonProperty("FlowPerHeatingCapacity")]
        FlowPerHeatingCapacity = 1,
        
        [JsonProperty("FractionOfAutosizedHeatingValue")]
        FractionOfAutosizedHeatingValue = 2,
        
        [JsonProperty("None")]
        None = 3,
        
        [JsonProperty("SupplyAirFlowRate")]
        SupplyAirFlowRate = 4,
    }
}