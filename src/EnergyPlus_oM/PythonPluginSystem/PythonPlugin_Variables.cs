using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    [Description("This object defines name identifiers for custom Python Plugin variable data that " +
                 "should be shared among all running Python Plugins.")]
    [JsonObject("PythonPlugin:Variables")]
    public class PythonPlugin_Variables : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("global_py_vars")]
        public string GlobalPyVars { get; set; } = "";
    }
}