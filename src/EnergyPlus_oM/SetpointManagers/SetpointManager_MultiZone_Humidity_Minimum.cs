using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This setpoint manager sets the minimum supply air humidity ratio based on humidification requirements of a controlled zone with critical humidity ratio setpoint (i.e., a zone with the highest humidity ratio setpoint) in an air loop served by a central air-conditioner.")]
    [JsonObject("SetpointManager:MultiZone:Humidity:Minimum")]
    public class SetpointManager_MultiZone_Humidity_Minimum : BHoMObject
    {
        

        [Description("Enter the name of an AirLoopHVAC object")]
        [JsonProperty("hvac_air_loop_name")]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty("minimum_setpoint_humidity_ratio")]
        public System.Nullable<float> MinimumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.005", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_setpoint_humidity_ratio")]
        public System.Nullable<float> MaximumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.012", CultureInfo.InvariantCulture);
        

        [Description("Node(s) at which the humidity ratio will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}