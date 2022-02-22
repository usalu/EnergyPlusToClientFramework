using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object includes the outdoor air flow rate set by the Controller:OutdoorAir o" +
                 "bject in the airflow network.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_OutdoorAirFlow : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("outdoor_air_mixer_name")]
        public string OutdoorAirMixerName { get; set; } = "";
        

        [Description(@"Enter the air mass flow coefficient at the conditions defined in the Reference Crack Conditions object. Defined at 1 Pa pressure difference. Enter the coefficient used in the following equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Exponent. Used only when no outdoor air flow rate.")]
        [JsonProperty("air_mass_flow_coefficient_when_no_outdoor_air_flow_at_reference_conditions")]
        public System.Nullable<float> AirMassFlowCoefficientWhenNoOutdoorAirFlowAtReferenceConditions { get; set; } = null;
        

        [Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
                     " Coefficient * (dP)^Air Mass Flow Exponent. Used only when no outdoor air flow r" +
                     "ate.")]
        [JsonProperty("air_mass_flow_exponent_when_no_outdoor_air_flow")]
        public System.Nullable<float> AirMassFlowExponentWhenNoOutdoorAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description("Select a AirflowNetwork:MultiZone:ReferenceCrackConditions name associated with t" +
                     "he air mass flow coefficient entered above.")]
        [JsonProperty("reference_crack_conditions")]
        public string ReferenceCrackConditions { get; set; } = "";
    }
}