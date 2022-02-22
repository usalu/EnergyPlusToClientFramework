using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("thermochromic glass at different temperatures")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_GlazingGroup_Thermochromic : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("temperature_data")]
        public string TemperatureData { get; set; } = "";
    }
}