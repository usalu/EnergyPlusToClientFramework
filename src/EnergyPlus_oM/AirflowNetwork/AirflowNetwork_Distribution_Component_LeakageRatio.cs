using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to define supply and return air leaks with respect to the fan" +
                 "\'s maximum air flow rate.")]
    [JsonObject("AirflowNetwork:Distribution:Component:LeakageRatio")]
    public class AirflowNetwork_Distribution_Component_LeakageRatio : BHoMObject
    {
        

        [Description("Defined as a ratio of leak flow rate to the maximum flow rate.")]
        [JsonProperty("effective_leakage_ratio")]
        public System.Nullable<float> EffectiveLeakageRatio { get; set; } = null;
        

        [Description("Enter the maximum air flow rate in this air loop.")]
        [JsonProperty("maximum_flow_rate")]
        public System.Nullable<float> MaximumFlowRate { get; set; } = null;
        

        [Description("Enter the pressure corresponding to the Effective leakage ratio entered above.")]
        [JsonProperty("reference_pressure_difference")]
        public System.Nullable<float> ReferencePressureDifference { get; set; } = null;
        

        [Description("Enter the exponent used in the air mass flow equation.")]
        [JsonProperty("air_mass_flow_exponent")]
        public System.Nullable<float> AirMassFlowExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
    }
}