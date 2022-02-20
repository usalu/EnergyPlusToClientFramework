using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Pumps
{
    public enum Pump_VariableSpeed_VfdControlType
    {
        
        [JsonProperty("ManualControl")]
        ManualControl = 0,
        
        [JsonProperty("PressureSetpointControl")]
        PressureSetpointControl = 1,
    }
}