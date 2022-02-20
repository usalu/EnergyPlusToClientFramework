using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Surfaces_Drawing_ReportType
    {
        
        [JsonProperty("DXF")]
        DXF = 0,
        
        [JsonProperty("DXF:WireFrame")]
        DXFWireFrame = 1,
        
        [JsonProperty("VRML")]
        VRML = 2,
    }
}