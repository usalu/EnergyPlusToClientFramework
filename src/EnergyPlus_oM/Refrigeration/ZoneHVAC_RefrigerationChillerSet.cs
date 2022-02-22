using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Works in conjunction with one or multiple air chillers, compressor racks, refrigeration systems, or refrigeration secondary system objects to simulate the performance of a group of air chillers cooling a single zone. The chiller set model passes information about the zone conditions to determine the performance of individual chiller coils within the set, thus providing the sensible and latent heat exchange with the zone environment.")]
    [JsonObject("ZoneHVAC:RefrigerationChillerSet")]
    public class ZoneHVAC_RefrigerationChillerSet : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections obje" +
                     "ct.")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Not used - reserved for future use Name of the zone exhaust node (see Node) from " +
                     "which the refrigeration chiller draws its indoor air. This should be one of the " +
                     "zone exhaust nodes for the zone cooled by the chiller set.")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Not used - reserved for future use The name of the node where the chiller coil se" +
                     "nds its outlet air, which must be one of the inlet air nodes for the zone which " +
                     "is being cooled.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("chillers")]
        public string Chillers { get; set; } = "";
    }
}