using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Defines a daylighting which can have an inside shelf, an outside shelf, or both. " +
                 "The inside shelf is defined as a building surface and the outside shelf is defin" +
                 "ed as a shading surface.")]
    [JsonObject("DaylightingDevice:Shelf")]
    public class DaylightingDevice_Shelf : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("window_name")]
        public string WindowName { get; set; } = "";
        

        [Description("This must refer to a BuildingSurface:Detailed or equivalent object This surface m" +
                     "ust be its own Surface for other side boundary conditions.")]
        [JsonProperty("inside_shelf_name")]
        public string InsideShelfName { get; set; } = "";
        

        [Description("This must refer to a Shading:Zone:Detailed object")]
        [JsonProperty("outside_shelf_name")]
        public string OutsideShelfName { get; set; } = "";
        

        [Description("Required if outside shelf is specified")]
        [JsonProperty("outside_shelf_construction_name")]
        public string OutsideShelfConstructionName { get; set; } = "";
        

        [JsonProperty("view_factor_to_outside_shelf")]
        public System.Nullable<float> ViewFactorToOutsideShelf { get; set; } = null;
    }
}