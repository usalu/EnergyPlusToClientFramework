using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Output from EnergyPlus can be written to an SQLite format file.")]
    [JsonObject("Output:SQLite")]
    public class Output_SQLite : BHoMObject
    {
        

        [JsonProperty("option_type")]
        public EmptyNoYes OptionType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Unit conversion option used when writing SQLite Tabular Data This option applies " +
                     "to TabularData and TabularDatawithString in the SQLite file")]
        [JsonProperty("unit_conversion_for_tabular_data")]
        public EmptyNoYes UnitConversionForTabularData { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "UseOutputControlTableStyle");
    }
}