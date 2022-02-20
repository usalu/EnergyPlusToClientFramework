using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ShadowCalculation_ShadingCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Imported")]
        Imported = 1,
        
        [JsonProperty("PixelCounting")]
        PixelCounting = 2,
        
        [JsonProperty("PolygonClipping")]
        PolygonClipping = 3,
        
        [JsonProperty("Scheduled")]
        Scheduled = 4,
    }
}