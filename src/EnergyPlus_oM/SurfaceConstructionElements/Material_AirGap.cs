using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Air Space in Opaque Construction")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Material_AirGap : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("thermal_resistance")]
        public System.Nullable<float> ThermalResistance { get; set; } = null;
    }
}