using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This setpoint manager is used to place a temperature setpoint on a system node that is derived from a current ground temperature. The ground temperatures are specified in different Site:GroundTemperature:* objects and used during the simulation. This setpoint manager is primarily intended for condenser or plant loops using some type of ground heat exchanger.")]
    [JsonObject("SetpointManager:FollowGroundTemperature")]
    public class SetpointManager_FollowGroundTemperature : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_variable")]
        public SetpointManager_FollowGroundTemperature_ControlVariable ControlVariable { get; set; } = (SetpointManager_FollowGroundTemperature_ControlVariable)Enum.Parse(typeof(SetpointManager_FollowGroundTemperature_ControlVariable), "Temperature");
        

        [JsonProperty("reference_ground_temperature_object_type")]
        public SetpointManager_FollowGroundTemperature_ReferenceGroundTemperatureObjectType ReferenceGroundTemperatureObjectType { get; set; } = (SetpointManager_FollowGroundTemperature_ReferenceGroundTemperatureObjectType)Enum.Parse(typeof(SetpointManager_FollowGroundTemperature_ReferenceGroundTemperatureObjectType), "SiteGroundTemperatureBuildingSurface");
        

        [JsonProperty("offset_temperature_difference")]
        public System.Nullable<float> OffsetTemperatureDifference { get; set; } = null;
        

        [JsonProperty("maximum_setpoint_temperature")]
        public System.Nullable<float> MaximumSetpointTemperature { get; set; } = null;
        

        [JsonProperty("minimum_setpoint_temperature")]
        public System.Nullable<float> MinimumSetpointTemperature { get; set; } = null;
        

        [Description("Node(s) at which control variable will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}