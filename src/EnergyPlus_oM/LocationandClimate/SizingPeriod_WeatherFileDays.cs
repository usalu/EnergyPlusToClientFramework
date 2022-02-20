using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Use a weather file period for design sizing calculations.")]
    [JsonObject("SizingPeriod:WeatherFileDays")]
    public class SizingPeriod_WeatherFileDays : BHoMObject
    {
        

        [JsonProperty("begin_month")]
        public System.Nullable<float> BeginMonth { get; set; } = null;
        

        [JsonProperty("begin_day_of_month")]
        public System.Nullable<float> BeginDayOfMonth { get; set; } = null;
        

        [JsonProperty("end_month")]
        public System.Nullable<float> EndMonth { get; set; } = null;
        

        [JsonProperty("end_day_of_month")]
        public System.Nullable<float> EndDayOfMonth { get; set; } = null;
        

        [Description(@"=[|Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|SummerDesignDay|WinterDesignDay| |CustomDay1|CustomDay2]; if you use SummerDesignDay or WinterDesignDay or the CustomDays then this will apply to the whole period; other days (i.e., Monday) will signify a start day and normal sequence of subsequent days")]
        [JsonProperty("day_of_week_for_start_day")]
        public EmptyNoYes DayOfWeekForStartDay { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Monday");
        

        [Description("If yes or blank, use daylight saving period as specified on Weatherfile. If no, d" +
                     "o not use the daylight saving period as specified on the Weatherfile.")]
        [JsonProperty("use_weather_file_daylight_saving_period")]
        public EmptyNoYes UseWeatherFileDaylightSavingPeriod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("use_weather_file_rain_and_snow_indicators")]
        public EmptyNoYes UseWeatherFileRainAndSnowIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}