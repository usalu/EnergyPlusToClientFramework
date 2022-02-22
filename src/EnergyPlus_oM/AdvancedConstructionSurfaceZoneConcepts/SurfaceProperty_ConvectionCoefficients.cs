using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Allow user settable interior and/or exterior convection coefficients. Note that some other factors may limit the lower bounds for these values, such as for windows, the interior convection coefficient must be >.28, for trombe wall algorithm selection (zone), the interior convection coefficient must be >.1 for TARP interior convection, the lower limit is also .1 Minimum and maximum limits are set in HeatBalanceAlgorithm object. Defaults in HeatBalanceAlgorithm object are [.1,1000].")]
    [JsonObject("SurfaceProperty:ConvectionCoefficients")]
    public class SurfaceProperty_ConvectionCoefficients : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("convection_coefficient_1_location")]
        public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location ConvectionCoefficient1Location { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location), "Inside");
        

        [JsonProperty("convection_coefficient_1_type")]
        public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type ConvectionCoefficient1Type { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type), "ASHRAEVerticalWall");
        

        [Description("used if Convection Type=Value, min and max limits are set in HeatBalanceAlgorithm" +
                     " object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
        [JsonProperty("convection_coefficient_1")]
        public System.Nullable<float> ConvectionCoefficient1 { get; set; } = null;
        

        [Description("used if Convection Type=Schedule,  min and max limits are set in HeatBalanceAlgor" +
                     "ithm object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
        [JsonProperty("convection_coefficient_1_schedule_name")]
        public string ConvectionCoefficient1ScheduleName { get; set; } = "";
        

        [Description("used if Convection Type = UserCurve")]
        [JsonProperty("convection_coefficient_1_user_curve_name")]
        public string ConvectionCoefficient1UserCurveName { get; set; } = "";
        

        [JsonProperty("convection_coefficient_2_location")]
        public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location ConvectionCoefficient2Location { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location), "Inside");
        

        [JsonProperty("convection_coefficient_2_type")]
        public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type ConvectionCoefficient2Type { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type), "ASHRAEVerticalWall");
        

        [Description("used if Convection Type=Value, min and max limits are set in HeatBalanceAlgorithm" +
                     " object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
        [JsonProperty("convection_coefficient_2")]
        public System.Nullable<float> ConvectionCoefficient2 { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("used if Convection Type=Schedule,  min and max limits are set in HeatBalanceAlgor" +
                     "ithm object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
        [JsonProperty("convection_coefficient_2_schedule_name")]
        public string ConvectionCoefficient2ScheduleName { get; set; } = "";
        

        [Description("used if Convection Type = UserCurve")]
        [JsonProperty("convection_coefficient_2_user_curve_name")]
        public string ConvectionCoefficient2UserCurveName { get; set; } = "";
    }
}