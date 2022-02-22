using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, variable volume, with no reheat co" +
                 "il.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirTerminal_SingleDuct_VAV_NoReheat : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("maximum_air_flow_rate")]
        public string MaximumAirFlowRate { get; set; } = "";
        

        [Description("Constant = Constant Minimum Air Flow Fraction (a fraction of Maximum Air Flow Rat" +
                     "e) FixedFlowRate = Fixed Minimum Air Flow Rate (a fixed minimum air volume flow " +
                     "rate) Scheduled = Scheduled Minimum Air Flow Fraction (a fraction of Maximum Air" +
                     " Flow")]
        [JsonProperty("zone_minimum_air_flow_input_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_SingleDuct_VAV_NoReheat_ZoneMinimumAirFlowInputMethod ZoneMinimumAirFlowInputMethod { get; set; } = (AirTerminal_SingleDuct_VAV_NoReheat_ZoneMinimumAirFlowInputMethod)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_NoReheat_ZoneMinimumAirFlowInputMethod), "Constant");
        

        [Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Constant If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional; if a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the following field are entered, the larger result is used. The values for autosizing are picked up from the Sizing:Zone input fields ""Cooling Minimum Air Flow per Zone Floor Area"", ""Cooling Minimum Air Flow"", and ""Cooling Minimum Air Flow Fraction"". If there is no sizing calculation a default of 0.000762 m3/s-m2 (0.15 cfm/ft2) is used.")]
        [JsonProperty("constant_minimum_air_flow_fraction")]
        public string ConstantMinimumAirFlowFraction { get; set; } = (System.String)"Autosize";
        

        [Description(@"This field is used if the field Zone Minimum Air Flow Input Method is FixedFlowRate. If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional; if a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the previous field are entered, the larger result is used. The values for autosizing are picked up from the Sizing:Zone input fields ""Cooling Minimum Air Flow per Zone Floor Area"", ""Cooling Minimum Air Flow"", and ""Cooling Minimum Air Flow Fraction"". If there is no sizing calculation a default of 0.000762 m3/s-m2 (0.15 cfm/ft2) is used.")]
        [JsonProperty("fixed_minimum_air_flow_rate")]
        public string FixedMinimumAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Scheduled Schedule values are fractions, 0.0 to 1.0. If the field Constant Minimum Air Flow Fraction is blank, then the average of the minimum and maximum schedule values is used for sizing normal-action reheat coils.")]
        [JsonProperty("minimum_air_flow_fraction_schedule_name")]
        public string MinimumAirFlowFractionScheduleName { get; set; } = "";
        

        [Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. If this field is blank, then the terminal unit will not be controlled for outdoor air flow.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field can be used with any of the three ""Zone Minimum Air Flow Input Method"". Schedule values are fractions, 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1.")]
        [JsonProperty("minimum_air_flow_turndown_schedule_name")]
        public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
}