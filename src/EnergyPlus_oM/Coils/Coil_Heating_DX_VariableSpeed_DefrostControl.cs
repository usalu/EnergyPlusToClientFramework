using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_DX_VariableSpeed_DefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
}