using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("This object sets up an EMS trend variable from an Erl variable A trend variable l" +
                 "ogs values across timesteps")]
    [JsonObject("EnergyManagementSystem:TrendVariable")]
    public class EnergyManagementSystem_TrendVariable : BHoMObject
    {
        

        [Description("must be a global scope EMS variable")]
        [JsonProperty("ems_variable_name")]
        public string EmsVariableName { get; set; } = "";
        

        [JsonProperty("number_of_timesteps_to_be_logged")]
        public System.Nullable<float> NumberOfTimestepsToBeLogged { get; set; } = null;
    }
}