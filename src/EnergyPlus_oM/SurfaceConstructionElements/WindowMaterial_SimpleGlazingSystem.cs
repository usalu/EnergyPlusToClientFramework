using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Alternate method of describing windows This window material object is used to def" +
                 "ine an entire glazing system using simple performance parameters.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_SimpleGlazingSystem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Enter U-Factor including film coefficients Note that the effective upper limit fo" +
                     "r U-factor is 5.8 W/m2-K")]
        [JsonProperty("u_factor")]
        public System.Nullable<float> UFactor { get; set; } = null;
        

        [Description("SHGC at Normal Incidence")]
        [JsonProperty("solar_heat_gain_coefficient")]
        public System.Nullable<float> SolarHeatGainCoefficient { get; set; } = null;
        

        [Description("VT at Normal Incidence optional")]
        [JsonProperty("visible_transmittance")]
        public System.Nullable<float> VisibleTransmittance { get; set; } = null;
    }
}