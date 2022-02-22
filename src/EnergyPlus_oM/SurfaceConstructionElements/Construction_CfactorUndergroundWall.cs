using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Alternate method of describing underground wall constructions")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_CfactorUndergroundWall : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Enter C-Factor without film coefficients or soil")]
        [JsonProperty("c_factor")]
        public System.Nullable<float> CFactor { get; set; } = null;
        

        [Description("Enter height of the underground wall")]
        [JsonProperty("height")]
        public System.Nullable<float> Height { get; set; } = null;
    }
}