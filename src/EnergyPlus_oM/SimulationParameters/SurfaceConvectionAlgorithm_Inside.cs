using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Default indoor surface heat transfer convection algorithm to be used for all zone" +
                 "s")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceConvectionAlgorithm_Inside : BHoMObject
    {
        

        [Description(@"Simple = constant value natural convection (ASHRAE) TARP = variable natural convection based on temperature difference (ASHRAE, Walton) CeilingDiffuser = ACH-based forced and mixed convection correlations for ceiling diffuser configuration with simple natural convection limit AdaptiveConvectionAlgorithm = dynamic selection of convection models based on conditions ASTMC1340 = mixed convection correlations based on heat flow direction, surface tilt angle, surface characteristic length, and air speed past the surface.")]
        [JsonProperty("algorithm")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_Algorithm Algorithm { get; set; } = (SurfaceConvectionAlgorithm_Inside_Algorithm)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_Algorithm), "TARP");
    }
}