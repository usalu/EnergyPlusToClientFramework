using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"Ventilation is specified as a design level which is modified by a schedule fraction, temperature difference and wind speed: Ventilation=Vdesign * Fschedule * (A + B*|(Tzone-Todb)| + C*WindSpd + D * WindSpd**2) If you use a ZoneList in the Zone or ZoneList name field then this definition applies to all the zones in the ZoneList.")]
    [JsonObject("ZoneVentilation:DesignFlowRate")]
    public class ZoneVentilation_DesignFlowRate : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of ventilation for this set of attributes Choices: Flow/Zone => Design Flow Rate -- simply enter Design Flow Rate Flow/Area => Flow Rate per Zone Floor Area - Value * Floor Area (zone) = Design Flow Rate Flow/Person => Flow Rate per Person - Value * #people = Design Flow Rate AirChanges/Hour => Air Changes per Hour - Value * Floor Volume (zone) adjusted for m3/s = Design Volume Flow Rate ""Vdesign"" in Equation is the result.")]
        [JsonProperty("design_flow_rate_calculation_method")]
        public ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod DesignFlowRateCalculationMethod { get; set; } = (ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod)Enum.Parse(typeof(ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod), "Empty");
        

        [JsonProperty("design_flow_rate")]
        public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

        [JsonProperty("flow_rate_per_zone_floor_area")]
        public System.Nullable<float> FlowRatePerZoneFloorArea { get; set; } = null;
        

        [JsonProperty("flow_rate_per_person")]
        public System.Nullable<float> FlowRatePerPerson { get; set; } = null;
        

        [JsonProperty("air_changes_per_hour")]
        public System.Nullable<float> AirChangesPerHour { get; set; } = null;
        

        [JsonProperty("ventilation_type")]
        public ZoneVentilation_DesignFlowRate_VentilationType VentilationType { get; set; } = (ZoneVentilation_DesignFlowRate_VentilationType)Enum.Parse(typeof(ZoneVentilation_DesignFlowRate_VentilationType), "Natural");
        

        [Description("pressure rise across the fan")]
        [JsonProperty("fan_pressure_rise")]
        public System.Nullable<float> FanPressureRise { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fan_total_efficiency")]
        public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("\"A\" in Equation")]
        [JsonProperty("constant_term_coefficient")]
        public System.Nullable<float> ConstantTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("\"B\" in Equation")]
        [JsonProperty("temperature_term_coefficient")]
        public System.Nullable<float> TemperatureTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"C\" in Equation")]
        [JsonProperty("velocity_term_coefficient")]
        public System.Nullable<float> VelocityTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"D\" in Equation")]
        [JsonProperty("velocity_squared_term_coefficient")]
        public System.Nullable<float> VelocitySquaredTermCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("this is the indoor temperature below which ventilation is shutoff")]
        [JsonProperty("minimum_indoor_temperature")]
        public System.Nullable<float> MinimumIndoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the indoor temperature versus time below which ventilation" +
                     " is shutoff.")]
        [JsonProperty("minimum_indoor_temperature_schedule_name")]
        public string MinimumIndoorTemperatureScheduleName { get; set; } = "";
        

        [Description("this is the indoor temperature above which ventilation is shutoff")]
        [JsonProperty("maximum_indoor_temperature")]
        public System.Nullable<float> MaximumIndoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the indoor temperature versus time above which ventilation" +
                     " is shutoff.")]
        [JsonProperty("maximum_indoor_temperature_schedule_name")]
        public string MaximumIndoorTemperatureScheduleName { get; set; } = "";
        

        [Description(@"This is the temperature differential between indoor and outdoor below which ventilation is shutoff. If ((IndoorTemp - OutdoorTemp) < DeltaTemperature) then ventilation is not allowed. For example, if delta temperature is 2C, ventilation is assumed to be available if the outside air temperature is at least 2C cooler than the zone air temperature. The values for this field can include negative numbers. This allows ventilation to occur even if the outdoor temperature is above the indoor temperature.")]
        [JsonProperty("delta_temperature")]
        public System.Nullable<float> DeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the temperature differential between indoor and outdoor ve" +
                     "rsus time below which ventilation is shutoff.")]
        [JsonProperty("delta_temperature_schedule_name")]
        public string DeltaTemperatureScheduleName { get; set; } = "";
        

        [Description("this is the outdoor temperature below which ventilation is shutoff")]
        [JsonProperty("minimum_outdoor_temperature")]
        public System.Nullable<float> MinimumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the outdoor temperature versus time below which ventilatio" +
                     "n is shutoff.")]
        [JsonProperty("minimum_outdoor_temperature_schedule_name")]
        public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("this is the outdoor temperature above which ventilation is shutoff")]
        [JsonProperty("maximum_outdoor_temperature")]
        public System.Nullable<float> MaximumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the outdoor temperature versus time above which ventilatio" +
                     "n is shutoff.")]
        [JsonProperty("maximum_outdoor_temperature_schedule_name")]
        public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("this is the outdoor wind speed above which ventilation is shutoff")]
        [JsonProperty("maximum_wind_speed")]
        public System.Nullable<float> MaximumWindSpeed { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
    }
}