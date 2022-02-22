using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("This object sets up an EMS trend variable from an Erl variable A trend variable l" +
                 "ogs values across timesteps")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_TrendVariable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("must be a global scope EMS variable")]
        [JsonProperty("ems_variable_name")]
        public string EmsVariableName { get; set; } = "";
        

        [JsonProperty("number_of_timesteps_to_be_logged")]
        public System.Nullable<float> NumberOfTimestepsToBeLogged { get; set; } = null;
    }
}