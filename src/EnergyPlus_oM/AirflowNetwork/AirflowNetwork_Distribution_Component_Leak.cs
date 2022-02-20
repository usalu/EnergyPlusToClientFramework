using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the characteristics of a supply or return air leak.")]
    [JsonObject("AirflowNetwork:Distribution:Component:Leak")]
    public class AirflowNetwork_Distribution_Component_Leak : BHoMObject
    {
        

        [Description("Defined at 1 Pa pressure difference across this component. Enter the coefficient " +
                     "used in the following equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP" +
                     ")^Air Mass Flow Exponent")]
        [JsonProperty("air_mass_flow_coefficient")]
        public System.Nullable<float> AirMassFlowCoefficient { get; set; } = null;
        

        [Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
                     " Coefficient * (dP)^Air Mass Flow Exponent")]
        [JsonProperty("air_mass_flow_exponent")]
        public System.Nullable<float> AirMassFlowExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
    }
}