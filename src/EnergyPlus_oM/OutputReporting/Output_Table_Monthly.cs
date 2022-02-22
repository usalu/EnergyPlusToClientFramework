using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"Provides a generic method of setting up tables of monthly results. The report has multiple columns that are each defined using a repeated group of fields for any number of columns. A single Output:Table:Monthly object often produces multiple tables in the output. A table is produced for every instance of a particular output variable. For example, a table defined with zone variables will be produced once for every zone.")]
    public class Output_Table_Monthly : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("digits_after_decimal")]
        public System.Nullable<float> DigitsAfterDecimal { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [JsonProperty("variable_details")]
        public string VariableDetails { get; set; } = "";
    }
}