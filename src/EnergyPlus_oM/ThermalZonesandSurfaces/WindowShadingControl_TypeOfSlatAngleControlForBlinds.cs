using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowShadingControl_TypeOfSlatAngleControlForBlinds
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlockBeamSolar")]
        BlockBeamSolar = 1,
        
        [JsonProperty("FixedSlatAngle")]
        FixedSlatAngle = 2,
        
        [JsonProperty("ScheduledSlatAngle")]
        ScheduledSlatAngle = 3,
    }
}