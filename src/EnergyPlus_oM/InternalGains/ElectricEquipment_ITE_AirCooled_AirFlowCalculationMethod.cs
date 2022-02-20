using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum ElectricEquipment_ITE_AirCooled_AirFlowCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FlowControlWithApproachTemperatures")]
        FlowControlWithApproachTemperatures = 1,
        
        [JsonProperty("FlowFromSystem")]
        FlowFromSystem = 2,
    }
}