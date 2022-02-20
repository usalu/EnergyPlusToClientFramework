using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager determine the ideal optimum condenser entering water temper" +
                 "ature setpoint for a given timestep.")]
    [JsonObject("SetpointManager:CondenserEnteringReset:Ideal")]
    public class SetpointManager_CondenserEnteringReset_Ideal : BHoMObject
    {
        

        [JsonProperty("control_variable")]
        public EmptyNoYes ControlVariable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Temperature");
        

        [JsonProperty("minimum_lift")]
        public System.Nullable<float> MinimumLift { get; set; } = (System.Nullable<float>)Single.Parse("11.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_condenser_entering_water_temperature")]
        public System.Nullable<float> MaximumCondenserEnteringWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("32", CultureInfo.InvariantCulture);
        

        [Description("Node(s) at which control variable will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}