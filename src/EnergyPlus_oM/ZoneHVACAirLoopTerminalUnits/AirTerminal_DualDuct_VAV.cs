using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, dual duct, variable volume.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirTerminal_DualDuct_VAV : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("The outlet node of the terminal unit. This is also the zone inlet node.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("hot_air_inlet_node_name")]
        public string HotAirInletNodeName { get; set; } = "";
        

        [JsonProperty("cold_air_inlet_node_name")]
        public string ColdAirInletNodeName { get; set; } = "";
        

        [JsonProperty("maximum_damper_air_flow_rate")]
        public string MaximumDamperAirFlowRate { get; set; } = "";
        

        [Description("fraction of maximum air flow")]
        [JsonProperty("zone_minimum_air_flow_fraction")]
        public System.Nullable<float> ZoneMinimumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. If this field is blank, then the terminal unit will not be controlled for outdoor air flow.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field is used with ""Zone Minimum Air Flow Fraction"". Schedule values are fractions 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1 and the VAV air terminal uses fixed fraction specified in the field ""Zone Minimum Air Flow Fraction"".")]
        [JsonProperty("minimum_air_flow_turndown_schedule_name")]
        public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
}