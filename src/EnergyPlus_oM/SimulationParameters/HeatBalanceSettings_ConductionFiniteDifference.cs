using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Determines settings for the Conduction Finite Difference algorithm for surface he" +
                 "at transfer modeling.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatBalanceSettings_ConductionFiniteDifference : BHoMObject
    {
        

        [JsonProperty("difference_scheme")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme DifferenceScheme { get; set; } = (HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme)Enum.Parse(typeof(HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme), "FullyImplicitFirstOrder");
        

        [Description("increase or decrease number of nodes")]
        [JsonProperty("space_discretization_constant")]
        public System.Nullable<float> SpaceDiscretizationConstant { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("relaxation_factor")]
        public System.Nullable<float> RelaxationFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("inside_face_surface_temperature_convergence_criteria")]
        public System.Nullable<float> InsideFaceSurfaceTemperatureConvergenceCriteria { get; set; } = (System.Nullable<float>)Single.Parse("0.002", CultureInfo.InvariantCulture);
    }
}