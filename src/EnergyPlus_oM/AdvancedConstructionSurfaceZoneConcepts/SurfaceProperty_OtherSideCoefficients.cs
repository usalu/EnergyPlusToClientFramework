using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object sets the other side conditions for a surface in a variety of ways.")]
    [JsonObject("SurfaceProperty:OtherSideCoefficients")]
    public class SurfaceProperty_OtherSideCoefficients : BHoMObject
    {
        

        [Description(@"if>0, this field becomes the exterior convective/radiative film coefficient and the other fields are used to calculate the outdoor air temperature then exterior surface temperature based on outdoor air and specified coefficient if<=0, then remaining fields calculate the outside surface temperature The following fields are used in the equation: OtherSideTemp=N2*N3 + N4*OutdoorDry-bulb + N5*GroundTemp + N6*WindSpeed*OutdoorDry-bulb + N7*TempZone + N9*TempPrev")]
        [JsonProperty("combined_convective_radiative_film_coefficient")]
        public System.Nullable<float> CombinedConvectiveRadiativeFilmCoefficient { get; set; } = null;
        

        [Description("This parameter will be overwritten by the values from the Constant Temperature Sc" +
                     "hedule Name (below) if one is present")]
        [JsonProperty("constant_temperature")]
        public System.Nullable<float> ConstantTemperature { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This coefficient is used even with a Schedule. It should normally be 1.0 in that " +
                     "case. This field is ignored if Sinusoidal Variation of Constant Temperature Coef" +
                     "ficient = Yes.")]
        [JsonProperty("constant_temperature_coefficient")]
        public System.Nullable<float> ConstantTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("external_dry_bulb_temperature_coefficient")]
        public System.Nullable<float> ExternalDryBulbTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("ground_temperature_coefficient")]
        public System.Nullable<float> GroundTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("wind_speed_coefficient")]
        public System.Nullable<float> WindSpeedCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("zone_air_temperature_coefficient")]
        public System.Nullable<float> ZoneAirTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Name of schedule for values of constant temperature. Schedule values replace any " +
                     "value specified in the field Constant Temperature.")]
        [JsonProperty("constant_temperature_schedule_name")]
        public string ConstantTemperatureScheduleName { get; set; } = "";
        

        [Description("Optionally used to vary Constant Temperature Coefficient with unitary sine wave")]
        [JsonProperty("sinusoidal_variation_of_constant_temperature_coefficient")]
        public EmptyNoYes SinusoidalVariationOfConstantTemperatureCoefficient { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Use with sinusoidal variation to define the time period")]
        [JsonProperty("period_of_sinusoidal_variation")]
        public System.Nullable<float> PeriodOfSinusoidalVariation { get; set; } = (System.Nullable<float>)Single.Parse("24", CultureInfo.InvariantCulture);
        

        [Description("This coefficient multiplies the other side temperature result from the previous z" +
                     "one timestep")]
        [JsonProperty("previous_other_side_temperature_coefficient")]
        public System.Nullable<float> PreviousOtherSideTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field specifies a lower limit for the other side temperature result. Blank i" +
                     "ndicates no limit")]
        [JsonProperty("minimum_other_side_temperature_limit")]
        public System.Nullable<float> MinimumOtherSideTemperatureLimit { get; set; } = null;
        

        [Description("This field specifies an upper limit for the other side temperature result. Blank " +
                     "indicates no limit")]
        [JsonProperty("maximum_other_side_temperature_limit")]
        public System.Nullable<float> MaximumOtherSideTemperatureLimit { get; set; } = null;
    }
}