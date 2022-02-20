using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_HybridUnitaryHVAC_MethodToChooseControlledInputsAndPartRuntimeFraction
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Automatic")]
        Automatic = 1,
        
        [JsonProperty("User Defined")]
        UserDefined = 2,
    }
}