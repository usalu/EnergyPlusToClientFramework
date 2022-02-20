using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("thermochromic glass at different temperatures")]
    [JsonObject("WindowMaterial:GlazingGroup:Thermochromic")]
    public class WindowMaterial_GlazingGroup_Thermochromic : BHoMObject
    {
        

        [JsonProperty("temperature_data")]
        public string TemperatureData { get; set; } = "";
    }
}