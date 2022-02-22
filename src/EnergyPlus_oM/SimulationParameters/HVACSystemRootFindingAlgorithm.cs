using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Specifies a HVAC system solver algorithm to find a root")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACSystemRootFindingAlgorithm : BHoMObject
    {
        

        [JsonProperty("algorithm")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACSystemRootFindingAlgorithm_Algorithm Algorithm { get; set; } = (HVACSystemRootFindingAlgorithm_Algorithm)Enum.Parse(typeof(HVACSystemRootFindingAlgorithm_Algorithm), "RegulaFalsi");
        

        [Description("This field is used when RegulaFalsiThenBisection or BisectionThenRegulaFalsi is e" +
                     "ntered. When iteration number is greater than the value, algorithm switches.")]
        [JsonProperty("number_of_iterations_before_algorithm_switch")]
        public System.Nullable<float> NumberOfIterationsBeforeAlgorithmSwitch { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
    }
}