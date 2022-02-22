using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object specifies the properties of air flow through windows and doors (windo" +
                 "w, door and glass door heat transfer subsurfaces) when they are closed or open.")]
    public class AirflowNetwork_MultiZone_Component_SimpleOpening : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Defined at 1 Pa pressure difference. Enter the coefficient used in the following " +
                     "equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Expone" +
                     "nt. Used only when opening (window or door) is closed.")]
        [JsonProperty("air_mass_flow_coefficient_when_opening_is_closed")]
        public System.Nullable<float> AirMassFlowCoefficientWhenOpeningIsClosed { get; set; } = null;
        

        [Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
                     " Coefficient * (dP)^Air Mass Flow Exponent. Used only when opening (window or do" +
                     "or) is closed.")]
        [JsonProperty("air_mass_flow_exponent_when_opening_is_closed")]
        public System.Nullable<float> AirMassFlowExponentWhenOpeningIsClosed { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum density difference above which two-way flow may occur due to st" +
                     "ack effect.")]
        [JsonProperty("minimum_density_difference_for_two_way_flow")]
        public System.Nullable<float> MinimumDensityDifferenceForTwoWayFlow { get; set; } = null;
        

        [Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
                     "ough a window or door at that Opening Factor.")]
        [JsonProperty("discharge_coefficient")]
        public System.Nullable<float> DischargeCoefficient { get; set; } = null;
    }
}