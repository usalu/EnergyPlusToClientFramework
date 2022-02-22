using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Glass material properties for Windows or Glass Doors Index of Refraction/Extincti" +
                 "on Coefficient input method Not to be used for coated glass")]
    public class WindowMaterial_Glazing_RefractionExtinctionMethod : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = null;
        

        [JsonProperty("solar_index_of_refraction")]
        public System.Nullable<float> SolarIndexOfRefraction { get; set; } = null;
        

        [JsonProperty("solar_extinction_coefficient")]
        public System.Nullable<float> SolarExtinctionCoefficient { get; set; } = null;
        

        [JsonProperty("visible_index_of_refraction")]
        public System.Nullable<float> VisibleIndexOfRefraction { get; set; } = null;
        

        [JsonProperty("visible_extinction_coefficient")]
        public System.Nullable<float> VisibleExtinctionCoefficient { get; set; } = null;
        

        [JsonProperty("infrared_transmittance_at_normal_incidence")]
        public System.Nullable<float> InfraredTransmittanceAtNormalIncidence { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Emissivity of front and back side assumed equal")]
        [JsonProperty("infrared_hemispherical_emissivity")]
        public System.Nullable<float> InfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty("conductivity")]
        public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("dirt_correction_factor_for_solar_and_visible_transmittance")]
        public System.Nullable<float> DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("solar_diffusing")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SolarDiffusing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
}