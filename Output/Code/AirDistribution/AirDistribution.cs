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
    public class AirLoopHVAC : BHoMObject, IEnergyPlusClass
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
    
    [Description("List equipment in simulation order")]
    [JsonObject("AirLoopHVAC:OutdoorAirSystem:EquipmentList")]
    public class AirLoopHVAC_OutdoorAirSystem_EquipmentList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("component_1_object_type")]
public string Component1ObjectType { get; set; } = "";
        

[JsonProperty("component_1_name")]
public string Component1Name { get; set; } = "";
        

[JsonProperty("component_2_object_type")]
public string Component2ObjectType { get; set; } = "";
        

[JsonProperty("component_2_name")]
public string Component2Name { get; set; } = "";
        

[JsonProperty("component_3_object_type")]
public string Component3ObjectType { get; set; } = "";
        

[JsonProperty("component_3_name")]
public string Component3Name { get; set; } = "";
        

[JsonProperty("component_4_object_type")]
public string Component4ObjectType { get; set; } = "";
        

[JsonProperty("component_4_name")]
public string Component4Name { get; set; } = "";
        

[JsonProperty("component_5_object_type")]
public string Component5ObjectType { get; set; } = "";
        

[JsonProperty("component_5_name")]
public string Component5Name { get; set; } = "";
        

[JsonProperty("component_6_object_type")]
public string Component6ObjectType { get; set; } = "";
        

[JsonProperty("component_6_name")]
public string Component6Name { get; set; } = "";
        

[JsonProperty("component_7_object_type")]
public string Component7ObjectType { get; set; } = "";
        

[JsonProperty("component_7_name")]
public string Component7Name { get; set; } = "";
        

[JsonProperty("component_8_object_type")]
public string Component8ObjectType { get; set; } = "";
        

[JsonProperty("component_8_name")]
public string Component8Name { get; set; } = "";
        

[JsonProperty("component_9_object_type")]
public string Component9ObjectType { get; set; } = "";
        

[JsonProperty("component_9_name")]
public string Component9Name { get; set; } = "";
    }
    
    [Description(@"Outdoor air subsystem for an AirLoopHVAC. Includes an outdoor air mixing box and optional outdoor air conditioning equipment such as heat recovery, preheat, and precool coils. From the perspective of the primary air loop the outdoor air system is treated as a single component.")]
    [JsonObject("AirLoopHVAC:OutdoorAirSystem")]
    public class AirLoopHVAC_OutdoorAirSystem : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an AirLoopHVAC:ControllerList object or blank if this object is" +
    " used in AirLoopHVAC:DedicatedOutdoorAirSystem.")]
[JsonProperty("controller_list_name")]
public string ControllerListName { get; set; } = "";
        

[Description("Enter the name of an AirLoopHVAC:OutdoorAirSystem:EquipmentList object.")]
[JsonProperty("outdoor_air_equipment_list_name")]
public string OutdoorAirEquipmentListName { get; set; } = "";
        

[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
[JsonProperty("availability_manager_list_name")]
public string AvailabilityManagerListName { get; set; } = "";
    }
    
    [Description("Outdoor air mixer. Node names cannot be duplicated within a single OutdoorAir:Mix" +
        "er object or across all outdoor air mixers.")]
    [JsonObject("OutdoorAir:Mixer")]
    public class OutdoorAir_Mixer : BHoMObject, IEnergyPlusClass
    {
        

[Description("Name of Mixed Air Node")]
[JsonProperty("mixed_air_node_name")]
public string MixedAirNodeName { get; set; } = "";
        

[Description("Name of Outdoor Air Stream Node")]
[JsonProperty("outdoor_air_stream_node_name")]
public string OutdoorAirStreamNodeName { get; set; } = "";
        

[Description("Name of Relief Air Stream Node")]
[JsonProperty("relief_air_stream_node_name")]
public string ReliefAirStreamNodeName { get; set; } = "";
        

[Description("Name of Return Air Stream Node")]
[JsonProperty("return_air_stream_node_name")]
public string ReturnAirStreamNodeName { get; set; } = "";
    }
    
    [Description("Split one air stream into N outlet streams (currently 500 per air loop, but exten" +
        "sible). Node names cannot be duplicated within a single zone splitter (AirLoopHV" +
        "AC:ZoneSplitter) list.")]
    [JsonObject("AirLoopHVAC:ZoneSplitter")]
    public class AirLoopHVAC_ZoneSplitter : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("nodes")]
public string Nodes { get; set; } = "";
    }
    
    [Description("Connects 1 zone inlet air stream, through zone supply plenum, to one or more outl" +
        "ets. Node names cannot be duplicated within a single supply plenum list.")]
    [JsonObject("AirLoopHVAC:SupplyPlenum")]
    public class AirLoopHVAC_SupplyPlenum : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("zone_node_name")]
public string ZoneNodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("nodes")]
public string Nodes { get; set; } = "";
    }
    
    [Description("A supply path can only contain AirLoopHVAC:ZoneSplitter and AirLoopHVAC:SupplyPle" +
        "num objects which may be in series or parallel.")]
    [JsonObject("AirLoopHVAC:SupplyPath")]
    public class AirLoopHVAC_SupplyPath : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("supply_air_path_inlet_node_name")]
public string SupplyAirPathInletNodeName { get; set; } = "";
        

[JsonProperty("components")]
public string Components { get; set; } = "";
    }
    
    [Description("Mix N inlet air streams into one (currently 500 per air loop, but extensible). No" +
        "de names cannot be duplicated within a single zone mixer (AirLoopHVAC:ZoneMixer)" +
        " list.")]
    [JsonObject("AirLoopHVAC:ZoneMixer")]
    public class AirLoopHVAC_ZoneMixer : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("nodes")]
public string Nodes { get; set; } = "";
    }
    
    [Description("Connects N zone inlet air streams, through zone return plenum, to outlet (current" +
        "ly 500 per air loop) Node names cannot be duplicated within a single plenum list" +
        ".")]
    [JsonObject("AirLoopHVAC:ReturnPlenum")]
    public class AirLoopHVAC_ReturnPlenum : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("zone_node_name")]
public string ZoneNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("induced_air_outlet_node_or_nodelist_name")]
public string InducedAirOutletNodeOrNodelistName { get; set; } = "";
        

[JsonProperty("nodes")]
public string Nodes { get; set; } = "";
    }
    
    [Description("A return air path can only contain one AirLoopHVAC:ZoneMixer and one or more AirL" +
        "oopHVAC:ReturnPlenum objects.")]
    [JsonObject("AirLoopHVAC:ReturnPath")]
    public class AirLoopHVAC_ReturnPath : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("return_air_path_outlet_node_name")]
public string ReturnAirPathOutletNodeName { get; set; } = "";
        

[JsonProperty("components")]
public string Components { get; set; } = "";
    }
    
    [Description("Defines a central forced air system to provide dedicated outdoor air to multiple " +
        "AirLoopHVACs.")]
    [JsonObject("AirLoopHVAC:DedicatedOutdoorAirSystem")]
    public class AirLoopHVAC_DedicatedOutdoorAirSystem : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an AirLoopHVAC:OutdoorAirSystem object.")]
[JsonProperty("airloophvac_outdoorairsystem_name")]
public string AirloophvacOutdoorairsystemName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Name of AirLoopHVAC:Mixer.")]
[JsonProperty("airloophvac_mixer_name")]
public string AirloophvacMixerName { get; set; } = "";
        

[Description("Name of AirLoopHVAC:Splitter.")]
[JsonProperty("airloophvac_splitter_name")]
public string AirloophvacSplitterName { get; set; } = "";
        

[JsonProperty("preheat_design_temperature")]
public System.Nullable<float> PreheatDesignTemperature { get; set; } = null;
        

[JsonProperty("preheat_design_humidity_ratio")]
public System.Nullable<float> PreheatDesignHumidityRatio { get; set; } = null;
        

[JsonProperty("precool_design_temperature")]
public System.Nullable<float> PrecoolDesignTemperature { get; set; } = null;
        

[JsonProperty("precool_design_humidity_ratio")]
public System.Nullable<float> PrecoolDesignHumidityRatio { get; set; } = null;
        

[Description("Enter the number of the AirLoopHAVC served by AirLoopHVAC:DedicatedOutdoorAirSyst" +
    "em")]
[JsonProperty("number_of_airloophvac")]
public System.Nullable<float> NumberOfAirloophvac { get; set; } = null;
        

[JsonProperty("airloophvacs")]
public string Airloophvacs { get; set; } = "";
    }
    
    [Description(@"Mix N inlet air streams from Relief Air Stream Node in OutdoorAir:Mixer objects served by AirLoopHVAC objects listed in AirLoopHVAC:DedicatedOutdoorAirSystem into one (currently 10 as default, but extensible). Node names cannot be duplicated within a single mixer list.")]
    [JsonObject("AirLoopHVAC:Mixer")]
    public class AirLoopHVAC_Mixer : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("nodes")]
public string Nodes { get; set; } = "";
    }
    
    [Description(@"Split one air stream from AirLoopHVAC:DedicatedOutdoorAirSystem outlet node into N outlet streams (currently 10 as default, but extensible). Node names should be Outdoor Air Stream Node Name in OutdoorAir:Mixer objects served by AirLoopHVAC objects listed in AirLoopHVAC:DedicatedOutdoorAirSystem.")]
    [JsonObject("AirLoopHVAC:Splitter")]
    public class AirLoopHVAC_Splitter : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("nodes")]
public string Nodes { get; set; } = "";
    }
}
