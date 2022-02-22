using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, variable volume for both cooling a" +
                 "nd heating, with no reheat coil.")]
    public class AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("The outlet node of the terminal unit. This is also the zone inlet node.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("maximum_air_flow_rate")]
        public string MaximumAirFlowRate { get; set; } = "";
        

        [Description("fraction of maximum air flow")]
        [JsonProperty("zone_minimum_air_flow_fraction")]
        public System.Nullable<float> ZoneMinimumAirFlowFraction { get; set; } = null;
        

        [Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field is used with ""Zone Minimum Air Flow Fraction"". Schedule values are fractions 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1 and the model uses the fixed fraction specified in in the field ""Zone Minimum Air Flow Fraction"".")]
        [JsonProperty("minimum_air_flow_turndown_schedule_name")]
        public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
}