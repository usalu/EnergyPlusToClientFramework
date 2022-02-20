using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_OutsideAirMixerObjectType
    {
        
        [JsonProperty("OutdoorAir:Mixer")]
        OutdoorAirMixer = 0,
    }
}