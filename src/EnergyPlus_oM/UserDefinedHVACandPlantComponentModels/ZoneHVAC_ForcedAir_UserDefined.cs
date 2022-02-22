namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
    using BH.oM.Adapters.EnergyPlus.AirflowNetwork;
    using BH.oM.Adapters.EnergyPlus.Coils;
    using BH.oM.Adapters.EnergyPlus.ComplianceObjects;
    using BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers;
    using BH.oM.Adapters.EnergyPlus.Controllers;
    using BH.oM.Adapters.EnergyPlus.Daylighting;
    using BH.oM.Adapters.EnergyPlus.DemandLimitingControls;
    using BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer;
    using BH.oM.Adapters.EnergyPlus.Economics;
    using BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications;
    using BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS;
    using BH.oM.Adapters.EnergyPlus.EvaporativeCoolers;
    using BH.oM.Adapters.EnergyPlus.ExteriorEquipment;
    using BH.oM.Adapters.EnergyPlus.ExternalInterface;
    using BH.oM.Adapters.EnergyPlus.Fans;
    using BH.oM.Adapters.EnergyPlus.FluidProperties;
    using BH.oM.Adapters.EnergyPlus.GeneralDataEntry;
    using BH.oM.Adapters.EnergyPlus.HeatRecovery;
    using BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers;
    using BH.oM.Adapters.EnergyPlus.HVACDesignObjects;
    using BH.oM.Adapters.EnergyPlus.HVACTemplates;
    using BH.oM.Adapters.EnergyPlus.HybridModel;
    using BH.oM.Adapters.EnergyPlus.InternalGains;
    using BH.oM.Adapters.EnergyPlus.LocationandClimate;
    using BH.oM.Adapters.EnergyPlus.NodeBranchManagement;
    using BH.oM.Adapters.EnergyPlus.NonZoneEquipment;
    using BH.oM.Adapters.EnergyPlus.OperationalFaults;
    using BH.oM.Adapters.EnergyPlus.OutputReporting;
    using BH.oM.Adapters.EnergyPlus.Parametrics;
    using BH.oM.Adapters.EnergyPlus.PerformanceCurves;
    using BH.oM.Adapters.EnergyPlus.PerformanceTables;
    using BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserLoops;
    using BH.oM.Adapters.EnergyPlus.Pumps;
    using BH.oM.Adapters.EnergyPlus.PythonPluginSystem;
    using BH.oM.Adapters.EnergyPlus.Refrigeration;
    using BH.oM.Adapters.EnergyPlus.RoomAirModels;
    using BH.oM.Adapters.EnergyPlus.Schedules;
    using BH.oM.Adapters.EnergyPlus.SetpointManagers;
    using BH.oM.Adapters.EnergyPlus.SimulationParameters;
    using BH.oM.Adapters.EnergyPlus.SolarCollectors;
    using BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements;
    using BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers;
    using BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces;
    using BH.oM.Adapters.EnergyPlus.UnitaryEquipment;
    using BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment;
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Defines a generic zone air unit for custom modeling using Energy Management Syste" +
        "m or External Interface")]
    public class ZoneHVAC_ForcedAir_UserDefined : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("overall_model_simulation_program_calling_manager_name")]
public string OverallModelSimulationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty("model_setup_and_sizing_program_calling_manager_name")]
public string ModelSetupAndSizingProgramCallingManagerName { get; set; } = "";
        

[Description("Air inlet node for the unit must be a zone air exhaust Node.")]
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
        

[JsonProperty("plant_connection_3_inlet_node_name")]
public string PlantConnection3InletNodeName { get; set; } = "";
        

[JsonProperty("plant_connection_3_outlet_node_name")]
public string PlantConnection3OutletNodeName { get; set; } = "";
        

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
