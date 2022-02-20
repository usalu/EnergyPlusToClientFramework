using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Transformer_ConductorMaterial
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Aluminum")]
        Aluminum = 1,
        
        [JsonProperty("Copper")]
        Copper = 2,
    }
}