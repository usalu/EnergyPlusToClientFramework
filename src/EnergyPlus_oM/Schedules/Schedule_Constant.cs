using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("Constant hourly value for entire year.")]
    [JsonObject("Schedule:Constant")]
    public class Schedule_Constant : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("schedule_type_limits_name")]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [JsonProperty("hourly_value")]
        public System.Nullable<float> HourlyValue { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}