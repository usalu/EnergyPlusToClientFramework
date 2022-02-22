using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, variable volume, with reheat coil " +
                 "(hot water, electric, gas, or steam).")]
    public class AirTerminal_SingleDuct_VAV_Reheat : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("the outlet node of the damper and the inlet node of the reheat coil this is an in" +
                     "ternal node to the terminal unit and connects the damper and reheat coil")]
        [JsonProperty("damper_air_outlet_node_name")]
        public string DamperAirOutletNodeName { get; set; } = "";
        

        [Description("the inlet node to the terminal unit and the damper")]
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
        public AirTerminal_SingleDuct_VAV_Reheat_ZoneMinimumAirFlowInputMethod ZoneMinimumAirFlowInputMethod { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_ZoneMinimumAirFlowInputMethod)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_ZoneMinimumAirFlowInputMethod), "Constant");
        

        [Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Constant If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional; if a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the following field are entered, the larger result is used. The values for autosizing are picked up from the Sizing:Zone input fields ""Cooling Minimum Air Flow per Zone Floor Area"", ""Cooling Minimum Air Flow"", and ""Cooling Minimum Air Flow Fraction"". If there is no sizing calculation a default of 0.000762 m3/s-m2 (0.15 cfm/ft2) is used.")]
        [JsonProperty("constant_minimum_air_flow_fraction")]
        public string ConstantMinimumAirFlowFraction { get; set; } = (System.String)"Autosize";
        

        [Description(@"This field is used if the field Zone Minimum Air Flow Input Method is FixedFlowRate. If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional; if a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the previous field are entered, the larger result is used. The values for autosizing are picked up from the Sizing:Zone input fields ""Cooling Minimum Air Flow per Zone Floor Area"", ""Cooling Minimum Air Flow"", and ""Cooling Minimum Air Flow Fraction"". If there is no sizing calculation a default of 0.000762 m3/s-m2 (0.15 cfm/ft2) is used.")]
        [JsonProperty("fixed_minimum_air_flow_rate")]
        public string FixedMinimumAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Scheduled Schedule values are fractions, 0.0 to 1.0. If the field Constant Minimum Air Flow Fraction is blank, then the average of the minimum and maximum schedule values is used for sizing normal-action reheat coils.")]
        [JsonProperty("minimum_air_flow_fraction_schedule_name")]
        public string MinimumAirFlowFractionScheduleName { get; set; } = "";
        

        [JsonProperty("reheat_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_SingleDuct_VAV_Reheat_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_ReheatCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_ReheatCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty("reheat_coil_name")]
        public string ReheatCoilName { get; set; } = "";
        

        [Description("Not used when reheat coil type is gas or electric")]
        [JsonProperty("maximum_hot_water_or_steam_flow_rate")]
        public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

        [Description("Not used when reheat coil type is gas or electric")]
        [JsonProperty("minimum_hot_water_or_steam_flow_rate")]
        public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The outlet node of the terminal unit and the reheat coil. This is also the zone i" +
                     "nlet node.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("convergence_tolerance")]
        public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("Normal means the damper is fixed at the minimum position in heating mode Reverse " +
                     "means the damper can open fully during reheat ReverseWithLimits means the damper" +
                     " will open partially during reheat as specified in the following 2 fields")]
        [JsonProperty("damper_heating_action")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_SingleDuct_VAV_Reheat_DamperHeatingAction DamperHeatingAction { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_DamperHeatingAction)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_DamperHeatingAction), "ReverseWithLimits");
        

        [Description(@"Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = ReverseWithLimits When autocalculating, the maximum flow per zone is set to 0.002032 m3/s-m2 (0.4 cfm/sqft) This optional field limits the maximum flow allowed in reheat mode. At no time will the maximum flow rate calculated here exceed the value of Maximum Air Flow Rate.")]
        [JsonProperty("maximum_flow_per_zone_floor_area_during_reheat")]
        public string MaximumFlowPerZoneFloorAreaDuringReheat { get; set; } = (System.String)"Autosize";
        

        [Description(@"Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = ReverseWithLimits When autocalculating, the maximum flow fraction is set to the ratio of 0.002032 m3/s-m2 (0.4 cfm/sqft) multiplied by the zone floor area and the Maximum Air Flow Rate. This optional field limits the maximum flow allowed in reheat mode. At no time will the maximum flow rate calculated here exceed the value of Maximum Air Flow Rate.")]
        [JsonProperty("maximum_flow_fraction_during_reheat")]
        public string MaximumFlowFractionDuringReheat { get; set; } = (System.String)"Autosize";
        

        [Description("Specifies the maximum allowable supply air temperature leaving the reheat coil. I" +
                     "f left blank, there is no limit and no default. If unknown, 35C (95F) is recomme" +
                     "nded.")]
        [JsonProperty("maximum_reheat_air_temperature")]
        public System.Nullable<float> MaximumReheatAirTemperature { get; set; } = null;
        

        [Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. If this field is blank, then the terminal unit will not be controlled for outdoor air flow.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field can be used with any of the three ""Zone Minimum Air Flow Input Method"". Schedule values are fractions, 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1.")]
        [JsonProperty("minimum_air_flow_turndown_schedule_name")]
        public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
}