using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Undisturbed ground temperature object using the Kusuda-Achenbach 1965 correlation" +
                 ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Undisturbed_KusudaAchenbach : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("soil_thermal_conductivity")]
        public System.Nullable<float> SoilThermalConductivity { get; set; } = null;
        

        [JsonProperty("soil_density")]
        public System.Nullable<float> SoilDensity { get; set; } = null;
        

        [JsonProperty("soil_specific_heat")]
        public System.Nullable<float> SoilSpecificHeat { get; set; } = null;
        

        [Description("Annual average surface temperature If left blank the Site:GroundTemperature:Shall" +
                     "ow object must be included in the input The soil temperature, amplitude, and pha" +
                     "se shift must all be included or omitted together")]
        [JsonProperty("average_soil_surface_temperature")]
        public System.Nullable<float> AverageSoilSurfaceTemperature { get; set; } = null;
        

        [Description("Annual average surface temperature variation from average. If left blank the Site" +
                     ":GroundTemperature:Shallow object must be included in the input The soil tempera" +
                     "ture, amplitude, and phase shift must all be included or omitted together")]
        [JsonProperty("average_amplitude_of_surface_temperature")]
        public System.Nullable<float> AverageAmplitudeOfSurfaceTemperature { get; set; } = null;
        

        [Description(@"The phase shift of minimum surface temperature, or the day of the year when the minimum surface temperature occurs. If left blank the Site:GroundTemperature:Shallow object must be included in the input The soil temperature, amplitude, and phase shift must all be included or omitted together")]
        [JsonProperty("phase_shift_of_minimum_surface_temperature")]
        public System.Nullable<float> PhaseShiftOfMinimumSurfaceTemperature { get; set; } = null;
    }
}