using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum Site_SolarAndVisibleSpectrum_SpectrumDataMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Default")]
        Default = 1,
        
        [JsonProperty("UserDefined")]
        UserDefined = 2,
    }
}