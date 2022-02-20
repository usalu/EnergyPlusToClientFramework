using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager determines the required mass flow rate through a return air" +
                 " bypass duct to meet the specified temperature setpoint")]
    [JsonObject("SetpointManager:ReturnAirBypassFlow")]
    public class SetpointManager_ReturnAirBypassFlow : BHoMObject
    {
        

        [JsonProperty("control_variable")]
        public EmptyNoYes ControlVariable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Flow");
        

        [Description("Enter the name of an AirLoopHVAC object.")]
        [JsonProperty("hvac_air_loop_name")]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty("temperature_setpoint_schedule_name")]
        public string TemperatureSetpointScheduleName { get; set; } = "";
    }
}