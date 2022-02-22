using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Options to change the individual convection model equations for dynamic selection when using AdaptiveConvectiongAlgorithm This object is only needed to make changes to the default model selections for any or all of the surface categories. This object is for the outside face, the side of the surface facing away from the thermal zone.")]
    public class SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("wind_convection_windward_vertical_wall_equation_source")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionWindwardVerticalWallEquationSource WindConvectionWindwardVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionWindwardVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionWindwardVerticalWallEquationSource), "TARPWindward");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("wind_convection_windward_equation_vertical_wall_user_curve_name")]
        public string WindConvectionWindwardEquationVerticalWallUserCurveName { get; set; } = "";
        

        [JsonProperty("wind_convection_leeward_vertical_wall_equation_source")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionLeewardVerticalWallEquationSource WindConvectionLeewardVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionLeewardVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionLeewardVerticalWallEquationSource), "TARPLeeward");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("wind_convection_leeward_vertical_wall_equation_user_curve_name")]
        public string WindConvectionLeewardVerticalWallEquationUserCurveName { get; set; } = "";
        

        [JsonProperty("wind_convection_horizontal_roof_equation_source")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionHorizontalRoofEquationSource WindConvectionHorizontalRoofEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionHorizontalRoofEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionHorizontalRoofEquationSource), "ClearRoof");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("wind_convection_horizontal_roof_user_curve_name")]
        public string WindConvectionHorizontalRoofUserCurveName { get; set; } = "";
        

        [Description("This is for vertical walls")]
        [JsonProperty("natural_convection_vertical_wall_equation_source")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionVerticalWallEquationSource NaturalConvectionVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionVerticalWallEquationSource), "ASHRAEVerticalWall");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("natural_convection_vertical_wall_equation_user_curve_name")]
        public string NaturalConvectionVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("This is for horizontal surfaces with heat flow directed for stable thermal strati" +
                     "fication")]
        [JsonProperty("natural_convection_stable_horizontal_equation_source")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionStableHorizontalEquationSource NaturalConvectionStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionStableHorizontalEquationSource), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("natural_convection_stable_horizontal_equation_user_curve_name")]
        public string NaturalConvectionStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [JsonProperty("natural_convection_unstable_horizontal_equation_source")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionUnstableHorizontalEquationSource NaturalConvectionUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionUnstableHorizontalEquationSource), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
                     " the previous field is set to UserCurve")]
        [JsonProperty("natural_convection_unstable_horizontal_equation_user_curve_name")]
        public string NaturalConvectionUnstableHorizontalEquationUserCurveName { get; set; } = "";
    }
}