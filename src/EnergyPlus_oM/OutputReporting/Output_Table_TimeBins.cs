using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Produces a bin report in the table output file which shows the amount of time in " +
                 "hours that occurs in different bins for a single specific output variable or met" +
                 "er. Two different types of binning are reported: by month and by hour of the day" +
                 ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_TimeBins : BHoMObject
    {
        

        [Description("use \'*\' (without quotes) to apply this variable to all keys")]
        [JsonProperty("key_value")]
        public string KeyValue { get; set; } = (System.String)"*";
        

        [JsonProperty("variable_name")]
        public string VariableName { get; set; } = "";
        

        [Description("The lowest value for the intervals being binned into.")]
        [JsonProperty("interval_start")]
        public System.Nullable<float> IntervalStart { get; set; } = null;
        

        [Description("The size of the bins starting with Interval start.")]
        [JsonProperty("interval_size")]
        public System.Nullable<float> IntervalSize { get; set; } = null;
        

        [Description("The number of bins used. The number of hours below the start of the Lowest bin an" +
                     "d above the value of the last bin are also shown.")]
        [JsonProperty("interval_count")]
        public System.Nullable<float> IntervalCount { get; set; } = null;
        

        [Description("Optional schedule name. Binning is performed for non-zero hours. Binning always p" +
                     "erformed if left blank.")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description("Optional input on the type of units for the variable used by other fields in the " +
                     "object.")]
        [JsonProperty("variable_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Table_TimeBins_VariableType VariableType { get; set; } = (Output_Table_TimeBins_VariableType)Enum.Parse(typeof(Output_Table_TimeBins_VariableType), "Energy");
    }
}