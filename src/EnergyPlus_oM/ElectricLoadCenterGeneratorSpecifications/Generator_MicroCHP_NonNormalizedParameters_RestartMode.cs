using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_MicroCHP_NonNormalizedParameters_RestartMode
    {
        
        [JsonProperty("MandatoryCoolDown")]
        MandatoryCoolDown = 0,
        
        [JsonProperty("OptionalCoolDown")]
        OptionalCoolDown = 1,
    }
}