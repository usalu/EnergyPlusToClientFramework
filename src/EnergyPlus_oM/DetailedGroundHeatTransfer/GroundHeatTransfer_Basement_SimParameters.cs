using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Specifies certain parameters that control the Basement preprocessor ground heat t" +
                 "ransfer simulation.")]
    [JsonObject("GroundHeatTransfer:Basement:SimParameters")]
    public class GroundHeatTransfer_Basement_SimParameters : BHoMObject, IEnergyPlusClass
    {
        

        [Description("0<F<1.0, typically 0.1 (0.3 for high k soil - saturated sand is about 2.6 w/m-K)")]
        [JsonProperty("f_multiplier_for_the_adi_solution")]
        public System.Nullable<float> FMultiplierForTheAdiSolution { get; set; } = null;
        

        [Description("typically 15-30]")]
        [JsonProperty("iyrs_maximum_number_of_yearly_iterations_")]
        public System.Nullable<float> IyrsMaximumNumberOfYearlyIterations { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
    }
}