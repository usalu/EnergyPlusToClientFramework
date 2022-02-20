using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, dual duct, constant volume.")]
    [JsonObject("AirTerminal:DualDuct:ConstantVolume")]
    public class AirTerminal_DualDuct_ConstantVolume : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("The outlet node of the terminal unit. This is also the zone inlet node.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("hot_air_inlet_node_name")]
        public string HotAirInletNodeName { get; set; } = "";
        

        [JsonProperty("cold_air_inlet_node_name")]
        public string ColdAirInletNodeName { get; set; } = "";
        

        [JsonProperty("maximum_air_flow_rate")]
        public string MaximumAirFlowRate { get; set; } = "";
    }
}