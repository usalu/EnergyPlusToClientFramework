using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Specifies the properties of window shade materials. Reflectance and emissivity properties are assumed to be the same on both sides of the shade. Shades are considered to be perfect diffusers (all transmitted and reflected radiation is hemispherically-diffuse) independent of angle of incidence.")]
    [JsonObject("WindowMaterial:Shade")]
    public class WindowMaterial_Shade : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Assumed independent of incidence angle")]
        [JsonProperty("solar_transmittance")]
        public System.Nullable<float> SolarTransmittance { get; set; } = null;
        

        [Description("Assumed same for both sides Assumed independent of incidence angle")]
        [JsonProperty("solar_reflectance")]
        public System.Nullable<float> SolarReflectance { get; set; } = null;
        

        [Description("Assumed independent of incidence angle")]
        [JsonProperty("visible_transmittance")]
        public System.Nullable<float> VisibleTransmittance { get; set; } = null;
        

        [Description("Assumed same for both sides Assumed independent of incidence angle")]
        [JsonProperty("visible_reflectance")]
        public System.Nullable<float> VisibleReflectance { get; set; } = null;
        

        [JsonProperty("infrared_hemispherical_emissivity")]
        public System.Nullable<float> InfraredHemisphericalEmissivity { get; set; } = null;
        

        [JsonProperty("infrared_transmittance")]
        public System.Nullable<float> InfraredTransmittance { get; set; } = null;
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = null;
        

        [JsonProperty("conductivity")]
        public System.Nullable<float> Conductivity { get; set; } = null;
        

        [JsonProperty("shade_to_glass_distance")]
        public System.Nullable<float> ShadeToGlassDistance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

        [JsonProperty("top_opening_multiplier")]
        public System.Nullable<float> TopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("bottom_opening_multiplier")]
        public System.Nullable<float> BottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("left_side_opening_multiplier")]
        public System.Nullable<float> LeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("right_side_opening_multiplier")]
        public System.Nullable<float> RightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("airflow_permeability")]
        public System.Nullable<float> AirflowPermeability { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}