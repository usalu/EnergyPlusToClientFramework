using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This setpoint manager is used to place a temperature setpoint on a system node that is derived from the current temperatures at a separate system node. The current value of the temperature at a reference node is obtained and used to generate setpoint on a second system node. If the reference node is also designated to be an outdoor air (intake) node, then this setpoint manager can be used to follow outdoor air conditions that are adjusted for altitude.")]
    [JsonObject("SetpointManager:FollowSystemNodeTemperature")]
    public class SetpointManager_FollowSystemNodeTemperature : BHoMObject
    {
        

        [JsonProperty("control_variable")]
        public EmptyNoYes ControlVariable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Temperature");
        

        [JsonProperty("reference_node_name")]
        public string ReferenceNodeName { get; set; } = "";
        

        [JsonProperty("reference_temperature_type")]
        public EmptyNoYes ReferenceTemperatureType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NodeDryBulb");
        

        [JsonProperty("offset_temperature_difference")]
        public System.Nullable<float> OffsetTemperatureDifference { get; set; } = null;
        

        [JsonProperty("maximum_limit_setpoint_temperature")]
        public System.Nullable<float> MaximumLimitSetpointTemperature { get; set; } = null;
        

        [JsonProperty("minimum_limit_setpoint_temperature")]
        public System.Nullable<float> MinimumLimitSetpointTemperature { get; set; } = null;
        

        [Description("Node(s) at which control variable will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}