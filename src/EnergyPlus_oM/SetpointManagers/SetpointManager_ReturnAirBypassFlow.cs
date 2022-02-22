using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager determines the required mass flow rate through a return air" +
                 " bypass duct to meet the specified temperature setpoint")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_ReturnAirBypassFlow : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("control_variable")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_ReturnAirBypassFlow_ControlVariable ControlVariable { get; set; } = (SetpointManager_ReturnAirBypassFlow_ControlVariable)Enum.Parse(typeof(SetpointManager_ReturnAirBypassFlow_ControlVariable), "Flow");
        

        [Description("Enter the name of an AirLoopHVAC object.")]
        [JsonProperty("hvac_air_loop_name")]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty("temperature_setpoint_schedule_name")]
        public string TemperatureSetpointScheduleName { get; set; } = "";
    }
}