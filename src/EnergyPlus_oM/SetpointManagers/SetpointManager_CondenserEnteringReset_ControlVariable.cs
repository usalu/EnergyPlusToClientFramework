using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_CondenserEnteringReset_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
}