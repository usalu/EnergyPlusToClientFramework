using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Specify a range of dates and other parameters for a simulation. Multiple run peri" +
                 "ods may be input, but they may not overlap.")]
    public class RunPeriod : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("begin_month")]
        public System.Nullable<float> BeginMonth { get; set; } = null;
        

        [JsonProperty("begin_day_of_month")]
        public System.Nullable<float> BeginDayOfMonth { get; set; } = null;
        

        [Description("Start year of the simulation, if this field is specified it must agree with the D" +
                     "ay of Week for Start Day If this field is blank, the year will be selected to ma" +
                     "tch the weekday, which is Sunday if not specified")]
        [JsonProperty("begin_year")]
        public System.Nullable<float> BeginYear { get; set; } = null;
        

        [JsonProperty("end_month")]
        public System.Nullable<float> EndMonth { get; set; } = null;
        

        [JsonProperty("end_day_of_month")]
        public System.Nullable<float> EndDayOfMonth { get; set; } = null;
        

        [Description("end year of simulation, if specified")]
        [JsonProperty("end_year")]
        public System.Nullable<float> EndYear { get; set; } = null;
        

        [Description("=[Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday]; If no year is input," +
                     " this field will default to Sunday If a year is input and this field is blank, t" +
                     "he correct weekday is determined")]
        [JsonProperty("day_of_week_for_start_day")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RunPeriod_DayOfWeekForStartDay DayOfWeekForStartDay { get; set; } = (RunPeriod_DayOfWeekForStartDay)Enum.Parse(typeof(RunPeriod_DayOfWeekForStartDay), "Friday");
        

        [Description("If yes or blank, use holidays as specified on Weatherfile. If no, do not use the " +
                     "holidays specified on the Weatherfile. Note: You can still specify holidays/spec" +
                     "ial days using the RunPeriodControl:SpecialDays object(s).")]
        [JsonProperty("use_weather_file_holidays_and_special_days")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileHolidaysAndSpecialDays { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("If yes or blank, use daylight saving period as specified on Weatherfile. If no, d" +
                     "o not use the daylight saving period as specified on the Weatherfile.")]
        [JsonProperty("use_weather_file_daylight_saving_period")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileDaylightSavingPeriod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("if yes and single day holiday falls on weekend, \"holiday\" occurs on following Mon" +
                     "day")]
        [JsonProperty("apply_weekend_holiday_rule")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ApplyWeekendHolidayRule { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("use_weather_file_rain_indicators")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileRainIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("use_weather_file_snow_indicators")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileSnowIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("treat_weather_as_actual")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes TreatWeatherAsActual { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
}