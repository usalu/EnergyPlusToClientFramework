using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_WaterCoil_Action
    {
        
        [JsonProperty("Normal")]
        Normal = 0,
        
        [JsonProperty("Reverse")]
        Reverse = 1,
    }
}