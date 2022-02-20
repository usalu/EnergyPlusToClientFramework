using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
{
    [Description("A sorted list of independent variables used by one or more Table:Lookup objects.")]
    [JsonObject("Table:IndependentVariableList")]
    public class Table_IndependentVariableList : BHoMObject
    {
        

        [JsonProperty("independent_variables")]
        public string IndependentVariables { get; set; } = "";
    }
}