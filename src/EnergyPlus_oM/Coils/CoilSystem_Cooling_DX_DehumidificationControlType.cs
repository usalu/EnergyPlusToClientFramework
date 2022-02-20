using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum CoilSystem_Cooling_DX_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("Multimode")]
        Multimode = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
}