using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionWindwardVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlockenWindward")]
        BlockenWindward = 1,
        
        [JsonProperty("DOE2Windward")]
        DOE2Windward = 2,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 3,
        
        [JsonProperty("McAdams")]
        McAdams = 4,
        
        [JsonProperty("Mitchell")]
        Mitchell = 5,
        
        [JsonProperty("MoWiTTWindward")]
        MoWiTTWindward = 6,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 7,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 8,
        
        [JsonProperty("TARPWindward")]
        TARPWindward = 9,
        
        [JsonProperty("UserCurve")]
        UserCurve = 10,
    }
}