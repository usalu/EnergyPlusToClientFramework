using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Alternate method of describing slab-on-grade or underground floor constructions")]
    public class Construction_FfactorGroundFloor : BHoMObject, IEnergyPlusClass
    {
        

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