using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    public enum ExternalInterface_NameOfExternalInterface
    {
        
        [JsonProperty("FunctionalMockupUnitExport")]
        FunctionalMockupUnitExport = 0,
        
        [JsonProperty("FunctionalMockupUnitImport")]
        FunctionalMockupUnitImport = 1,
        
        [JsonProperty("PtolemyServer")]
        PtolemyServer = 2,
    }
}