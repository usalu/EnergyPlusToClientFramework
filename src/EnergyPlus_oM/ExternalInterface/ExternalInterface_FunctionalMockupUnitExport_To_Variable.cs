using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("Declares Erl variable as having global scope No spaces allowed in names used for " +
                 "Erl variables")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ExternalInterface_FunctionalMockupUnitExport_To_Variable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("fmu_variable_name")]
        public string FmuVariableName { get; set; } = "";
        

        [Description("Used during the first call of EnergyPlus.")]
        [JsonProperty("initial_value")]
        public System.Nullable<float> InitialValue { get; set; } = null;
    }
}