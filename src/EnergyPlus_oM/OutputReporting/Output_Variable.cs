using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"each Output:Variable command picks variables to be put onto the standard output file (.eso) some variables may not be reported for every simulation. a list of variables that can be reported are available after a run on the report dictionary file (.rdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Variable : BHoMObject
    {
        

        [Description("use \'*\' (without quotes) to apply this variable to all keys")]
        [JsonProperty("key_value")]
        public string KeyValue { get; set; } = (System.String)"*";
        

        [JsonProperty("variable_name")]
        public string VariableName { get; set; } = "";
        

        [Description("Detailed lists every instance (i.e. HVAC variable timesteps) Timestep refers to t" +
                     "he zone Timestep/Number of Timesteps in hour value RunPeriod and Environment are" +
                     " the same")]
        [JsonProperty("reporting_frequency")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Variable_ReportingFrequency ReportingFrequency { get; set; } = (Output_Variable_ReportingFrequency)Enum.Parse(typeof(Output_Variable_ReportingFrequency), "Hourly");
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
    }
}