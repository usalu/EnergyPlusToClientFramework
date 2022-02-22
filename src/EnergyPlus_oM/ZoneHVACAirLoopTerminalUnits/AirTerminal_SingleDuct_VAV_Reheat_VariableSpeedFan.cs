using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description(@"Central air system terminal unit, single duct, variable volume, with reheat coil (hot water, electric, gas, or steam) and variable-speed fan. These units are usually employed in underfloor air distribution (UFAD) systems where the air is supplied at low static pressure through an underfloor plenum. The fan is used to control the flow of conditioned air that enters the space.")]
    [JsonObject("AirTerminal:SingleDuct:VAV:Reheat:VariableSpeedFan")]
    public class AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_cooling_air_flow_rate")]
        public string MaximumCoolingAirFlowRate { get; set; } = "";
        

        [JsonProperty("maximum_heating_air_flow_rate")]
        public string MaximumHeatingAirFlowRate { get; set; } = "";
        

        [Description("fraction of cooling air flow rate")]
        [JsonProperty("zone_minimum_air_flow_fraction")]
        public System.Nullable<float> ZoneMinimumAirFlowFraction { get; set; } = null;
        

        [Description("The name of the HVAC system node that is the air inlet node for the terminal unit" +
                     ". This is also the air inlet node for the unit\'s fan.")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("The name of the HVAC system node that is the air outlet node for the terminal uni" +
                     "t. This is also the air outlet node for the unit\'s heating coil\'s air outlet nod" +
                     "e. This node is also a zone inlet node.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("fan_object_type")]
        public AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_FanObjectType FanObjectType { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_FanObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_FanObjectType), "FanSystemModel");
        

        [JsonProperty("fan_name")]
        public string FanName { get; set; } = "";
        

        [JsonProperty("heating_coil_object_type")]
        public AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_HeatingCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [Description("Not used when heating coil type is gas or electric")]
        [JsonProperty("maximum_hot_water_or_steam_flow_rate")]
        public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

        [Description("Not used when heating coil type is gas or electric")]
        [JsonProperty("minimum_hot_water_or_steam_flow_rate")]
        public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_convergence_tolerance")]
        public System.Nullable<float> HeatingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description(@"This field adjusts the fan-off minimum flow rate by multiplying it using this scheduled fraction values. This field is used with ""Zone Minimum Air Flow Fraction"". Schedule values are fractions 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1 and the model uses the fixed fraction specified in in the field ""Zone Minimum Air Flow Fraction"".")]
        [JsonProperty("minimum_air_flow_turndown_schedule_name")]
        public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
}