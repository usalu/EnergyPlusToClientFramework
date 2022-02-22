using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description(@"The design day object creates the parameters for the program to create the 24 hour weather profile that can be used for sizing as well as running to test the other simulation parameters. Parameters in this include a date (month and day), a day type (which uses the appropriate schedules for either sizing or simple tests), min/max temperatures, wind speeds, and solar radiation values.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SizingPeriod_DesignDay : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("month")]
        public System.Nullable<float> Month { get; set; } = null;
        

        [Description("must be valid for Month field")]
        [JsonProperty("day_of_month")]
        public System.Nullable<float> DayOfMonth { get; set; } = null;
        

        [Description("Day Type selects the schedules appropriate for this design day")]
        [JsonProperty("day_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_DayType DayType { get; set; } = (SizingPeriod_DesignDay_DayType)Enum.Parse(typeof(SizingPeriod_DesignDay_DayType), "CustomDay1");
        

        [Description("This field is required when field \"Dry-Bulb Temperature Range Modifier Type\" is n" +
                     "ot \"TemperatureProfileSchedule\".")]
        [JsonProperty("maximum_dry_bulb_temperature")]
        public System.Nullable<float> MaximumDryBulbTemperature { get; set; } = null;
        

        [Description("Must still produce appropriate maximum dry-bulb (within range) This field is not " +
                     "needed if Dry-Bulb Temperature Range Modifier Type is \"delta\".")]
        [JsonProperty("daily_dry_bulb_temperature_range")]
        public System.Nullable<float> DailyDryBulbTemperatureRange { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Type of modifier to the dry-bulb temperature calculated for the timestep")]
        [JsonProperty("dry_bulb_temperature_range_modifier_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType DryBulbTemperatureRangeModifierType { get; set; } = (SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType)Enum.Parse(typeof(SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType), "DefaultMultipliers");
        

        [Description(@"Only used when previous field is ""MultiplierSchedule"", ""DifferenceSchedule"" or ""TemperatureProfileSchedule"". For type ""MultiplierSchedule""  the hour/time interval values should specify the fraction (0-1) of the dry-bulb temperature range to be subtracted from the maximum dry-bulb temperature for each timestep in the day For type ""DifferenceSchedule"" the values should specify a number to be subtracted from the maximum dry-bulb temperature for each timestep in the day. Note that numbers in the difference schedule cannot be negative as that would result in a higher maximum than the maximum previously specified. For type ""TemperatureProfileSchedule"" the values should specify the actual dry-bulb temperature for each timestep in the day.")]
        [JsonProperty("dry_bulb_temperature_range_modifier_day_schedule_name")]
        public string DryBulbTemperatureRangeModifierDayScheduleName { get; set; } = "";
        

        [Description("values/schedules indicated here and in subsequent fields create the humidity valu" +
                     "es in the 24 hour design day conditions profile.")]
        [JsonProperty("humidity_condition_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_HumidityConditionType HumidityConditionType { get; set; } = (SizingPeriod_DesignDay_HumidityConditionType)Enum.Parse(typeof(SizingPeriod_DesignDay_HumidityConditionType), "WetBulb");
        

        [Description("Wetbulb or dewpoint temperature coincident with the maximum temperature. Required" +
                     " only if field Humidity Condition Type is \"Wetbulb\", \"Dewpoint\", \"WetBulbProfile" +
                     "MultiplierSchedule\", \"WetBulbProfileDifferenceSchedule\", or \"WetBulbProfileDefau" +
                     "ltMultipliers\"")]
        [JsonProperty("wetbulb_or_dewpoint_at_maximum_dry_bulb")]
        public System.Nullable<float> WetbulbOrDewpointAtMaximumDryBulb { get; set; } = null;
        

        [Description(@"Only used when Humidity Condition Type is ""RelativeHumiditySchedule"", ""WetBulbProfileMultiplierSchedule"", or ""WetBulbProfileDifferenceSchedule"" For type ""RelativeHumiditySchedule"", the hour/time interval values should specify relative humidity (percent) from 0.0 to 100.0. For type ""WetBulbProfileMultiplierSchedule"" the hour/time interval values should specify the fraction (0-1) of the wet-bulb temperature range to be subtracted from the maximum wet-bulb temperature for each timestep in the day (units = Fraction) For type ""WetBulbProfileDifferenceSchedule"" the values should specify a number to be subtracted from the maximum wet-bulb temperature for each timestep in the day. (units = deltaC)")]
        [JsonProperty("humidity_condition_day_schedule_name")]
        public string HumidityConditionDayScheduleName { get; set; } = "";
        

        [Description("Humidity ratio coincident with the maximum temperature (constant humidity ratio t" +
                     "hroughout day). Required only if field Humidity Condition Type is \"HumidityRatio" +
                     "\".")]
        [JsonProperty("humidity_ratio_at_maximum_dry_bulb")]
        public System.Nullable<float> HumidityRatioAtMaximumDryBulb { get; set; } = null;
        

        [Description("Enthalpy coincident with the maximum temperature. Required only if field Humidity" +
                     " Condition Type is \"Enthalpy\".")]
        [JsonProperty("enthalpy_at_maximum_dry_bulb")]
        public System.Nullable<float> EnthalpyAtMaximumDryBulb { get; set; } = null;
        

        [Description("Required only if Humidity Condition Type = \"WetbulbProfileMultiplierSchedule\" or " +
                     "\"WetBulbProfileDefaultMultipliers\"")]
        [JsonProperty("daily_wet_bulb_temperature_range")]
        public System.Nullable<float> DailyWetBulbTemperatureRange { get; set; } = null;
        

        [Description("This field\'s value is also checked against the calculated \"standard barometric pr" +
                     "essure\" for the location. If out of range (>10%) or blank, then is replaced by s" +
                     "tandard value.")]
        [JsonProperty("barometric_pressure")]
        public System.Nullable<float> BarometricPressure { get; set; } = null;
        

        [JsonProperty("wind_speed")]
        public System.Nullable<float> WindSpeed { get; set; } = null;
        

        [Description("North=0.0 East=90.0 0 and 360 are the same direction.")]
        [JsonProperty("wind_direction")]
        public System.Nullable<float> WindDirection { get; set; } = null;
        

        [Description("Yes is raining (all day), No is not raining")]
        [JsonProperty("rain_indicator")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes RainIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Yes is Snow on Ground, No is no Snow on Ground")]
        [JsonProperty("snow_indicator")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SnowIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Yes -- use schedules modified for Daylight Saving Time Schedules. No - do not use" +
                     " schedules modified for Daylight Saving Time Schedules")]
        [JsonProperty("daylight_saving_time_indicator")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes DaylightSavingTimeIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("solar_model_indicator")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_SolarModelIndicator SolarModelIndicator { get; set; } = (SizingPeriod_DesignDay_SolarModelIndicator)Enum.Parse(typeof(SizingPeriod_DesignDay_SolarModelIndicator), "ASHRAEClearSky");
        

        [Description("if Solar Model Indicator = Schedule, then beam schedule name (for day)")]
        [JsonProperty("beam_solar_day_schedule_name")]
        public string BeamSolarDayScheduleName { get; set; } = "";
        

        [Description("if Solar Model Indicator = Schedule, then diffuse schedule name (for day)")]
        [JsonProperty("diffuse_solar_day_schedule_name")]
        public string DiffuseSolarDayScheduleName { get; set; } = "";
        

        [Description("Required if Solar Model Indicator = ASHRAETau or ASHRAETau2017 ASHRAETau2017 sola" +
                     "r model can be used with 2013 and 2017 HOF matching taub")]
        [JsonProperty("ashrae_clear_sky_optical_depth_for_beam_irradiance_taub_")]
        public System.Nullable<float> AshraeClearSkyOpticalDepthForBeamIrradianceTaub { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Required if Solar Model Indicator = ASHRAETau or ASHRAETau2017 ASHRAETau2017 sola" +
                     "r model can be used with 2013 and 2017 HOF matching taud")]
        [JsonProperty("ashrae_clear_sky_optical_depth_for_diffuse_irradiance_taud_")]
        public System.Nullable<float> AshraeClearSkyOpticalDepthForDiffuseIrradianceTaud { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used if Sky Model Indicator = ASHRAEClearSky or ZhangHuang 0.0 is totally unclear" +
                     ", 1.0 is totally clear")]
        [JsonProperty("sky_clearness")]
        public System.Nullable<float> SkyClearness { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If used this design day will be run with a custom limit on the maximum number of " +
                     "days that are repeated for warmup. Limiting the number of warmup days can improv" +
                     "e run time.")]
        [JsonProperty("maximum_number_warmup_days")]
        public System.Nullable<float> MaximumNumberWarmupDays { get; set; } = null;
        

        [Description("If used this can control if you want the thermal history to be reset at the begin" +
                     "ning of the design day. When using a series of similiar design days, this field " +
                     "can be used to retain warmup state from the previous design day.")]
        [JsonProperty("begin_environment_reset_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_BeginEnvironmentResetMode BeginEnvironmentResetMode { get; set; } = (SizingPeriod_DesignDay_BeginEnvironmentResetMode)Enum.Parse(typeof(SizingPeriod_DesignDay_BeginEnvironmentResetMode), "FullResetAtBeginEnvironment");
    }
}