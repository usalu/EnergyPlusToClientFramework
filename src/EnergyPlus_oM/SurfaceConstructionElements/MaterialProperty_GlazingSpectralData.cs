using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Name is followed by up to 800 sets of normal-incidence measured values of [wavele" +
                 "ngth, transmittance, front reflectance, back reflectance] for wavelengths coveri" +
                 "ng the solar spectrum (from about 0.25 to 2.5 microns)")]
    public class MaterialProperty_GlazingSpectralData : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("wavelength_1")]
        public System.Nullable<float> Wavelength1 { get; set; } = null;
        

        [JsonProperty("transmittance_1")]
        public System.Nullable<float> Transmittance1 { get; set; } = null;
        

        [JsonProperty("front_reflectance_1")]
        public System.Nullable<float> FrontReflectance1 { get; set; } = null;
        

        [JsonProperty("back_reflectance_1")]
        public System.Nullable<float> BackReflectance1 { get; set; } = null;
        

        [JsonProperty("wavelength_2")]
        public System.Nullable<float> Wavelength2 { get; set; } = null;
        

        [JsonProperty("transmittance_2")]
        public System.Nullable<float> Transmittance2 { get; set; } = null;
        

        [JsonProperty("front_reflectance_2")]
        public System.Nullable<float> FrontReflectance2 { get; set; } = null;
        

        [JsonProperty("back_reflectance_2")]
        public System.Nullable<float> BackReflectance2 { get; set; } = null;
        

        [JsonProperty("wavelength_3")]
        public System.Nullable<float> Wavelength3 { get; set; } = null;
        

        [JsonProperty("transmittance_3")]
        public System.Nullable<float> Transmittance3 { get; set; } = null;
        

        [JsonProperty("front_reflectance_3")]
        public System.Nullable<float> FrontReflectance3 { get; set; } = null;
        

        [JsonProperty("back_reflectance_3")]
        public System.Nullable<float> BackReflectance3 { get; set; } = null;
        

        [JsonProperty("wavelength_4")]
        public System.Nullable<float> Wavelength4 { get; set; } = null;
        

        [JsonProperty("transmittance_4")]
        public System.Nullable<float> Transmittance4 { get; set; } = null;
        

        [JsonProperty("front_reflectance_4")]
        public System.Nullable<float> FrontReflectance4 { get; set; } = null;
        

        [JsonProperty("back_reflectance_4")]
        public System.Nullable<float> BackReflectance4 { get; set; } = null;
        

        [JsonProperty("extensions")]
        public string Extensions { get; set; } = "";
    }
}