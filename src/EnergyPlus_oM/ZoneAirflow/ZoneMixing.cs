using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"ZoneMixing is a simple air exchange from one zone to another. Note that this statement only affects the energy balance of the ""receiving"" zone and will not produce any effect on the ""source"" zone. Mixing statements can be complementary and include multiple zones, but the balancing of flows between zones is left to the user's discretion.")]
    [JsonObject("ZoneMixing")]
    public class ZoneMixing : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of ventilation for this set of attributes Choices: Flow/Zone => Design Flow Rate -- simply enter Design Flow Rate Flow/Area => Flow Rate per Zone Floor Area - Value * Floor Area (zone) = Design Flow Rate Flow/Person => Flow Rate per Person - Value * #people = Design Flow Rate AirChanges/Hour => Air Changes per Hour - Value * Floor Volume (zone) adjusted for m3/s = Design Volume Flow Rate ""Vdesign"" in Equation is the result.")]
        [JsonProperty("design_flow_rate_calculation_method")]
        public ZoneMixing_DesignFlowRateCalculationMethod DesignFlowRateCalculationMethod { get; set; } = (ZoneMixing_DesignFlowRateCalculationMethod)Enum.Parse(typeof(ZoneMixing_DesignFlowRateCalculationMethod), "Empty");
        

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
                     "iving zones below which mixing is shutoff.")]
        [JsonProperty("delta_temperature")]
        public System.Nullable<float> DeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the temperature differential between source and receiving " +
                     "zones versus time below which mixing is shutoff.")]
        [JsonProperty("delta_temperature_schedule_name")]
        public string DeltaTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the zone dry-bulb temperature versus time below which mixi" +
                     "ng is shutoff.")]
        [JsonProperty("minimum_zone_temperature_schedule_name")]
        public string MinimumZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the zone dry-bulb temperature versus time above which mixi" +
                     "ng is shutoff.")]
        [JsonProperty("maximum_zone_temperature_schedule_name")]
        public string MaximumZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the source zone dry-bulb temperature versus time below whi" +
                     "ch mixing is shutoff.")]
        [JsonProperty("minimum_source_zone_temperature_schedule_name")]
        public string MinimumSourceZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the source zone dry-bulb temperature versus time above whi" +
                     "ch mixing is shutoff.")]
        [JsonProperty("maximum_source_zone_temperature_schedule_name")]
        public string MaximumSourceZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the outdoor temperature versus time below which mixing is " +
                     "shutoff.")]
        [JsonProperty("minimum_outdoor_temperature_schedule_name")]
        public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the outdoor temperature versus time above which mixing is " +
                     "shutoff.")]
        [JsonProperty("maximum_outdoor_temperature_schedule_name")]
        public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
    }
}