using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
{
    [Description("A sorted list of independent variables used by one or more Table:Lookup objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Table_IndependentVariableList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("independent_variables")]
        public string IndependentVariables { get; set; } = "";
    }
}