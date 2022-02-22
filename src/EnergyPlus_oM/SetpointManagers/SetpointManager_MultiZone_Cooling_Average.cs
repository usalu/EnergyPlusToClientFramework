using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager sets the average supply air temperature based on the coolin" +
                 "g load requirements of all controlled zones in an air loop served by a central a" +
                 "ir-conditioner.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_MultiZone_Cooling_Average : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of an AirLoopHVAC object")]
        [JsonProperty("hvac_air_loop_name")]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty("minimum_setpoint_temperature")]
        public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_setpoint_temperature")]
        public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}