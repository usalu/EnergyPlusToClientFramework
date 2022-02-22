using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This Setpoint Manager is used to place a setpoint temperature on system node acco" +
                 "rding to the outdoor air temperature using a reset rule. The outdoor air tempera" +
                 "ture is obtained from the weather information during the simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_OutdoorAirReset : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("control_variable")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_OutdoorAirReset_ControlVariable ControlVariable { get; set; } = (SetpointManager_OutdoorAirReset_ControlVariable)Enum.Parse(typeof(SetpointManager_OutdoorAirReset_ControlVariable), "Temperature");
        

        [JsonProperty("setpoint_at_outdoor_low_temperature")]
        public System.Nullable<float> SetpointAtOutdoorLowTemperature { get; set; } = null;
        

        [JsonProperty("outdoor_low_temperature")]
        public System.Nullable<float> OutdoorLowTemperature { get; set; } = null;
        

        [JsonProperty("setpoint_at_outdoor_high_temperature")]
        public System.Nullable<float> SetpointAtOutdoorHighTemperature { get; set; } = null;
        

        [JsonProperty("outdoor_high_temperature")]
        public System.Nullable<float> OutdoorHighTemperature { get; set; } = null;
        

        [Description("Node(s) at which temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
        

        [Description("Optional input. Schedule allows scheduling of the outdoor air reset rule - a sche" +
                     "dule value of 1 means use the first rule; a value of 2 means use the second rule" +
                     ".")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description("2nd outdoor air temperature reset rule")]
        [JsonProperty("setpoint_at_outdoor_low_temperature_2")]
        public System.Nullable<float> SetpointAtOutdoorLowTemperature2 { get; set; } = null;
        

        [Description("2nd outdoor air temperature reset rule")]
        [JsonProperty("outdoor_low_temperature_2")]
        public System.Nullable<float> OutdoorLowTemperature2 { get; set; } = null;
        

        [Description("2nd outdoor air temperature reset rule")]
        [JsonProperty("setpoint_at_outdoor_high_temperature_2")]
        public System.Nullable<float> SetpointAtOutdoorHighTemperature2 { get; set; } = null;
        

        [Description("2nd outdoor air temperature reset rule")]
        [JsonProperty("outdoor_high_temperature_2")]
        public System.Nullable<float> OutdoorHighTemperature2 { get; set; } = null;
    }
}