using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Overrides fan/pump schedules depending on temperature at sensor node.")]
    public class AvailabilityManager_HighTemperatureTurnOff : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("sensor_node_name")]
        public string SensorNodeName { get; set; } = "";
        

        [JsonProperty("temperature")]
        public System.Nullable<float> Temperature { get; set; } = null;
    }
}