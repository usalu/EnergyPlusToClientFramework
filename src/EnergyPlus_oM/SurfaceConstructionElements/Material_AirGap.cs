using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Air Space in Opaque Construction")]
    [JsonObject("Material:AirGap")]
    public class Material_AirGap : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("thermal_resistance")]
        public System.Nullable<float> ThermalResistance { get; set; } = null;
    }
}