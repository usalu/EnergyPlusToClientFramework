using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Constructions_DetailsType2
    {
        
        [JsonProperty("Constructions")]
        Constructions = 0,
        
        [JsonProperty("Materials")]
        Materials = 1,
    }
}