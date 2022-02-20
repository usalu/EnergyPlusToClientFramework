using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_PVWatts_ModuleType
    {
        
        [JsonProperty("Premium")]
        Premium = 0,
        
        [JsonProperty("Standard")]
        Standard = 1,
        
        [JsonProperty("ThinFilm")]
        ThinFilm = 2,
    }
}