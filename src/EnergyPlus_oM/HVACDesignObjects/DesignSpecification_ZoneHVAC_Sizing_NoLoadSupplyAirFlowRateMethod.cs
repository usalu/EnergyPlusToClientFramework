using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [JsonProperty("FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 2,
        
        [JsonProperty("FractionOfAutosizedHeatingAirflow")]
        FractionOfAutosizedHeatingAirflow = 3,
        
        [JsonProperty("None")]
        None = 4,
        
        [JsonProperty("SupplyAirFlowRate")]
        SupplyAirFlowRate = 5,
    }
}