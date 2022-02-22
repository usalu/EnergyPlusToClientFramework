using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Use a weather file period for design sizing calculations. EPW weather files are c" +
                 "reated with typical and extreme periods created heuristically from the weather f" +
                 "ile data. For more details on these periods, see AuxiliaryPrograms document.")]
    public class SizingPeriod_WeatherFileConditionType : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Following is a list of all possible types of Extreme and Typical periods that mig" +
                     "ht be identified in the Weather File. Not all possible types are available for a" +
                     "ll weather files.")]
        [JsonProperty("period_selection")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_WeatherFileConditionType_PeriodSelection PeriodSelection { get; set; } = (SizingPeriod_WeatherFileConditionType_PeriodSelection)Enum.Parse(typeof(SizingPeriod_WeatherFileConditionType_PeriodSelection), "AutumnTypical");
        

        [Description(@"=[|Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|SummerDesignDay|WinterDesignDay| |CustomDay1|CustomDay2]; if you use SummerDesignDay or WinterDesignDay or the CustomDays then this will apply to the whole period; other days (i.e., Monday) will signify a start day and normal sequence of subsequent days")]
        [JsonProperty("day_of_week_for_start_day")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_WeatherFileConditionType_DayOfWeekForStartDay DayOfWeekForStartDay { get; set; } = (SizingPeriod_WeatherFileConditionType_DayOfWeekForStartDay)Enum.Parse(typeof(SizingPeriod_WeatherFileConditionType_DayOfWeekForStartDay), "Monday");
        

        [Description("If yes or blank, use daylight saving period as specified on Weatherfile. If no, d" +
                     "o not use the daylight saving period as specified on the Weatherfile.")]
        [JsonProperty("use_weather_file_daylight_saving_period")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileDaylightSavingPeriod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("use_weather_file_rain_and_snow_indicators")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileRainAndSnowIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}