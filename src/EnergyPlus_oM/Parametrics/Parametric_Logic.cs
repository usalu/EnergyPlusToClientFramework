using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Parametrics
{
    [Description(@"This object allows some types of objects to be included for some parametric cases and not for others. For example, you might want an overhang on a window in some parametric runs and not others. A single Parametric:Logic object is allowed per file. Consult the Input Output Reference for available commands and syntax.")]
    [JsonObject("Parametric:Logic")]
    public class Parametric_Logic : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("lines")]
        public string Lines { get; set; } = "";
    }
}