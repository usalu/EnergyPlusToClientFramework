using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"Provides a generic method of setting up tables of annual results with one row per object. The report has multiple columns that are each defined using a repeated group of fields for any number of columns. A single Output:Table:Annual produces a single table in the output.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_Annual : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description(@"An optional text string that is compared to the names of the objects referenced by the variables and if they match are included in the table. A footnote will appear that indicates that the objects shown may not be all the objects that of that type that occur in the file.")]
        [JsonProperty("filter")]
        public string Filter { get; set; } = "";
        

        [Description("Optional schedule name. If left blank, aggregation is performed for all hours sim" +
                     "ulated. If a schedule is specified, aggregation is performed for non-zero hours " +
                     "in the schedule.")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [JsonProperty("variable_details")]
        public string VariableDetails { get; set; } = "";
    }
}