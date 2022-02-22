using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("thermochromic glass at different temperatures")]
    public class WindowMaterial_GlazingGroup_Thermochromic : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("temperature_data")]
        public string TemperatureData { get; set; } = "";
    }
}