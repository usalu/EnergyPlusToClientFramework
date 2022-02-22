using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:Day:Hourly contains 24 values for each hour of the day.")]
    [JsonObject("Schedule:Day:Hourly")]
    public class Schedule_Day_Hourly : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("schedule_type_limits_name")]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [JsonProperty("hour_1")]
        public System.Nullable<float> Hour1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_2")]
        public System.Nullable<float> Hour2 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_3")]
        public System.Nullable<float> Hour3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_4")]
        public System.Nullable<float> Hour4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_5")]
        public System.Nullable<float> Hour5 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_6")]
        public System.Nullable<float> Hour6 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_7")]
        public System.Nullable<float> Hour7 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_8")]
        public System.Nullable<float> Hour8 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_9")]
        public System.Nullable<float> Hour9 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_10")]
        public System.Nullable<float> Hour10 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_11")]
        public System.Nullable<float> Hour11 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_12")]
        public System.Nullable<float> Hour12 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_13")]
        public System.Nullable<float> Hour13 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_14")]
        public System.Nullable<float> Hour14 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_15")]
        public System.Nullable<float> Hour15 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_16")]
        public System.Nullable<float> Hour16 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_17")]
        public System.Nullable<float> Hour17 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_18")]
        public System.Nullable<float> Hour18 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_19")]
        public System.Nullable<float> Hour19 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_20")]
        public System.Nullable<float> Hour20 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_21")]
        public System.Nullable<float> Hour21 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_22")]
        public System.Nullable<float> Hour22 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_23")]
        public System.Nullable<float> Hour23 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("hour_24")]
        public System.Nullable<float> Hour24 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}