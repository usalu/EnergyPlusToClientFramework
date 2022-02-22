using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    [Description("This object defines name identifiers for custom Python Plugin variable data that " +
                 "should be shared among all running Python Plugins.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PythonPlugin_Variables : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("global_py_vars")]
        public string GlobalPyVars { get; set; } = "";
    }
}