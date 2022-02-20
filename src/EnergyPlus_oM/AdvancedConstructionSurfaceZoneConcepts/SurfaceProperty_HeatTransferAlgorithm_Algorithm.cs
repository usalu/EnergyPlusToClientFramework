using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_HeatTransferAlgorithm_Algorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CombinedHeatAndMoistureFiniteElement")]
        CombinedHeatAndMoistureFiniteElement = 1,
        
        [JsonProperty("ConductionFiniteDifference")]
        ConductionFiniteDifference = 2,
        
        [JsonProperty("ConductionTransferFunction")]
        ConductionTransferFunction = 3,
        
        [JsonProperty("MoisturePenetrationDepthConductionTransferFunction")]
        MoisturePenetrationDepthConductionTransferFunction = 4,
    }
}