namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
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
    public class GlobalGeometryRules : BHoMObject, IEnergyPlusClass
    {
        

[Description("Specified as entry for a 4 sided surface/rectangle Surfaces are specified as view" +
    "ed from outside the surface Shading surfaces as viewed from behind. (towards wha" +
    "t they are shading)")]
[JsonProperty("starting_vertex_position")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GlobalGeometryRules_StartingVertexPosition StartingVertexPosition { get; set; } = (GlobalGeometryRules_StartingVertexPosition)Enum.Parse(typeof(GlobalGeometryRules_StartingVertexPosition), "LowerLeftCorner");
        

[JsonProperty("vertex_entry_direction")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GlobalGeometryRules_VertexEntryDirection VertexEntryDirection { get; set; } = (GlobalGeometryRules_VertexEntryDirection)Enum.Parse(typeof(GlobalGeometryRules_VertexEntryDirection), "Clockwise");
        

[Description("Relative -- coordinates are entered relative to zone origin World -- all coordina" +
    "tes entered are \"absolute\" for this facility")]
[JsonProperty("coordinate_system")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GlobalGeometryRules_CoordinateSystem CoordinateSystem { get; set; } = (GlobalGeometryRules_CoordinateSystem)Enum.Parse(typeof(GlobalGeometryRules_CoordinateSystem), "Relative");
        

[Description("Relative -- coordinates are entered relative to zone origin World -- all coordina" +
    "tes entered are \"absolute\" for this facility")]
[JsonProperty("daylighting_reference_point_coordinate_system")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GlobalGeometryRules_DaylightingReferencePointCoordinateSystem DaylightingReferencePointCoordinateSystem { get; set; } = (GlobalGeometryRules_DaylightingReferencePointCoordinateSystem)Enum.Parse(typeof(GlobalGeometryRules_DaylightingReferencePointCoordinateSystem), "Relative");
        

[Description("Relative -- Starting corner is entered relative to zone origin World -- Starting " +
    "corner is entered in \"absolute\"")]
[JsonProperty("rectangular_surface_coordinate_system")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GlobalGeometryRules_RectangularSurfaceCoordinateSystem RectangularSurfaceCoordinateSystem { get; set; } = (GlobalGeometryRules_RectangularSurfaceCoordinateSystem)Enum.Parse(typeof(GlobalGeometryRules_RectangularSurfaceCoordinateSystem), "Relative");
    }
    
    public enum GlobalGeometryRules_StartingVertexPosition
    {
        
        [System.Runtime.Serialization.EnumMember(Value="LowerLeftCorner")]
        LowerLeftCorner = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LowerRightCorner")]
        LowerRightCorner = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UpperLeftCorner")]
        UpperLeftCorner = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="UpperRightCorner")]
        UpperRightCorner = 3,
    }
    
    public enum GlobalGeometryRules_VertexEntryDirection
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Clockwise")]
        Clockwise = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Counterclockwise")]
        Counterclockwise = 1,
    }
    
    public enum GlobalGeometryRules_CoordinateSystem
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Relative")]
        Relative = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="World")]
        World = 1,
    }
    
    public enum GlobalGeometryRules_DaylightingReferencePointCoordinateSystem
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Relative")]
        Relative = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="World")]
        World = 2,
    }
    
    public enum GlobalGeometryRules_RectangularSurfaceCoordinateSystem
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Relative")]
        Relative = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="World")]
        World = 2,
    }
    
    [Description("Provides a simple method of altering the footprint geometry of a model. The inten" +
        "t is to provide a single parameter that can be used to reshape the building desc" +
        "ription contained in the rest of the input file.")]
    public class GeometryTransform : BHoMObject, IEnergyPlusClass
    {
        

[Description("only current allowed value is \"XY\"")]
[JsonProperty("plane_of_transform")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GeometryTransform_PlaneOfTransform PlaneOfTransform { get; set; } = (GeometryTransform_PlaneOfTransform)Enum.Parse(typeof(GeometryTransform_PlaneOfTransform), "XY");
        

[Description("Aspect ratio of building as described in idf")]
[JsonProperty("current_aspect_ratio")]
public System.Nullable<float> CurrentAspectRatio { get; set; } = null;
        

[Description("Aspect ratio to transform to during run")]
[JsonProperty("new_aspect_ratio")]
public System.Nullable<float> NewAspectRatio { get; set; } = null;
    }
    
    public enum GeometryTransform_PlaneOfTransform
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="XY")]
        XY = 1,
    }
    
    [Description("Defines a thermal zone of the building.")]
    public class Zone : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("direction_of_relative_north")]
public System.Nullable<float> DirectionOfRelativeNorth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("x_origin")]
public System.Nullable<float> XOrigin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("y_origin")]
public System.Nullable<float> YOrigin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("z_origin")]
public System.Nullable<float> ZOrigin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("type")]
public System.Nullable<float> Type { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("multiplier")]
public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"If this field is 0.0, negative or autocalculate, then the average height of the zone is automatically calculated and used in subsequent calculations. If this field is positive, then the number entered here will be used. Note that the Zone Ceiling Height is the distance from the Floor to the Ceiling in the Zone, not an absolute height from the ground.")]
[JsonProperty("ceiling_height")]
public string CeilingHeight { get; set; } = (System.String)"Autocalculate";
        

[Description("If this field is 0.0, negative or autocalculate, then the volume of the zone is a" +
    "utomatically calculated and used in subsequent calculations. If this field is po" +
    "sitive, then the number entered here will be used.")]
[JsonProperty("volume")]
public string Volume { get; set; } = (System.String)"Autocalculate";
        

[Description("If this field is 0.0, negative or autocalculate, then the floor area of the zone " +
    "is automatically calculated and used in subsequent calculations. If this field i" +
    "s positive, then the number entered here will be used.")]
[JsonProperty("floor_area")]
public string FloorArea { get; set; } = (System.String)"Autocalculate";
        

[Description(@"Will default to same value as SurfaceConvectionAlgorithm:Inside object setting this field overrides the default SurfaceConvectionAlgorithm:Inside for this zone Simple = constant natural convection (ASHRAE) TARP = variable natural convection based on temperature difference (ASHRAE) CeilingDiffuser = ACH based forced and mixed convection correlations for ceiling diffuser configuration with simple natural convection limit AdaptiveConvectionAlgorithm = dynamic selection of convection models based on conditions TrombeWall = variable natural convection in an enclosed rectangular cavity ASTMC1340 = mixed convection correlations specified for attic zone")]
[JsonProperty("zone_inside_convection_algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Zone_ZoneInsideConvectionAlgorithm ZoneInsideConvectionAlgorithm { get; set; } = (Zone_ZoneInsideConvectionAlgorithm)Enum.Parse(typeof(Zone_ZoneInsideConvectionAlgorithm), "Empty");
        

[Description(@"Will default to same value as SurfaceConvectionAlgorithm:Outside object setting this field overrides the default SurfaceConvectionAlgorithm:Outside for this zone SimpleCombined = Combined radiation and convection coefficient using simple ASHRAE model TARP = correlation from models developed by ASHRAE, Walton, and Sparrow et. al. MoWiTT = correlation from measurements by Klems and Yazdanian for smooth surfaces DOE-2 = correlation from measurements by Klems and Yazdanian for rough surfaces AdaptiveConvectionAlgorithm = dynamic selection of correlations based on conditions")]
[JsonProperty("zone_outside_convection_algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Zone_ZoneOutsideConvectionAlgorithm ZoneOutsideConvectionAlgorithm { get; set; } = (Zone_ZoneOutsideConvectionAlgorithm)Enum.Parse(typeof(Zone_ZoneOutsideConvectionAlgorithm), "Empty");
        

[JsonProperty("part_of_total_floor_area")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes PartOfTotalFloorArea { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
    
    public enum Zone_ZoneInsideConvectionAlgorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASTMC1340")]
        ASTMC1340 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CeilingDiffuser")]
        CeilingDiffuser = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Simple")]
        Simple = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="TARP")]
        TARP = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="TrombeWall")]
        TrombeWall = 6,
    }
    
    public enum Zone_ZoneOutsideConvectionAlgorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DOE-2")]
        DOE2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MoWiTT")]
        MoWiTT = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleCombined")]
        SimpleCombined = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="TARP")]
        TARP = 5,
    }
    
    [Description(@"Defines a list of thermal zones which can be referenced as a group. The ZoneList name may be used elsewhere in the input to apply a parameter to all zones in the list. ZoneLists can be used effectively with the following objects: People, Lights, ElectricEquipment, GasEquipment, HotWaterEquipment, ZoneInfiltration:DesignFlowRate, ZoneVentilation:DesignFlowRate, Sizing:Zone, ZoneControl:Thermostat, and others.")]
    public class ZoneList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("zones")]
public string Zones { get; set; } = "";
    }
    
    [Description("Adds a multiplier to a ZoneList. This can be used to reduce the amount of input n" +
        "ecessary for simulating repetitive structures, such as the identical floors of a" +
        " multi-story building.")]
    public class ZoneGroup : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("zone_list_name")]
public string ZoneListName { get; set; } = "";
        

[JsonProperty("zone_list_multiplier")]
public System.Nullable<float> ZoneListMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    [Description("Allows for detailed entry of building heat transfer surfaces. Does not include su" +
        "bsurfaces such as windows or doors.")]
    public class BuildingSurface_Detailed : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public BuildingSurface_Detailed_SurfaceType SurfaceType { get; set; } = (BuildingSurface_Detailed_SurfaceType)Enum.Parse(typeof(BuildingSurface_Detailed_SurfaceType), "Ceiling");
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("outside_boundary_condition")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public BuildingSurface_Detailed_OutsideBoundaryCondition OutsideBoundaryCondition { get; set; } = (BuildingSurface_Detailed_OutsideBoundaryCondition)Enum.Parse(typeof(BuildingSurface_Detailed_OutsideBoundaryCondition), "Adiabatic");
        

[Description(@"Non-blank only if the field Outside Boundary Condition is Surface, Zone, OtherSideCoefficients or OtherSideConditionsModel If Surface, specify name of corresponding surface in adjacent zone or specify current surface name for internal partition separating like zones If Zone, specify the name of the corresponding zone and the program will generate the corresponding interzone surface If Foundation, specify the name of the corresponding Foundation object and the program will calculate the heat transfer appropriately If OtherSideCoefficients, specify name of SurfaceProperty:OtherSideCoefficients If OtherSideConditionsModel, specify name of SurfaceProperty:OtherSideConditionsModel")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[JsonProperty("sun_exposure")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public BuildingSurface_Detailed_SunExposure SunExposure { get; set; } = (BuildingSurface_Detailed_SunExposure)Enum.Parse(typeof(BuildingSurface_Detailed_SunExposure), "SunExposed");
        

[JsonProperty("wind_exposure")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public BuildingSurface_Detailed_WindExposure WindExposure { get; set; } = (BuildingSurface_Detailed_WindExposure)Enum.Parse(typeof(BuildingSurface_Detailed_WindExposure), "WindExposed");
        

[Description(@"From the exterior of the surface Unused if one uses the ""reflections"" options in Solar Distribution in Building input unless a DaylightingDevice:Shelf or DaylightingDevice:Tubular object has been specified. autocalculate will automatically calculate this value from the tilt of the surface")]
[JsonProperty("view_factor_to_ground")]
public string ViewFactorToGround { get; set; } = (System.String)"Autocalculate";
        

[Description(@"shown with 120 vertex coordinates -- extensible object ""extensible"" -- duplicate last set of x,y,z coordinates (last 3 fields), remembering to remove ; from ""inner"" fields. for clarity in any error messages, renumber the fields as well. (and changing z terminator to a comma "","" for all but last one which needs a semi-colon "";"") vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. If world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
[JsonProperty("number_of_vertices")]
public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("vertices")]
public string Vertices { get; set; } = "";
    }
    
    public enum BuildingSurface_Detailed_SurfaceType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Ceiling")]
        Ceiling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Floor")]
        Floor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Roof")]
        Roof = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Wall")]
        Wall = 3,
    }
    
    public enum BuildingSurface_Detailed_OutsideBoundaryCondition
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Adiabatic")]
        Adiabatic = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Foundation")]
        Foundation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Ground")]
        Ground = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageFloor")]
        GroundBasementPreprocessorAverageFloor = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageWall")]
        GroundBasementPreprocessorAverageWall = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorLowerWall")]
        GroundBasementPreprocessorLowerWall = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorUpperWall")]
        GroundBasementPreprocessorUpperWall = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundFCfactorMethod")]
        GroundFCfactorMethod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorAverage")]
        GroundSlabPreprocessorAverage = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorCore")]
        GroundSlabPreprocessorCore = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorPerimeter")]
        GroundSlabPreprocessorPerimeter = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideCoefficients")]
        OtherSideCoefficients = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideConditionsModel")]
        OtherSideConditionsModel = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Surface")]
        Surface = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 15,
    }
    
    public enum BuildingSurface_Detailed_SunExposure
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NoSun")]
        NoSun = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SunExposed")]
        SunExposed = 2,
    }
    
    public enum BuildingSurface_Detailed_WindExposure
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NoWind")]
        NoWind = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="WindExposed")]
        WindExposed = 2,
    }
    
    [Description("Allows for detailed entry of wall heat transfer surfaces.")]
    public class Wall_Detailed : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("outside_boundary_condition")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Wall_Detailed_OutsideBoundaryCondition OutsideBoundaryCondition { get; set; } = (Wall_Detailed_OutsideBoundaryCondition)Enum.Parse(typeof(Wall_Detailed_OutsideBoundaryCondition), "Adiabatic");
        

[Description(@"Non-blank only if the field Outside Boundary Condition is Surface, Zone, OtherSideCoefficients or OtherSideConditionsModel If Surface, specify name of corresponding surface in adjacent zone or specify current surface name for internal partition separating like zones If Zone, specify the name of the corresponding zone and the program will generate the corresponding interzone surface If Foundation, specify the name of the corresponding Foundation object and If OtherSideCoefficients, specify name of SurfaceProperty:OtherSideCoefficients If OtherSideConditionsModel, specify name of SurfaceProperty:OtherSideConditionsModel")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[JsonProperty("sun_exposure")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Wall_Detailed_SunExposure SunExposure { get; set; } = (Wall_Detailed_SunExposure)Enum.Parse(typeof(Wall_Detailed_SunExposure), "SunExposed");
        

[JsonProperty("wind_exposure")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Wall_Detailed_WindExposure WindExposure { get; set; } = (Wall_Detailed_WindExposure)Enum.Parse(typeof(Wall_Detailed_WindExposure), "WindExposed");
        

[Description(@"From the exterior of the surface Unused if one uses the ""reflections"" options in Solar Distribution in Building input unless a DaylightingDevice:Shelf or DaylightingDevice:Tubular object has been specified. autocalculate will automatically calculate this value from the tilt of the surface")]
[JsonProperty("view_factor_to_ground")]
public string ViewFactorToGround { get; set; } = (System.String)"Autocalculate";
        

[Description(@"shown with 10 vertex coordinates -- extensible object ""extensible"" -- duplicate last set of x,y,z coordinates, renumbering please (and changing z terminator to a comma "","" for all but last one which needs a semi-colon "";"") vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. If world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
[JsonProperty("number_of_vertices")]
public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("vertices")]
public string Vertices { get; set; } = "";
    }
    
    public enum Wall_Detailed_OutsideBoundaryCondition
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Adiabatic")]
        Adiabatic = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Foundation")]
        Foundation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Ground")]
        Ground = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageFloor")]
        GroundBasementPreprocessorAverageFloor = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageWall")]
        GroundBasementPreprocessorAverageWall = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorLowerWall")]
        GroundBasementPreprocessorLowerWall = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorUpperWall")]
        GroundBasementPreprocessorUpperWall = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundFCfactorMethod")]
        GroundFCfactorMethod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorAverage")]
        GroundSlabPreprocessorAverage = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorCore")]
        GroundSlabPreprocessorCore = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorPerimeter")]
        GroundSlabPreprocessorPerimeter = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideCoefficients")]
        OtherSideCoefficients = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideConditionsModel")]
        OtherSideConditionsModel = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Surface")]
        Surface = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 15,
    }
    
    public enum Wall_Detailed_SunExposure
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NoSun")]
        NoSun = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SunExposed")]
        SunExposed = 2,
    }
    
    public enum Wall_Detailed_WindExposure
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NoWind")]
        NoWind = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="WindExposed")]
        WindExposed = 2,
    }
    
    [Description("Allows for detailed entry of roof/ceiling heat transfer surfaces.")]
    public class RoofCeiling_Detailed : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("outside_boundary_condition")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoofCeiling_Detailed_OutsideBoundaryCondition OutsideBoundaryCondition { get; set; } = (RoofCeiling_Detailed_OutsideBoundaryCondition)Enum.Parse(typeof(RoofCeiling_Detailed_OutsideBoundaryCondition), "Adiabatic");
        

[Description(@"Non-blank only if the field Outside Boundary Condition is Surface, Zone, OtherSideCoefficients or OtherSideConditionsModel If Surface, specify name of corresponding surface in adjacent zone or specify current surface name for internal partition separating like zones If Zone, specify the name of the corresponding zone and the program will generate the corresponding interzone surface If OtherSideCoefficients, specify name of SurfaceProperty:OtherSideCoefficients If OtherSideConditionsModel, specify name of SurfaceProperty:OtherSideConditionsModel")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[JsonProperty("sun_exposure")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoofCeiling_Detailed_SunExposure SunExposure { get; set; } = (RoofCeiling_Detailed_SunExposure)Enum.Parse(typeof(RoofCeiling_Detailed_SunExposure), "SunExposed");
        

[JsonProperty("wind_exposure")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoofCeiling_Detailed_WindExposure WindExposure { get; set; } = (RoofCeiling_Detailed_WindExposure)Enum.Parse(typeof(RoofCeiling_Detailed_WindExposure), "WindExposed");
        

[Description(@"From the exterior of the surface Unused if one uses the ""reflections"" options in Solar Distribution in Building input unless a DaylightingDevice:Shelf or DaylightingDevice:Tubular object has been specified. autocalculate will automatically calculate this value from the tilt of the surface")]
[JsonProperty("view_factor_to_ground")]
public string ViewFactorToGround { get; set; } = (System.String)"Autocalculate";
        

[Description(@"shown with 10 vertex coordinates -- extensible object ""extensible"" -- duplicate last set of x,y,z coordinates, renumbering please (and changing z terminator to a comma "","" for all but last one which needs a semi-colon "";"") vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. If world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
[JsonProperty("number_of_vertices")]
public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("vertices")]
public string Vertices { get; set; } = "";
    }
    
    public enum RoofCeiling_Detailed_OutsideBoundaryCondition
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Adiabatic")]
        Adiabatic = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Ground")]
        Ground = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageFloor")]
        GroundBasementPreprocessorAverageFloor = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageWall")]
        GroundBasementPreprocessorAverageWall = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorLowerWall")]
        GroundBasementPreprocessorLowerWall = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorUpperWall")]
        GroundBasementPreprocessorUpperWall = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorAverage")]
        GroundSlabPreprocessorAverage = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorCore")]
        GroundSlabPreprocessorCore = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorPerimeter")]
        GroundSlabPreprocessorPerimeter = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideCoefficients")]
        OtherSideCoefficients = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideConditionsModel")]
        OtherSideConditionsModel = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="Surface")]
        Surface = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 13,
    }
    
    public enum RoofCeiling_Detailed_SunExposure
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NoSun")]
        NoSun = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SunExposed")]
        SunExposed = 2,
    }
    
    public enum RoofCeiling_Detailed_WindExposure
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NoWind")]
        NoWind = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="WindExposed")]
        WindExposed = 2,
    }
    
    [Description("Allows for detailed entry of floor heat transfer surfaces.")]
    public class Floor_Detailed : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("outside_boundary_condition")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Floor_Detailed_OutsideBoundaryCondition OutsideBoundaryCondition { get; set; } = (Floor_Detailed_OutsideBoundaryCondition)Enum.Parse(typeof(Floor_Detailed_OutsideBoundaryCondition), "Adiabatic");
        

[Description(@"Non-blank only if the field Outside Boundary Condition is Surface, Zone, OtherSideCoefficients or OtherSideConditionsModel If Surface, specify name of corresponding surface in adjacent zone or specify current surface name for internal partition separating like zones If Zone, specify the name of the corresponding zone and the program will generate the corresponding interzone surface If Foundation, specify the name of the corresponding Foundation object and If OtherSideCoefficients, specify name of SurfaceProperty:OtherSideCoefficients If OtherSideConditionsModel, specify name of SurfaceProperty:OtherSideConditionsModel")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[JsonProperty("sun_exposure")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Floor_Detailed_SunExposure SunExposure { get; set; } = (Floor_Detailed_SunExposure)Enum.Parse(typeof(Floor_Detailed_SunExposure), "SunExposed");
        

[JsonProperty("wind_exposure")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Floor_Detailed_WindExposure WindExposure { get; set; } = (Floor_Detailed_WindExposure)Enum.Parse(typeof(Floor_Detailed_WindExposure), "WindExposed");
        

[Description(@"From the exterior of the surface Unused if one uses the ""reflections"" options in Solar Distribution in Building input unless a DaylightingDevice:Shelf or DaylightingDevice:Tubular object has been specified. autocalculate will automatically calculate this value from the tilt of the surface")]
[JsonProperty("view_factor_to_ground")]
public string ViewFactorToGround { get; set; } = (System.String)"Autocalculate";
        

[Description(@"shown with 10 vertex coordinates -- extensible object ""extensible"" -- duplicate last set of x,y,z coordinates, renumbering please (and changing z terminator to a comma "","" for all but last one which needs a semi-colon "";"") vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. If world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
[JsonProperty("number_of_vertices")]
public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("vertices")]
public string Vertices { get; set; } = "";
    }
    
    public enum Floor_Detailed_OutsideBoundaryCondition
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Adiabatic")]
        Adiabatic = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Foundation")]
        Foundation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Ground")]
        Ground = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageFloor")]
        GroundBasementPreprocessorAverageFloor = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageWall")]
        GroundBasementPreprocessorAverageWall = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorLowerWall")]
        GroundBasementPreprocessorLowerWall = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorUpperWall")]
        GroundBasementPreprocessorUpperWall = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundFCfactorMethod")]
        GroundFCfactorMethod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorAverage")]
        GroundSlabPreprocessorAverage = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorCore")]
        GroundSlabPreprocessorCore = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorPerimeter")]
        GroundSlabPreprocessorPerimeter = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideCoefficients")]
        OtherSideCoefficients = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideConditionsModel")]
        OtherSideConditionsModel = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Surface")]
        Surface = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 15,
    }
    
    public enum Floor_Detailed_SunExposure
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NoSun")]
        NoSun = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SunExposed")]
        SunExposed = 2,
    }
    
    public enum Floor_Detailed_WindExposure
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NoWind")]
        NoWind = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="WindExposed")]
        WindExposed = 2,
    }
    
    [Description("Allows for simplified entry of exterior walls. View Factor to Ground is automatic" +
        "ally calculated.")]
    public class Wall_Exterior : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Facing direction of outside of wall (S=180,N=0,E=90,W=270)")]
[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Walls are usually tilted 90 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[Description("Starting (x,y,z) coordinate is the Lower Left Corner of the Wall")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of interior walls.")]
    public class Wall_Adiabatic : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Facing direction of outside of wall (S=180,N=0,E=90,W=270)")]
[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Walls are usually tilted 90 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[Description("Starting (x,y,z) coordinate is the Lower Left Corner of the Wall")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of underground walls.")]
    public class Wall_Underground : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file. If the construction is type" +
    " \"Construction:CfactorUndergroundWall\", then the GroundFCfactorMethod will be us" +
    "ed.")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Facing direction of outside of wall (S=180,N=0,E=90,W=270)")]
[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Walls are usually tilted 90 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[Description("Starting (x,y,z) coordinate is the Lower Left Corner of the Wall")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of interzone walls (walls between zones).")]
    public class Wall_Interzone : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone for the inside of the surface")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Specify a surface name in an adjacent zone for known interior walls. Specify a zo" +
    "ne name of an adjacent zone to automatically generate the interior wall in the a" +
    "djacent zone.")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[Description("Facing direction of outside of wall (S=180,N=0,E=90,W=270)")]
[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Walls are usually tilted 90 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[Description("Starting (x,y,z) coordinate is the Lower Left Corner of the Wall")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of roofs (exterior). View Factor to Ground is automat" +
        "ically calculated.")]
    public class Roof : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Facing direction of outside of Roof")]
[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Flat Roofs are tilted 0 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If not Flat, Starting coordinate is the Lower Left Corner of the Roof")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[Description("Along X Axis")]
[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[Description("Along Y Axis")]
[JsonProperty("width")]
public System.Nullable<float> Width { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of interior ceilings.")]
    public class Ceiling_Adiabatic : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Facing direction of outside of Ceiling")]
[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Ceilings are usually tilted 0 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If not Flat, Starting coordinate is the Lower Left Corner of the Ceiling")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[Description("Along X Axis")]
[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[Description("Along Y Axis")]
[JsonProperty("width")]
public System.Nullable<float> Width { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of ceilings using adjacent zone (interzone) heat tran" +
        "sfer - adjacent surface should be a floor")]
    public class Ceiling_Interzone : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone for the inside of the surface")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Specify a surface name in an adjacent zone for known interior floors Specify a zo" +
    "ne name of an adjacent zone to automatically generate the interior floor in the " +
    "adjacent zone.")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[Description("Facing direction of outside of wall (S=180,N=0,E=90,W=270)")]
[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Ceilings are usually tilted 0 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If not Flat, should be Lower Left Corner (from outside)")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[Description("Along X Axis")]
[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[Description("Along Y Axis")]
[JsonProperty("width")]
public System.Nullable<float> Width { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of exterior floors with ground contact. View Factors " +
        "to Ground is automatically calculated.")]
    public class Floor_GroundContact : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file If the construction is type " +
    "\"Construction:FfactorGroundFloor\", then the GroundFCfactorMethod will be used.")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Floors are usually tilted 180 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
        

[Description("if not flat, should be lower left corner (from outside)")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[Description("Along X Axis")]
[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[Description("Along Y Axis")]
[JsonProperty("width")]
public System.Nullable<float> Width { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of exterior floors ignoring ground contact or interio" +
        "r floors. View Factor to Ground is automatically calculated.")]
    public class Floor_Adiabatic : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Floors are usually tilted 180 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
        

[Description("if not flat, should be lower left corner (from outside)")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[Description("Along X Axis")]
[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[Description("Along Y Axis")]
[JsonProperty("width")]
public System.Nullable<float> Width { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of floors using adjacent zone (interzone) heat transf" +
        "er - adjacent surface should be a ceiling.")]
    public class Floor_Interzone : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone for the inside of the surface")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Specify a surface name in an adjacent zone for known interior ceilings. Specify a" +
    " zone name of an adjacent zone to automatically generate the interior ceiling in" +
    " the adjacent zone.")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[Description("Floors are usually tilted 180 degrees")]
[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
        

[Description("If not Flat, should be Lower Left Corner (from outside)")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[Description("Along X Axis")]
[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[Description("Along Y Axis")]
[JsonProperty("width")]
public System.Nullable<float> Width { get; set; } = null;
    }
    
    [Description("Allows for detailed entry of subsurfaces (windows, doors, glass doors, tubular da" +
        "ylighting devices).")]
    public class FenestrationSurface_Detailed : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public FenestrationSurface_Detailed_SurfaceType SurfaceType { get; set; } = (FenestrationSurface_Detailed_SurfaceType)Enum.Parse(typeof(FenestrationSurface_Detailed_SurfaceType), "Door");
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[JsonProperty("building_surface_name")]
public string BuildingSurfaceName { get; set; } = "";
        

[Description(@"Non-blank only if base surface field Outside Boundary Condition is Surface or OtherSideCoefficients If Base Surface's Surface, specify name of corresponding subsurface in adjacent zone or specify current subsurface name for internal partition separating like zones If OtherSideCoefficients, specify name of SurfaceProperty:OtherSideCoefficients or leave blank to inherit Base Surface's OtherSide Coefficients")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[Description(@"From the exterior of the surface Unused if one uses the ""reflections"" options in Solar Distribution in Building input unless a DaylightingDevice:Shelf or DaylightingDevice:Tubular object has been specified. autocalculate will automatically calculate this value from the tilt of the surface")]
[JsonProperty("view_factor_to_ground")]
public string ViewFactorToGround { get; set; } = (System.String)"Autocalculate";
        

[Description(@"Enter the name of a WindowProperty:FrameAndDivider object Used only for exterior windows (rectangular) and glass doors. Unused for triangular windows. If not specified (blank), window or glass door has no frame or divider and no beam solar reflection from reveal surfaces.")]
[JsonProperty("frame_and_divider_name")]
public string FrameAndDividerName { get; set; } = "";
        

[Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
    " truncated to integer")]
[JsonProperty("multiplier")]
public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. If world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
[JsonProperty("number_of_vertices")]
public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("vertex_1_x_coordinate")]
public System.Nullable<float> Vertex1XCoordinate { get; set; } = null;
        

[JsonProperty("vertex_1_y_coordinate")]
public System.Nullable<float> Vertex1YCoordinate { get; set; } = null;
        

[JsonProperty("vertex_1_z_coordinate")]
public System.Nullable<float> Vertex1ZCoordinate { get; set; } = null;
        

[JsonProperty("vertex_2_x_coordinate")]
public System.Nullable<float> Vertex2XCoordinate { get; set; } = null;
        

[JsonProperty("vertex_2_y_coordinate")]
public System.Nullable<float> Vertex2YCoordinate { get; set; } = null;
        

[JsonProperty("vertex_2_z_coordinate")]
public System.Nullable<float> Vertex2ZCoordinate { get; set; } = null;
        

[JsonProperty("vertex_3_x_coordinate")]
public System.Nullable<float> Vertex3XCoordinate { get; set; } = null;
        

[JsonProperty("vertex_3_y_coordinate")]
public System.Nullable<float> Vertex3YCoordinate { get; set; } = null;
        

[JsonProperty("vertex_3_z_coordinate")]
public System.Nullable<float> Vertex3ZCoordinate { get; set; } = null;
        

[Description("Not used for triangles")]
[JsonProperty("vertex_4_x_coordinate")]
public System.Nullable<float> Vertex4XCoordinate { get; set; } = null;
        

[Description("Not used for triangles")]
[JsonProperty("vertex_4_y_coordinate")]
public System.Nullable<float> Vertex4YCoordinate { get; set; } = null;
        

[Description("Not used for triangles")]
[JsonProperty("vertex_4_z_coordinate")]
public System.Nullable<float> Vertex4ZCoordinate { get; set; } = null;
    }
    
    public enum FenestrationSurface_Detailed_SurfaceType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Door")]
        Door = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoor")]
        GlassDoor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffuser")]
        TubularDaylightDiffuser = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDome")]
        TubularDaylightDome = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Window")]
        Window = 4,
    }
    
    [Description("Allows for simplified entry of Windows.")]
    public class Window : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Name of Surface (Wall, usually) the Window is on (i.e., Base Surface) Window assu" +
    "mes the azimuth and tilt angles of the surface it is on.")]
[JsonProperty("building_surface_name")]
public string BuildingSurfaceName { get; set; } = "";
        

[Description(@"Enter the name of a WindowProperty:FrameAndDivider object Used only for exterior windows (rectangular) and glass doors. Unused for triangular windows. If not specified (blank), window or glass door has no frame or divider and no beam solar reflection from reveal surfaces.")]
[JsonProperty("frame_and_divider_name")]
public string FrameAndDividerName { get; set; } = "";
        

[Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
    " truncated to integer")]
[JsonProperty("multiplier")]
public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Window starting coordinate is specified relative to the Base Surface origin.")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[Description("How far up the wall the Window starts. (in 2-d, this would be a Y Coordinate)")]
[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of opaque Doors.")]
    public class Door : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Name of Surface (Wall, usually) the Door is on (i.e., Base Surface) Door assumes " +
    "the azimuth and tilt angles of the surface it is on.")]
[JsonProperty("building_surface_name")]
public string BuildingSurfaceName { get; set; } = "";
        

[Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
    " truncated to integer")]
[JsonProperty("multiplier")]
public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Door starting coordinate is specified relative to the Base Surface origin.")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[Description("How far up the wall the Door starts. (in 2-d, this would be a Y Coordinate)")]
[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of glass Doors.")]
    public class GlazedDoor : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Name of Surface (Wall, usually) the Door is on (i.e., Base Surface) Door assumes " +
    "the azimuth and tilt angles of the surface it is on.")]
[JsonProperty("building_surface_name")]
public string BuildingSurfaceName { get; set; } = "";
        

[Description(@"Enter the name of a WindowProperty:FrameAndDivider object Used only for exterior windows (rectangular) and glass doors. Unused for triangular windows. If not specified (blank), window or glass door has no frame or divider and no beam solar reflection from reveal surfaces.")]
[JsonProperty("frame_and_divider_name")]
public string FrameAndDividerName { get; set; } = "";
        

[Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
    " truncated to integer")]
[JsonProperty("multiplier")]
public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Door starting coordinate is specified relative to the Base Surface origin.")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[Description("How far up the wall the Door starts. (in 2-d, this would be a Y Coordinate)")]
[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of interzone windows (adjacent to other zones).")]
    public class Window_Interzone : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Name of Surface (Wall, usually) the Window is on (i.e., Base Surface) Window assu" +
    "mes the azimuth and tilt angles of the surface it is on.")]
[JsonProperty("building_surface_name")]
public string BuildingSurfaceName { get; set; } = "";
        

[Description(@"Specify a surface name in an adjacent zone for known interior windows. Specify a zone name of an adjacent zone to automatically generate the interior window in the adjacent zone. a blank field will set up a Window in an adjacent zone (same zone as adjacent to base surface)")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
    " truncated to integer")]
[JsonProperty("multiplier")]
public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Window starting coordinate is specified relative to the Base Surface origin.")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[Description("How far up the wall the Window starts. (in 2-d, this would be a Y Coordinate)")]
[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of interzone (opaque interior) doors (adjacent to oth" +
        "er zones).")]
    public class Door_Interzone : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Name of Surface (Wall, usually) the Door is on (i.e., Base Surface) Door assumes " +
    "the azimuth and tilt angles of the surface it is on.")]
[JsonProperty("building_surface_name")]
public string BuildingSurfaceName { get; set; } = "";
        

[Description(@"Specify a surface name in an adjacent zone for known interior doors. Specify a zone name of an adjacent zone to automatically generate the interior door in the adjacent zone. a blank field will set up a Window in an adjacent zone (same zone as adjacent to base surface)")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
    " truncated to integer")]
[JsonProperty("multiplier")]
public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Door starting coordinate is specified relative to the Base Surface origin.")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[Description("How far up the wall the Door starts. (in 2-d, this would be a Y Coordinate)")]
[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Allows for simplified entry of interzone (glass interior) doors (adjacent to othe" +
        "r zones).")]
    public class GlazedDoor_Interzone : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Name of Surface (Wall, usually) the Door is on (i.e., Base Surface) Door assumes " +
    "the azimuth and tilt angles of the surface it is on.")]
[JsonProperty("building_surface_name")]
public string BuildingSurfaceName { get; set; } = "";
        

[Description(@"Specify a surface name in an adjacent zone for known interior doors. Specify a zone name of an adjacent zone to automatically generate the interior door in the adjacent zone. a blank field will set up a Window in an adjacent zone (same zone as adjacent to base surface)")]
[JsonProperty("outside_boundary_condition_object")]
public string OutsideBoundaryConditionObject { get; set; } = "";
        

[Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
    " truncated to integer")]
[JsonProperty("multiplier")]
public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Door starting coordinate is specified relative to the Base Surface origin.")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[Description("How far up the wall the Door starts. (in 2-d, this would be a Y Coordinate)")]
[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Specifies the type, location, and controls for window shades, window blinds, and " +
        "switchable glazing. Referencing the surface objects for exterior windows and gla" +
        "ss doors (ref: FenestrationSurface:Detailed, Window, and GlazedDoor).")]
    public class WindowShadingControl : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description(@"If multiple WindowShadingControl objects are used than the order that they deploy the window shades can be set with this field. The first WindowShadingControl should be 1 and subsequent WindowShadingControl should 2 or 3 or higher. This is usually used when the Multiple Surface Control Type field is set to Group and groups of windows are being controlled in a certain order.")]
[JsonProperty("shading_control_sequence_number")]
public System.Nullable<float> ShadingControlSequenceNumber { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("shading_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowShadingControl_ShadingType ShadingType { get; set; } = (WindowShadingControl_ShadingType)Enum.Parse(typeof(WindowShadingControl_ShadingType), "BetweenGlassBlind");
        

[Description(@"Required if Shading Type = SwitchableGlazing Required if Shading Type = interior or exterior shade or blind, or exterior screen, and ""Shading Device Material Name"" is not specified. If both ""Construction with Shading Name"" and ""Shading Device Material Name"" are entered, the former takes precedence.")]
[JsonProperty("construction_with_shading_name")]
public string ConstructionWithShadingName { get; set; } = "";
        

[Description(@"OnIfScheduleAllows requires that Schedule Name be specified and Shading Control Is Scheduled = Yes. AlwaysOn, AlwaysOff and OnIfScheduleAllows are the only valid control types for ExteriorScreen. The following six control types are used primarily to reduce zone cooling load due to window solar gain Following entry should be used only if Shading Type = SwitchableGlazing and window is in a daylit zone The following three control types are used to reduce zone Heating load. They can be used with any Shading Type but are most appropriate for opaque interior or exterior shades with high insulating value (""opaque movable insulation"") The following two control types are used to reduce zone heating and cooling load. They can be used with any Shading Type but are most appropriate for translucent interior or exterior shades with high insulating value (""translucent movable insulation"") The following two control types are used to reduce zone Cooling load. They can be used with any Shading Type but are most appropriate for interior or exterior blinds,interior or exterior shades with low insulating value, or switchable glazing The following four control types require that both Setpoint and Setpoint2 be specified Setpoint will correspond to outdoor air temp or zone air temp (deg C) Setpoint2 will correspond to solar on window or horizontal solar (W/m2)")]
[JsonProperty("shading_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowShadingControl_ShadingControlType ShadingControlType { get; set; } = (WindowShadingControl_ShadingControlType)Enum.Parse(typeof(WindowShadingControl_ShadingControlType), "AlwaysOff");
        

[Description(@"Required if Shading Control Is Scheduled = Yes. If schedule value = 1, shading control is active, i.e., shading can take place only if the control test passes. If schedule value = 0, shading is off whether or not the control test passes. Schedule Name is required if Shading Control Is Scheduled = Yes. If Schedule Name is not specified, shading control is assumed to be active at all times.")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description("W/m2 for solar-based controls, W for cooling- or heating-based controls, deg C fo" +
    "r temperature-based controls. Unused for Shading Control Type = AlwaysOn, Always" +
    "Off, OnIfScheduleAllows, OnIfHighGlare, Glare, and DaylightIlluminance")]
[JsonProperty("setpoint")]
public System.Nullable<float> Setpoint { get; set; } = null;
        

[Description("If Yes, Schedule Name is required; if No, Schedule Name is not used. Shading Cont" +
    "rol Is Scheduled = Yes is required if Shading Control Type = OnIfScheduleAllows." +
    "")]
[JsonProperty("shading_control_is_scheduled")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes ShadingControlIsScheduled { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description(@"If Yes and window is in a daylit zone, shading is on if zone's discomfort glare index exceeds the maximum discomfort glare index specified in the Daylighting object referenced by the zone. The glare test is OR'ed with the test specified by Shading Control Type. Glare Control Is Active = Yes is required if Shading Control Type = OnIfHighGlare.")]
[JsonProperty("glare_control_is_active")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes GlareControlIsActive { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description(@"Enter the name of a WindowMaterial:Shade, WindowMaterial:Screen or WindowMaterial:Blind object. Required if ""Construction with Shading Name"" is not specified. Not used if Shading Control Type = SwitchableGlazing, BetweenGlassShade, or BetweenGlassBlind. If both ""Construction with Shading Name"" and ""Shading Device Material Name"" are entered, the former takes precedence.")]
[JsonProperty("shading_device_material_name")]
public string ShadingDeviceMaterialName { get; set; } = "";
        

[Description("Used only if Shading Type = InteriorBlind, ExteriorBlind or BetweenGlassBlind. If" +
    " choice is ScheduledSlatAngle then Slat Angle Schedule Name is required.")]
[JsonProperty("type_of_slat_angle_control_for_blinds")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowShadingControl_TypeOfSlatAngleControlForBlinds TypeOfSlatAngleControlForBlinds { get; set; } = (WindowShadingControl_TypeOfSlatAngleControlForBlinds)Enum.Parse(typeof(WindowShadingControl_TypeOfSlatAngleControlForBlinds), "FixedSlatAngle");
        

[Description("Used only if Shading Type = InteriorBlind, ExteriorBlind or BetweenGlassBlind. Re" +
    "quired if Type of Slat Angle Control for Blinds = ScheduledSlatAngle Schedule va" +
    "lues should be degrees (0 minimum, 180 maximum)")]
[JsonProperty("slat_angle_schedule_name")]
public string SlatAngleScheduleName { get; set; } = "";
        

[Description(@"W/m2 for solar-based controls, deg C for temperature-based controls. Used only as the second setpoint for the following two-setpoint control types: OnIfHighOutdoorAirTempAndHighSolarOnWindow, OnIfHighOutdoorAirTempAndHighHorizontalSolar, OnIfHighZoneAirTempAndHighSolarOnWindow, and OnIfHighZoneAirTempAndHighHorizontalSolar")]
[JsonProperty("setpoint_2")]
public System.Nullable<float> Setpoint2 { get; set; } = null;
        

[Description("Reference to the Daylighting:Controls object that provides the glare and illumina" +
    "nce control to the zone.")]
[JsonProperty("daylighting_control_object_name")]
public string DaylightingControlObjectName { get; set; } = "";
        

[Description(@"When Sequential is used the list of fenestration surfaces are controlled individually in the order specified When Group is used the entire list is controlled simultaneously and if glare control is needed the entire group of window shades are deployed together a the same time")]
[JsonProperty("multiple_surface_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowShadingControl_MultipleSurfaceControlType MultipleSurfaceControlType { get; set; } = (WindowShadingControl_MultipleSurfaceControlType)Enum.Parse(typeof(WindowShadingControl_MultipleSurfaceControlType), "Sequential");
        

[JsonProperty("fenestration_surfaces")]
public string FenestrationSurfaces { get; set; } = "";
    }
    
    public enum WindowShadingControl_ShadingType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="BetweenGlassBlind")]
        BetweenGlassBlind = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BetweenGlassShade")]
        BetweenGlassShade = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ExteriorBlind")]
        ExteriorBlind = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ExteriorScreen")]
        ExteriorScreen = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ExteriorShade")]
        ExteriorShade = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="InteriorBlind")]
        InteriorBlind = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="InteriorShade")]
        InteriorShade = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="SwitchableGlazing")]
        SwitchableGlazing = 7,
    }
    
    public enum WindowShadingControl_ShadingControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AlwaysOff")]
        AlwaysOff = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AlwaysOn")]
        AlwaysOn = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetDaylightIlluminanceSetpoint")]
        MeetDaylightIlluminanceSetpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OffNightAndOnDayIfCoolingAndHighSolarOnWindow")]
        OffNightAndOnDayIfCoolingAndHighSolarOnWindow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighGlare")]
        OnIfHighGlare = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighHorizontalSolar")]
        OnIfHighHorizontalSolar = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighOutdoorAirTempAndHighHorizontalSolar")]
        OnIfHighOutdoorAirTempAndHighHorizontalSolar = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighOutdoorAirTempAndHighSolarOnWindow")]
        OnIfHighOutdoorAirTempAndHighSolarOnWindow = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighOutdoorAirTemperature")]
        OnIfHighOutdoorAirTemperature = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighSolarOnWindow")]
        OnIfHighSolarOnWindow = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighZoneAirTempAndHighHorizontalSolar")]
        OnIfHighZoneAirTempAndHighHorizontalSolar = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighZoneAirTempAndHighSolarOnWindow")]
        OnIfHighZoneAirTempAndHighSolarOnWindow = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighZoneAirTemperature")]
        OnIfHighZoneAirTemperature = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighZoneCooling")]
        OnIfHighZoneCooling = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfScheduleAllows")]
        OnIfScheduleAllows = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightAndOnDayIfCoolingAndHighSolarOnWindow")]
        OnNightAndOnDayIfCoolingAndHighSolarOnWindow = 15,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfHeatingAndOffDay")]
        OnNightIfHeatingAndOffDay = 16,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfHeatingAndOnDayIfCooling")]
        OnNightIfHeatingAndOnDayIfCooling = 17,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfLowInsideTempAndOffDay")]
        OnNightIfLowInsideTempAndOffDay = 18,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfLowOutdoorTempAndOffDay")]
        OnNightIfLowOutdoorTempAndOffDay = 19,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfLowOutdoorTempAndOnDayIfCooling")]
        OnNightIfLowOutdoorTempAndOnDayIfCooling = 20,
    }
    
    public enum WindowShadingControl_TypeOfSlatAngleControlForBlinds
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BlockBeamSolar")]
        BlockBeamSolar = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedSlatAngle")]
        FixedSlatAngle = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ScheduledSlatAngle")]
        ScheduledSlatAngle = 3,
    }
    
    public enum WindowShadingControl_MultipleSurfaceControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Group")]
        Group = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Sequential")]
        Sequential = 2,
    }
    
    [Description("Specifies the dimensions of a window frame, dividers, and inside reveal surfaces." +
        " Referenced by the surface objects for exterior windows and glass doors (ref: Fe" +
        "nestrationSurface:Detailed, Window, and GlazedDoor).")]
    public class WindowProperty_FrameAndDivider : BHoMObject, IEnergyPlusClass
    {
        

[Description("Width of frame in plane of window Frame width assumed the same on all sides of wi" +
    "ndow")]
[JsonProperty("frame_width")]
public System.Nullable<float> FrameWidth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Amount that frame projects outward from the outside face of the glazing")]
[JsonProperty("frame_outside_projection")]
public System.Nullable<float> FrameOutsideProjection { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Amount that frame projects inward from the inside face of the glazing")]
[JsonProperty("frame_inside_projection")]
public System.Nullable<float> FrameInsideProjection { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Effective conductance of frame Excludes air films Obtained from WINDOW 5 or other" +
    " 2-D calculation")]
[JsonProperty("frame_conductance")]
public System.Nullable<float> FrameConductance { get; set; } = null;
        

[Description("Excludes air films; applies only to multipane windows Obtained from WINDOW 5 or o" +
    "ther 2-D calculation")]
[JsonProperty("ratio_of_frame_edge_glass_conductance_to_center_of_glass_conductance")]
public System.Nullable<float> RatioOfFrameEdgeGlassConductanceToCenterOfGlassConductance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Assumed same on outside and inside of frame")]
[JsonProperty("frame_solar_absorptance")]
public System.Nullable<float> FrameSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Assumed same on outside and inside of frame")]
[JsonProperty("frame_visible_absorptance")]
public System.Nullable<float> FrameVisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Assumed same on outside and inside of frame")]
[JsonProperty("frame_thermal_hemispherical_emissivity")]
public System.Nullable<float> FrameThermalHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("divider_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowProperty_FrameAndDivider_DividerType DividerType { get; set; } = (WindowProperty_FrameAndDivider_DividerType)Enum.Parse(typeof(WindowProperty_FrameAndDivider_DividerType), "DividedLite");
        

[Description("Width of dividers in plane of window Width assumed the same for all dividers")]
[JsonProperty("divider_width")]
public System.Nullable<float> DividerWidth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("\"Horizontal\" means parallel to local window X-axis")]
[JsonProperty("number_of_horizontal_dividers")]
public System.Nullable<float> NumberOfHorizontalDividers { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("\"Vertical\" means parallel to local window Y-axis")]
[JsonProperty("number_of_vertical_dividers")]
public System.Nullable<float> NumberOfVerticalDividers { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Amount that divider projects outward from the outside face of the glazing Outside" +
    " projection assumed the same for all divider elements")]
[JsonProperty("divider_outside_projection")]
public System.Nullable<float> DividerOutsideProjection { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Amount that divider projects inward from the inside face of the glazing Inside pr" +
    "ojection assumed the same for all divider elements")]
[JsonProperty("divider_inside_projection")]
public System.Nullable<float> DividerInsideProjection { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Effective conductance of divider Excludes air films Obtained from WINDOW 5 or oth" +
    "er 2-D calculation")]
[JsonProperty("divider_conductance")]
public System.Nullable<float> DividerConductance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Excludes air films Obtained from WINDOW 5 or other 2-D calculation")]
[JsonProperty("ratio_of_divider_edge_glass_conductance_to_center_of_glass_conductance")]
public System.Nullable<float> RatioOfDividerEdgeGlassConductanceToCenterOfGlassConductance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Assumed same on outside and inside of divider")]
[JsonProperty("divider_solar_absorptance")]
public System.Nullable<float> DividerSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Assumed same on outside and inside of divider")]
[JsonProperty("divider_visible_absorptance")]
public System.Nullable<float> DividerVisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Assumed same on outside and inside of divider")]
[JsonProperty("divider_thermal_hemispherical_emissivity")]
public System.Nullable<float> DividerThermalHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("outside_reveal_solar_absorptance")]
public System.Nullable<float> OutsideRevealSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("inside_sill_depth")]
public System.Nullable<float> InsideSillDepth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("inside_sill_solar_absorptance")]
public System.Nullable<float> InsideSillSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Distance from plane of inside surface of glazing to plane of inside surface of wall. Outside reveal depth is determined from the geometry of the window and the wall it is on; it is non-zero if the plane of the outside surface of the glazing is set back from the plane of the outside surface of the wall.")]
[JsonProperty("inside_reveal_depth")]
public System.Nullable<float> InsideRevealDepth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("inside_reveal_solar_absorptance")]
public System.Nullable<float> InsideRevealSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum WindowProperty_FrameAndDivider_DividerType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DividedLite")]
        DividedLite = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Suspended")]
        Suspended = 2,
    }
    
    [Description("Used to control forced airflow through a gap between glass layers")]
    public class WindowProperty_AirflowControl : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("airflow_source")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowProperty_AirflowControl_AirflowSource AirflowSource { get; set; } = (WindowProperty_AirflowControl_AirflowSource)Enum.Parse(typeof(WindowProperty_AirflowControl_AirflowSource), "IndoorAir");
        

[Description("If ReturnAir is selected, the name of the Return Air Node may be specified below." +
    "")]
[JsonProperty("airflow_destination")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowProperty_AirflowControl_AirflowDestination AirflowDestination { get; set; } = (WindowProperty_AirflowControl_AirflowDestination)Enum.Parse(typeof(WindowProperty_AirflowControl_AirflowDestination), "OutdoorAir");
        

[Description("Above is m3/s per m of glazing width")]
[JsonProperty("maximum_flow_rate")]
public System.Nullable<float> MaximumFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("ScheduledOnly requires that Airflow Has Multiplier Schedule Name = Yes and that A" +
    "irflow Multiplier Schedule Name is specified.")]
[JsonProperty("airflow_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowProperty_AirflowControl_AirflowControlType AirflowControlType { get; set; } = (WindowProperty_AirflowControl_AirflowControlType)Enum.Parse(typeof(WindowProperty_AirflowControl_AirflowControlType), "AlwaysOnAtMaximumFlow");
        

[Description("If Yes, then Airflow Multiplier Schedule Name must be specified")]
[JsonProperty("airflow_is_scheduled")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes AirflowIsScheduled { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Required if Airflow Is Scheduled = Yes. Schedule values are 0.0 or 1.0 and multip" +
    "ly Maximum Air Flow.")]
[JsonProperty("airflow_multiplier_schedule_name")]
public string AirflowMultiplierScheduleName { get; set; } = "";
        

[Description("Name of the return air node for this airflow window if the Airflow Destination is" +
    " ReturnAir. If left blank, defaults to the first return air node for the zone of" +
    " the window surface.")]
[JsonProperty("airflow_return_air_node_name")]
public string AirflowReturnAirNodeName { get; set; } = "";
    }
    
    public enum WindowProperty_AirflowControl_AirflowSource
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAir")]
        IndoorAir = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAir")]
        OutdoorAir = 2,
    }
    
    public enum WindowProperty_AirflowControl_AirflowDestination
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAir")]
        IndoorAir = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAir")]
        OutdoorAir = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ReturnAir")]
        ReturnAir = 3,
    }
    
    public enum WindowProperty_AirflowControl_AirflowControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AlwaysOff")]
        AlwaysOff = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AlwaysOnAtMaximumFlow")]
        AlwaysOnAtMaximumFlow = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ScheduledOnly")]
        ScheduledOnly = 3,
    }
    
    [Description("This is a movable exterior glass layer that is usually applied in the winter and " +
        "removed in the summer.")]
    public class WindowProperty_StormWindow : BHoMObject, IEnergyPlusClass
    {
        

[Description("Must be the name of a FenestrationSurface:Detailed object with Surface Type = WIN" +
    "DOW. The WindowProperty:StormWindow object can only be used with exterior window" +
    "s.")]
[JsonProperty("window_name")]
public string WindowName { get; set; } = "";
        

[Description("Must be a WindowMaterial:Glazing or WindowMaterial:Glazing:RefractionExtinctionMe" +
    "thod Gap between storm glass layer and adjacent glass layer is assumed to be fil" +
    "led with Air")]
[JsonProperty("storm_glass_layer_name")]
public string StormGlassLayerName { get; set; } = "";
        

[JsonProperty("distance_between_storm_glass_layer_and_adjacent_glass")]
public System.Nullable<float> DistanceBetweenStormGlassLayerAndAdjacentGlass { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[JsonProperty("month_that_storm_glass_layer_is_put_on")]
public System.Nullable<float> MonthThatStormGlassLayerIsPutOn { get; set; } = null;
        

[JsonProperty("day_of_month_that_storm_glass_layer_is_put_on")]
public System.Nullable<float> DayOfMonthThatStormGlassLayerIsPutOn { get; set; } = null;
        

[JsonProperty("month_that_storm_glass_layer_is_taken_off")]
public System.Nullable<float> MonthThatStormGlassLayerIsTakenOff { get; set; } = null;
        

[JsonProperty("day_of_month_that_storm_glass_layer_is_taken_off")]
public System.Nullable<float> DayOfMonthThatStormGlassLayerIsTakenOff { get; set; } = null;
    }
    
    [Description(@"Used to describe internal zone surface area that does not need to be part of geometric representation. This should be the total surface area exposed to the zone air. If you use a ZoneList in the Zone or ZoneList name field then this definition applies to all the zones in the ZoneList.")]
    public class InternalMass : BHoMObject, IEnergyPlusClass
    {
        

[Description("To be matched with a construction in this input file")]
[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Zone the surface is a part of used to be Interior Environment")]
[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[JsonProperty("surface_area")]
public System.Nullable<float> SurfaceArea { get; set; } = null;
    }
    
    [Description("used for shading elements such as trees these items are fixed in space and would " +
        "not move with relative geometry")]
    public class Shading_Site : BHoMObject, IEnergyPlusClass
    {
        

[Description("Facing direction of outside of shading device (S=180,N=0,E=90,W=270)")]
[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[Description("Starting coordinate is the Lower Left Corner of the Shade")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("used for shading elements such as trees, other buildings, parts of this building " +
        "not being modeled these items are relative to the current building and would mov" +
        "e with relative geometry")]
    public class Shading_Building : BHoMObject, IEnergyPlusClass
    {
        

[Description("Facing direction of outside of shading device (S=180,N=0,E=90,W=270)")]
[JsonProperty("azimuth_angle")]
public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

[JsonProperty("tilt_angle")]
public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[Description("Starting coordinate is the Lower Left Corner of the Shade")]
[JsonProperty("starting_x_coordinate")]
public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

[JsonProperty("starting_y_coordinate")]
public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

[JsonProperty("starting_z_coordinate")]
public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("used for shading elements such as trees these items are fixed in space and would " +
        "not move with relative geometry")]
    public class Shading_Site_Detailed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Transmittance schedule for the shading device, defaults to zero (always opaque)")]
[JsonProperty("transmittance_schedule_name")]
public string TransmittanceScheduleName { get; set; } = "";
        

[Description("shown with 6 vertex coordinates -- extensible object Rules for vertices are given" +
    " in GlobalGeometryRules coordinates -- For this object all surface coordinates a" +
    "re in world coordinates.")]
[JsonProperty("number_of_vertices")]
public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("vertices")]
public string Vertices { get; set; } = "";
    }
    
    [Description("used for shading elements such as trees, other buildings, parts of this building " +
        "not being modeled these items are relative to the current building and would mov" +
        "e with relative geometry")]
    public class Shading_Building_Detailed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Transmittance schedule for the shading device, defaults to zero (always opaque)")]
[JsonProperty("transmittance_schedule_name")]
public string TransmittanceScheduleName { get; set; } = "";
        

[Description("shown with 6 vertex coordinates -- extensible object Rules for vertices are given" +
    " in GlobalGeometryRules coordinates -- For this object all surface coordinates a" +
    "re relative to the building origin (0,0,0) and will rotate with the BUILDING nor" +
    "th axis.")]
[JsonProperty("number_of_vertices")]
public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("vertices")]
public string Vertices { get; set; } = "";
    }
    
    [Description("Overhangs are usually flat shading surfaces that reference a window or door.")]
    public class Shading_Overhang : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("window_or_door_name")]
public string WindowOrDoorName { get; set; } = "";
        

[JsonProperty("height_above_window_or_door")]
public System.Nullable<float> HeightAboveWindowOrDoor { get; set; } = null;
        

[JsonProperty("tilt_angle_from_window_door")]
public System.Nullable<float> TiltAngleFromWindowDoor { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[JsonProperty("left_extension_from_window_door_width")]
public System.Nullable<float> LeftExtensionFromWindowDoorWidth { get; set; } = null;
        

[Description("N3 + N4 + Window/Door Width is Overhang Length")]
[JsonProperty("right_extension_from_window_door_width")]
public System.Nullable<float> RightExtensionFromWindowDoorWidth { get; set; } = null;
        

[JsonProperty("depth")]
public System.Nullable<float> Depth { get; set; } = null;
    }
    
    [Description("Overhangs are typically flat shading surfaces that reference a window or door.")]
    public class Shading_Overhang_Projection : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("window_or_door_name")]
public string WindowOrDoorName { get; set; } = "";
        

[JsonProperty("height_above_window_or_door")]
public System.Nullable<float> HeightAboveWindowOrDoor { get; set; } = null;
        

[JsonProperty("tilt_angle_from_window_door")]
public System.Nullable<float> TiltAngleFromWindowDoor { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[JsonProperty("left_extension_from_window_door_width")]
public System.Nullable<float> LeftExtensionFromWindowDoorWidth { get; set; } = null;
        

[Description("N3 + N4 + Window/Door Width is Overhang Length")]
[JsonProperty("right_extension_from_window_door_width")]
public System.Nullable<float> RightExtensionFromWindowDoorWidth { get; set; } = null;
        

[JsonProperty("depth_as_fraction_of_window_door_height")]
public System.Nullable<float> DepthAsFractionOfWindowDoorHeight { get; set; } = null;
    }
    
    [Description("Fins are usually shading surfaces that are perpendicular to a window or door.")]
    public class Shading_Fin : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("window_or_door_name")]
public string WindowOrDoorName { get; set; } = "";
        

[JsonProperty("left_extension_from_window_door")]
public System.Nullable<float> LeftExtensionFromWindowDoor { get; set; } = null;
        

[JsonProperty("left_distance_above_top_of_window")]
public System.Nullable<float> LeftDistanceAboveTopOfWindow { get; set; } = null;
        

[Description("N2 + N3 + height of Window/Door is height of Fin")]
[JsonProperty("left_distance_below_bottom_of_window")]
public System.Nullable<float> LeftDistanceBelowBottomOfWindow { get; set; } = null;
        

[JsonProperty("left_tilt_angle_from_window_door")]
public System.Nullable<float> LeftTiltAngleFromWindowDoor { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[JsonProperty("left_depth")]
public System.Nullable<float> LeftDepth { get; set; } = null;
        

[JsonProperty("right_extension_from_window_door")]
public System.Nullable<float> RightExtensionFromWindowDoor { get; set; } = null;
        

[JsonProperty("right_distance_above_top_of_window")]
public System.Nullable<float> RightDistanceAboveTopOfWindow { get; set; } = null;
        

[Description("N7 + N8 + height of Window/Door is height of Fin")]
[JsonProperty("right_distance_below_bottom_of_window")]
public System.Nullable<float> RightDistanceBelowBottomOfWindow { get; set; } = null;
        

[JsonProperty("right_tilt_angle_from_window_door")]
public System.Nullable<float> RightTiltAngleFromWindowDoor { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[JsonProperty("right_depth")]
public System.Nullable<float> RightDepth { get; set; } = null;
    }
    
    [Description("Fins are usually shading surfaces that are perpendicular to a window or door.")]
    public class Shading_Fin_Projection : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("window_or_door_name")]
public string WindowOrDoorName { get; set; } = "";
        

[JsonProperty("left_extension_from_window_door")]
public System.Nullable<float> LeftExtensionFromWindowDoor { get; set; } = null;
        

[JsonProperty("left_distance_above_top_of_window")]
public System.Nullable<float> LeftDistanceAboveTopOfWindow { get; set; } = null;
        

[Description("N2 + N3 + height of Window/Door is height of Fin")]
[JsonProperty("left_distance_below_bottom_of_window")]
public System.Nullable<float> LeftDistanceBelowBottomOfWindow { get; set; } = null;
        

[JsonProperty("left_tilt_angle_from_window_door")]
public System.Nullable<float> LeftTiltAngleFromWindowDoor { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[JsonProperty("left_depth_as_fraction_of_window_door_width")]
public System.Nullable<float> LeftDepthAsFractionOfWindowDoorWidth { get; set; } = null;
        

[JsonProperty("right_extension_from_window_door")]
public System.Nullable<float> RightExtensionFromWindowDoor { get; set; } = null;
        

[JsonProperty("right_distance_above_top_of_window")]
public System.Nullable<float> RightDistanceAboveTopOfWindow { get; set; } = null;
        

[Description("N7 + N8 + height of Window/Door is height of Fin")]
[JsonProperty("right_distance_below_bottom_of_window")]
public System.Nullable<float> RightDistanceBelowBottomOfWindow { get; set; } = null;
        

[JsonProperty("right_tilt_angle_from_window_door")]
public System.Nullable<float> RightTiltAngleFromWindowDoor { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[JsonProperty("right_depth_as_fraction_of_window_door_width")]
public System.Nullable<float> RightDepthAsFractionOfWindowDoorWidth { get; set; } = null;
    }
    
    [Description("used For fins, overhangs, elements that shade the building, are attached to the b" +
        "uilding but are not part of the heat transfer calculations")]
    public class Shading_Zone_Detailed : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("base_surface_name")]
public string BaseSurfaceName { get; set; } = "";
        

[Description("Transmittance schedule for the shading device, defaults to zero (always opaque)")]
[JsonProperty("transmittance_schedule_name")]
public string TransmittanceScheduleName { get; set; } = "";
        

[Description(@"shown with 6 vertex coordinates -- extensible object vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. if world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
[JsonProperty("number_of_vertices")]
public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("vertices")]
public string Vertices { get; set; } = "";
    }
    
    [Description("If this object is not defined for a shading surface the default values listed in " +
        "following fields will be used in the solar reflection calculation.")]
    public class ShadingProperty_Reflectance : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("shading_surface_name")]
public string ShadingSurfaceName { get; set; } = "";
        

[JsonProperty("diffuse_solar_reflectance_of_unglazed_part_of_shading_surface")]
public System.Nullable<float> DiffuseSolarReflectanceOfUnglazedPartOfShadingSurface { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("diffuse_visible_reflectance_of_unglazed_part_of_shading_surface")]
public System.Nullable<float> DiffuseVisibleReflectanceOfUnglazedPartOfShadingSurface { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_of_shading_surface_that_is_glazed")]
public System.Nullable<float> FractionOfShadingSurfaceThatIsGlazed { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Required if Fraction of Shading Surface That Is Glazed > 0.0")]
[JsonProperty("glazing_construction_name")]
public string GlazingConstructionName { get; set; } = "";
    }
}
