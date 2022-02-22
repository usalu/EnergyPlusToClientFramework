using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("This object declares an FMU input variable")]
    public class ExternalInterface_FunctionalMockupUnitImport_From_Variable : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("output_variable_index_key_name")]
        public string OutputVariableIndexKeyName { get; set; } = "";
        

        [JsonProperty("output_variable_name")]
        public string OutputVariableName { get; set; } = "";
        

        [JsonProperty("fmu_file_name")]
        public string FmuFileName { get; set; } = "";
        

        [JsonProperty("fmu_instance_name")]
        public string FmuInstanceName { get; set; } = "";
        

        [JsonProperty("fmu_variable_name")]
        public string FmuVariableName { get; set; } = "";
    }
}