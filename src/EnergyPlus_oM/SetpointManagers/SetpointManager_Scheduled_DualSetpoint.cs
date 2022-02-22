using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager places a high and low schedule value on one or more nodes.")]
    public class SetpointManager_Scheduled_DualSetpoint : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_variable")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_Scheduled_DualSetpoint_ControlVariable ControlVariable { get; set; } = (SetpointManager_Scheduled_DualSetpoint_ControlVariable)Enum.Parse(typeof(SetpointManager_Scheduled_DualSetpoint_ControlVariable), "Temperature");
        

        [JsonProperty("high_setpoint_schedule_name")]
        public string HighSetpointScheduleName { get; set; } = "";
        

        [JsonProperty("low_setpoint_schedule_name")]
        public string LowSetpointScheduleName { get; set; } = "";
        

        [Description("Node(s) at which temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}