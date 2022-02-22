using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Undisturbed ground temperature object using the Xing 2014 2 harmonic parameter mo" +
                 "del.")]
    [JsonObject("Site:GroundTemperature:Undisturbed:Xing")]
    public class Site_GroundTemperature_Undisturbed_Xing : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("soil_thermal_conductivity")]
        public System.Nullable<float> SoilThermalConductivity { get; set; } = null;
        

        [JsonProperty("soil_density")]
        public System.Nullable<float> SoilDensity { get; set; } = null;
        

        [JsonProperty("soil_specific_heat")]
        public System.Nullable<float> SoilSpecificHeat { get; set; } = null;
        

        [JsonProperty("average_soil_surface_tempeature")]
        public System.Nullable<float> AverageSoilSurfaceTempeature { get; set; } = null;
        

        [JsonProperty("soil_surface_temperature_amplitude_1")]
        public System.Nullable<float> SoilSurfaceTemperatureAmplitude1 { get; set; } = null;
        

        [JsonProperty("soil_surface_temperature_amplitude_2")]
        public System.Nullable<float> SoilSurfaceTemperatureAmplitude2 { get; set; } = null;
        

        [JsonProperty("phase_shift_of_temperature_amplitude_1")]
        public System.Nullable<float> PhaseShiftOfTemperatureAmplitude1 { get; set; } = null;
        

        [JsonProperty("phase_shift_of_temperature_amplitude_2")]
        public System.Nullable<float> PhaseShiftOfTemperatureAmplitude2 { get; set; } = null;
    }
}