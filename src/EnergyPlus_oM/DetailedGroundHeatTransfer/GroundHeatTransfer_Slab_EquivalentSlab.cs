using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Using an equivalent slab allows non-rectangular shapes to be modeled accurately. " +
                 "Object uses the area - perimeter (area/perimeter) ratio to determine the size of" +
                 " an equivalent rectangular slab. EnergyPlus users normally use this option.")]
    public class GroundHeatTransfer_Slab_EquivalentSlab : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Equivalent square slab is simulated,  side is 4*APRatio.")]
        [JsonProperty("apratio_the_area_to_perimeter_ratio_for_this_slab")]
        public System.Nullable<float> ApratioTheAreaToPerimeterRatioForThisSlab { get; set; } = null;
        

        [Description(@"This field specifies the thickness of the slab. The slab top surface is level with the ground surface, so this is the depth into the ground. The slab depth has a significant effect on the temperature calculation, and it is also important for the auto-grid process. The finite difference grids are set in such a way that they use the slab thickness to determine the vertical grid spacing. Autogridding will fail if the slab thickness is specified larger than 0.25 meters.")]
        [JsonProperty("slabdepth_thickness_of_slab_on_grade")]
        public System.Nullable<float> SlabdepthThicknessOfSlabOnGrade { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("This field specifies the distance from the slab to the edge of the area that will" +
                     " be modeled with the grid system. It is the basic size dimension that is used to" +
                     " set the horizontal extent of the domain. 15 meters is a reasonable value.")]
        [JsonProperty("clearance_distance_from_edge_of_slab_to_domain_edge")]
        public System.Nullable<float> ClearanceDistanceFromEdgeOfSlabToDomainEdge { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [Description("This field specifies the vertical distance from the slab to the bottom edge of th" +
                     "e area that will be modeled with the grid system. 15 meters is a reasonable valu" +
                     "e.")]
        [JsonProperty("zclearance_distance_from_bottom_of_slab_to_domain_bottom")]
        public System.Nullable<float> ZclearanceDistanceFromBottomOfSlabToDomainBottom { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
    }
}