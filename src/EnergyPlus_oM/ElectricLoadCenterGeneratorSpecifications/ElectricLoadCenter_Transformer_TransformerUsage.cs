using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Transformer_TransformerUsage
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LoadCenterPowerConditioning")]
        LoadCenterPowerConditioning = 1,
        
        [JsonProperty("PowerInFromGrid")]
        PowerInFromGrid = 2,
        
        [JsonProperty("PowerOutToGrid")]
        PowerOutToGrid = 3,
    }
}