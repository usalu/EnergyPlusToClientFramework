using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_EvaporativeCoolerUnit_FirstEvaporativeCoolerObjectType
    {
        
        [JsonProperty("EvaporativeCooler:Direct:CelDekPad")]
        EvaporativeCoolerDirectCelDekPad = 0,
        
        [JsonProperty("EvaporativeCooler:Direct:ResearchSpecial")]
        EvaporativeCoolerDirectResearchSpecial = 1,
        
        [JsonProperty("EvaporativeCooler:Indirect:CelDekPad")]
        EvaporativeCoolerIndirectCelDekPad = 2,
        
        [JsonProperty("EvaporativeCooler:Indirect:ResearchSpecial")]
        EvaporativeCoolerIndirectResearchSpecial = 3,
        
        [JsonProperty("EvaporativeCooler:Indirect:WetCoil")]
        EvaporativeCoolerIndirectWetCoil = 4,
    }
}