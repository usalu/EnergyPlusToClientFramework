using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object specifies the properties of air flow through a horizontal opening")]
    [JsonObject("AirflowNetwork:MultiZone:Component:HorizontalOpening")]
    public class AirflowNetwork_MultiZone_Component_HorizontalOpening : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Defined at 1 Pa pressure difference. Enter the coefficient used in the following " +
                     "equation: Mass flow rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Expone" +
                     "nt. Used only when opening is closed.")]
        [JsonProperty("air_mass_flow_coefficient_when_opening_is_closed")]
        public System.Nullable<float> AirMassFlowCoefficientWhenOpeningIsClosed { get; set; } = null;
        

        [Description("Enter the exponent used in the following equation: Mass flow rate = Air Mass Flow" +
                     " Coefficient * (dP)^Air Mass Flow Exponent. Used only when opening is closed.")]
        [JsonProperty("air_mass_flow_exponent_when_opening_is_closed")]
        public System.Nullable<float> AirMassFlowExponentWhenOpeningIsClosed { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description("Sloping plane angle = 90 is equivalent to fully open.")]
        [JsonProperty("sloping_plane_angle")]
        public System.Nullable<float> SlopingPlaneAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

        [Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
                     "ough the opening at that Opening Factor.")]
        [JsonProperty("discharge_coefficient")]
        public System.Nullable<float> DischargeCoefficient { get; set; } = null;
    }
}