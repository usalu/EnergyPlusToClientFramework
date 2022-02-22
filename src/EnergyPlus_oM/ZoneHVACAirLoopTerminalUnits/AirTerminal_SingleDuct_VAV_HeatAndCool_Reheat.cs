using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, variable volume for both cooling a" +
                 "nd heating, with reheat coil (hot water, electric, gas, or steam).")]
    [JsonObject("AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat")]
    public class AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat : BHoMObject, IEnergyPlusClass
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
        

        [Description("fraction of maximum air flow")]
        [JsonProperty("zone_minimum_air_flow_fraction")]
        public System.Nullable<float> ZoneMinimumAirFlowFraction { get; set; } = null;
        

        [JsonProperty("reheat_coil_object_type")]
        public AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_ReheatCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_ReheatCoilObjectType), "CoilHeatingElectric");
        

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
        

        [Description("Specifies the maximum allowable supply air temperature leaving the reheat coil. I" +
                     "f left blank, there is no limit and no default. If unknown, 35C (95F) is recomme" +
                     "nded.")]
        [JsonProperty("maximum_reheat_air_temperature")]
        public System.Nullable<float> MaximumReheatAirTemperature { get; set; } = null;
        

        [Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field is used with ""Zone Minimum Air Flow Fraction"". Schedule values are fractions 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1 and the model uses the fixed fraction specified in in the field ""Zone Minimum Air Flow Fraction"".")]
        [JsonProperty("minimum_air_flow_turndown_schedule_name")]
        public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
}