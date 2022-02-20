using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_HeatingSupplyAirFlowRateMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DesignDay")]
        DesignDay = 1,
        
        [JsonProperty("Flow/System")]
        FlowSystem = 2,
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 3,
        
        [JsonProperty("FlowPerHeatingCapacity")]
        FlowPerHeatingCapacity = 4,
        
        [JsonProperty("FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 5,
        
        [JsonProperty("FractionOfAutosizedHeatingAirflow")]
        FractionOfAutosizedHeatingAirflow = 6,
    }
}