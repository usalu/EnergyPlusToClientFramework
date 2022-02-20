using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionHorizontalRoofEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlockenWindward")]
        BlockenWindward = 1,
        
        [JsonProperty("ClearRoof")]
        ClearRoof = 2,
        
        [JsonProperty("DOE2Windward")]
        DOE2Windward = 3,
        
        [JsonProperty("EmmelRoof")]
        EmmelRoof = 4,
        
        [JsonProperty("McAdams")]
        McAdams = 5,
        
        [JsonProperty("Mitchell")]
        Mitchell = 6,
        
        [JsonProperty("MoWiTTWindward")]
        MoWiTTWindward = 7,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 8,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 9,
        
        [JsonProperty("TARPWindward")]
        TARPWindward = 10,
        
        [JsonProperty("UserCurve")]
        UserCurve = 11,
    }
}