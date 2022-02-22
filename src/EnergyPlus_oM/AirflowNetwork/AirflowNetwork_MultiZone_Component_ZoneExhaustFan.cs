using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object specifies the additional properties for a zone exhaust fan to perform" +
                 " multizone airflow calculations.")]
    [JsonObject("AirflowNetwork:MultiZone:Component:ZoneExhaustFan")]
    public class AirflowNetwork_MultiZone_Component_ZoneExhaustFan : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Enter the air mass flow coefficient at the conditions defined in the Reference Crack Conditions object. Defined at 1 Pa pressure difference. Enter the coefficient used in the following equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Exponent. Used only when the fan is off.")]
        [JsonProperty("air_mass_flow_coefficient_when_the_zone_exhaust_fan_is_off_at_reference_condition" +
                      "s")]
        public System.Nullable<float> AirMassFlowCoefficientWhenTheZoneExhaustFanIsOffAtReferenceConditions { get; set; } = null;
        

        [Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
                     " Coefficient * (dP)^Air Mass Flow Exponent. Used only when the fan is off.")]
        [JsonProperty("air_mass_flow_exponent_when_the_zone_exhaust_fan_is_off")]
        public System.Nullable<float> AirMassFlowExponentWhenTheZoneExhaustFanIsOff { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description("Select a AirflowNetwork:MultiZone:ReferenceCrackConditions name associated with t" +
                     "he air mass flow coefficient entered above.")]
        [JsonProperty("reference_crack_conditions")]
        public string ReferenceCrackConditions { get; set; } = "";
    }
}