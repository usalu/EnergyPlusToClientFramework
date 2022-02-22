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
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_VariableDictionary : BHoMObject
    {
        

[JsonProperty("key_field")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_VariableDictionary_KeyField KeyField { get; set; } = (Output_VariableDictionary_KeyField)Enum.Parse(typeof(Output_VariableDictionary_KeyField), "Empty");
        

[JsonProperty("sort_option")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_VariableDictionary_SortOption SortOption { get; set; } = (Output_VariableDictionary_SortOption)Enum.Parse(typeof(Output_VariableDictionary_SortOption), "Name");
    }
    
    public enum Output_VariableDictionary_KeyField
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IDF")]
        IDF = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="regular")]
        Regular = 2,
    }
    
    public enum Output_VariableDictionary_SortOption
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Name")]
        Name = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Unsorted")]
        Unsorted = 1,
    }
    
    [Description("Produces a report summarizing the details of surfaces in the eio output file.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Surfaces_List : BHoMObject
    {
        

[JsonProperty("report_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Surfaces_List_ReportType ReportType { get; set; } = (Output_Surfaces_List_ReportType)Enum.Parse(typeof(Output_Surfaces_List_ReportType), "CostInfo");
        

[Description("(IDF, only for Output:Surfaces:List, Lines report -- will print transformed coord" +
    "inates in IDF style)")]
[JsonProperty("report_specifications")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Surfaces_List_ReportSpecifications ReportSpecifications { get; set; } = (Output_Surfaces_List_ReportSpecifications)Enum.Parse(typeof(Output_Surfaces_List_ReportSpecifications), "IDF");
    }
    
    public enum Output_Surfaces_List_ReportType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="CostInfo")]
        CostInfo = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DecayCurvesFromComponentLoadsSummary")]
        DecayCurvesFromComponentLoadsSummary = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Details")]
        Details = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetailsWithVertices")]
        DetailsWithVertices = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Lines")]
        Lines = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Vertices")]
        Vertices = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ViewFactorInfo")]
        ViewFactorInfo = 6,
    }
    
    public enum Output_Surfaces_List_ReportSpecifications
    {
        
        [System.Runtime.Serialization.EnumMember(Value="IDF")]
        IDF = 0,
    }
    
    [Description("Produces reports/files that are capable of rendering graphically or being importe" +
        "d into other programs. Rendering does not alter the actual inputs/surfaces.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Surfaces_Drawing : BHoMObject
    {
        

[JsonProperty("report_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Surfaces_Drawing_ReportType ReportType { get; set; } = (Output_Surfaces_Drawing_ReportType)Enum.Parse(typeof(Output_Surfaces_Drawing_ReportType), "DXF");
        

[Description("Triangulate3DFace (default), ThickPolyline, RegularPolyline apply to DXF This fie" +
    "ld is ignored for DXF:WireFrame and VRML")]
[JsonProperty("report_specifications_1")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Surfaces_Drawing_ReportSpecifications1 ReportSpecifications1 { get; set; } = (Output_Surfaces_Drawing_ReportSpecifications1)Enum.Parse(typeof(Output_Surfaces_Drawing_ReportSpecifications1), "Triangulate3DFace");
        

[Description("Use ColorScheme Name for DXF reports")]
[JsonProperty("report_specifications_2")]
public string ReportSpecifications2 { get; set; } = "";
    }
    
    public enum Output_Surfaces_Drawing_ReportType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="DXF")]
        DXF = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DXF:WireFrame")]
        DXFWireFrame = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="VRML")]
        VRML = 2,
    }
    
    public enum Output_Surfaces_Drawing_ReportSpecifications1
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="RegularPolyline")]
        RegularPolyline = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThickPolyline")]
        ThickPolyline = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Triangulate3DFace")]
        Triangulate3DFace = 3,
    }
    
    [Description("Produces a condensed reporting that illustrates the full range of schedule values" +
        " in the eio output file. In the style of input: DaySchedule,  WeekSchedule, and " +
        "Annual Schedule.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Schedules : BHoMObject
    {
        

[JsonProperty("key_field")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Schedules_KeyField KeyField { get; set; } = (Output_Schedules_KeyField)Enum.Parse(typeof(Output_Schedules_KeyField), "Hourly");
    }
    
    public enum Output_Schedules_KeyField
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 1,
    }
    
    [Description("Adds a report to the eio output file which shows details for each construction, i" +
        "ncluding overall properties, a list of material layers, and calculated results r" +
        "elated to conduction transfer functions.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Constructions : BHoMObject
    {
        

[JsonProperty("details_type_1")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Constructions_DetailsType1 DetailsType1 { get; set; } = (Output_Constructions_DetailsType1)Enum.Parse(typeof(Output_Constructions_DetailsType1), "Constructions");
        

[JsonProperty("details_type_2")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Constructions_DetailsType2 DetailsType2 { get; set; } = (Output_Constructions_DetailsType2)Enum.Parse(typeof(Output_Constructions_DetailsType2), "Constructions");
    }
    
    public enum Output_Constructions_DetailsType1
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Constructions")]
        Constructions = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Materials")]
        Materials = 1,
    }
    
    public enum Output_Constructions_DetailsType2
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Constructions")]
        Constructions = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Materials")]
        Materials = 1,
    }
    
    [Description("This object is used to control the output produced by the Energy Management Syste" +
        "m")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_EnergyManagementSystem : BHoMObject
    {
        

[JsonProperty("actuator_availability_dictionary_reporting")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting ActuatorAvailabilityDictionaryReporting { get; set; } = (Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting)Enum.Parse(typeof(Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting), "None");
        

[JsonProperty("internal_variable_availability_dictionary_reporting")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting InternalVariableAvailabilityDictionaryReporting { get; set; } = (Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting)Enum.Parse(typeof(Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting), "None");
        

[JsonProperty("ems_runtime_language_debug_output_level")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel EmsRuntimeLanguageDebugOutputLevel { get; set; } = (Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel)Enum.Parse(typeof(Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel), "None");
    }
    
    public enum Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NotByUniqueKeyNames")]
        NotByUniqueKeyNames = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Verbose")]
        Verbose = 3,
    }
    
    public enum Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NotByUniqueKeyNames")]
        NotByUniqueKeyNames = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Verbose")]
        Verbose = 3,
    }
    
    public enum Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ErrorsOnly")]
        ErrorsOnly = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Verbose")]
        Verbose = 3,
    }
    
    [Description(@"This object is used to set colors for reporting on various building elements particularly for the DXF reports. We know the user can enter 0 to 255 and the color map is available in DXF output. Therefore, we are limiting the colors in that range. You can extend by editing the IDD but you do so on your own. Colors not changed in any scheme will remain as the default scheme uses.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutputControl_SurfaceColorScheme : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("drawing_element_1_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement1Type DrawingElement1Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement1Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement1Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_1")]
public System.Nullable<float> ColorForDrawingElement1 { get; set; } = null;
        

[JsonProperty("drawing_element_2_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement2Type DrawingElement2Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement2Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement2Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_2")]
public System.Nullable<float> ColorForDrawingElement2 { get; set; } = null;
        

[JsonProperty("drawing_element_3_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement3Type DrawingElement3Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement3Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement3Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_3")]
public System.Nullable<float> ColorForDrawingElement3 { get; set; } = null;
        

[JsonProperty("drawing_element_4_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement4Type DrawingElement4Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement4Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement4Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_4")]
public System.Nullable<float> ColorForDrawingElement4 { get; set; } = null;
        

[JsonProperty("drawing_element_5_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement5Type DrawingElement5Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement5Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement5Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_5")]
public System.Nullable<float> ColorForDrawingElement5 { get; set; } = null;
        

[JsonProperty("drawing_element_6_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement6Type DrawingElement6Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement6Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement6Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_6")]
public System.Nullable<float> ColorForDrawingElement6 { get; set; } = null;
        

[JsonProperty("drawing_element_7_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement7Type DrawingElement7Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement7Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement7Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_7")]
public System.Nullable<float> ColorForDrawingElement7 { get; set; } = null;
        

[JsonProperty("drawing_element_8_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement8Type DrawingElement8Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement8Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement8Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_8")]
public System.Nullable<float> ColorForDrawingElement8 { get; set; } = null;
        

[JsonProperty("drawing_element_9_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement9Type DrawingElement9Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement9Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement9Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_9")]
public System.Nullable<float> ColorForDrawingElement9 { get; set; } = null;
        

[JsonProperty("drawing_element_10_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement10Type DrawingElement10Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement10Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement10Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_10")]
public System.Nullable<float> ColorForDrawingElement10 { get; set; } = null;
        

[JsonProperty("drawing_element_11_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement11Type DrawingElement11Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement11Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement11Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_11")]
public System.Nullable<float> ColorForDrawingElement11 { get; set; } = null;
        

[JsonProperty("drawing_element_12_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement12Type DrawingElement12Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement12Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement12Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_12")]
public System.Nullable<float> ColorForDrawingElement12 { get; set; } = null;
        

[JsonProperty("drawing_element_13_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement13Type DrawingElement13Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement13Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement13Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_13")]
public System.Nullable<float> ColorForDrawingElement13 { get; set; } = null;
        

[JsonProperty("drawing_element_14_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement14Type DrawingElement14Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement14Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement14Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_14")]
public System.Nullable<float> ColorForDrawingElement14 { get; set; } = null;
        

[JsonProperty("drawing_element_15_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_SurfaceColorScheme_DrawingElement15Type DrawingElement15Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement15Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement15Type), "AttachedBuildingShades");
        

[Description("use color number for output assignment (e.g. DXF)")]
[JsonProperty("color_for_drawing_element_15")]
public System.Nullable<float> ColorForDrawingElement15 { get; set; } = null;
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement1Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement2Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement3Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement4Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement5Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement6Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement7Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement8Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement9Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement10Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement11Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement12Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement13Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement14Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    public enum OutputControl_SurfaceColorScheme_DrawingElement15Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Doors")]
        Doors = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Floors")]
        Floors = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GlassDoors")]
        GlassDoors = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Photovoltaics")]
        Photovoltaics = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Roofs")]
        Roofs = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Text")]
        Text = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Walls")]
        Walls = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Windows")]
        Windows = 14,
    }
    
    [Description(@"This object allows the user to call report types that are predefined and will appear with the other tabular reports. These predefined reports are sensitive to the OutputControl:Table:Style object and appear in the same files as the tabular reports. The entries for this object is a list of the predefined reports that should appear in the tabular report output file.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_SummaryReports : BHoMObject
    {
        

[JsonProperty("reports")]
public string Reports { get; set; } = "";
    }
    
    [Description("Produces a bin report in the table output file which shows the amount of time in " +
        "hours that occurs in different bins for a single specific output variable or met" +
        "er. Two different types of binning are reported: by month and by hour of the day" +
        ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_TimeBins : BHoMObject
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
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Table_TimeBins_VariableType VariableType { get; set; } = (Output_Table_TimeBins_VariableType)Enum.Parse(typeof(Output_Table_TimeBins_VariableType), "Energy");
    }
    
    public enum Output_Table_TimeBins_VariableType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Energy")]
        Energy = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 3,
    }
    
    [Description(@"Provides a generic method of setting up tables of monthly results. The report has multiple columns that are each defined using a repeated group of fields for any number of columns. A single Output:Table:Monthly object often produces multiple tables in the output. A table is produced for every instance of a particular output variable. For example, a table defined with zone variables will be produced once for every zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_Monthly : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("digits_after_decimal")]
public System.Nullable<float> DigitsAfterDecimal { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[JsonProperty("variable_details")]
public string VariableDetails { get; set; } = "";
    }
    
    [Description(@"Provides a generic method of setting up tables of annual results with one row per object. The report has multiple columns that are each defined using a repeated group of fields for any number of columns. A single Output:Table:Annual produces a single table in the output.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_Annual : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

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
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutputControl_Table_Style : BHoMObject
    {
        

[JsonProperty("column_separator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_Table_Style_ColumnSeparator ColumnSeparator { get; set; } = (OutputControl_Table_Style_ColumnSeparator)Enum.Parse(typeof(OutputControl_Table_Style_ColumnSeparator), "Comma");
        

[JsonProperty("unit_conversion")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_Table_Style_UnitConversion UnitConversion { get; set; } = (OutputControl_Table_Style_UnitConversion)Enum.Parse(typeof(OutputControl_Table_Style_UnitConversion), "None");
    }
    
    public enum OutputControl_Table_Style_ColumnSeparator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="All")]
        All = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Comma")]
        Comma = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CommaAndHTML")]
        CommaAndHTML = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="CommaAndXML")]
        CommaAndXML = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="HTML")]
        HTML = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Tab")]
        Tab = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="TabAndHTML")]
        TabAndHTML = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="XML")]
        XML = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="XMLandHTML")]
        XMLandHTML = 10,
    }
    
    public enum OutputControl_Table_Style_UnitConversion
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="InchPound")]
        InchPound = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="JtoGJ")]
        JtoGJ = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="JtoKWH")]
        JtoKWH = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="JtoMJ")]
        JtoMJ = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 5,
    }
    
    [Description("Calculations of the time that setpoints are not met use a tolerance of 0.2C. This" +
        " object allows changing the tolerance used to determine when setpoints are being" +
        " met.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutputControl_ReportingTolerances : BHoMObject
    {
        

[Description(@"If the zone temperature is below the heating setpoint by more than this value, the following output variables will increment as appropriate Zone Heating Setpoint Not Met Time Zone Heating Setpoint Not Met While Occupied Time This also impacts table report ""Annual Building Utility Performance Summary"" subtable ""Comfort and Setpoint Not Met Summary""")]
[JsonProperty("tolerance_for_time_heating_setpoint_not_met")]
public System.Nullable<float> ToleranceForTimeHeatingSetpointNotMet { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description(@"If the zone temperature is above the cooling setpoint by more than this value, the following output variables will increment as appropriate Zone Cooling Setpoint Not Met Time Zone Cooling Setpoint Not Met While Occupied Time This also impacts table report ""Annual Building Utility Performance Summary"" subtable ""Comfort and Setpoint Not Met Summary""")]
[JsonProperty("tolerance_for_time_cooling_setpoint_not_met")]
public System.Nullable<float> ToleranceForTimeCoolingSetpointNotMet { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
    
    [Description(@"each Output:Variable command picks variables to be put onto the standard output file (.eso) some variables may not be reported for every simulation. a list of variables that can be reported are available after a run on the report dictionary file (.rdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Variable : BHoMObject
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
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Variable_ReportingFrequency ReportingFrequency { get; set; } = (Output_Variable_ReportingFrequency)Enum.Parse(typeof(Output_Variable_ReportingFrequency), "Hourly");
        

[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
    }
    
    public enum Output_Variable_ReportingFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Annual")]
        Annual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Daily")]
        Daily = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Detailed")]
        Detailed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Environment")]
        Environment = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Monthly")]
        Monthly = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="RunPeriod")]
        RunPeriod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Each Output:Meter command picks meters to be put onto the standard output file (.eso) and meter file (.mtr). Not all meters are reported in every simulation. A list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Meter : BHoMObject
    {
        

[Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
    "e:..., e.g. GeneralLights:* for all General Lights Output:Meter puts results on " +
    "both the eplusout.mtr and eplusout.eso files")]
[JsonProperty("key_name")]
public string KeyName { get; set; } = "";
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same")]
[JsonProperty("reporting_frequency")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Meter_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_ReportingFrequency)Enum.Parse(typeof(Output_Meter_ReportingFrequency), "Hourly");
    }
    
    public enum Output_Meter_ReportingFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Annual")]
        Annual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Daily")]
        Daily = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Detailed")]
        Detailed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Environment")]
        Environment = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Monthly")]
        Monthly = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="RunPeriod")]
        RunPeriod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Each Output:Meter:MeterFileOnly command picks meters to be put only onto meter file (.mtr). Not all meters are reported in every simulation. A list of meters that can be reported a list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Meter_MeterFileOnly : BHoMObject
    {
        

[Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
    "e:..., e.g. GeneralLights:* for all General Lights Output:Meter:MeterFileOnly pu" +
    "ts results on the eplusout.mtr file only")]
[JsonProperty("key_name")]
public string KeyName { get; set; } = "";
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same")]
[JsonProperty("reporting_frequency")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Meter_MeterFileOnly_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_MeterFileOnly_ReportingFrequency)Enum.Parse(typeof(Output_Meter_MeterFileOnly_ReportingFrequency), "Hourly");
    }
    
    public enum Output_Meter_MeterFileOnly_ReportingFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Annual")]
        Annual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Daily")]
        Daily = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Detailed")]
        Detailed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Environment")]
        Environment = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Monthly")]
        Monthly = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="RunPeriod")]
        RunPeriod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Each Output:Meter:Cumulative command picks meters to be reported cumulatively onto the standard output file (.eso) and meter file (.mtr). Not all meters are reported in every simulation. a list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Meter_Cumulative : BHoMObject
    {
        

[Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
    "e:..., e.g. GeneralLights:* for all General Lights Output:Meter:Cumulative puts " +
    "results on both the eplusout.mtr and eplusout.eso files")]
[JsonProperty("key_name")]
public string KeyName { get; set; } = "";
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same")]
[JsonProperty("reporting_frequency")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Meter_Cumulative_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_Cumulative_ReportingFrequency)Enum.Parse(typeof(Output_Meter_Cumulative_ReportingFrequency), "Hourly");
    }
    
    public enum Output_Meter_Cumulative_ReportingFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Annual")]
        Annual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Daily")]
        Daily = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Detailed")]
        Detailed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Environment")]
        Environment = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Monthly")]
        Monthly = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="RunPeriod")]
        RunPeriod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Each Output:Meter:Cumulative:MeterFileOnly command picks meters to be reported cumulatively onto the standard output file (.eso) and meter file (.mtr). Not all meters are reported in every simulation. a list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Meter_Cumulative_MeterFileOnly : BHoMObject
    {
        

[Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
    "e:..., e.g. GeneralLights:* for all General Lights Output:Meter:Cumulative:Meter" +
    "FileOnly puts results on the eplusout.mtr file only")]
[JsonProperty("key_name")]
public string KeyName { get; set; } = "";
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same")]
[JsonProperty("reporting_frequency")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_Meter_Cumulative_MeterFileOnly_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_Cumulative_MeterFileOnly_ReportingFrequency)Enum.Parse(typeof(Output_Meter_Cumulative_MeterFileOnly_ReportingFrequency), "Hourly");
    }
    
    public enum Output_Meter_Cumulative_MeterFileOnly_ReportingFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Annual")]
        Annual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Daily")]
        Daily = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Detailed")]
        Detailed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Environment")]
        Environment = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Monthly")]
        Monthly = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="RunPeriod")]
        RunPeriod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 8,
    }
    
    [Description(@"Used to allow users to combine specific variables and/or meters into ""custom"" meter configurations. To access these meters by name, one must first run a simulation to generate the RDD/MDD files and names. A Meter:Custom cannot reference another Meter:Custom.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Meter_Custom : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("resource_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Meter_Custom_ResourceType ResourceType { get; set; } = (Meter_Custom_ResourceType)Enum.Parse(typeof(Meter_Custom_ResourceType), "Coal");
        

[JsonProperty("variable_details")]
public string VariableDetails { get; set; } = "";
    }
    
    public enum Meter_Custom_ResourceType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictCooling")]
        DistrictCooling = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Generic")]
        Generic = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Water")]
        Water = 14,
    }
    
    [Description("Used to allow users to combine specific variables and/or meters into \"custom\" met" +
        "er configurations. To access these meters by name, one must first run a simulati" +
        "on to generate the RDD/MDD files and names.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Meter_CustomDecrement : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("resource_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Meter_CustomDecrement_ResourceType ResourceType { get; set; } = (Meter_CustomDecrement_ResourceType)Enum.Parse(typeof(Meter_CustomDecrement_ResourceType), "Coal");
        

[JsonProperty("source_meter_name")]
public string SourceMeterName { get; set; } = "";
        

[JsonProperty("variable_details")]
public string VariableDetails { get; set; } = "";
    }
    
    public enum Meter_CustomDecrement_ResourceType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictCooling")]
        DistrictCooling = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Generic")]
        Generic = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Water")]
        Water = 14,
    }
    
    [Description("Conditionally turn on/off output from EnergyPlus.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutputControl_Files : BHoMObject
    {
        

[JsonProperty("output_csv")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputCsv { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("output_mtr")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputMtr { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_eso")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputEso { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_eio")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputEio { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_tabular")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputTabular { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_sqlite")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputSqlite { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_json")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputJson { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_audit")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputAudit { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_zone_sizing")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputZoneSizing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_system_sizing")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputSystemSizing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_dxf")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputDxf { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_bnd")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputBnd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_rdd")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputRdd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_mdd")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputMdd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_mtd")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputMtd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_end")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputEnd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_shd")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputShd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_dfs")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputDfs { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_glhe")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputGlhe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_delightin")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputDelightin { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_delighteldmp")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputDelighteldmp { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_delightdfdmp")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputDelightdfdmp { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_edd")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputEdd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_dbg")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputDbg { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_perflog")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputPerflog { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_sln")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputSln { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_sci")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputSci { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_wrl")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputWrl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_screen")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputScreen { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_extshd")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputExtshd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Not Implemented Yet")]
[JsonProperty("output_tarcog")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputTarcog { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
    
    [Description("Output from EnergyPlus can be written to JSON format files.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_JSON : BHoMObject
    {
        

[JsonProperty("option_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_JSON_OptionType OptionType { get; set; } = (Output_JSON_OptionType)Enum.Parse(typeof(Output_JSON_OptionType), "TimeSeries");
        

[JsonProperty("output_json")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputJson { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("output_cbor")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputCbor { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("output_messagepack")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputMessagepack { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
    
    public enum Output_JSON_OptionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="TimeSeries")]
        TimeSeries = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="TimeSeriesAndTabular")]
        TimeSeriesAndTabular = 1,
    }
    
    [Description("Output from EnergyPlus can be written to an SQLite format file.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_SQLite : BHoMObject
    {
        

[JsonProperty("option_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_SQLite_OptionType OptionType { get; set; } = (Output_SQLite_OptionType)Enum.Parse(typeof(Output_SQLite_OptionType), "Simple");
        

[Description("Unit conversion option used when writing SQLite Tabular Data This option applies " +
    "to TabularData and TabularDatawithString in the SQLite file")]
[JsonProperty("unit_conversion_for_tabular_data")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_SQLite_UnitConversionForTabularData UnitConversionForTabularData { get; set; } = (Output_SQLite_UnitConversionForTabularData)Enum.Parse(typeof(Output_SQLite_UnitConversionForTabularData), "UseOutputControlTableStyle");
    }
    
    public enum Output_SQLite_OptionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Simple")]
        Simple = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleAndTabular")]
        SimpleAndTabular = 1,
    }
    
    public enum Output_SQLite_UnitConversionForTabularData
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="InchPound")]
        InchPound = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="JtoGJ")]
        JtoGJ = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="JtoKWH")]
        JtoKWH = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="JtoMJ")]
        JtoMJ = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="UseOutputControlTableStyle")]
        UseOutputControlTableStyle = 6,
    }
    
    [Description("This is used to Automatically report the facility meters and turn on the Environm" +
        "ental Impact Report calculations for all of the Environmental Factors.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_EnvironmentalImpactFactors : BHoMObject
    {
        

[Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
    "and Environment are the same. Detailed is not a valid choice.")]
[JsonProperty("reporting_frequency")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_EnvironmentalImpactFactors_ReportingFrequency ReportingFrequency { get; set; } = (Output_EnvironmentalImpactFactors_ReportingFrequency)Enum.Parse(typeof(Output_EnvironmentalImpactFactors_ReportingFrequency), "Annual");
    }
    
    public enum Output_EnvironmentalImpactFactors_ReportingFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Annual")]
        Annual = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Daily")]
        Daily = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Environment")]
        Environment = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Monthly")]
        Monthly = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="RunPeriod")]
        RunPeriod = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 6,
    }
    
    [Description("Used to help convert district and ideal energy use to a fuel type and provide tot" +
        "al carbon equivalent with coefficients Also used in Source=>Site conversions.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnvironmentalImpactFactors : BHoMObject
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
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FuelFactors : BHoMObject
    {
        

[JsonProperty("existing_fuel_resource_name")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 9,
    }
    
    [Description("Special keys to produce certain warning messages or effect certain simulation cha" +
        "racteristics.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Diagnostics : BHoMObject
    {
        

[JsonProperty("diagnostics")]
public string Diagnostics { get; set; } = "";
    }
    
    [Description("switch eplusout.dbg file on or off")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_DebuggingData : BHoMObject
    {
        

[JsonProperty("report_debugging_data")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes ReportDebuggingData { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("report_during_warmup")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes ReportDuringWarmup { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
    
    [Description("This object does not come from a user input. This is generated by a pre-processor" +
        " so that various conditions can be gracefully passed on by the InputProcessor.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_PreprocessorMessage : BHoMObject
    {
        

[JsonProperty("preprocessor_name")]
public string PreprocessorName { get; set; } = "";
        

[Description("Depending on type, InputProcessor may terminate the program.")]
[JsonProperty("error_severity")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        
        [System.Runtime.Serialization.EnumMember(Value="Fatal")]
        Fatal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Information")]
        Information = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Severe")]
        Severe = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Warning")]
        Warning = 3,
    }
}
