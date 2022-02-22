using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Parametrics
{
    [Description("Controls which parametric runs are simulated. This object is optional. If it is n" +
                 "ot included, then all parametric runs are performed.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Parametric_RunControl : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("runs")]
        public string Runs { get; set; } = "";
    }
}