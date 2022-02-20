using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_HumidistatOffset_HumidistatOffsetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ThermostatOffsetDependent")]
        ThermostatOffsetDependent = 1,
        
        [JsonProperty("ThermostatOffsetIndependent")]
        ThermostatOffsetIndependent = 2,
    }
}