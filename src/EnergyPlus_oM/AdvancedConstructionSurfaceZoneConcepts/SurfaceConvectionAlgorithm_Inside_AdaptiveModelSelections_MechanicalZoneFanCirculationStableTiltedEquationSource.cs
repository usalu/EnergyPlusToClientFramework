using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("UserCurve")]
        UserCurve = 1,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 2,
    }
}