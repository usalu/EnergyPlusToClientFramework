using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    [Description("Defines a generic air system component for custom modeling using Energy Managemen" +
                 "t System or External Interface")]
    [JsonObject("Coil:UserDefined")]
    public class Coil_UserDefined : BHoMObject
    {
        

        [JsonProperty("overall_model_simulation_program_calling_manager_name")]
        public string OverallModelSimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("model_setup_and_sizing_program_calling_manager_name")]
        public string ModelSetupAndSizingProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("number_of_air_connections")]
        public System.Nullable<float> NumberOfAirConnections { get; set; } = null;
        

        [Description("Inlet air for primary air stream")]
        [JsonProperty("air_connection_1_inlet_node_name")]
        public string AirConnection1InletNodeName { get; set; } = "";
        

        [Description("Outlet air for primary air stream")]
        [JsonProperty("air_connection_1_outlet_node_name")]
        public string AirConnection1OutletNodeName { get; set; } = "";
        

        [Description("Inlet air for secondary air stream")]
        [JsonProperty("air_connection_2_inlet_node_name")]
        public string AirConnection2InletNodeName { get; set; } = "";
        

        [Description("Outlet air for secondary air stream")]
        [JsonProperty("air_connection_2_outlet_node_name")]
        public string AirConnection2OutletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_is_used")]
        public EmptyNoYes PlantConnectionIsUsed { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("plant_connection_inlet_node_name")]
        public string PlantConnectionInletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_outlet_node_name")]
        public string PlantConnectionOutletNodeName { get; set; } = "";
        

        [Description("Water use storage tank for alternate source of water consumed by device")]
        [JsonProperty("supply_inlet_water_storage_tank_name")]
        public string SupplyInletWaterStorageTankName { get; set; } = "";
        

        [Description("Water use storage tank for collection of condensate by device")]
        [JsonProperty("collection_outlet_water_storage_tank_name")]
        public string CollectionOutletWaterStorageTankName { get; set; } = "";
        

        [Description("Used for modeling device losses to surrounding zone")]
        [JsonProperty("ambient_zone_name")]
        public string AmbientZoneName { get; set; } = "";
    }
}