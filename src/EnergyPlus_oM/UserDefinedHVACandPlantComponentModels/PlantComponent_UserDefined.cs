using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    [Description("Defines a generic plant component for custom modeling using Energy Management Sys" +
                 "tem or External Interface")]
    [JsonObject("PlantComponent:UserDefined")]
    public class PlantComponent_UserDefined : BHoMObject
    {
        

        [JsonProperty("main_model_program_calling_manager_name")]
        public string MainModelProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("number_of_plant_loop_connections")]
        public System.Nullable<float> NumberOfPlantLoopConnections { get; set; } = null;
        

        [JsonProperty("plant_connection_1_inlet_node_name")]
        public string PlantConnection1InletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_1_outlet_node_name")]
        public string PlantConnection1OutletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_1_loading_mode")]
        public EmptyNoYes PlantConnection1LoadingMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("plant_connection_1_loop_flow_request_mode")]
        public EmptyNoYes PlantConnection1LoopFlowRequestMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("plant_connection_1_initialization_program_calling_manager_name")]
        public string PlantConnection1InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("plant_connection_1_simulation_program_calling_manager_name")]
        public string PlantConnection1SimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("plant_connection_2_inlet_node_name")]
        public string PlantConnection2InletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_2_outlet_node_name")]
        public string PlantConnection2OutletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_2_loading_mode")]
        public EmptyNoYes PlantConnection2LoadingMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("plant_connection_2_loop_flow_request_mode")]
        public EmptyNoYes PlantConnection2LoopFlowRequestMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("plant_connection_2_initialization_program_calling_manager_name")]
        public string PlantConnection2InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("plant_connection_2_simulation_program_calling_manager_name")]
        public string PlantConnection2SimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("plant_connection_3_inlet_node_name")]
        public string PlantConnection3InletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_3_outlet_node_name")]
        public string PlantConnection3OutletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_3_loading_mode")]
        public EmptyNoYes PlantConnection3LoadingMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("plant_connection_3_loop_flow_request_mode")]
        public EmptyNoYes PlantConnection3LoopFlowRequestMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("plant_connection_3_initialization_program_calling_manager_name")]
        public string PlantConnection3InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("plant_connection_3_simulation_program_calling_manager_name")]
        public string PlantConnection3SimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("plant_connection_4_inlet_node_name")]
        public string PlantConnection4InletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_4_outlet_node_name")]
        public string PlantConnection4OutletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_4_loading_mode")]
        public EmptyNoYes PlantConnection4LoadingMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("plant_connection_4_loop_flow_request_mode")]
        public EmptyNoYes PlantConnection4LoopFlowRequestMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("plant_connection_4_initialization_program_calling_manager_name")]
        public string PlantConnection4InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("plant_connection_4_simulation_program_calling_manager_name")]
        public string PlantConnection4SimulationProgramCallingManagerName { get; set; } = "";
        

        [Description("Inlet air used for heat rejection or air source")]
        [JsonProperty("air_connection_inlet_node_name")]
        public string AirConnectionInletNodeName { get; set; } = "";
        

        [Description("Outlet air used for heat rejection or air source")]
        [JsonProperty("air_connection_outlet_node_name")]
        public string AirConnectionOutletNodeName { get; set; } = "";
        

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