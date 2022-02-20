using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowProperty_AirflowControl_AirflowSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("IndoorAir")]
        IndoorAir = 1,
        
        [JsonProperty("OutdoorAir")]
        OutdoorAir = 2,
    }
}