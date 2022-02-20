using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Surfaces_Drawing_ReportSpecifications1
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("RegularPolyline")]
        RegularPolyline = 1,
        
        [JsonProperty("ThickPolyline")]
        ThickPolyline = 2,
        
        [JsonProperty("Triangulate3DFace")]
        Triangulate3DFace = 3,
    }
}