using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to provide advanced thermal comfort control of window opening" +
                 " and closing for both exterior and interior windows.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_OccupantVentilationControl : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("minimum_opening_time")]
        public System.Nullable<float> MinimumOpeningTime { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_closing_time")]
        public System.Nullable<float> MinimumClosingTime { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Enter a curve name that represents thermal comfort temperature as a function of outdoor dry-bulb temperature. Up to two curves are allowed if the performance cannot be represented by a single curve. The following two fields are used if two curves are required.")]
        [JsonProperty("thermal_comfort_low_temperature_curve_name")]
        public string ThermalComfortLowTemperatureCurveName { get; set; } = "";
        

        [Description("This point is used to allow separate low and high thermal comfort temperature cur" +
                     "ves. If a single performance curve is used, leave this field blank.")]
        [JsonProperty("thermal_comfort_temperature_boundary_point")]
        public System.Nullable<float> ThermalComfortTemperatureBoundaryPoint { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description(@"Enter a curve name that represents thermal comfort temperature as a function of outdoor dry-bulb temperature. Up to two curves are allowed if the performance cannot be represented by a single curve. If a single performance curve is used, leave this field blank.")]
        [JsonProperty("thermal_comfort_high_temperature_curve_name")]
        public string ThermalComfortHighTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("maximum_threshold_for_persons_dissatisfied_ppd")]
        public System.Nullable<float> MaximumThresholdForPersonsDissatisfiedPpd { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("If Yes, occupancy check will be performed as part of the opening probability chec" +
                     "k.")]
        [JsonProperty("occupancy_check")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes OccupancyCheck { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("If this field is blank, the opening probability check is bypassed and opening is " +
                     "true.")]
        [JsonProperty("opening_probability_schedule_name")]
        public string OpeningProbabilityScheduleName { get; set; } = "";
        

        [Description("If this field is blank, the closing probability check is bypassed and closing is " +
                     "true.")]
        [JsonProperty("closing_probability_schedule_name")]
        public string ClosingProbabilityScheduleName { get; set; } = "";
    }
}