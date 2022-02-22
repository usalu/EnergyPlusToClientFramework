using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"New general DX cooling coil supporting on or more speeds and one or or operating  modes. Includes DX evaporator coil, compressor, and condenser. Object is currently only supported by the AIRLOOPHVAC:UNITARYSYSTEM object. Remaining Coil:Cooling:DX* objects will be deprecated at a future date, after which, this object will replace all other Coil:Cooling:DX* objects.")]
    public class Coil_Cooling_DX : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("evaporator_inlet_node_name")]
        public string EvaporatorInletNodeName { get; set; } = "";
        

        [JsonProperty("evaporator_outlet_node_name")]
        public string EvaporatorOutletNodeName { get; set; } = "";
        

        [Description("Schedule value > 0 means the coil is available. If this field is blank, the coil " +
                     "is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (condenser) of a DX system or heat pump is to be placed. This is an optional input field specified only when the user desires to reject the condenser heat into a zone. The heat rejected is modeled as internal sensible heat gain of the zone.")]
        [JsonProperty("condenser_zone_name")]
        public string CondenserZoneName { get; set; } = "";
        

        [Description("This is the name of an air node in the simulation. This may be an explicitly defi" +
                     "ned outdoor air node, or it may be a separate air node.")]
        [JsonProperty("condenser_inlet_node_name")]
        public string CondenserInletNodeName { get; set; } = "";
        

        [Description("This is the name of an air node in the simulation.")]
        [JsonProperty("condenser_outlet_node_name")]
        public string CondenserOutletNodeName { get; set; } = "";
        

        [JsonProperty("performance_object_name")]
        public string PerformanceObjectName { get; set; } = "";
        

        [JsonProperty("condensate_collection_water_storage_tank_name")]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

        [JsonProperty("evaporative_condenser_supply_water_storage_tank_name")]
        public string EvaporativeCondenserSupplyWaterStorageTankName { get; set; } = "";
    }
}