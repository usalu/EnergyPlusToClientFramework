using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Table_TimeBins_VariableType
    {
        
        [JsonProperty("Energy")]
        Energy = 0,
        
        [JsonProperty("Power")]
        Power = 1,
        
        [JsonProperty("Temperature")]
        Temperature = 2,
        
        [JsonProperty("VolumetricFlow")]
        VolumetricFlow = 3,
    }
}