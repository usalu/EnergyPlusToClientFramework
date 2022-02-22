using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    [Description("Defines a generic single duct air terminal unit for custom modeling using Energy " +
                 "Management System or External Interface")]
    [JsonObject("AirTerminal:SingleDuct:UserDefined")]
    public class AirTerminal_SingleDuct_UserDefined : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("overall_model_simulation_program_calling_manager_name")]
        public string OverallModelSimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("model_setup_and_sizing_program_calling_manager_name")]
        public string ModelSetupAndSizingProgramCallingManagerName { get; set; } = "";
        

        [Description("Air inlet node for the unit must be a zone splitter outlet.")]
        [JsonProperty("primary_air_inlet_node_name")]
        public string PrimaryAirInletNodeName { get; set; } = "";
        

        [Description("Air outlet node for the unit must be a zone air inlet node.")]
        [JsonProperty("primary_air_outlet_node_name")]
        public string PrimaryAirOutletNodeName { get; set; } = "";
        

        [Description("Inlet air used for heat rejection or air source")]
        [JsonProperty("secondary_air_inlet_node_name")]
        public string SecondaryAirInletNodeName { get; set; } = "";
        

        [Description("Outlet air used for heat rejection or air source")]
        [JsonProperty("secondary_air_outlet_node_name")]
        public string SecondaryAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("number_of_plant_loop_connections")]
        public System.Nullable<float> NumberOfPlantLoopConnections { get; set; } = null;
        

        [JsonProperty("plant_connection_1_inlet_node_name")]
        public string PlantConnection1InletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_1_outlet_node_name")]
        public string PlantConnection1OutletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_2_inlet_node_name")]
        public string PlantConnection2InletNodeName { get; set; } = "";
        

        [JsonProperty("plant_connection_2_outlet_node_name")]
        public string PlantConnection2OutletNodeName { get; set; } = "";
        

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