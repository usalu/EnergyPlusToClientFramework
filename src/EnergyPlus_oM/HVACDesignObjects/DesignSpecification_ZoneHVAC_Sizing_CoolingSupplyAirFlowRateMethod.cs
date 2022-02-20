using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 1,
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 2,
        
        [JsonProperty("FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 3,
        
        [JsonProperty("None")]
        None = 4,
        
        [JsonProperty("SupplyAirFlowRate")]
        SupplyAirFlowRate = 5,
    }
}