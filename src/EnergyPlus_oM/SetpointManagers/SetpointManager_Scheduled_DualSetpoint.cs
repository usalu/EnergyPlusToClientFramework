using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager places a high and low schedule value on one or more nodes.")]
    [JsonObject("SetpointManager:Scheduled:DualSetpoint")]
    public class SetpointManager_Scheduled_DualSetpoint : BHoMObject
    {
        

        [JsonProperty("control_variable")]
        public EmptyNoYes ControlVariable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Temperature");
        

        [JsonProperty("high_setpoint_schedule_name")]
        public string HighSetpointScheduleName { get; set; } = "";
        

        [JsonProperty("low_setpoint_schedule_name")]
        public string LowSetpointScheduleName { get; set; } = "";
        

        [Description("Node(s) at which temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}