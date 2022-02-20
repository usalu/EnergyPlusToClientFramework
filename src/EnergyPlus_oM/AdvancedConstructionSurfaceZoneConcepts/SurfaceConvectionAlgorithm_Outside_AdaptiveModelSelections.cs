using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Options to change the individual convection model equations for dynamic selection when using AdaptiveConvectiongAlgorithm This object is only needed to make changes to the default model selections for any or all of the surface categories. This object is for the outside face, the side of the surface facing away from the thermal zone.")]
    [JsonObject("SurfaceConvectionAlgorithm:Outside:AdaptiveModelSelections")]
    public class SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections : BHoMObject
    {
        

        [JsonProperty("wind_convection_windward_vertical_wall_equation_source")]
        public EmptyNoYes WindConvectionWindwardVerticalWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "TARPWindward");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("wind_convection_windward_equation_vertical_wall_user_curve_name")]
        public string WindConvectionWindwardEquationVerticalWallUserCurveName { get; set; } = "";
        

        [JsonProperty("wind_convection_leeward_vertical_wall_equation_source")]
        public EmptyNoYes WindConvectionLeewardVerticalWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "TARPLeeward");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("wind_convection_leeward_vertical_wall_equation_user_curve_name")]
        public string WindConvectionLeewardVerticalWallEquationUserCurveName { get; set; } = "";
        

        [JsonProperty("wind_convection_horizontal_roof_equation_source")]
        public EmptyNoYes WindConvectionHorizontalRoofEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ClearRoof");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("wind_convection_horizontal_roof_user_curve_name")]
        public string WindConvectionHorizontalRoofUserCurveName { get; set; } = "";
        

        [Description("This is for vertical walls")]
        [JsonProperty("natural_convection_vertical_wall_equation_source")]
        public EmptyNoYes NaturalConvectionVerticalWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ASHRAEVerticalWall");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("natural_convection_vertical_wall_equation_user_curve_name")]
        public string NaturalConvectionVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("This is for horizontal surfaces with heat flow directed for stable thermal strati" +
                     "fication")]
        [JsonProperty("natural_convection_stable_horizontal_equation_source")]
        public EmptyNoYes NaturalConvectionStableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("natural_convection_stable_horizontal_equation_user_curve_name")]
        public string NaturalConvectionStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [JsonProperty("natural_convection_unstable_horizontal_equation_source")]
        public EmptyNoYes NaturalConvectionUnstableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("natural_convection_unstable_horizontal_equation_user_curve_name")]
        public string NaturalConvectionUnstableHorizontalEquationUserCurveName { get; set; } = "";
    }
}