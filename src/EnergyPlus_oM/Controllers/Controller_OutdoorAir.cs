using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    [Description("Controller to set the outdoor air flow rate for an air loop. Control options incl" +
                 "ude fixed, proportional, scheduled, economizer, and demand-controlled ventilatio" +
                 "n.")]
    [JsonObject("Controller:OutdoorAir")]
    public class Controller_OutdoorAir : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("relief_air_outlet_node_name")]
        public string ReliefAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("return_air_node_name")]
        public string ReturnAirNodeName { get; set; } = "";
        

        [JsonProperty("mixed_air_node_name")]
        public string MixedAirNodeName { get; set; } = "";
        

        [Description("Outdoor air inlet node entering the first pre-treat component if any")]
        [JsonProperty("actuator_node_name")]
        public string ActuatorNodeName { get; set; } = "";
        

        [Description("If there is a Mechanical Ventilation Controller (Controller:MechanicalVentilation" +
                     "), note that this value times the Minimum Outdoor Air Schedule is a hard minimum" +
                     " that may override DCV or other advanced OA controls.")]
        [JsonProperty("minimum_outdoor_air_flow_rate")]
        public string MinimumOutdoorAirFlowRate { get; set; } = "";
        

        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = "";
        

        [JsonProperty("economizer_control_type")]
        public Controller_OutdoorAir_EconomizerControlType EconomizerControlType { get; set; } = (Controller_OutdoorAir_EconomizerControlType)Enum.Parse(typeof(Controller_OutdoorAir_EconomizerControlType), "NoEconomizer");
        

        [JsonProperty("economizer_control_action_type")]
        public Controller_OutdoorAir_EconomizerControlActionType EconomizerControlActionType { get; set; } = (Controller_OutdoorAir_EconomizerControlActionType)Enum.Parse(typeof(Controller_OutdoorAir_EconomizerControlActionType), "ModulateFlow");
        

        [Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb economizer " +
                     "control type. No input or blank input means this limit is not operative. Limit i" +
                     "s applied regardless of economizer control type.")]
        [JsonProperty("economizer_maximum_limit_dry_bulb_temperature")]
        public System.Nullable<float> EconomizerMaximumLimitDryBulbTemperature { get; set; } = null;
        

        [Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control typ" +
                     "e. No input or blank input means this limit is not operative Limit is applied re" +
                     "gardless of economizer control type.")]
        [JsonProperty("economizer_maximum_limit_enthalpy")]
        public System.Nullable<float> EconomizerMaximumLimitEnthalpy { get; set; } = null;
        

        [Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
                     "economizer control type. No input or blank input means this limit is not operati" +
                     "ve. Limit is applied regardless of economizer control type.")]
        [JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
        public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

        [Description(@"Enter the name of a quadratic or cubic curve which defines the maximum outdoor humidity ratio (function of outdoor dry-bulb temperature) for ElectronicEnthalpy economizer control type. No input or blank input means this limit is not operative Limit is applied regardless of economizer control type.")]
        [JsonProperty("electronic_enthalpy_limit_curve_name")]
        public string ElectronicEnthalpyLimitCurveName { get; set; } = "";
        

        [Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control. No i" +
                     "nput or blank input means this limit is not operative Limit is applied regardles" +
                     "s of economizer control type.")]
        [JsonProperty("economizer_minimum_limit_dry_bulb_temperature")]
        public System.Nullable<float> EconomizerMinimumLimitDryBulbTemperature { get; set; } = null;
        

        [JsonProperty("lockout_type")]
        public Controller_OutdoorAir_LockoutType LockoutType { get; set; } = (Controller_OutdoorAir_LockoutType)Enum.Parse(typeof(Controller_OutdoorAir_LockoutType), "NoLockout");
        

        [JsonProperty("minimum_limit_type")]
        public Controller_OutdoorAir_MinimumLimitType MinimumLimitType { get; set; } = (Controller_OutdoorAir_MinimumLimitType)Enum.Parse(typeof(Controller_OutdoorAir_MinimumLimitType), "ProportionalMinimum");
        

        [Description("Schedule values multiply the minimum outdoor air flow rate")]
        [JsonProperty("minimum_outdoor_air_schedule_name")]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [Description("schedule values multiply the design/mixed air flow rate")]
        [JsonProperty("minimum_fraction_of_outdoor_air_schedule_name")]
        public string MinimumFractionOfOutdoorAirScheduleName { get; set; } = "";
        

        [Description("schedule values multiply the design/mixed air flow rate")]
        [JsonProperty("maximum_fraction_of_outdoor_air_schedule_name")]
        public string MaximumFractionOfOutdoorAirScheduleName { get; set; } = "";
        

        [Description("Enter the name of a Controller:MechanicalVentilation object. Optional field for d" +
                     "efining outdoor ventilation air based on flow rate per unit floor area and flow " +
                     "rate per person. Simplified method of demand-controlled ventilation.")]
        [JsonProperty("mechanical_ventilation_controller_name")]
        public string MechanicalVentilationControllerName { get; set; } = "";
        

        [Description(@"Optional schedule to simulate ""push-button"" type economizer control. Schedule values greater than 0 indicate time-of-day economizer control is enabled. Economizer control may be used with or without the high humidity control option. When used together, high humidity control has priority over economizer control. If the field Economizer Control Type = NoEconomizer, then this option is disabled.")]
        [JsonProperty("time_of_day_economizer_control_schedule_name")]
        public string TimeOfDayEconomizerControlScheduleName { get; set; } = "";
        

        [Description(@"Optional field to enable modified outdoor air flow rates based on zone relative humidity. Select Yes to modify outdoor air flow rate based on a zone humidistat. Select No to disable this feature. If the field Economizer Control Type = NoEconomizer, then this option is disabled.")]
        [JsonProperty("high_humidity_control")]
        public EmptyNoYes HighHumidityControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Enter the name of the zone where the humidistat is located. This field is only us" +
                     "ed when the field High Humidity Control = Yes.")]
        [JsonProperty("humidistat_control_zone_name")]
        public string HumidistatControlZoneName { get; set; } = "";
        

        [Description("Enter the ratio of outdoor air to the maximum outdoor air flow rate when modified" +
                     " air flow rates are active based on high indoor humidity. The minimum value must" +
                     " be greater than 0. This field is only used when the field High Humidity Control" +
                     " = Yes.")]
        [JsonProperty("high_humidity_outdoor_air_flow_ratio")]
        public System.Nullable<float> HighHumidityOutdoorAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"If No is selected, the outdoor air flow rate is modified any time indoor relative humidity is above the humidistat setpoint. If Yes is selected, the outdoor air flow rate is modified any time the indoor relative humidity is above the humidistat setpoint and the outdoor humidity ratio is less than the indoor humidity ratio. This field is only used when the field High Humidity Control = Yes.")]
        [JsonProperty("control_high_indoor_humidity_based_on_outdoor_humidity_ratio")]
        public EmptyNoYes ControlHighIndoorHumidityBasedOnOutdoorHumidityRatio { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description(@"BypassWhenWithinEconomizerLimits specifies that heat recovery is active only when the economizer is off because conditions are outside the economizer control limits BypassWhenOAFlowGreaterThanMinimum specifies enhanced economizer controls to allow heat recovery when economizer is active (within limits) but the outdoor air flow rate is at the minimum.")]
        [JsonProperty("heat_recovery_bypass_control_type")]
        public Controller_OutdoorAir_HeatRecoveryBypassControlType HeatRecoveryBypassControlType { get; set; } = (Controller_OutdoorAir_HeatRecoveryBypassControlType)Enum.Parse(typeof(Controller_OutdoorAir_HeatRecoveryBypassControlType), "BypassWhenWithinEconomizerLimits");
    }
}