using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_UserCurve_ReferenceTemperatureForConvectionHeatTransfer
    {
        
        [JsonProperty("AdjacentAirTemperature")]
        AdjacentAirTemperature = 0,
        
        [JsonProperty("MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 2,
    }
}