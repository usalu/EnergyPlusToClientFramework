using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("Declares Erl variable as having global scope No spaces allowed in names used for " +
                 "Erl variables")]
    public class ExternalInterface_FunctionalMockupUnitImport_To_Variable : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("fmu_file_name")]
        public string FmuFileName { get; set; } = "";
        

        [JsonProperty("fmu_instance_name")]
        public string FmuInstanceName { get; set; } = "";
        

        [JsonProperty("fmu_variable_name")]
        public string FmuVariableName { get; set; } = "";
        

        [Description("Used during the first call of EnergyPlus.")]
        [JsonProperty("initial_value")]
        public System.Nullable<float> InitialValue { get; set; } = null;
    }
}