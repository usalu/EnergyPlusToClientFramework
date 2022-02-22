using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Parametrics
{
    [Description("Controls which parametric runs are simulated. This object is optional. If it is n" +
                 "ot included, then all parametric runs are performed.")]
    [JsonObject("Parametric:RunControl")]
    public class Parametric_RunControl : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("runs")]
        public string Runs { get; set; } = "";
    }
}