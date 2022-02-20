using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Determines settings for the Conduction Finite Difference algorithm for surface he" +
                 "at transfer modeling.")]
    [JsonObject("HeatBalanceSettings:ConductionFiniteDifference")]
    public class HeatBalanceSettings_ConductionFiniteDifference : BHoMObject
    {
        

        [JsonProperty("difference_scheme")]
        public EmptyNoYes DifferenceScheme { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FullyImplicitFirstOrder");
        

        [Description("increase or decrease number of nodes")]
        [JsonProperty("space_discretization_constant")]
        public System.Nullable<float> SpaceDiscretizationConstant { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("relaxation_factor")]
        public System.Nullable<float> RelaxationFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("inside_face_surface_temperature_convergence_criteria")]
        public System.Nullable<float> InsideFaceSurfaceTemperatureConvergenceCriteria { get; set; } = (System.Nullable<float>)Single.Parse("0.002", CultureInfo.InvariantCulture);
    }
}