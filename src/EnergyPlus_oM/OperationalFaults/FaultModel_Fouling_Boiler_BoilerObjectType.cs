using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_Fouling_Boiler_BoilerObjectType
    {
        
        [JsonProperty("Boiler:HotWater")]
        BoilerHotWater = 0,
    }
}