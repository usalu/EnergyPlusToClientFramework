using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ShadowCalculation_SkyDiffuseModelingAlgorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSkyDiffuseModeling")]
        DetailedSkyDiffuseModeling = 1,
        
        [JsonProperty("SimpleSkyDiffuseModeling")]
        SimpleSkyDiffuseModeling = 2,
    }
}