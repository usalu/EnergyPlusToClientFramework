using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_PVWatts_ArrayGeometryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Surface")]
        Surface = 1,
        
        [JsonProperty("TiltAzimuth")]
        TiltAzimuth = 2,
    }
}