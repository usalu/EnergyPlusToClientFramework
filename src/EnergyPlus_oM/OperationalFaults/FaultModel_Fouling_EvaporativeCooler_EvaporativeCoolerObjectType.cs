using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_Fouling_EvaporativeCooler_EvaporativeCoolerObjectType
    {
        
        [JsonProperty("EvaporativeCooler:Indirect:WetCoil")]
        EvaporativeCoolerIndirectWetCoil = 0,
    }
}