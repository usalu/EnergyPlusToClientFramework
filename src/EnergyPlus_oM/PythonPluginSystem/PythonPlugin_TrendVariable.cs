using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    [Description("This object sets up a Python plugin trend variable from an Python plugin variable" +
                 " A trend variable logs values across timesteps")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PythonPlugin_TrendVariable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("name_of_a_python_plugin_variable")]
        public string NameOfAPythonPluginVariable { get; set; } = "";
        

        [JsonProperty("number_of_timesteps_to_be_logged")]
        public System.Nullable<float> NumberOfTimestepsToBeLogged { get; set; } = null;
    }
}