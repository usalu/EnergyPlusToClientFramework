namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
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
    using BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels;
    using BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment;
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Defines a central forced air system.")]
    [JsonObject("AirLoopHVAC")]
    public class AirLoopHVAC : BHoMObject
    {
        

[Description("Enter the name of an AirLoopHVAC:ControllerList object.")]
[JsonProperty("controller_list_name")]
public string ControllerListName { get; set; } = "";
        

[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
[JsonProperty("availability_manager_list_name")]
public string AvailabilityManagerListName { get; set; } = "";
        

[JsonProperty("design_supply_air_flow_rate")]
public string DesignSupplyAirFlowRate { get; set; } = (System.String)"0";
        

[Description("Name of a BranchList containing all the branches in this air loop")]
[JsonProperty("branch_list_name")]
public string BranchListName { get; set; } = "";
        

[Description("Name of a ConnectorList containing all the splitters and mixers in the loop")]
[JsonProperty("connector_list_name")]
public string ConnectorListName { get; set; } = "";
        

[Description(@"Name of inlet node where air enters the supply side of the air loop. If this air loop has a return path, then this node is where return air enters the supply side. If this air loop has no return path, then this node is where outdoor air or other air enters the supply side.")]
[JsonProperty("supply_side_inlet_node_name")]
public string SupplySideInletNodeName { get; set; } = "";
        

[Description("Name of outlet node where return air leaves the demand side and enters the supply" +
    " side. Required if this air loop has a return path. Leave this field blank if th" +
    "ere is no return.")]
[JsonProperty("demand_side_outlet_node_name")]
public string DemandSideOutletNodeName { get; set; } = "";
        

[Description("Name of a Node or NodeList containing the inlet node(s) supplying air to zone equ" +
    "ipment.")]
[JsonProperty("demand_side_inlet_node_names")]
public string DemandSideInletNodeNames { get; set; } = "";
        

[Description("Name of a Node or NodeList containing the outlet node(s) supplying air to the dem" +
    "and side.")]
[JsonProperty("supply_side_outlet_node_names")]
public string SupplySideOutletNodeNames { get; set; } = "";
        

[Description(@"The design return air flow rate as a fraction of supply air flow rate with no exhaust. This can be used to model a pressurized system or set to zero to model a DOAS with no return flow. Use ZoneAirMassFlowConservation to balance zone infiltration and mixing flows.")]
[JsonProperty("design_return_air_flow_fraction_of_supply_air_flow")]
public System.Nullable<float> DesignReturnAirFlowFractionOfSupplyAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}
