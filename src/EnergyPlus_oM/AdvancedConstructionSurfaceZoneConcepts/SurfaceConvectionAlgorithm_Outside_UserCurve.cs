using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Used to describe a custom model equation for surface convection heat transfer coe" +
                 "fficient If more than one curve is referenced they are all used and added togeth" +
                 "er.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceConvectionAlgorithm_Outside_UserCurve : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("wind_speed_type_for_curve")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Outside_UserCurve_WindSpeedTypeForCurve WindSpeedTypeForCurve { get; set; } = (SurfaceConvectionAlgorithm_Outside_UserCurve_WindSpeedTypeForCurve)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_UserCurve_WindSpeedTypeForCurve), "HeightAdjust");
        

        [Description("Curve\'s \"x\" is wind speed of the type determined in the previous field (m/s)")]
        [JsonProperty("hf_function_of_wind_speed_curve_name")]
        public string HfFunctionOfWindSpeedCurveName { get; set; } = "";
        

        [Description("Curve\'s \"x\" is absolute value of delta-T (Surface temperature minus air temperatu" +
                     "re, (C))")]
        [JsonProperty("hn_function_of_temperature_difference_curve_name")]
        public string HnFunctionOfTemperatureDifferenceCurveName { get; set; } = "";
        

        [Description("Curve\'s \"x\" is absolute value of delta-T/Height (Surface temp minus Air temp)/(ve" +
                     "rtical length scale), (C/m) when used for an outside face the vertical length sc" +
                     "ale is the exterior facade\'s overall height")]
        [JsonProperty("hn_function_of_temperature_difference_divided_by_height_curve_name")]
        public string HnFunctionOfTemperatureDifferenceDividedByHeightCurveName { get; set; } = "";
    }
}