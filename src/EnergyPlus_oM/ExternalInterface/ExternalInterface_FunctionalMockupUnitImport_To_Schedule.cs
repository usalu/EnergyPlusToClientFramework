using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("This objects contains only one value, which is used during the first call of Ener" +
                 "gyPlus")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ExternalInterface_FunctionalMockupUnitImport_To_Schedule : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("schedule_type_limits_names")]
        public string ScheduleTypeLimitsNames { get; set; } = "";
        

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