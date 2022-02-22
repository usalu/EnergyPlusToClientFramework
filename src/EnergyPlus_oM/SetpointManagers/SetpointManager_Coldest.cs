using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This SetpointManager is used in dual duct systems to reset the setpoint temperatu" +
                 "re of the air in the heating supply duct. Usually it is used in conjunction with" +
                 " a SetpointManager:Warmest resetting the temperature of the air in the cooling s" +
                 "upply duct.")]
    [JsonObject("SetpointManager:Coldest")]
    public class SetpointManager_Coldest : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_variable")]
        public SetpointManager_Coldest_ControlVariable ControlVariable { get; set; } = (SetpointManager_Coldest_ControlVariable)Enum.Parse(typeof(SetpointManager_Coldest_ControlVariable), "Temperature");
        

        [Description("Enter the name of an AirLoopHVAC object.")]
        [JsonProperty("hvac_air_loop_name")]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty("minimum_setpoint_temperature")]
        public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_setpoint_temperature")]
        public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty("strategy")]
        public SetpointManager_Coldest_Strategy Strategy { get; set; } = (SetpointManager_Coldest_Strategy)Enum.Parse(typeof(SetpointManager_Coldest_Strategy), "MinimumTemperature");
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}