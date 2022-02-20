using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_FourPipeFanCoil_OutdoorAirMixerObjectType
    {
        
        [JsonProperty("OutdoorAir:Mixer")]
        OutdoorAirMixer = 0,
    }
}