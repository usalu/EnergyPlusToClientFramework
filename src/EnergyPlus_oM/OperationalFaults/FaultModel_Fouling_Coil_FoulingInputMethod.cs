using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_Fouling_Coil_FoulingInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FouledUARated")]
        FouledUARated = 1,
        
        [JsonProperty("FoulingFactor")]
        FoulingFactor = 2,
    }
}