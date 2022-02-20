using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    public enum Fan_ComponentModel_VfdEfficiencyType
    {
        
        [JsonProperty("Power")]
        Power = 0,
        
        [JsonProperty("Speed")]
        Speed = 1,
    }
}