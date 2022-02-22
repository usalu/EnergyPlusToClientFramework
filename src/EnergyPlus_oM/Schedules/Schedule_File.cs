using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:File points to a text computer file that has 8760-8784 hours of data.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_File : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("schedule_type_limits_name")]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [JsonProperty("file_name")]
        public string FileName { get; set; } = "";
        

        [JsonProperty("column_number")]
        public System.Nullable<float> ColumnNumber { get; set; } = null;
        

        [JsonProperty("rows_to_skip_at_top")]
        public System.Nullable<float> RowsToSkipAtTop { get; set; } = null;
        

        [Description("8760 hours does not account for leap years, 8784 does. should be either 8760 or 8" +
                     "784")]
        [JsonProperty("number_of_hours_of_data")]
        public System.Nullable<float> NumberOfHoursOfData { get; set; } = (System.Nullable<float>)Single.Parse("8760", CultureInfo.InvariantCulture);
        

        [JsonProperty("column_separator")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Schedule_File_ColumnSeparator ColumnSeparator { get; set; } = (Schedule_File_ColumnSeparator)Enum.Parse(typeof(Schedule_File_ColumnSeparator), "Comma");
        

        [Description(@"when the interval does not match the user specified timestep a ""Yes"" choice will average between the intervals request (to timestep resolution. a ""No"" choice will use the interval value at the simulation timestep without regard to if it matches the boundary or not.")]
        [JsonProperty("interpolate_to_timestep")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes InterpolateToTimestep { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Must be evenly divisible into 60")]
        [JsonProperty("minutes_per_item")]
        public System.Nullable<float> MinutesPerItem { get; set; } = null;
    }
}