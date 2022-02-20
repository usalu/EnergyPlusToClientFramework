using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager is used to place a temperature setpoint on a system node th" +
                 "at is derived from the current outdoor air environmental conditions. The outdoor" +
                 " air conditions are obtained from the weather information during the simulation." +
                 "")]
    [JsonObject("SetpointManager:FollowOutdoorAirTemperature")]
    public class SetpointManager_FollowOutdoorAirTemperature : BHoMObject
    {
        

        [JsonProperty("control_variable")]
        public EmptyNoYes ControlVariable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Temperature");
        

        [JsonProperty("reference_temperature_type")]
        public EmptyNoYes ReferenceTemperatureType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "OutdoorAirWetBulb");
        

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