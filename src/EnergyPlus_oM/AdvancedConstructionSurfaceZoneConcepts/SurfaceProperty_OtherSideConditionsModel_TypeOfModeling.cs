using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_OtherSideConditionsModel_TypeOfModeling
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConvectiveUnderwater")]
        ConvectiveUnderwater = 1,
        
        [JsonProperty("GapConvectionRadiation")]
        GapConvectionRadiation = 2,
        
        [JsonProperty("GroundCoupledSurface")]
        GroundCoupledSurface = 3,
        
        [JsonProperty("UndergroundPipingSystemSurface")]
        UndergroundPipingSystemSurface = 4,
    }
}