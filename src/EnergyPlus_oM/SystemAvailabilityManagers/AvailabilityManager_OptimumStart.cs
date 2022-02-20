using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Determines the optimal start of HVAC systems before occupancy.")]
    [JsonObject("AvailabilityManager:OptimumStart")]
    public class AvailabilityManager_OptimumStart : BHoMObject
    {
        

        [JsonProperty("applicability_schedule_name")]
        public string ApplicabilityScheduleName { get; set; } = "";
        

        [JsonProperty("fan_schedule_name")]
        public string FanScheduleName { get; set; } = "";
        

        [JsonProperty("control_type")]
        public EmptyNoYes ControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ControlZone");
        

        [JsonProperty("control_zone_name")]
        public string ControlZoneName { get; set; } = "";
        

        [JsonProperty("zone_list_name")]
        public string ZoneListName { get; set; } = "";
        

        [Description("this is the maximum number of hours that a system can start before occupancy")]
        [JsonProperty("maximum_value_for_optimum_start_time")]
        public System.Nullable<float> MaximumValueForOptimumStartTime { get; set; } = (System.Nullable<float>)Single.Parse("6", CultureInfo.InvariantCulture);
        

        [JsonProperty("control_algorithm")]
        public EmptyNoYes ControlAlgorithm { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AdaptiveASHRAE");
        

        [JsonProperty("constant_temperature_gradient_during_cooling")]
        public System.Nullable<float> ConstantTemperatureGradientDuringCooling { get; set; } = null;
        

        [JsonProperty("constant_temperature_gradient_during_heating")]
        public System.Nullable<float> ConstantTemperatureGradientDuringHeating { get; set; } = null;
        

        [JsonProperty("initial_temperature_gradient_during_cooling")]
        public System.Nullable<float> InitialTemperatureGradientDuringCooling { get; set; } = null;
        

        [JsonProperty("initial_temperature_gradient_during_heating")]
        public System.Nullable<float> InitialTemperatureGradientDuringHeating { get; set; } = null;
        

        [Description("this is the number of hours before occupancy for a system")]
        [JsonProperty("constant_start_time")]
        public System.Nullable<float> ConstantStartTime { get; set; } = null;
        

        [Description("this is the number of days that their actual temperature gradients will be used i" +
                     "n the AdaptiveTemperatureGradient method")]
        [JsonProperty("number_of_previous_days")]
        public System.Nullable<float> NumberOfPreviousDays { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
}