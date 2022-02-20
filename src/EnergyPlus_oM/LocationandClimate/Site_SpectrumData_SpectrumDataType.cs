using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum Site_SpectrumData_SpectrumDataType
    {
        
        [JsonProperty("Solar")]
        Solar = 0,
        
        [JsonProperty("Visible")]
        Visible = 1,
    }
}