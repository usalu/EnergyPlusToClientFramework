using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("VariableRefrigerantFlowDX")]
        VariableRefrigerantFlowDX = 2,
    }
}