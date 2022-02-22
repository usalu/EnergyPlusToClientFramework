using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("ZoneCrossMixing exchanges an equal amount of air between two zones. Note that thi" +
                 "s statement affects the energy balance of both zones.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneCrossMixing : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of ventilation for this set of attributes Choices: Flow/Zone => Design Flow Rate -- simply enter Design Flow Rate Flow/Area => Flow Rate per Zone Floor Area - Value * Floor Area (zone) = Design Flow Rate Flow/Person => Flow Rate per Person - Value * #people = Design Flow Rate AirChanges/Hour => Air Changes per Hour - Value * Floor Volume (zone) adjusted for m3/s = Design Volume Flow Rate ""Vdesign"" in Equation is the result.")]
        [JsonProperty("design_flow_rate_calculation_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneCrossMixing_DesignFlowRateCalculationMethod DesignFlowRateCalculationMethod { get; set; } = (ZoneCrossMixing_DesignFlowRateCalculationMethod)Enum.Parse(typeof(ZoneCrossMixing_DesignFlowRateCalculationMethod), "Empty");
        

        [JsonProperty("design_flow_rate")]
        public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

        [JsonProperty("flow_rate_per_zone_floor_area")]
        public System.Nullable<float> FlowRatePerZoneFloorArea { get; set; } = null;
        

        [JsonProperty("flow_rate_per_person")]
        public System.Nullable<float> FlowRatePerPerson { get; set; } = null;
        

        [JsonProperty("air_changes_per_hour")]
        public System.Nullable<float> AirChangesPerHour { get; set; } = null;
        

        [JsonProperty("source_zone_name")]
        public string SourceZoneName { get; set; } = "";
        

        [Description("This field contains the constant temperature differential between source and rece" +
                     "iving zones below which cross mixing is shutoff. This value must be greater than" +
                     " or equal to zero.")]
        [JsonProperty("delta_temperature")]
        public System.Nullable<float> DeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the temperature differential between source and receiving " +
                     "zones versus time below which cross mixing is shutoff.")]
        [JsonProperty("delta_temperature_schedule_name")]
        public string DeltaTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the indoor temperature versus time below which cross mixin" +
                     "g is shutoff.")]
        [JsonProperty("minimum_zone_temperature_schedule_name")]
        public string MinimumZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the indoor temperature versus time above which cross mixin" +
                     "g is shutoff.")]
        [JsonProperty("maximum_zone_temperature_schedule_name")]
        public string MaximumZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the source zone dry-bulb temperature versus time below whi" +
                     "ch cross mixing is shutoff.")]
        [JsonProperty("minimum_source_zone_temperature_schedule_name")]
        public string MinimumSourceZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the source zone dry-bulb temperature versus time above whi" +
                     "ch cross mixing is shutoff.")]
        [JsonProperty("maximum_source_zone_temperature_schedule_name")]
        public string MaximumSourceZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the outdoor temperature versus time below which cross mixi" +
                     "ng is shutoff.")]
        [JsonProperty("minimum_outdoor_temperature_schedule_name")]
        public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the outdoor temperature versus time above which cross mixi" +
                     "ng is shutoff.")]
        [JsonProperty("maximum_outdoor_temperature_schedule_name")]
        public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
    }
}