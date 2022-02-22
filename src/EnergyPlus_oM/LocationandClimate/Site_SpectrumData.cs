using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Spectrum Data Type is followed by up to 107 sets of normal-incidence measured val" +
                 "ues of [wavelength, spectrum] for wavelengths covering the solar (0.25 to 2.5 mi" +
                 "crons) or visible spectrum (0.38 to 0.78 microns)")]
    public class Site_SpectrumData : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("spectrum_data_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_SpectrumData_SpectrumDataType SpectrumDataType { get; set; } = (Site_SpectrumData_SpectrumDataType)Enum.Parse(typeof(Site_SpectrumData_SpectrumDataType), "Solar");
        

        [JsonProperty("wavelength")]
        public System.Nullable<float> Wavelength { get; set; } = null;
        

        [JsonProperty("spectrum")]
        public System.Nullable<float> Spectrum { get; set; } = null;
        

        [JsonProperty("wavelength_1")]
        public System.Nullable<float> Wavelength1 { get; set; } = null;
        

        [JsonProperty("spectrum_2")]
        public System.Nullable<float> Spectrum2 { get; set; } = null;
        

        [JsonProperty("extensions")]
        public string Extensions { get; set; } = "";
    }
}