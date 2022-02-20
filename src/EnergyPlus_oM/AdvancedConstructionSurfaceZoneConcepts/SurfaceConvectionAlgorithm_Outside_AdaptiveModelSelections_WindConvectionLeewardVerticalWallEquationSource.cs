using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionLeewardVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DOE2Leeward")]
        DOE2Leeward = 1,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 2,
        
        [JsonProperty("McAdams")]
        McAdams = 3,
        
        [JsonProperty("Mitchell")]
        Mitchell = 4,
        
        [JsonProperty("MoWiTTLeeward")]
        MoWiTTLeeward = 5,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 6,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 7,
        
        [JsonProperty("TARPLeeward")]
        TARPLeeward = 8,
        
        [JsonProperty("UserCurve")]
        UserCurve = 9,
    }
}