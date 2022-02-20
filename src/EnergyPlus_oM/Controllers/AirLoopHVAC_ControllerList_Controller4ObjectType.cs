using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum AirLoopHVAC_ControllerList_Controller4ObjectType
    {
        
        [JsonProperty("Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
        
        [JsonProperty("Controller:WaterCoil")]
        ControllerWaterCoil = 1,
    }
}