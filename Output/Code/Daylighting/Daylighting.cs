namespace BH.oM.Adapters.EnergyPlus.Daylighting
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
    
    
    [Description("Dimming of overhead electric lighting is determined from each reference point. Gl" +
        "are from daylighting is also calculated.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Daylighting_Controls : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("daylighting_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Daylighting_Controls_DaylightingMethod DaylightingMethod { get; set; } = (Daylighting_Controls_DaylightingMethod)Enum.Parse(typeof(Daylighting_Controls_DaylightingMethod), "SplitFlux");
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("lighting_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Daylighting_Controls_LightingControlType LightingControlType { get; set; } = (Daylighting_Controls_LightingControlType)Enum.Parse(typeof(Daylighting_Controls_LightingControlType), "Continuous");
        

[JsonProperty("minimum_input_power_fraction_for_continuous_or_continuousoff_dimming_control")]
public System.Nullable<float> MinimumInputPowerFractionForContinuousOrContinuousoffDimmingControl { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_light_output_fraction_for_continuous_or_continuousoff_dimming_control")]
public System.Nullable<float> MinimumLightOutputFractionForContinuousOrContinuousoffDimmingControl { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("The number of steps, excluding off, in a stepped lighting control system. If Ligh" +
    "ting Control Type is Stepped, this field must be greater than zero. The steps ar" +
    "e assumed to be equally spaced.")]
[JsonProperty("number_of_stepped_control_steps")]
public System.Nullable<float> NumberOfSteppedControlSteps { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("probability_lighting_will_be_reset_when_needed_in_manual_stepped_control")]
public System.Nullable<float> ProbabilityLightingWillBeResetWhenNeededInManualSteppedControl { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("glare_calculation_daylighting_reference_point_name")]
public string GlareCalculationDaylightingReferencePointName { get; set; } = "";
        

[JsonProperty("glare_calculation_azimuth_angle_of_view_direction_clockwise_from_zone_y_axis")]
public System.Nullable<float> GlareCalculationAzimuthAngleOfViewDirectionClockwiseFromZoneYAxis { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The default is for general office work")]
[JsonProperty("maximum_allowable_discomfort_glare_index")]
public System.Nullable<float> MaximumAllowableDiscomfortGlareIndex { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description(@"Maximum surface area for nodes in gridding all surfaces in the DElight zone. All reflective and transmitting surfaces will be subdivided into approximately square nodes that do not exceed this maximum. Higher resolution subdivisions require greater calculation times, but generally produce more accurate results.")]
[JsonProperty("delight_gridding_resolution")]
public System.Nullable<float> DelightGriddingResolution { get; set; } = null;
        

[JsonProperty("control_data")]
public string ControlData { get; set; } = "";
    }
    
    public enum Daylighting_Controls_DaylightingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DElight")]
        DElight = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SplitFlux")]
        SplitFlux = 2,
    }
    
    public enum Daylighting_Controls_LightingControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Continuous")]
        Continuous = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ContinuousOff")]
        ContinuousOff = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Stepped")]
        Stepped = 3,
    }
    
    [Description("Used by Daylighting:Controls to identify the reference point coordinates for each" +
        " sensor. Reference points are given in coordinates specified in the GlobalGeomet" +
        "ryRules object Daylighting Reference Point CoordinateSystem field")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Daylighting_ReferencePoint : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("x_coordinate_of_reference_point")]
public System.Nullable<float> XCoordinateOfReferencePoint { get; set; } = null;
        

[JsonProperty("y_coordinate_of_reference_point")]
public System.Nullable<float> YCoordinateOfReferencePoint { get; set; } = null;
        

[JsonProperty("z_coordinate_of_reference_point")]
public System.Nullable<float> ZCoordinateOfReferencePoint { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
    }
    
    [Description("Used for DElight Complex Fenestration of all types")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Daylighting_DELight_ComplexFenestration : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Used to select the appropriate Complex Fenestration BTDF data")]
[JsonProperty("complex_fenestration_type")]
public string ComplexFenestrationType { get; set; } = "";
        

[Description("This is a reference to a valid surface object (such as BuildingSurface:Detailed) " +
    "hosting this complex fenestration, analogous to the base surface Name field for " +
    "subsurfaces such as Windows.")]
[JsonProperty("building_surface_name")]
public string BuildingSurfaceName { get; set; } = "";
        

[Description("This is a reference to a valid FenestrationSurface:Detailed window object used to" +
    " account for the geometry, and the solar and thermal gains/losses, of the Comple" +
    "x Fenestration")]
[JsonProperty("window_name")]
public string WindowName { get; set; } = "";
        

[Description(@"In-plane counter-clockwise rotation angle of the Complex Fenestration optical reference direction and the base edge of the Complex Fenestration. The Rotation will typically be zero when the host and CFS surfaces are rectangular and height and width edges are aligned.")]
[JsonProperty("fenestration_rotation")]
public System.Nullable<float> FenestrationRotation { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("Defines a tubular daylighting device (TDD) consisting of three components: a dome" +
        ", a pipe, and a diffuser. The dome and diffuser are defined separately using the" +
        " FenestrationSurface:Detailed object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DaylightingDevice_Tubular : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("This must refer to a subsurface object of type TubularDaylightDome")]
[JsonProperty("dome_name")]
public string DomeName { get; set; } = "";
        

[Description("This must refer to a subsurface object of type TubularDaylightDiffuser Delivery z" +
    "one is specified in the diffuser object")]
[JsonProperty("diffuser_name")]
public string DiffuserName { get; set; } = "";
        

[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[JsonProperty("diameter")]
public System.Nullable<float> Diameter { get; set; } = null;
        

[Description("The exterior exposed length is the difference between total and sum of zone lengt" +
    "hs")]
[JsonProperty("total_length")]
public System.Nullable<float> TotalLength { get; set; } = null;
        

[Description("R value between TubularDaylightDome and TubularDaylightDiffuser")]
[JsonProperty("effective_thermal_resistance")]
public System.Nullable<float> EffectiveThermalResistance { get; set; } = (System.Nullable<float>)Single.Parse("0.28", CultureInfo.InvariantCulture);
        

[JsonProperty("transition_lengths")]
public string TransitionLengths { get; set; } = "";
    }
    
    [Description("Defines a daylighting which can have an inside shelf, an outside shelf, or both. " +
        "The inside shelf is defined as a building surface and the outside shelf is defin" +
        "ed as a shading surface.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DaylightingDevice_Shelf : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("window_name")]
public string WindowName { get; set; } = "";
        

[Description("This must refer to a BuildingSurface:Detailed or equivalent object This surface m" +
    "ust be its own Surface for other side boundary conditions.")]
[JsonProperty("inside_shelf_name")]
public string InsideShelfName { get; set; } = "";
        

[Description("This must refer to a Shading:Zone:Detailed object")]
[JsonProperty("outside_shelf_name")]
public string OutsideShelfName { get; set; } = "";
        

[Description("Required if outside shelf is specified")]
[JsonProperty("outside_shelf_construction_name")]
public string OutsideShelfConstructionName { get; set; } = "";
        

[JsonProperty("view_factor_to_outside_shelf")]
public System.Nullable<float> ViewFactorToOutsideShelf { get; set; } = null;
    }
    
    [Description("Applies only to exterior windows in daylighting-controlled zones or in zones that" +
        " share an interior window with a daylighting-controlled  zone. Generally used wi" +
        "th skylights.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DaylightingDevice_LightWell : BHoMObject
    {
        

[JsonProperty("exterior_window_name")]
public string ExteriorWindowName { get; set; } = "";
        

[Description("Distance from Bottom of Window to Bottom of Well")]
[JsonProperty("height_of_well")]
public System.Nullable<float> HeightOfWell { get; set; } = null;
        

[JsonProperty("perimeter_of_bottom_of_well")]
public System.Nullable<float> PerimeterOfBottomOfWell { get; set; } = null;
        

[JsonProperty("area_of_bottom_of_well")]
public System.Nullable<float> AreaOfBottomOfWell { get; set; } = null;
        

[JsonProperty("visible_reflectance_of_well_walls")]
public System.Nullable<float> VisibleReflectanceOfWellWalls { get; set; } = null;
    }
    
    [Description("Reports hourly daylight factors for each exterior window for four sky types (clea" +
        "r, turbid clear, intermediate, and overcast).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_DaylightFactors : BHoMObject
    {
        

[JsonProperty("reporting_days")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Output_DaylightFactors_ReportingDays ReportingDays { get; set; } = (Output_DaylightFactors_ReportingDays)Enum.Parse(typeof(Output_DaylightFactors_ReportingDays), "AllShadowCalculationDays");
    }
    
    public enum Output_DaylightFactors_ReportingDays
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AllShadowCalculationDays")]
        AllShadowCalculationDays = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SizingDays")]
        SizingDays = 1,
    }
    
    [Description("reference points are given in coordinates specified in the GlobalGeometryRules ob" +
        "ject Daylighting Reference Point CoordinateSystem field")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_IlluminanceMap : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("z_height")]
public System.Nullable<float> ZHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("x_minimum_coordinate")]
public System.Nullable<float> XMinimumCoordinate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("x_maximum_coordinate")]
public System.Nullable<float> XMaximumCoordinate { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Maximum number of total grid points must be <= 2500 (X*Y)")]
[JsonProperty("number_of_x_grid_points")]
public System.Nullable<float> NumberOfXGridPoints { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[JsonProperty("y_minimum_coordinate")]
public System.Nullable<float> YMinimumCoordinate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("y_maximum_coordinate")]
public System.Nullable<float> YMaximumCoordinate { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Maximum number of total grid points must be <= 2500 (X*Y)")]
[JsonProperty("number_of_y_grid_points")]
public System.Nullable<float> NumberOfYGridPoints { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
    
    [Description(@"default style for the Daylighting Illuminance Map is comma -- this works well for importing into spreadsheet programs such as Excel(tm) but not so well for word processing programs -- there tab may be a better choice. fixed puts spaces between the ""columns""")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutputControl_IlluminanceMap_Style : BHoMObject
    {
        

[JsonProperty("column_separator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_IlluminanceMap_Style_ColumnSeparator ColumnSeparator { get; set; } = (OutputControl_IlluminanceMap_Style_ColumnSeparator)Enum.Parse(typeof(OutputControl_IlluminanceMap_Style_ColumnSeparator), "Comma");
    }
    
    public enum OutputControl_IlluminanceMap_Style_ColumnSeparator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Comma")]
        Comma = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Tab")]
        Tab = 3,
    }
}
