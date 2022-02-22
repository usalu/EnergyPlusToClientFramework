using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This SetpointManager resets the cooling supply air temperature of a central force" +
                 "d air HVAC system according to the cooling demand of the warmest zone.")]
    [JsonObject("SetpointManager:Warmest")]
    public class SetpointManager_Warmest : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_variable")]
        public SetpointManager_Warmest_ControlVariable ControlVariable { get; set; } = (SetpointManager_Warmest_ControlVariable)Enum.Parse(typeof(SetpointManager_Warmest_ControlVariable), "Temperature");
        

        [Description("Enter the name of an AirLoopHVAC object")]
        [JsonProperty("hvac_air_loop_name")]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty("minimum_setpoint_temperature")]
        public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_setpoint_temperature")]
        public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("strategy")]
        public SetpointManager_Warmest_Strategy Strategy { get; set; } = (SetpointManager_Warmest_Strategy)Enum.Parse(typeof(SetpointManager_Warmest_Strategy), "MaximumTemperature");
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}