using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Overrides fan/pump schedules depending on temperature at sensor node.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AvailabilityManager_LowTemperatureTurnOff : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("sensor_node_name")]
        public string SensorNodeName { get; set; } = "";
        

        [JsonProperty("temperature")]
        public System.Nullable<float> Temperature { get; set; } = null;
        

        [Description("If blank, defaults to always active")]
        [JsonProperty("applicability_schedule_name")]
        public string ApplicabilityScheduleName { get; set; } = "";
    }
}