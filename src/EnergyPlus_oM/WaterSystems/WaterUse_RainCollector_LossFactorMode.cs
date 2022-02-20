using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    public enum WaterUse_RainCollector_LossFactorMode
    {
        
        [JsonProperty("Constant")]
        Constant = 0,
        
        [JsonProperty("Scheduled")]
        Scheduled = 1,
    }
}