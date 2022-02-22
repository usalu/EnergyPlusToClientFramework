using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Using an equivalent slab allows non-rectangular shapes to be modeled accurately. " +
                 "The simulation default should be EquivSizing=True")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_EquivSlab : BHoMObject
    {
        

        [JsonProperty("apratio_the_area_to_perimeter_ratio_for_this_slab")]
        public System.Nullable<float> ApratioTheAreaToPerimeterRatioForThisSlab { get; set; } = null;
        

        [Description("Will the dimensions of an equivalent slab be calculated (TRUE) or will the dimens" +
                     "ions be input directly? (FALSE)] Only advanced special simulations should use FA" +
                     "LSE.")]
        [JsonProperty("equivsizing_flag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatTransfer_Basement_EquivSlab_EquivsizingFlag EquivsizingFlag { get; set; } = (GroundHeatTransfer_Basement_EquivSlab_EquivsizingFlag)Enum.Parse(typeof(GroundHeatTransfer_Basement_EquivSlab_EquivsizingFlag), "FALSE");
    }
}