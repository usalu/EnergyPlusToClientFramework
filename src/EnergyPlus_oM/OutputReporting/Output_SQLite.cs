using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Output from EnergyPlus can be written to an SQLite format file.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_SQLite : BHoMObject
    {
        

        [JsonProperty("option_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_SQLite_OptionType OptionType { get; set; } = (Output_SQLite_OptionType)Enum.Parse(typeof(Output_SQLite_OptionType), "Simple");
        

        [Description("Unit conversion option used when writing SQLite Tabular Data This option applies " +
                     "to TabularData and TabularDatawithString in the SQLite file")]
        [JsonProperty("unit_conversion_for_tabular_data")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_SQLite_UnitConversionForTabularData UnitConversionForTabularData { get; set; } = (Output_SQLite_UnitConversionForTabularData)Enum.Parse(typeof(Output_SQLite_UnitConversionForTabularData), "UseOutputControlTableStyle");
    }
}