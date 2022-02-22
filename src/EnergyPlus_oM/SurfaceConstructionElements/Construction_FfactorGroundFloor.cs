using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Alternate method of describing slab-on-grade or underground floor constructions")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_FfactorGroundFloor : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("f_factor")]
        public System.Nullable<float> FFactor { get; set; } = null;
        

        [Description("Enter area of the floor")]
        [JsonProperty("area")]
        public System.Nullable<float> Area { get; set; } = null;
        

        [Description("Enter exposed perimeter of the floor")]
        [JsonProperty("perimeterexposed")]
        public System.Nullable<float> Perimeterexposed { get; set; } = null;
    }
}