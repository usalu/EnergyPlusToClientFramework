namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
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
    
    
    [Description("Specifies the geometric rules used to describe the input of surface vertices and " +
        "daylighting reference points.")]
    [JsonObject("GlobalGeometryRules")]
    public class GlobalGeometryRules : BHoMObject, IEnergyPlusClass
    {
        

[Description("Specified as entry for a 4 sided surface/rectangle Surfaces are specified as view" +
    "ed from outside the surface Shading surfaces as viewed from behind. (towards wha" +
    "t they are shading)")]
[JsonProperty("starting_vertex_position")]
public GlobalGeometryRules_StartingVertexPosition StartingVertexPosition { get; set; } = (GlobalGeometryRules_StartingVertexPosition)Enum.Parse(typeof(GlobalGeometryRules_StartingVertexPosition), "LowerLeftCorner");
        

[JsonProperty("vertex_entry_direction")]
public GlobalGeometryRules_VertexEntryDirection VertexEntryDirection { get; set; } = (GlobalGeometryRules_VertexEntryDirection)Enum.Parse(typeof(GlobalGeometryRules_VertexEntryDirection), "Clockwise");
        

[Description("Relative -- coordinates are entered relative to zone origin World -- all coordina" +
    "tes entered are \"absolute\" for this facility")]
[JsonProperty("coordinate_system")]
public GlobalGeometryRules_CoordinateSystem CoordinateSystem { get; set; } = (GlobalGeometryRules_CoordinateSystem)Enum.Parse(typeof(GlobalGeometryRules_CoordinateSystem), "Relative");
        

[Description("Relative -- coordinates are entered relative to zone origin World -- all coordina" +
    "tes entered are \"absolute\" for this facility")]
[JsonProperty("daylighting_reference_point_coordinate_system")]
public GlobalGeometryRules_DaylightingReferencePointCoordinateSystem DaylightingReferencePointCoordinateSystem { get; set; } = (GlobalGeometryRules_DaylightingReferencePointCoordinateSystem)Enum.Parse(typeof(GlobalGeometryRules_DaylightingReferencePointCoordinateSystem), "Relative");
        

[Description("Relative -- Starting corner is entered relative to zone origin World -- Starting " +
    "corner is entered in \"absolute\"")]
[JsonProperty("rectangular_surface_coordinate_system")]
public GlobalGeometryRules_RectangularSurfaceCoordinateSystem RectangularSurfaceCoordinateSystem { get; set; } = (GlobalGeometryRules_RectangularSurfaceCoordinateSystem)Enum.Parse(typeof(GlobalGeometryRules_RectangularSurfaceCoordinateSystem), "Relative");
    }
}
