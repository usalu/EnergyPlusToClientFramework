using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("This object declares an FMU input variable")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ExternalInterface_FunctionalMockupUnitExport_From_Variable : BHoMObject
    {
        

        [JsonProperty("output_variable_index_key_name")]
        public string OutputVariableIndexKeyName { get; set; } = "";
        

        [JsonProperty("output_variable_name")]
        public string OutputVariableName { get; set; } = "";
        

        [JsonProperty("fmu_variable_name")]
        public string FmuVariableName { get; set; } = "";
    }
}