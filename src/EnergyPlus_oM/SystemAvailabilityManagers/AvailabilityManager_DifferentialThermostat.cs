using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Overrides fan/pump schedules depending on temperature difference between two node" +
                 "s.")]
    public class AvailabilityManager_DifferentialThermostat : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("hot_node_name")]
        public string HotNodeName { get; set; } = "";
        

        [JsonProperty("cold_node_name")]
        public string ColdNodeName { get; set; } = "";
        

        [JsonProperty("temperature_difference_on_limit")]
        public System.Nullable<float> TemperatureDifferenceOnLimit { get; set; } = null;
        

        [Description("Defaults to Temperature Difference On Limit.")]
        [JsonProperty("temperature_difference_off_limit")]
        public System.Nullable<float> TemperatureDifferenceOffLimit { get; set; } = null;
    }
}