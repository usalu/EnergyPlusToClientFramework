using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_WaterToAirHeatPump_OutdoorAirMixerObjectType
    {
        
        [JsonProperty("OutdoorAir:Mixer")]
        OutdoorAirMixer = 0,
    }
}