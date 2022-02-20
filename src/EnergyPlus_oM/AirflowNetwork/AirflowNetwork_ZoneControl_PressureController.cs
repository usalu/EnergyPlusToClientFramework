using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to control a zone to a specified indoor pressure using the Ai" +
                 "rflowNetwork model. The specified pressure setpoint is used to control the zone " +
                 "exhaust fan flow rate in a controlled zone or the relief air flow rate in an air" +
                 " loop.")]
    [JsonObject("AirflowNetwork:ZoneControl:PressureController")]
    public class AirflowNetwork_ZoneControl_PressureController : BHoMObject
    {
        

        [JsonProperty("control_zone_name")]
        public string ControlZoneName { get; set; } = "";
        

        [Description("The current selection is AirflowNetwork:MultiZone:Component:ZoneExhaustFan or Air" +
                     "flowNetwork:Distribution:Component:ReliefAirFlow.")]
        [JsonProperty("control_object_type")]
        public EmptyNoYes ControlObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Control names are names of individual control objects")]
        [JsonProperty("control_object_name")]
        public string ControlObjectName { get; set; } = "";
        

        [Description("Availability schedule name for pressure controller. Schedule value > 0 means the " +
                     "pressure controller is enabled. If this field is blank, then pressure controller" +
                     " is always enabled.")]
        [JsonProperty("pressure_control_availability_schedule_name")]
        public string PressureControlAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("pressure_setpoint_schedule_name")]
        public string PressureSetpointScheduleName { get; set; } = "";
    }
}