using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Refined definition of the foundation surface construction used to inform two-dime" +
                 "nsional heat transfer calculated using the Kiva ground heat transfer methodology" +
                 ".")]
    [JsonObject("Foundation:Kiva")]
    public class Foundation_Kiva : BHoMObject
    {
        

        [Description("Indoor air temperature used for Kiva initialization (prior to warmup period) If l" +
                     "eft blank, indoor air temperature will be determined based on zone setpoints")]
        [JsonProperty("initial_indoor_air_temperature")]
        public System.Nullable<float> InitialIndoorAirTemperature { get; set; } = null;
        

        [JsonProperty("interior_horizontal_insulation_material_name")]
        public string InteriorHorizontalInsulationMaterialName { get; set; } = "";
        

        [Description("Distance from the slab bottom to the top of interior horizontal insulation")]
        [JsonProperty("interior_horizontal_insulation_depth")]
        public System.Nullable<float> InteriorHorizontalInsulationDepth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Extent of insulation as measured from the wall interior")]
        [JsonProperty("interior_horizontal_insulation_width")]
        public System.Nullable<float> InteriorHorizontalInsulationWidth { get; set; } = null;
        

        [JsonProperty("interior_vertical_insulation_material_name")]
        public string InteriorVerticalInsulationMaterialName { get; set; } = "";
        

        [Description("Extent of insulation as measured from the wall top to the bottom edge of the inte" +
                     "rior vertical insulation")]
        [JsonProperty("interior_vertical_insulation_depth")]
        public System.Nullable<float> InteriorVerticalInsulationDepth { get; set; } = null;
        

        [JsonProperty("exterior_horizontal_insulation_material_name")]
        public string ExteriorHorizontalInsulationMaterialName { get; set; } = "";
        

        [Description("Distance from the exterior grade to the top of exterior horizontal insulation")]
        [JsonProperty("exterior_horizontal_insulation_depth")]
        public System.Nullable<float> ExteriorHorizontalInsulationDepth { get; set; } = null;
        

        [Description("Extent of insulation as measured from the wall exterior")]
        [JsonProperty("exterior_horizontal_insulation_width")]
        public System.Nullable<float> ExteriorHorizontalInsulationWidth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("exterior_vertical_insulation_material_name")]
        public string ExteriorVerticalInsulationMaterialName { get; set; } = "";
        

        [Description("Extent of insulation as measured from the wall top to the bottom edge of the exte" +
                     "rior vertical insulation")]
        [JsonProperty("exterior_vertical_insulation_depth")]
        public System.Nullable<float> ExteriorVerticalInsulationDepth { get; set; } = null;
        

        [Description("Distance from the exterior grade to the wall top")]
        [JsonProperty("wall_height_above_grade")]
        public System.Nullable<float> WallHeightAboveGrade { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Distance from the slab bottom to the bottom of the foundation wall")]
        [JsonProperty("wall_depth_below_slab")]
        public System.Nullable<float> WallDepthBelowSlab { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Defines the below-grade surface construction for slabs. Required if foundation wa" +
                     "ll is not exposed to the zone.")]
        [JsonProperty("footing_wall_construction_name")]
        public string FootingWallConstructionName { get; set; } = "";
        

        [JsonProperty("footing_material_name")]
        public string FootingMaterialName { get; set; } = "";
        

        [Description("Top-to-bottom dimension of the footing (not to be confused with its depth in the " +
                     "ground). The width of the footing is defined by the material\'s thickness.")]
        [JsonProperty("footing_depth")]
        public System.Nullable<float> FootingDepth { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

        [JsonProperty("blocks")]
        public string Blocks { get; set; } = "";
    }
}