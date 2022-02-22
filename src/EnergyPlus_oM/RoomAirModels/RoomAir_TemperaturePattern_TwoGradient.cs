using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("Used to model room air with two temperature gradients in the vertical direction. " +
                 "Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    public class RoomAir_TemperaturePattern_TwoGradient : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("room_air_temperature_pattern_two_gradient_name")]
        public string RoomAirTemperaturePatternTwoGradientName { get; set; } = "";
        

        [Description("reference this entry in Schedule Name")]
        [JsonProperty("control_integer_for_pattern_control_schedule_name")]
        public System.Nullable<float> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

        [Description("= Distance from floor of zone")]
        [JsonProperty("thermostat_height")]
        public System.Nullable<float> ThermostatHeight { get; set; } = null;
        

        [Description("= Distance from floor of zone")]
        [JsonProperty("return_air_height")]
        public System.Nullable<float> ReturnAirHeight { get; set; } = null;
        

        [Description("= Distance from floor of zone")]
        [JsonProperty("exhaust_air_height")]
        public System.Nullable<float> ExhaustAirHeight { get; set; } = null;
        

        [Description("Slope of temperature change in vertical direction")]
        [JsonProperty("temperature_gradient_lower_bound")]
        public System.Nullable<float> TemperatureGradientLowerBound { get; set; } = null;
        

        [Description("Slope of temperature change in vertical direction")]
        [JsonProperty("temperature_gradient_upper_bound")]
        public System.Nullable<float> TemperatureGradientUpperBound { get; set; } = null;
        

        [JsonProperty("gradient_interpolation_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode GradientInterpolationMode { get; set; } = (RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode)Enum.Parse(typeof(RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode), "OutdoorDryBulbTemperature");
        

        [JsonProperty("upper_temperature_bound")]
        public System.Nullable<float> UpperTemperatureBound { get; set; } = null;
        

        [JsonProperty("lower_temperature_bound")]
        public System.Nullable<float> LowerTemperatureBound { get; set; } = null;
        

        [JsonProperty("upper_heat_rate_bound")]
        public System.Nullable<float> UpperHeatRateBound { get; set; } = null;
        

        [JsonProperty("lower_heat_rate_bound")]
        public System.Nullable<float> LowerHeatRateBound { get; set; } = null;
    }
}