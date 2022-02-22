using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:Week:Daily contains 12 Schedule:Day:Hourly objects, one for each day t" +
                 "ype.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Week_Daily : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("sunday_schedule_day_name")]
        public string SundayScheduleDayName { get; set; } = "";
        

        [JsonProperty("monday_schedule_day_name")]
        public string MondayScheduleDayName { get; set; } = "";
        

        [JsonProperty("tuesday_schedule_day_name")]
        public string TuesdayScheduleDayName { get; set; } = "";
        

        [JsonProperty("wednesday_schedule_day_name")]
        public string WednesdayScheduleDayName { get; set; } = "";
        

        [JsonProperty("thursday_schedule_day_name")]
        public string ThursdayScheduleDayName { get; set; } = "";
        

        [JsonProperty("friday_schedule_day_name")]
        public string FridayScheduleDayName { get; set; } = "";
        

        [JsonProperty("saturday_schedule_day_name")]
        public string SaturdayScheduleDayName { get; set; } = "";
        

        [JsonProperty("holiday_schedule_day_name")]
        public string HolidayScheduleDayName { get; set; } = "";
        

        [JsonProperty("summerdesignday_schedule_day_name")]
        public string SummerdesigndayScheduleDayName { get; set; } = "";
        

        [JsonProperty("winterdesignday_schedule_day_name")]
        public string WinterdesigndayScheduleDayName { get; set; } = "";
        

        [JsonProperty("customday1_schedule_day_name")]
        public string Customday1ScheduleDayName { get; set; } = "";
        

        [JsonProperty("customday2_schedule_day_name")]
        public string Customday2ScheduleDayName { get; set; } = "";
    }
}