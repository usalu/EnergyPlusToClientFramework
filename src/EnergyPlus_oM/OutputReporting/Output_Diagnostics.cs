using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Special keys to produce certain warning messages or effect certain simulation cha" +
                 "racteristics.")]
    [JsonObject("Output:Diagnostics")]
    public class Output_Diagnostics : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("diagnostics")]
        public string Diagnostics { get; set; } = "";
    }
}