using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("If this object is omitted, the default solar and visible spectrum data will be us" +
                 "ed.")]
    [JsonObject("Site:SolarAndVisibleSpectrum")]
    public class Site_SolarAndVisibleSpectrum : BHoMObject, IEnergyPlusClass
    {
        

        [Description("The method specifies which of the solar and visible spectrum data to use in the c" +
                     "alculations. Choices: Default - existing hard-wired spectrum data in EnergyPlus." +
                     " UserDefined - user specified spectrum data referenced by the next two fields")]
        [JsonProperty("spectrum_data_method")]
        public Site_SolarAndVisibleSpectrum_SpectrumDataMethod SpectrumDataMethod { get; set; } = (Site_SolarAndVisibleSpectrum_SpectrumDataMethod)Enum.Parse(typeof(Site_SolarAndVisibleSpectrum_SpectrumDataMethod), "Default");
        

        [JsonProperty("solar_spectrum_data_object_name")]
        public string SolarSpectrumDataObjectName { get; set; } = "";
        

        [JsonProperty("visible_spectrum_data_object_name")]
        public string VisibleSpectrumDataObjectName { get; set; } = "";
    }
}