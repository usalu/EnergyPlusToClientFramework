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
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Enter the name of an AirLoopHVAC:ControllerList object.")]
[JsonProperty(PropertyName="controller_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ControllerListName { get; set; } = "";
        

[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
[JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AvailabilityManagerListName { get; set; } = "";
        

[JsonProperty(PropertyName="design_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> DesignSupplyAirFlowRate { get; set; } = (System.Nullable<double>)Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("Name of a BranchList containing all the branches in this air loop")]
[JsonProperty(PropertyName="branch_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string BranchListName { get; set; } = "";
        

[Description("Name of a ConnectorList containing all the splitters and mixers in the loop")]
[JsonProperty(PropertyName="connector_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ConnectorListName { get; set; } = "";
        

[Description(@"Name of inlet node where air enters the supply side of the air loop. If this air loop has a return path, then this node is where return air enters the supply side. If this air loop has no return path, then this node is where outdoor air or other air enters the supply side.")]
[JsonProperty(PropertyName="supply_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplySideInletNodeName { get; set; } = "";
        

[Description("Name of outlet node where return air leaves the demand side and enters the supply" +
    " side. Required if this air loop has a return path. Leave this field blank if th" +
    "ere is no return.")]
[JsonProperty(PropertyName="demand_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string DemandSideOutletNodeName { get; set; } = "";
        

[Description("Name of a Node or NodeList containing the inlet node(s) supplying air to zone equ" +
    "ipment.")]
[JsonProperty(PropertyName="demand_side_inlet_node_names", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string DemandSideInletNodeNames { get; set; } = "";
        

[Description("Name of a Node or NodeList containing the outlet node(s) supplying air to the dem" +
    "and side.")]
[JsonProperty(PropertyName="supply_side_outlet_node_names", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplySideOutletNodeNames { get; set; } = "";
        

[Description(@"The design return air flow rate as a fraction of supply air flow rate with no exhaust. This can be used to model a pressurized system or set to zero to model a DOAS with no return flow. Use ZoneAirMassFlowConservation to balance zone infiltration and mixing flows.")]
[JsonProperty(PropertyName="design_return_air_flow_fraction_of_supply_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> DesignReturnAirFlowFractionOfSupplyAirFlow { get; set; } = (System.Nullable<double>)Double.Parse("1", CultureInfo.InvariantCulture);
    }
    
    [Description("List equipment in simulation order")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_OutdoorAirSystem_EquipmentList : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="component_1_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component1ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="component_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component1Name { get; set; } = "";
        

[JsonProperty(PropertyName="component_2_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component2ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="component_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component2Name { get; set; } = "";
        

[JsonProperty(PropertyName="component_3_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component3ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="component_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component3Name { get; set; } = "";
        

[JsonProperty(PropertyName="component_4_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component4ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="component_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component4Name { get; set; } = "";
        

[JsonProperty(PropertyName="component_5_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component5ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="component_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component5Name { get; set; } = "";
        

[JsonProperty(PropertyName="component_6_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component6ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="component_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component6Name { get; set; } = "";
        

[JsonProperty(PropertyName="component_7_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component7ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="component_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component7Name { get; set; } = "";
        

[JsonProperty(PropertyName="component_8_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component8ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="component_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component8Name { get; set; } = "";
        

[JsonProperty(PropertyName="component_9_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component9ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="component_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Component9Name { get; set; } = "";
    }
    
    [Description(@"Outdoor air subsystem for an AirLoopHVAC. Includes an outdoor air mixing box and optional outdoor air conditioning equipment such as heat recovery, preheat, and precool coils. From the perspective of the primary air loop the outdoor air system is treated as a single component.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_OutdoorAirSystem : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Enter the name of an AirLoopHVAC:ControllerList object or blank if this object is" +
    " used in AirLoopHVAC:DedicatedOutdoorAirSystem.")]
[JsonProperty(PropertyName="controller_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ControllerListName { get; set; } = "";
        

[Description("Enter the name of an AirLoopHVAC:OutdoorAirSystem:EquipmentList object.")]
[JsonProperty(PropertyName="outdoor_air_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string OutdoorAirEquipmentListName { get; set; } = "";
        

[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
[JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AvailabilityManagerListName { get; set; } = "";
    }
    
    [Description("Outdoor air mixer. Node names cannot be duplicated within a single OutdoorAir:Mix" +
        "er object or across all outdoor air mixers.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutdoorAir_Mixer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Name of Mixed Air Node")]
[JsonProperty(PropertyName="mixed_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string MixedAirNodeName { get; set; } = "";
        

[Description("Name of Outdoor Air Stream Node")]
[JsonProperty(PropertyName="outdoor_air_stream_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string OutdoorAirStreamNodeName { get; set; } = "";
        

[Description("Name of Relief Air Stream Node")]
[JsonProperty(PropertyName="relief_air_stream_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ReliefAirStreamNodeName { get; set; } = "";
        

[Description("Name of Return Air Stream Node")]
[JsonProperty(PropertyName="return_air_stream_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ReturnAirStreamNodeName { get; set; } = "";
    }
    
    [Description("Split one air stream into N outlet streams (currently 500 per air loop, but exten" +
        "sible). Node names cannot be duplicated within a single zone splitter (AirLoopHV" +
        "AC:ZoneSplitter) list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_ZoneSplitter : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="nodes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Nodes { get; set; } = "";
    }
    
    [Description("Connects 1 zone inlet air stream, through zone supply plenum, to one or more outl" +
        "ets. Node names cannot be duplicated within a single supply plenum list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_SupplyPlenum : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ZoneNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="nodes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Nodes { get; set; } = "";
    }
    
    [Description("A supply path can only contain AirLoopHVAC:ZoneSplitter and AirLoopHVAC:SupplyPle" +
        "num objects which may be in series or parallel.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_SupplyPath : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="supply_air_path_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplyAirPathInletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="components", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Components { get; set; } = "";
    }
    
    [Description("Mix N inlet air streams into one (currently 500 per air loop, but extensible). No" +
        "de names cannot be duplicated within a single zone mixer (AirLoopHVAC:ZoneMixer)" +
        " list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_ZoneMixer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="nodes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Nodes { get; set; } = "";
    }
    
    [Description("Connects N zone inlet air streams, through zone return plenum, to outlet (current" +
        "ly 500 per air loop) Node names cannot be duplicated within a single plenum list" +
        ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_ReturnPlenum : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ZoneNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="induced_air_outlet_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string InducedAirOutletNodeOrNodelistName { get; set; } = "";
        

[JsonProperty(PropertyName="nodes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Nodes { get; set; } = "";
    }
    
    [Description("A return air path can only contain one AirLoopHVAC:ZoneMixer and one or more AirL" +
        "oopHVAC:ReturnPlenum objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_ReturnPath : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="return_air_path_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ReturnAirPathOutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="components", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Components { get; set; } = "";
    }
    
    [Description("Defines a central forced air system to provide dedicated outdoor air to multiple " +
        "AirLoopHVACs.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_DedicatedOutdoorAirSystem : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Enter the name of an AirLoopHVAC:OutdoorAirSystem object.")]
[JsonProperty(PropertyName="airloophvac_outdoorairsystem_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirloophvacOutdoorairsystemName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Name of AirLoopHVAC:Mixer.")]
[JsonProperty(PropertyName="airloophvac_mixer_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirloophvacMixerName { get; set; } = "";
        

[Description("Name of AirLoopHVAC:Splitter.")]
[JsonProperty(PropertyName="airloophvac_splitter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirloophvacSplitterName { get; set; } = "";
        

[JsonProperty(PropertyName="preheat_design_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> PreheatDesignTemperature { get; set; } = null;
        

[JsonProperty(PropertyName="preheat_design_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> PreheatDesignHumidityRatio { get; set; } = null;
        

[JsonProperty(PropertyName="precool_design_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> PrecoolDesignTemperature { get; set; } = null;
        

[JsonProperty(PropertyName="precool_design_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> PrecoolDesignHumidityRatio { get; set; } = null;
        

[Description("Enter the number of the AirLoopHAVC served by AirLoopHVAC:DedicatedOutdoorAirSyst" +
    "em")]
[JsonProperty(PropertyName="number_of_airloophvac", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NumberOfAirloophvac { get; set; } = null;
        

[JsonProperty(PropertyName="airloophvacs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Airloophvacs { get; set; } = "";
    }
    
    [Description(@"Mix N inlet air streams from Relief Air Stream Node in OutdoorAir:Mixer objects served by AirLoopHVAC objects listed in AirLoopHVAC:DedicatedOutdoorAirSystem into one (currently 10 as default, but extensible). Node names cannot be duplicated within a single mixer list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_Mixer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="nodes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Nodes { get; set; } = "";
    }
    
    [Description(@"Split one air stream from AirLoopHVAC:DedicatedOutdoorAirSystem outlet node into N outlet streams (currently 10 as default, but extensible). Node names should be Outdoor Air Stream Node Name in OutdoorAir:Mixer objects served by AirLoopHVAC objects listed in AirLoopHVAC:DedicatedOutdoorAirSystem.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_Splitter : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="nodes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Nodes { get; set; } = "";
    }
}
