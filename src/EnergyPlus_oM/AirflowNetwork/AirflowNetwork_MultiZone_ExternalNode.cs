using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines outdoor environmental conditions outside of the building.")]
    [JsonObject("AirflowNetwork:MultiZone:ExternalNode")]
    public class AirflowNetwork_MultiZone_ExternalNode : BHoMObject
    {
        

        [Description("Designates the reference height used to calculate relative pressure.")]
        [JsonProperty("external_node_height")]
        public System.Nullable<float> ExternalNodeHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The name of the AirflowNetwork:MultiZone:WindPressureCoefficientValues, curve, or" +
                     " table object specifying the wind pressure coefficient.")]
        [JsonProperty("wind_pressure_coefficient_curve_name")]
        public string WindPressureCoefficientCurveName { get; set; } = "";
        

        [Description("Specify whether the pressure curve is symmetric or not. Specify Yes for curves th" +
                     "at should be evaluated from 0 to 180 degrees Specify No for curves that should b" +
                     "e evaluated from 0 to 360 degrees")]
        [JsonProperty("symmetric_wind_pressure_coefficient_curve")]
        public EmptyNoYes SymmetricWindPressureCoefficientCurve { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Specify whether the angle used to compute the wind pressure coefficient is absolu" +
                     "te or relative Specify Relative to compute the angle between the wind direction " +
                     "and the surface azimuth Specify Absolute to use the wind direction angle directl" +
                     "y")]
        [JsonProperty("wind_angle_type")]
        public EmptyNoYes WindAngleType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Absolute");
    }
}