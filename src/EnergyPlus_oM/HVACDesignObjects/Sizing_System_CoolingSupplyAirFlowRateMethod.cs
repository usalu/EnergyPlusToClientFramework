using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_CoolingSupplyAirFlowRateMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DesignDay")]
        DesignDay = 1,
        
        [JsonProperty("Flow/System")]
        FlowSystem = 2,
        
        [JsonProperty("FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 3,
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 4,
        
        [JsonProperty("FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 5,
    }
}