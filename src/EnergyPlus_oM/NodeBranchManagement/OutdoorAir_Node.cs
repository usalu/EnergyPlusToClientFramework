using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description(@"This object sets the temperature and humidity conditions for an outdoor air node. It allows the height above ground to be specified. This object may be used more than once. The same node name may not appear in both an OutdoorAir:Node object and an OutdoorAir:NodeList object. This object defines local outdoor air environmental conditions.")]
    [JsonObject("OutdoorAir:Node")]
    public class OutdoorAir_Node : BHoMObject
    {
        

        [Description("A value less than zero indicates that the height will be ignored and the weather " +
                     "file conditions will be used.")]
        [JsonProperty("height_above_ground")]
        public System.Nullable<float> HeightAboveGround { get; set; } = (System.Nullable<float>)Single.Parse("-1", CultureInfo.InvariantCulture);
        

        [Description("Schedule values are real numbers, -100.0 to 100.0, units C")]
        [JsonProperty("drybulb_temperature_schedule_name")]
        public string DrybulbTemperatureScheduleName { get; set; } = "";
        

        [Description("Schedule values are real numbers, -100.0 to 100.0, units C")]
        [JsonProperty("wetbulb_temperature_schedule_name")]
        public string WetbulbTemperatureScheduleName { get; set; } = "";
        

        [Description("Schedule values are real numbers, 0.0 to 40.0, units m/s")]
        [JsonProperty("wind_speed_schedule_name")]
        public string WindSpeedScheduleName { get; set; } = "";
        

        [Description("Schedule values are real numbers, 0.0 to 360.0, units degree")]
        [JsonProperty("wind_direction_schedule_name")]
        public string WindDirectionScheduleName { get; set; } = "";
        

        [Description("The name of the AirflowNetwork:MultiZone:WindPressureCoefficientValues, curve, or" +
                     " table object specifying the wind pressure coefficient.")]
        [JsonProperty("wind_pressure_coefficient_curve_name")]
        public string WindPressureCoefficientCurveName { get; set; } = "";
        

        [Description("Specify whether the pressure curve is symmetric or not. Specify Yes for curves th" +
                     "at should be evaluated from 0 to 180 degrees Specify No for curves that should b" +
                     "e evaluated from 0 to 360 degrees")]
        [JsonProperty("symmetric_wind_pressure_coefficient_curve")]
        public EmptyNoYes SymmetricWindPressureCoefficientCurve { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Specify whether the angle used to compute the wind pressure coefficient is absolu" +
                     "te or relative Specify Relative to compute the angle between the wind direction " +
                     "and the surface azimuth Specify Absolute to use the wind direction angle directl" +
                     "y")]
        [JsonProperty("wind_angle_type")]
        public EmptyNoYes WindAngleType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Absolute");
    }
}