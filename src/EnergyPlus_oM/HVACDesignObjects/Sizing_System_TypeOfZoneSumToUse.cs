using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_TypeOfZoneSumToUse
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coincident")]
        Coincident = 1,
        
        [JsonProperty("NonCoincident")]
        NonCoincident = 2,
    }
}