using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"This object is specified as natural ventilation driven by wind and stack effect only: Ventilation Wind = Cw * Opening Area * Schedule * WindSpd Ventilation Stack = Cd * Opening Area * Schedule * SQRT(2*g*DH*(|(Tzone-Todb)|/Tzone)) Total Ventilation = SQRT((Ventilation Wind)^2 + (Ventilation Stack)^2)")]
    [JsonObject("ZoneVentilation:WindandStackOpenArea")]
    public class ZoneVentilation_WindandStackOpenArea : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("This is the opening area used to calculate stack effect and wind driven ventilati" +
                     "on.")]
        [JsonProperty("opening_area")]
        public System.Nullable<float> OpeningArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the fraction values applied to the opening area given in t" +
                     "he previous input field (0.0 - 1.0).")]
        [JsonProperty("opening_area_fraction_schedule_name")]
        public string OpeningAreaFractionScheduleName { get; set; } = "";
        

        [Description(@"This field is used to calculate wind driven ventilation. ""Cw"" in the wind-driven equation and the maximum value is 1.0. When the input is Autocalculate, the program calculates Cw based on an angle between wind direction and effective angle Cw = 0.55 at angle = 0, and Cw = 0.3 at angle=180 Linear interpolation is used to calculate Cw based on the above two values.")]
        [JsonProperty("opening_effectiveness")]
        public string OpeningEffectiveness { get; set; } = (System.String)"Autocalculate";
        

        [Description("This field is defined as normal angle of the opening area and is used when input " +
                     "field Opening Effectiveness = Autocalculate.")]
        [JsonProperty("effective_angle")]
        public System.Nullable<float> EffectiveAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This is the height difference between the midpoint of an opening and the neutral " +
                     "pressure level. \"DH\" in the stack equation.")]
        [JsonProperty("height_difference")]
        public System.Nullable<float> HeightDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This is the discharge coefficient used to calculate stack effect. \"Cd\" in the sta" +
                     "ck equation and the maximum value is 1.0. When the input is Autocalculate, the f" +
                     "ollowing equation is used to calculate the coefficient: Cd = 0.4 + 0.0045*|(Tzon" +
                     "e-Todb)|")]
        [JsonProperty("discharge_coefficient_for_opening")]
        public string DischargeCoefficientForOpening { get; set; } = (System.String)"Autocalculate";
        

        [Description("This is the indoor temperature below which ventilation is shutoff.")]
        [JsonProperty("minimum_indoor_temperature")]
        public System.Nullable<float> MinimumIndoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the indoor temperature versus time below which ventilation" +
                     " is shutoff.")]
        [JsonProperty("minimum_indoor_temperature_schedule_name")]
        public string MinimumIndoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the indoor temperature above which ventilation is shutoff.")]
        [JsonProperty("maximum_indoor_temperature")]
        public System.Nullable<float> MaximumIndoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the indoor temperature versus time above which ventilation" +
                     " is shutoff.")]
        [JsonProperty("maximum_indoor_temperature_schedule_name")]
        public string MaximumIndoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the temperature differential between indoor and outdoor below which venti" +
                     "lation is shutoff.")]
        [JsonProperty("delta_temperature")]
        public System.Nullable<float> DeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the temperature differential between indoor and outdoor ve" +
                     "rsus time below which ventilation is shutoff.")]
        [JsonProperty("delta_temperature_schedule_name")]
        public string DeltaTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the outdoor temperature below which ventilation is shutoff.")]
        [JsonProperty("minimum_outdoor_temperature")]
        public System.Nullable<float> MinimumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the outdoor temperature versus time below which ventilatio" +
                     "n is shutoff.")]
        [JsonProperty("minimum_outdoor_temperature_schedule_name")]
        public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the outdoor temperature above which ventilation is shutoff.")]
        [JsonProperty("maximum_outdoor_temperature")]
        public System.Nullable<float> MaximumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the outdoor temperature versus time above which ventilatio" +
                     "n is shutoff.")]
        [JsonProperty("maximum_outdoor_temperature_schedule_name")]
        public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the outdoor wind speed above which ventilation is shutoff.")]
        [JsonProperty("maximum_wind_speed")]
        public System.Nullable<float> MaximumWindSpeed { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
    }
}