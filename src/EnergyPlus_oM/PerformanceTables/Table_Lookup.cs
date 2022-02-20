using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
{
    [Description(@"Lookup tables are used in place of curves and can represent any number of independent variables (defined as Table:IndependentVariable objects in a Table:IndependentVariableList). Output values are interpolated within the bounds defined by each independent variable and extrapolated beyond the bounds according to the interpolation/extrapolation methods defined by each independent variable.")]
    [JsonObject("Table:Lookup")]
    public class Table_Lookup : BHoMObject
    {
        

        [JsonProperty("independent_variable_list_name")]
        public string IndependentVariableListName { get; set; } = "";
        

        [JsonProperty("normalization_method")]
        public EmptyNoYes NormalizationMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

        [JsonProperty("normalization_divisor")]
        public System.Nullable<float> NormalizationDivisor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_output")]
        public System.Nullable<float> MinimumOutput { get; set; } = null;
        

        [JsonProperty("maximum_output")]
        public System.Nullable<float> MaximumOutput { get; set; } = null;
        

        [JsonProperty("output_unit_type")]
        public EmptyNoYes OutputUnitType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("external_file_name")]
        public string ExternalFileName { get; set; } = "";
        

        [JsonProperty("external_file_column_number")]
        public System.Nullable<float> ExternalFileColumnNumber { get; set; } = null;
        

        [JsonProperty("external_file_starting_row_number")]
        public System.Nullable<float> ExternalFileStartingRowNumber { get; set; } = null;
        

        [JsonProperty("values")]
        public string Values { get; set; } = "";
    }
}