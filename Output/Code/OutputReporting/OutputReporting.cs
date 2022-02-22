namespace BH.oM.Adapters.EnergyPlus.OutputReporting
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
    
    
    [Description(@"Produces a list summarizing the output variables and meters that are available for reporting for the model being simulated (rdd output file). The list varies depending on the types of objects present in the idf file. For example, variables related to lights will only appear if a Lights object is present. The IDF option generates complete Output:Variable objects to simplify adding the desired output to the idf file.")]
    [JsonObject("Output:VariableDictionary")]
    public class Output_VariableDictionary : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("key_field")]
public Output_VariableDictionary_KeyField KeyField { get; set; } = (Output_VariableDictionary_KeyField)Enum.Parse(typeof(Output_VariableDictionary_KeyField), "Empty");
        

[JsonProperty("sort_option")]
public Output_VariableDictionary_SortOption SortOption { get; set; } = (Output_VariableDictionary_SortOption)Enum.Parse(typeof(Output_VariableDictionary_SortOption), "Name");
    }
    
    public enum Output_VariableDictionary_KeyField
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("IDF")]
        IDF = 1,
        
        [JsonProperty("regular")]
        Regular = 2,
    }
    
    public enum Output_VariableDictionary_SortOption
    {
        
        [JsonProperty("Name")]
        Name = 0,
        
        [JsonProperty("Unsorted")]
        Unsorted = 1,
    }
    
    [Description("Produces a report summarizing the details of surfaces in the eio output file.")]
    [JsonObject("Output:Surfaces:List")]
    public class Output_Surfaces_List : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("report_type")]
public Output_Surfaces_List_ReportType ReportType { get; set; } = (Output_Surfaces_List_ReportType)Enum.Parse(typeof(Output_Surfaces_List_ReportType), "CostInfo");
        

[Description("(IDF, only for Output:Surfaces:List, Lines report -- will print transformed coord" +
    "inates in IDF style)")]
[JsonProperty("report_specifications")]
public Output_Surfaces_List_ReportSpecifications ReportSpecifications { get; set; } = (Output_Surfaces_List_ReportSpecifications)Enum.Parse(typeof(Output_Surfaces_List_ReportSpecifications), "IDF");
    }
    
    public enum Output_Surfaces_List_ReportType
    {
        
        [JsonProperty("CostInfo")]
        CostInfo = 0,
        
        [JsonProperty("DecayCurvesFromComponentLoadsSummary")]
        DecayCurvesFromComponentLoadsSummary = 1,
        
        [JsonProperty("Details")]
        Details = 2,
        
        [JsonProperty("DetailsWithVertices")]
        DetailsWithVertices = 3,
        
        [JsonProperty("Lines")]
        Lines = 4,
        
        [JsonProperty("Vertices")]
        Vertices = 5,
        
        [JsonProperty("ViewFactorInfo")]
        ViewFactorInfo = 6,
    }
    
    public enum Output_Surfaces_List_ReportSpecifications
    {
        
        [JsonProperty("IDF")]
        IDF = 0,
    }
    
    [Description("Produces reports/files that are capable of rendering graphically or being importe" +
        "d into other programs. Rendering does not alter the actual inputs/surfaces.")]
    [JsonObject("Output:Surfaces:Drawing")]
    public class Output_Surfaces_Drawing : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("report_type")]
public Output_Surfaces_Drawing_ReportType ReportType { get; set; } = (Output_Surfaces_Drawing_ReportType)Enum.Parse(typeof(Output_Surfaces_Drawing_ReportType), "DXF");
        

[Description("Triangulate3DFace (default), ThickPolyline, RegularPolyline apply to DXF This fie" +
    "ld is ignored for DXF:WireFrame and VRML")]
[JsonProperty("report_specifications_1")]
public Output_Surfaces_Drawing_ReportSpecifications1 ReportSpecifications1 { get; set; } = (Output_Surfaces_Drawing_ReportSpecifications1)Enum.Parse(typeof(Output_Surfaces_Drawing_ReportSpecifications1), "Triangulate3DFace");
        

[Description("Use ColorScheme Name for DXF reports")]
[JsonProperty("report_specifications_2")]
public string ReportSpecifications2 { get; set; } = "";
    }
    
    public enum Output_Surfaces_Drawing_ReportType
    {
        
        [JsonProperty("DXF")]
        DXF = 0,
        
        [JsonProperty("DXF:WireFrame")]
        DXFWireFrame = 1,
        
        [JsonProperty("VRML")]
        VRML = 2,
    }
    
    public enum Output_Surfaces_Drawing_ReportSpecifications1
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("RegularPolyline")]
        RegularPolyline = 1,
        
        [JsonProperty("ThickPolyline")]
        ThickPolyline = 2,
        
        [JsonProperty("Triangulate3DFace")]
        Triangulate3DFace = 3,
    }
    
    [Description("Produces a condensed reporting that illustrates the full range of schedule values" +
        " in the eio output file. In the style of input: DaySchedule,  WeekSchedule, and " +
        "Annual Schedule.")]
    [JsonObject("Output:Schedules")]
    public class Output_Schedules : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("key_field")]
public Output_Schedules_KeyField KeyField { get; set; } = (Output_Schedules_KeyField)Enum.Parse(typeof(Output_Schedules_KeyField), "Hourly");
    }
    
    public enum Output_Schedules_KeyField
    {
        
        [JsonProperty("Hourly")]
        Hourly = 0,
        
        [JsonProperty("Timestep")]
        Timestep = 1,
    }
    
    [Description("Adds a report to the eio output file which shows details for each construction, i" +
        "ncluding overall properties, a list of material layers, and calculated results r" +
        "elated to conduction transfer functions.")]
    [JsonObject("Output:Constructions")]
    public class Output_Constructions : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("details_type_1")]
public Output_Constructions_DetailsType1 DetailsType1 { get; set; } = (Output_Constructions_DetailsType1)Enum.Parse(typeof(Output_Constructions_DetailsType1), "Constructions");
        

[JsonProperty("details_type_2")]
public Output_Constructions_DetailsType2 DetailsType2 { get; set; } = (Output_Constructions_DetailsType2)Enum.Parse(typeof(Output_Constructions_DetailsType2), "Constructions");
    }
    
    public enum Output_Constructions_DetailsType1
    {
        
        [JsonProperty("Constructions")]
        Constructions = 0,
        
        [JsonProperty("Materials")]
        Materials = 1,
    }
    
    public enum Output_Constructions_DetailsType2
    {
        
        [JsonProperty("Constructions")]
        Constructions = 0,
        
        [JsonProperty("Materials")]
        Materials = 1,
    }
    
    [Description("This object is used to control the output produced by the Energy Management Syste" +
        "m")]
    [JsonObject("Output:EnergyManagementSystem")]
    public class Output_EnergyManagementSystem : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("actuator_availability_dictionary_reporting")]
public Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting ActuatorAvailabilityDictionaryReporting { get; set; } = (Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting)Enum.Parse(typeof(Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting), "None");
        

[JsonProperty("internal_variable_availability_dictionary_reporting")]
public Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting InternalVariableAvailabilityDictionaryReporting { get; set; } = (Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting)Enum.Parse(typeof(Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting), "None");
        

[JsonProperty("ems_runtime_language_debug_output_level")]
public Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel EmsRuntimeLanguageDebugOutputLevel { get; set; } = (Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel)Enum.Parse(typeof(Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel), "None");
    }
    
    public enum Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("NotByUniqueKeyNames")]
        NotByUniqueKeyNames = 2,
        
        [JsonProperty("Verbose")]
        Verbose = 3,
    }
    
    public enum Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("NotByUniqueKeyNames")]
        NotByUniqueKeyNames = 2,
        
        [JsonProperty("Verbose")]
        Verbose = 3,
    }
    
    public enum Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ErrorsOnly")]
        ErrorsOnly = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Verbose")]
        Verbose = 3,
    }
    
    [Description(@"This object is used to set colors for reporting on various building elements particularly for the DXF reports. We know the user can enter 0 to 255 and the color map is available in DXF output. Therefore, we are limiting the colors in that range. You can extend by editing the IDD but you do so on your own. Colors not changed in any scheme will remain as the default scheme uses.")]
    [JsonObject("OutputControl:SurfaceColorScheme")]
    public class OutputControl_SurfaceColorScheme : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("drawing_element_1_type")]
public OutputControl_SurfaceColorScheme_DrawingElement1Type DrawingElement1Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement1Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement1Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_1")]
public System.Nullable<float> ColorForDrawingElement1 { get; set; } = null;
        

[JsonProperty("drawing_element_2_type")]
public OutputControl_SurfaceColorScheme_DrawingElement2Type DrawingElement2Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement2Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement2Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_2")]
public System.Nullable<float> ColorForDrawingElement2 { get; set; } = null;
        

[JsonProperty("drawing_element_3_type")]
public OutputControl_SurfaceColorScheme_DrawingElement3Type DrawingElement3Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement3Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement3Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_3")]
public System.Nullable<float> ColorForDrawingElement3 { get; set; } = null;
        

[JsonProperty("drawing_element_4_type")]
public OutputControl_SurfaceColorScheme_DrawingElement4Type DrawingElement4Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement4Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement4Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_4")]
public System.Nullable<float> ColorForDrawingElement4 { get; set; } = null;
        

[JsonProperty("drawing_element_5_type")]
public OutputControl_SurfaceColorScheme_DrawingElement5Type DrawingElement5Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement5Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement5Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_5")]
public System.Nullable<float> ColorForDrawingElement5 { get; set; } = null;
        

[JsonProperty("drawing_element_6_type")]
public OutputControl_SurfaceColorScheme_DrawingElement6Type DrawingElement6Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement6Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement6Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_6")]
public System.Nullable<float> ColorForDrawingElement6 { get; set; } = null;
        

[JsonProperty("drawing_element_7_type")]
public OutputControl_SurfaceColorScheme_DrawingElement7Type DrawingElement7Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement7Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement7Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_7")]
public System.Nullable<float> ColorForDrawingElement7 { get; set; } = null;
        

[JsonProperty("drawing_element_8_type")]
public OutputControl_SurfaceColorScheme_DrawingElement8Type DrawingElement8Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement8Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement8Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_8")]
public System.Nullable<float> ColorForDrawingElement8 { get; set; } = null;
        

[JsonProperty("drawing_element_9_type")]
public OutputControl_SurfaceColorScheme_DrawingElement9Type DrawingElement9Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement9Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement9Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_9")]
public System.Nullable<float> ColorForDrawingElement9 { get; set; } = null;
        

[JsonProperty("drawing_element_10_type")]
public OutputControl_SurfaceColorScheme_DrawingElement10Type DrawingElement10Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement10Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement10Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_10")]
public System.Nullable<float> ColorForDrawingElement10 { get; set; } = null;
        

[JsonProperty("drawing_element_11_type")]
public OutputControl_SurfaceColorScheme_DrawingElement11Type DrawingElement11Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement11Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement11Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_11")]
public System.Nullable<float> ColorForDrawingElement11 { get; set; } = null;
        

[JsonProperty("drawing_element_12_type")]
public OutputControl_SurfaceColorScheme_DrawingElement12Type DrawingElement12Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement12Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement12Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_12")]
public System.Nullable<float> ColorForDrawingElement12 { get; set; } = null;
        

[JsonProperty("drawing_element_13_type")]
public OutputControl_SurfaceColorScheme_DrawingElement13Type DrawingElement13Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement13Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement13Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_13")]
public System.Nullable<float> ColorForDrawingElement13 { get; set; } = null;
        

[JsonProperty("drawing_element_14_type")]
public OutputControl_SurfaceColorScheme_DrawingElement14Type DrawingElement14Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement14Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement14Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_14")]
public System.Nullable<float> ColorForDrawingElement14 { get; set; } = null;
        

[JsonProperty("drawing_element_15_type")]
public OutputControl_SurfaceColorScheme_DrawingElement15Type DrawingElement15Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement15Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement15Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_15")]
public System.Nullable<float> ColorForDrawingElement15 { get; set; } = null;
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement1Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement2Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement3Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement4Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement5Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement6Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement7Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement8Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement9Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement10Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement11Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement12Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement13Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement14Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement15Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
    
    [Description(@"This object allows the user to call report types that are predefined and will appear with the other tabular reports. These predefined reports are sensitive to the OutputControl:Table:Style object and appear in the same files as the tabular reports. The entries for this object is a list of the predefined reports that should appear in the tabular report output file.")]
    [JsonObject("Output:Table:SummaryReports")]
    public class Output_Table_SummaryReports : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("reports")]
public string Reports { get; set; } = "";
    }
    
    [Description("Produces a bin report in the table output file which shows the amount of time in " +
        "hours that occurs in different bins for a single specific output variable or met" +
        "er. Two different types of binning are reported: by month and by hour of the day" +
        ".")]
    [JsonObject("Output:Table:TimeBins")]
    public class Output_Table_TimeBins : BHoMObject, IEnergyPlusClass
    {
        

[Description("use \'*\' (without quotes) to apply this variable to all keys")]
[JsonProperty("key_value")]
public string KeyValue { get; set; } = (System.String)"*";
        

[JsonProperty("variable_name")]
public string VariableName { get; set; } = "";
        

[Description("The lowest value for the intervals being binned into.")]
[JsonProperty("interval_start")]
public System.Nullable<float> IntervalStart { get; set; } = null;
        

[Description("The size of the bins starting with Interval start.")]
[JsonProperty("interval_size")]
public System.Nullable<float> IntervalSize { get; set; } = null;
        

[Description("The number of bins used. The number of hours below the start of the Lowest bin an" +
    "d above the value of the last bin are also shown.")]
[JsonProperty("interval_count")]
public System.Nullable<float> IntervalCount { get; set; } = null;
        

[Description("Optional schedule name. Binning is performed for non-zero hours. Binning always p" +
    "erformed if left blank.")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description("Optional input on the type of units for the variable used by other fields in the " +
    "object.")]
[JsonProperty("variable_type")]
public Output_Table_TimeBins_VariableType VariableType { get; set; } = (Output_Table_TimeBins_VariableType)Enum.Parse(typeof(Output_Table_TimeBins_VariableType), "Energy");
    }
    
    public enum Output_Table_TimeBins_VariableType
    {
        
        [JsonProperty("Energy")]
        Energy = 0,
        
        [JsonProperty("Power")]
        Power = 1,
        
        [JsonProperty("Temperature")]
        Temperature = 2,
        
        [JsonProperty("VolumetricFlow")]
        VolumetricFlow = 3,
    }
    
    [Description(@"Provides a generic method of setting up tables of monthly results. The report has multiple columns that are each defined using a repeated group of fields for any number of columns. A single Output:Table:Monthly object often produces multiple tables in the output. A table is produced for every instance of a particular output variable. For example, a table defined with zone variables will be produced once for every zone.")]
    [JsonObject("Output:Table:Monthly")]
    public class Output_Table_Monthly : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("digits_after_decimal")]
public System.Nullable<float> DigitsAfterDecimal { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[JsonProperty("variable_details")]
public string VariableDetails { get; set; } = "";
    }
    
    [Description(@"Provides a generic method of setting up tables of annual results with one row per object. The report has multiple columns that are each defined using a repeated group of fields for any number of columns. A single Output:Table:Annual produces a single table in the output.")]
    [JsonObject("Output:Table:Annual")]
    public class Output_Table_Annual : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"An optional text string that is compared to the names of the objects referenced by the variables and if they match are included in the table. A footnote will appear that indicates that the objects shown may not be all the objects that of that type that occur in the file.")]
[JsonProperty("filter")]
public string Filter { get; set; } = "";
        

[Description("Optional schedule name. If left blank, aggregation is performed for all hours sim" +
    "ulated. If a schedule is specified, aggregation is performed for non-zero hours " +
    "in the schedule.")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[JsonProperty("variable_details")]
public string VariableDetails { get; set; } = "";
    }
    
    [Description(@"default style for the OutputControl:Table:Style is comma -- this works well for importing into spreadsheet programs such as Excel(tm) but not so well for word processing programs -- there tab may be a better choice. fixed puts spaces between the ""columns"". HTML produces tables in HTML. XML produces an XML file. note - if no OutputControl:Table:Style is included, the defaults are comma and None.")]
    [JsonObject("OutputControl:Table:Style")]
    public class OutputControl_Table_Style : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("column_separator")]
public OutputControl_Table_Style_ColumnSeparator ColumnSeparator { get; set; } = (OutputControl_Table_Style_ColumnSeparator)Enum.Parse(typeof(OutputControl_Table_Style_ColumnSeparator), "Comma");
        

[JsonProperty("unit_conversion")]
public OutputControl_Table_Style_UnitConversion UnitConversion { get; set; } = (OutputControl_Table_Style_UnitConversion)Enum.Parse(typeof(OutputControl_Table_Style_UnitConversion), "None");
    }
    
    public enum OutputControl_Table_Style_ColumnSeparator
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("All")]
        All = 1,
        
        [JsonProperty("Comma")]
        Comma = 2,
        
        [JsonProperty("CommaAndHTML")]
        CommaAndHTML = 3,
        
        [JsonProperty("CommaAndXML")]
        CommaAndXML = 4,
        
        [JsonProperty("Fixed")]
        Fixed = 5,
        
        [JsonProperty("HTML")]
        HTML = 6,
        
        [JsonProperty("Tab")]
        Tab = 7,
        
        [JsonProperty("TabAndHTML")]
        TabAndHTML = 8,
        
        [JsonProperty("XML")]
        XML = 9,
        
        [JsonProperty("XMLandHTML")]
        XMLandHTML = 10,
    }
    
    public enum OutputControl_Table_Style_UnitConversion
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("InchPound")]
        InchPound = 1,
        
        [JsonProperty("JtoGJ")]
        JtoGJ = 2,
        
        [JsonProperty("JtoKWH")]
        JtoKWH = 3,
        
        [JsonProperty("JtoMJ")]
        JtoMJ = 4,
        
        [JsonProperty("None")]
        None = 5,
    }
    
    [Description("Calculations of the time that setpoints are not met use a tolerance of 0.2C. This" +
        " object allows changing the tolerance used to determine when setpoints are being" +
        " met.")]
    [JsonObject("OutputControl:ReportingTolerances")]
    public class OutputControl_ReportingTolerances : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"If the zone temperature is below the heating setpoint by more than this value, the following output variables will increment as appropriate Zone Heating Setpoint Not Met Time Zone Heating Setpoint Not Met While Occupied Time This also impacts table report ""Annual Building Utility Performance Summary"" subtable ""Comfort and Setpoint Not Met Summary""")]
[JsonProperty("tolerance_for_time_heating_setpoint_not_met")]
public System.Nullable<float> ToleranceForTimeHeatingSetpointNotMet { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description(@"If the zone temperature is above the cooling setpoint by more than this value, the following output variables will increment as appropriate Zone Cooling Setpoint Not Met Time Zone Cooling Setpoint Not Met While Occupied Time This also impacts table report ""Annual Building Utility Performance Summary"" subtable ""Comfort and Setpoint Not Met Summary""")]
[JsonProperty("tolerance_for_time_cooling_setpoint_not_met")]
public System.Nullable<float> ToleranceForTimeCoolingSetpointNotMet { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
    
    [Description(@"each Output:Variable command picks variables to be put onto the standard output file (.eso) some variables may not be reported for every simulation. a list of variables that can be reported are available after a run on the report dictionary file (.rdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject("Output:Variable")]
    public class Output_Variable : BHoMObject, IEnergyPlusClass
    {
        

[Description("use \'*\' (without quotes) to apply this variable to all keys")]
[JsonProperty("key_value")]
public string KeyValue { get; set; } = (System.String)"*";
        

[JsonProperty("variable_name")]
public string VariableName { get; set; } = "";
        

[Description("Detailed lists every instance (i.e. HVAC variable timesteps) Timestep refers to t" +
    "he zone Timestep/Number of Timesteps in hour value RunPeriod and Environment are" +
    " the same")]
[JsonProperty("reporting_frequency")]
public Output_Variable_ReportingFrequency ReportingFrequency { get; set; } = (Output_Variable_ReportingFrequency)Enum.Parse(typeof(Output_Variable_ReportingFrequency), "Hourly");
        

[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
    }
    
    public enum Output_Variable_ReportingFrequency
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Annual")]
        Annual = 1,
        
        [JsonProperty("Daily")]
        Daily = 2,
        
        [JsonProperty("Detailed")]
        Detailed = 3,
        
        [JsonProperty("Environment")]
        Environment = 4,
        
        [JsonProperty("Hourly")]
        Hourly = 5,
        
        [JsonProperty("Monthly")]
        Monthly = 6,
        
        [JsonProperty("RunPeriod")]
        RunPeriod = 7,
        
        [JsonProperty("Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Each Output:Meter command picks meters to be put onto the standard output file (.eso) and meter file (.mtr). Not all meters are reported in every simulation. A list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject("Output:Meter")]
    public class Output_Meter : BHoMObject, IEnergyPlusClass
    {
        

[Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
    "e:..., e.g. GeneralLights:* for all General Lights Output:Meter puts results on " +
    "both the eplusout.mtr and eplusout.eso files")]
[JsonProperty("key_name")]
public string KeyName { get; set; } = "";
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same")]
[JsonProperty("reporting_frequency")]
public Output_Meter_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_ReportingFrequency)Enum.Parse(typeof(Output_Meter_ReportingFrequency), "Hourly");
    }
    
    public enum Output_Meter_ReportingFrequency
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Annual")]
        Annual = 1,
        
        [JsonProperty("Daily")]
        Daily = 2,
        
        [JsonProperty("Detailed")]
        Detailed = 3,
        
        [JsonProperty("Environment")]
        Environment = 4,
        
        [JsonProperty("Hourly")]
        Hourly = 5,
        
        [JsonProperty("Monthly")]
        Monthly = 6,
        
        [JsonProperty("RunPeriod")]
        RunPeriod = 7,
        
        [JsonProperty("Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Each Output:Meter:MeterFileOnly command picks meters to be put only onto meter file (.mtr). Not all meters are reported in every simulation. A list of meters that can be reported a list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject("Output:Meter:MeterFileOnly")]
    public class Output_Meter_MeterFileOnly : BHoMObject, IEnergyPlusClass
    {
        

[Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
    "e:..., e.g. GeneralLights:* for all General Lights Output:Meter:MeterFileOnly pu" +
    "ts results on the eplusout.mtr file only")]
[JsonProperty("key_name")]
public string KeyName { get; set; } = "";
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same")]
[JsonProperty("reporting_frequency")]
public Output_Meter_MeterFileOnly_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_MeterFileOnly_ReportingFrequency)Enum.Parse(typeof(Output_Meter_MeterFileOnly_ReportingFrequency), "Hourly");
    }
    
    public enum Output_Meter_MeterFileOnly_ReportingFrequency
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Annual")]
        Annual = 1,
        
        [JsonProperty("Daily")]
        Daily = 2,
        
        [JsonProperty("Detailed")]
        Detailed = 3,
        
        [JsonProperty("Environment")]
        Environment = 4,
        
        [JsonProperty("Hourly")]
        Hourly = 5,
        
        [JsonProperty("Monthly")]
        Monthly = 6,
        
        [JsonProperty("RunPeriod")]
        RunPeriod = 7,
        
        [JsonProperty("Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Each Output:Meter:Cumulative command picks meters to be reported cumulatively onto the standard output file (.eso) and meter file (.mtr). Not all meters are reported in every simulation. a list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject("Output:Meter:Cumulative")]
    public class Output_Meter_Cumulative : BHoMObject, IEnergyPlusClass
    {
        

[Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
    "e:..., e.g. GeneralLights:* for all General Lights Output:Meter:Cumulative puts " +
    "results on both the eplusout.mtr and eplusout.eso files")]
[JsonProperty("key_name")]
public string KeyName { get; set; } = "";
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same")]
[JsonProperty("reporting_frequency")]
public Output_Meter_Cumulative_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_Cumulative_ReportingFrequency)Enum.Parse(typeof(Output_Meter_Cumulative_ReportingFrequency), "Hourly");
    }
    
    public enum Output_Meter_Cumulative_ReportingFrequency
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Annual")]
        Annual = 1,
        
        [JsonProperty("Daily")]
        Daily = 2,
        
        [JsonProperty("Detailed")]
        Detailed = 3,
        
        [JsonProperty("Environment")]
        Environment = 4,
        
        [JsonProperty("Hourly")]
        Hourly = 5,
        
        [JsonProperty("Monthly")]
        Monthly = 6,
        
        [JsonProperty("RunPeriod")]
        RunPeriod = 7,
        
        [JsonProperty("Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Each Output:Meter:Cumulative:MeterFileOnly command picks meters to be reported cumulatively onto the standard output file (.eso) and meter file (.mtr). Not all meters are reported in every simulation. a list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject("Output:Meter:Cumulative:MeterFileOnly")]
    public class Output_Meter_Cumulative_MeterFileOnly : BHoMObject, IEnergyPlusClass
    {
        

[Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
    "e:..., e.g. GeneralLights:* for all General Lights Output:Meter:Cumulative:Meter" +
    "FileOnly puts results on the eplusout.mtr file only")]
[JsonProperty("key_name")]
public string KeyName { get; set; } = "";
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same")]
[JsonProperty("reporting_frequency")]
public Output_Meter_Cumulative_MeterFileOnly_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_Cumulative_MeterFileOnly_ReportingFrequency)Enum.Parse(typeof(Output_Meter_Cumulative_MeterFileOnly_ReportingFrequency), "Hourly");
    }
    
    public enum Output_Meter_Cumulative_MeterFileOnly_ReportingFrequency
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Annual")]
        Annual = 1,
        
        [JsonProperty("Daily")]
        Daily = 2,
        
        [JsonProperty("Detailed")]
        Detailed = 3,
        
        [JsonProperty("Environment")]
        Environment = 4,
        
        [JsonProperty("Hourly")]
        Hourly = 5,
        
        [JsonProperty("Monthly")]
        Monthly = 6,
        
        [JsonProperty("RunPeriod")]
        RunPeriod = 7,
        
        [JsonProperty("Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Used to allow users to combine specific variables and/or meters into ""custom"" meter configurations. To access these meters by name, one must first run a simulation to generate the RDD/MDD files and names. A Meter:Custom cannot reference another Meter:Custom.")]
    [JsonObject("Meter:Custom")]
    public class Meter_Custom : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("resource_type")]
public Meter_Custom_ResourceType ResourceType { get; set; } = (Meter_Custom_ResourceType)Enum.Parse(typeof(Meter_Custom_ResourceType), "Coal");
        

[JsonProperty("variable_details")]
public string VariableDetails { get; set; } = "";
    }
    
    public enum Meter_Custom_ResourceType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("DistrictCooling")]
        DistrictCooling = 2,
        
        [JsonProperty("DistrictHeating")]
        DistrictHeating = 3,
        
        [JsonProperty("Electricity")]
        Electricity = 4,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 5,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 6,
        
        [JsonProperty("Gasoline")]
        Gasoline = 7,
        
        [JsonProperty("Generic")]
        Generic = 8,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 9,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 10,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 11,
        
        [JsonProperty("Propane")]
        Propane = 12,
        
        [JsonProperty("Steam")]
        Steam = 13,
        
        [JsonProperty("Water")]
        Water = 14,
    }
    
    [Description("Used to allow users to combine specific variables and/or meters into \"custom\" met" +
        "er configurations. To access these meters by name, one must first run a simulati" +
        "on to generate the RDD/MDD files and names.")]
    [JsonObject("Meter:CustomDecrement")]
    public class Meter_CustomDecrement : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("resource_type")]
public Meter_CustomDecrement_ResourceType ResourceType { get; set; } = (Meter_CustomDecrement_ResourceType)Enum.Parse(typeof(Meter_CustomDecrement_ResourceType), "Coal");
        

[JsonProperty("source_meter_name")]
public string SourceMeterName { get; set; } = "";
        

[JsonProperty("variable_details")]
public string VariableDetails { get; set; } = "";
    }
    
    public enum Meter_CustomDecrement_ResourceType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("DistrictCooling")]
        DistrictCooling = 2,
        
        [JsonProperty("DistrictHeating")]
        DistrictHeating = 3,
        
        [JsonProperty("Electricity")]
        Electricity = 4,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 5,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 6,
        
        [JsonProperty("Gasoline")]
        Gasoline = 7,
        
        [JsonProperty("Generic")]
        Generic = 8,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 9,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 10,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 11,
        
        [JsonProperty("Propane")]
        Propane = 12,
        
        [JsonProperty("Steam")]
        Steam = 13,
        
        [JsonProperty("Water")]
        Water = 14,
    }
    
    [Description("Conditionally turn on/off output from EnergyPlus.")]
    [JsonObject("OutputControl:Files")]
    public class OutputControl_Files : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("output_csv")]
public EmptyNoYes OutputCsv { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("output_mtr")]
public EmptyNoYes OutputMtr { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_eso")]
public EmptyNoYes OutputEso { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_eio")]
public EmptyNoYes OutputEio { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_tabular")]
public EmptyNoYes OutputTabular { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_sqlite")]
public EmptyNoYes OutputSqlite { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_json")]
public EmptyNoYes OutputJson { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_audit")]
public EmptyNoYes OutputAudit { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_zone_sizing")]
public EmptyNoYes OutputZoneSizing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_system_sizing")]
public EmptyNoYes OutputSystemSizing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_dxf")]
public EmptyNoYes OutputDxf { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_bnd")]
public EmptyNoYes OutputBnd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_rdd")]
public EmptyNoYes OutputRdd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_mdd")]
public EmptyNoYes OutputMdd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_mtd")]
public EmptyNoYes OutputMtd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_end")]
public EmptyNoYes OutputEnd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_shd")]
public EmptyNoYes OutputShd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_dfs")]
public EmptyNoYes OutputDfs { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_glhe")]
public EmptyNoYes OutputGlhe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_delightin")]
public EmptyNoYes OutputDelightin { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_delighteldmp")]
public EmptyNoYes OutputDelighteldmp { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_delightdfdmp")]
public EmptyNoYes OutputDelightdfdmp { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_edd")]
public EmptyNoYes OutputEdd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_dbg")]
public EmptyNoYes OutputDbg { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_perflog")]
public EmptyNoYes OutputPerflog { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_sln")]
public EmptyNoYes OutputSln { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_sci")]
public EmptyNoYes OutputSci { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_wrl")]
public EmptyNoYes OutputWrl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_screen")]
public EmptyNoYes OutputScreen { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_extshd")]
public EmptyNoYes OutputExtshd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Not Implemented Yet")]
[JsonProperty("output_tarcog")]
public EmptyNoYes OutputTarcog { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
    
    [Description("Output from EnergyPlus can be written to JSON format files.")]
    [JsonObject("Output:JSON")]
    public class Output_JSON : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("option_type")]
public Output_JSON_OptionType OptionType { get; set; } = (Output_JSON_OptionType)Enum.Parse(typeof(Output_JSON_OptionType), "TimeSeries");
        

[JsonProperty("output_json")]
public EmptyNoYes OutputJson { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_cbor")]
public EmptyNoYes OutputCbor { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("output_messagepack")]
public EmptyNoYes OutputMessagepack { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
    
    public enum Output_JSON_OptionType
    {
        
        [JsonProperty("TimeSeries")]
        TimeSeries = 0,
        
        [JsonProperty("TimeSeriesAndTabular")]
        TimeSeriesAndTabular = 1,
    }
    
    [Description("Output from EnergyPlus can be written to an SQLite format file.")]
    [JsonObject("Output:SQLite")]
    public class Output_SQLite : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("option_type")]
public Output_SQLite_OptionType OptionType { get; set; } = (Output_SQLite_OptionType)Enum.Parse(typeof(Output_SQLite_OptionType), "Simple");
        

[Description("Unit conversion option used when writing SQLite Tabular Data This option applies " +
    "to TabularData and TabularDatawithString in the SQLite file")]
[JsonProperty("unit_conversion_for_tabular_data")]
public Output_SQLite_UnitConversionForTabularData UnitConversionForTabularData { get; set; } = (Output_SQLite_UnitConversionForTabularData)Enum.Parse(typeof(Output_SQLite_UnitConversionForTabularData), "UseOutputControlTableStyle");
    }
    
    public enum Output_SQLite_OptionType
    {
        
        [JsonProperty("Simple")]
        Simple = 0,
        
        [JsonProperty("SimpleAndTabular")]
        SimpleAndTabular = 1,
    }
    
    public enum Output_SQLite_UnitConversionForTabularData
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("InchPound")]
        InchPound = 1,
        
        [JsonProperty("JtoGJ")]
        JtoGJ = 2,
        
        [JsonProperty("JtoKWH")]
        JtoKWH = 3,
        
        [JsonProperty("JtoMJ")]
        JtoMJ = 4,
        
        [JsonProperty("None")]
        None = 5,
        
        [JsonProperty("UseOutputControlTableStyle")]
        UseOutputControlTableStyle = 6,
    }
    
    [Description("This is used to Automatically report the facility meters and turn on the Environm" +
        "ental Impact Report calculations for all of the Environmental Factors.")]
    [JsonObject("Output:EnvironmentalImpactFactors")]
    public class Output_EnvironmentalImpactFactors : BHoMObject, IEnergyPlusClass
    {
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same. Detailed is not a valid choice.")]
[JsonProperty("reporting_frequency")]
public Output_EnvironmentalImpactFactors_ReportingFrequency ReportingFrequency { get; set; } = (Output_EnvironmentalImpactFactors_ReportingFrequency)Enum.Parse(typeof(Output_EnvironmentalImpactFactors_ReportingFrequency), "Annual");
    }
    
    public enum Output_EnvironmentalImpactFactors_ReportingFrequency
    {
        
        [JsonProperty("Annual")]
        Annual = 0,
        
        [JsonProperty("Daily")]
        Daily = 1,
        
        [JsonProperty("Environment")]
        Environment = 2,
        
        [JsonProperty("Hourly")]
        Hourly = 3,
        
        [JsonProperty("Monthly")]
        Monthly = 4,
        
        [JsonProperty("RunPeriod")]
        RunPeriod = 5,
        
        [JsonProperty("Timestep")]
        Timestep = 6,
    }
    
    [Description("Used to help convert district and ideal energy use to a fuel type and provide tot" +
        "al carbon equivalent with coefficients Also used in Source=>Site conversions.")]
    [JsonObject("EnvironmentalImpactFactors")]
    public class EnvironmentalImpactFactors : BHoMObject, IEnergyPlusClass
    {
        

[Description("District heating efficiency used when converted to natural gas")]
[JsonProperty("district_heating_efficiency")]
public System.Nullable<float> DistrictHeatingEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[Description("District cooling COP used when converted to electricity")]
[JsonProperty("district_cooling_cop")]
public System.Nullable<float> DistrictCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Steam conversion efficiency used to convert steam usage to natural gas")]
[JsonProperty("steam_conversion_efficiency")]
public System.Nullable<float> SteamConversionEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

[JsonProperty("total_carbon_equivalent_emission_factor_from_n2o")]
public System.Nullable<float> TotalCarbonEquivalentEmissionFactorFromN2o { get; set; } = (System.Nullable<float>)Single.Parse("80.7272", CultureInfo.InvariantCulture);
        

[JsonProperty("total_carbon_equivalent_emission_factor_from_ch4")]
public System.Nullable<float> TotalCarbonEquivalentEmissionFactorFromCh4 { get; set; } = (System.Nullable<float>)Single.Parse("6.2727", CultureInfo.InvariantCulture);
        

[JsonProperty("total_carbon_equivalent_emission_factor_from_co2")]
public System.Nullable<float> TotalCarbonEquivalentEmissionFactorFromCo2 { get; set; } = (System.Nullable<float>)Single.Parse("0.2727", CultureInfo.InvariantCulture);
    }
    
    [Description("Provides Fuel Factors for Emissions as well as Source=>Site conversions. OtherFue" +
        "l1, OtherFuel2 provide options for users who want to create and use fuels that m" +
        "ay not be mainstream (biomass, wood, pellets).")]
    [JsonObject("FuelFactors")]
    public class FuelFactors : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("existing_fuel_resource_name")]
public FuelFactors_ExistingFuelResourceName ExistingFuelResourceName { get; set; } = (FuelFactors_ExistingFuelResourceName)Enum.Parse(typeof(FuelFactors_ExistingFuelResourceName), "Coal");
        

[JsonProperty("units_of_measure")]
public string UnitsOfMeasure { get; set; } = "";
        

[JsonProperty("energy_per_unit_factor")]
public System.Nullable<float> EnergyPerUnitFactor { get; set; } = null;
        

[JsonProperty("source_energy_factor")]
public System.Nullable<float> SourceEnergyFactor { get; set; } = null;
        

[JsonProperty("source_energy_schedule_name")]
public string SourceEnergyScheduleName { get; set; } = "";
        

[JsonProperty("co2_emission_factor")]
public System.Nullable<float> Co2EmissionFactor { get; set; } = null;
        

[JsonProperty("co2_emission_factor_schedule_name")]
public string Co2EmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("co_emission_factor")]
public System.Nullable<float> CoEmissionFactor { get; set; } = null;
        

[JsonProperty("co_emission_factor_schedule_name")]
public string CoEmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("ch4_emission_factor")]
public System.Nullable<float> Ch4EmissionFactor { get; set; } = null;
        

[JsonProperty("ch4_emission_factor_schedule_name")]
public string Ch4EmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("nox_emission_factor")]
public System.Nullable<float> NoxEmissionFactor { get; set; } = null;
        

[JsonProperty("nox_emission_factor_schedule_name")]
public string NoxEmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("n2o_emission_factor")]
public System.Nullable<float> N2oEmissionFactor { get; set; } = null;
        

[JsonProperty("n2o_emission_factor_schedule_name")]
public string N2oEmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("so2_emission_factor")]
public System.Nullable<float> So2EmissionFactor { get; set; } = null;
        

[JsonProperty("so2_emission_factor_schedule_name")]
public string So2EmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("pm_emission_factor")]
public System.Nullable<float> PmEmissionFactor { get; set; } = null;
        

[JsonProperty("pm_emission_factor_schedule_name")]
public string PmEmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("pm10_emission_factor")]
public System.Nullable<float> Pm10EmissionFactor { get; set; } = null;
        

[JsonProperty("pm10_emission_factor_schedule_name")]
public string Pm10EmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("pm2_5_emission_factor")]
public System.Nullable<float> Pm25EmissionFactor { get; set; } = null;
        

[JsonProperty("pm2_5_emission_factor_schedule_name")]
public string Pm25EmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("nh3_emission_factor")]
public System.Nullable<float> Nh3EmissionFactor { get; set; } = null;
        

[JsonProperty("nh3_emission_factor_schedule_name")]
public string Nh3EmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("nmvoc_emission_factor")]
public System.Nullable<float> NmvocEmissionFactor { get; set; } = null;
        

[JsonProperty("nmvoc_emission_factor_schedule_name")]
public string NmvocEmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("hg_emission_factor")]
public System.Nullable<float> HgEmissionFactor { get; set; } = null;
        

[JsonProperty("hg_emission_factor_schedule_name")]
public string HgEmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("pb_emission_factor")]
public System.Nullable<float> PbEmissionFactor { get; set; } = null;
        

[JsonProperty("pb_emission_factor_schedule_name")]
public string PbEmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("water_emission_factor")]
public System.Nullable<float> WaterEmissionFactor { get; set; } = null;
        

[JsonProperty("water_emission_factor_schedule_name")]
public string WaterEmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("nuclear_high_level_emission_factor")]
public System.Nullable<float> NuclearHighLevelEmissionFactor { get; set; } = null;
        

[JsonProperty("nuclear_high_level_emission_factor_schedule_name")]
public string NuclearHighLevelEmissionFactorScheduleName { get; set; } = "";
        

[JsonProperty("nuclear_low_level_emission_factor")]
public System.Nullable<float> NuclearLowLevelEmissionFactor { get; set; } = null;
        

[JsonProperty("nuclear_low_level_emission_factor_schedule_name")]
public string NuclearLowLevelEmissionFactorScheduleName { get; set; } = "";
    }
    
    public enum FuelFactors_ExistingFuelResourceName
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("Electricity")]
        Electricity = 2,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 3,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 4,
        
        [JsonProperty("Gasoline")]
        Gasoline = 5,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 6,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 7,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 8,
        
        [JsonProperty("Propane")]
        Propane = 9,
    }
    
    [Description("Special keys to produce certain warning messages or effect certain simulation cha" +
        "racteristics.")]
    [JsonObject("Output:Diagnostics")]
    public class Output_Diagnostics : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("diagnostics")]
public string Diagnostics { get; set; } = "";
    }
    
    [Description("switch eplusout.dbg file on or off")]
    [JsonObject("Output:DebuggingData")]
    public class Output_DebuggingData : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("report_debugging_data")]
public EmptyNoYes ReportDebuggingData { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("report_during_warmup")]
public EmptyNoYes ReportDuringWarmup { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
    
    [Description("This object does not come from a user input. This is generated by a pre-processor" +
        " so that various conditions can be gracefully passed on by the InputProcessor.")]
    [JsonObject("Output:PreprocessorMessage")]
    public class Output_PreprocessorMessage : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("preprocessor_name")]
public string PreprocessorName { get; set; } = "";
        

[Description("Depending on type, InputProcessor may terminate the program.")]
[JsonProperty("error_severity")]
public Output_PreprocessorMessage_ErrorSeverity ErrorSeverity { get; set; } = (Output_PreprocessorMessage_ErrorSeverity)Enum.Parse(typeof(Output_PreprocessorMessage_ErrorSeverity), "Fatal");
        

[JsonProperty("message_line_1")]
public string MessageLine1 { get; set; } = "";
        

[JsonProperty("message_line_2")]
public string MessageLine2 { get; set; } = "";
        

[JsonProperty("message_line_3")]
public string MessageLine3 { get; set; } = "";
        

[JsonProperty("message_line_4")]
public string MessageLine4 { get; set; } = "";
        

[JsonProperty("message_line_5")]
public string MessageLine5 { get; set; } = "";
        

[JsonProperty("message_line_6")]
public string MessageLine6 { get; set; } = "";
        

[JsonProperty("message_line_7")]
public string MessageLine7 { get; set; } = "";
        

[JsonProperty("message_line_8")]
public string MessageLine8 { get; set; } = "";
        

[JsonProperty("message_line_9")]
public string MessageLine9 { get; set; } = "";
        

[JsonProperty("message_line_10")]
public string MessageLine10 { get; set; } = "";
    }
    
    public enum Output_PreprocessorMessage_ErrorSeverity
    {
        
        [JsonProperty("Fatal")]
        Fatal = 0,
        
        [JsonProperty("Information")]
        Information = 1,
        
        [JsonProperty("Severe")]
        Severe = 2,
        
        [JsonProperty("Warning")]
        Warning = 3,
    }
}
