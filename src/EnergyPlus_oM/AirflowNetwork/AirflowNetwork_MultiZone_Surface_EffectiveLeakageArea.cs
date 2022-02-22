using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to define surface air leakage.")]
    public class AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the effective leakage area.")]
        [JsonProperty("effective_leakage_area")]
        public System.Nullable<float> EffectiveLeakageArea { get; set; } = null;
        

        [Description("Enter the coefficient used in the air mass flow equation.")]
        [JsonProperty("discharge_coefficient")]
        public System.Nullable<float> DischargeCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Enter the pressure difference used to define the air mass flow coefficient and ex" +
                     "ponent.")]
        [JsonProperty("reference_pressure_difference")]
        public System.Nullable<float> ReferencePressureDifference { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

        [Description("Enter the exponent used in the air mass flow equation.")]
        [JsonProperty("air_mass_flow_exponent")]
        public System.Nullable<float> AirMassFlowExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
    }
}