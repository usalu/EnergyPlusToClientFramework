using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager sets both the supply air temperature and the supply air flo" +
                 "w rate.")]
    [JsonObject("SetpointManager:WarmestTemperatureFlow")]
    public class SetpointManager_WarmestTemperatureFlow : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_variable")]
        public SetpointManager_WarmestTemperatureFlow_ControlVariable ControlVariable { get; set; } = (SetpointManager_WarmestTemperatureFlow_ControlVariable)Enum.Parse(typeof(SetpointManager_WarmestTemperatureFlow_ControlVariable), "Temperature");
        

        [Description("Enter the name of an AirLoopHVAC object.")]
        [JsonProperty("hvac_air_loop_name")]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty("minimum_setpoint_temperature")]
        public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_setpoint_temperature")]
        public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [Description(@"For TemperatureFirst the manager tries to find the highest setpoint temperature that will satisfy all the zone cooling loads at minimum supply air flow rate. If this setpoint temperature is less than the minimum, the setpoint temperature is set to the minimum, and the supply air flow rate is increased to meet the loads. For FlowFirst the manager tries to find the lowest supply air flow rate that will satisfy all the zone cooling loads at the maximum setpoint temperature. If this flow is greater than the maximum, the flow is set to the maximum and the setpoint temperature is reduced to satisfy the cooling loads.")]
        [JsonProperty("strategy")]
        public SetpointManager_WarmestTemperatureFlow_Strategy Strategy { get; set; } = (SetpointManager_WarmestTemperatureFlow_Strategy)Enum.Parse(typeof(SetpointManager_WarmestTemperatureFlow_Strategy), "TemperatureFirst");
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
        

        [Description("Fraction of the maximum supply air flow rate. Used to define the minimum supply f" +
                     "low for the TemperatureFirst strategy.")]
        [JsonProperty("minimum_turndown_ratio")]
        public System.Nullable<float> MinimumTurndownRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
}