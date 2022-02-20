using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_FourPipeFanCoil_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 1,
    }
}