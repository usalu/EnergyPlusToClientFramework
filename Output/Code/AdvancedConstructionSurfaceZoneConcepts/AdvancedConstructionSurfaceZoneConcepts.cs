namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
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
    
    
    [Description(@"Determines which Heat Balance Algorithm will be used for a specific surface Allows selectively overriding the global setting in HeatBalanceAlgorithm CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    [JsonObject("SurfaceProperty:HeatTransferAlgorithm")]
    public class SurfaceProperty_HeatTransferAlgorithm : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[JsonProperty("algorithm")]
public SurfaceProperty_HeatTransferAlgorithm_Algorithm Algorithm { get; set; } = (SurfaceProperty_HeatTransferAlgorithm_Algorithm)Enum.Parse(typeof(SurfaceProperty_HeatTransferAlgorithm_Algorithm), "ConductionTransferFunction");
    }
    
    public enum SurfaceProperty_HeatTransferAlgorithm_Algorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CombinedHeatAndMoistureFiniteElement")]
        CombinedHeatAndMoistureFiniteElement = 1,
        
        [JsonProperty("ConductionFiniteDifference")]
        ConductionFiniteDifference = 2,
        
        [JsonProperty("ConductionTransferFunction")]
        ConductionTransferFunction = 3,
        
        [JsonProperty("MoisturePenetrationDepthConductionTransferFunction")]
        MoisturePenetrationDepthConductionTransferFunction = 4,
    }
    
    [Description(@"Determines which Heat Balance Algorithm will be used for a group of surface types Allows selectively overriding the global setting in HeatBalanceAlgorithm CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    [JsonObject("SurfaceProperty:HeatTransferAlgorithm:MultipleSurface")]
    public class SurfaceProperty_HeatTransferAlgorithm_MultipleSurface : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_type")]
public SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_SurfaceType SurfaceType { get; set; } = (SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_SurfaceType)Enum.Parse(typeof(SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_SurfaceType), "AllExteriorFloors");
        

[JsonProperty("algorithm")]
public SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_Algorithm Algorithm { get; set; } = (SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_Algorithm)Enum.Parse(typeof(SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_Algorithm), "ConductionTransferFunction");
    }
    
    public enum SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_SurfaceType
    {
        
        [JsonProperty("AllExteriorFloors")]
        AllExteriorFloors = 0,
        
        [JsonProperty("AllExteriorRoofs")]
        AllExteriorRoofs = 1,
        
        [JsonProperty("AllExteriorSurfaces")]
        AllExteriorSurfaces = 2,
        
        [JsonProperty("AllExteriorWalls")]
        AllExteriorWalls = 3,
        
        [JsonProperty("AllGroundContactSurfaces")]
        AllGroundContactSurfaces = 4,
        
        [JsonProperty("AllInteriorCeilings")]
        AllInteriorCeilings = 5,
        
        [JsonProperty("AllInteriorFloors")]
        AllInteriorFloors = 6,
        
        [JsonProperty("AllInteriorSurfaces")]
        AllInteriorSurfaces = 7,
        
        [JsonProperty("AllInteriorWalls")]
        AllInteriorWalls = 8,
    }
    
    public enum SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_Algorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CombinedHeatAndMoistureFiniteElement")]
        CombinedHeatAndMoistureFiniteElement = 1,
        
        [JsonProperty("ConductionFiniteDifference")]
        ConductionFiniteDifference = 2,
        
        [JsonProperty("ConductionTransferFunction")]
        ConductionTransferFunction = 3,
        
        [JsonProperty("MoisturePenetrationDepthConductionTransferFunction")]
        MoisturePenetrationDepthConductionTransferFunction = 4,
    }
    
    [Description(@"Determines which Heat Balance Algorithm will be used for a list of surfaces Allows selectively overriding the global setting in HeatBalanceAlgorithm CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    [JsonObject("SurfaceProperty:HeatTransferAlgorithm:SurfaceList")]
    public class SurfaceProperty_HeatTransferAlgorithm_SurfaceList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("algorithm")]
public SurfaceProperty_HeatTransferAlgorithm_SurfaceList_Algorithm Algorithm { get; set; } = (SurfaceProperty_HeatTransferAlgorithm_SurfaceList_Algorithm)Enum.Parse(typeof(SurfaceProperty_HeatTransferAlgorithm_SurfaceList_Algorithm), "ConductionTransferFunction");
        

[JsonProperty("surface")]
public string Surface { get; set; } = "";
    }
    
    public enum SurfaceProperty_HeatTransferAlgorithm_SurfaceList_Algorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CombinedHeatAndMoistureFiniteElement")]
        CombinedHeatAndMoistureFiniteElement = 1,
        
        [JsonProperty("ConductionFiniteDifference")]
        ConductionFiniteDifference = 2,
        
        [JsonProperty("ConductionTransferFunction")]
        ConductionTransferFunction = 3,
        
        [JsonProperty("MoisturePenetrationDepthConductionTransferFunction")]
        MoisturePenetrationDepthConductionTransferFunction = 4,
    }
    
    [Description(@"Determines which Heat Balance Algorithm will be used for surfaces that have a specific type of construction Allows selectively overriding the global setting in HeatBalanceAlgorithm CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    [JsonObject("SurfaceProperty:HeatTransferAlgorithm:Construction")]
    public class SurfaceProperty_HeatTransferAlgorithm_Construction : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("algorithm")]
public SurfaceProperty_HeatTransferAlgorithm_Construction_Algorithm Algorithm { get; set; } = (SurfaceProperty_HeatTransferAlgorithm_Construction_Algorithm)Enum.Parse(typeof(SurfaceProperty_HeatTransferAlgorithm_Construction_Algorithm), "ConductionTransferFunction");
        

[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
    }
    
    public enum SurfaceProperty_HeatTransferAlgorithm_Construction_Algorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CombinedHeatAndMoistureFiniteElement")]
        CombinedHeatAndMoistureFiniteElement = 1,
        
        [JsonProperty("ConductionFiniteDifference")]
        ConductionFiniteDifference = 2,
        
        [JsonProperty("ConductionTransferFunction")]
        ConductionTransferFunction = 3,
        
        [JsonProperty("MoisturePenetrationDepthConductionTransferFunction")]
        MoisturePenetrationDepthConductionTransferFunction = 4,
    }
    
    [Description("Allows an additional heat source term to be added to the inside or outside surfac" +
        "e boundary. A heat source can be added to either or both the inside and outside " +
        "of the same surface.")]
    [JsonObject("SurfaceProperty:HeatBalanceSourceTerm")]
    public class SurfaceProperty_HeatBalanceSourceTerm : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[Description(@"The value of this schedule is the source term value for the inside face of this surface If this field is left blank, no inside surface source term will be applied. The schedule values are heat rate per surface area (W/m2), when positive schedule values indicate heat gain and negative values indicates loss.")]
[JsonProperty("inside_face_heat_source_term_schedule_name")]
public string InsideFaceHeatSourceTermScheduleName { get; set; } = "";
        

[Description(@"The value of this schedule is the source term value for the outside face of this surface If this field is left blank, no outside surface source term will be applied. The schedule values are heat rate per surface area (W/m2), when positive schedule values indicate heat gain and negative values indicates loss.")]
[JsonProperty("outside_face_heat_source_term_schedule_name")]
public string OutsideFaceHeatSourceTermScheduleName { get; set; } = "";
    }
    
    [Description("Exterior or Interior Insulation on opaque surfaces")]
    [JsonObject("SurfaceControl:MovableInsulation")]
    public class SurfaceControl_MovableInsulation : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("insulation_type")]
public SurfaceControl_MovableInsulation_InsulationType InsulationType { get; set; } = (SurfaceControl_MovableInsulation_InsulationType)Enum.Parse(typeof(SurfaceControl_MovableInsulation_InsulationType), "Inside");
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[JsonProperty("material_name")]
public string MaterialName { get; set; } = "";
        

[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
    }
    
    public enum SurfaceControl_MovableInsulation_InsulationType
    {
        
        [JsonProperty("Inside")]
        Inside = 0,
        
        [JsonProperty("Outside")]
        Outside = 1,
    }
    
    [Description("This object sets the other side conditions for a surface in a variety of ways.")]
    [JsonObject("SurfaceProperty:OtherSideCoefficients")]
    public class SurfaceProperty_OtherSideCoefficients : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"if>0, this field becomes the exterior convective/radiative film coefficient and the other fields are used to calculate the outdoor air temperature then exterior surface temperature based on outdoor air and specified coefficient if<=0, then remaining fields calculate the outside surface temperature The following fields are used in the equation: OtherSideTemp=N2*N3 + N4*OutdoorDry-bulb + N5*GroundTemp + N6*WindSpeed*OutdoorDry-bulb + N7*TempZone + N9*TempPrev")]
[JsonProperty("combined_convective_radiative_film_coefficient")]
public System.Nullable<float> CombinedConvectiveRadiativeFilmCoefficient { get; set; } = null;
        

[Description("This parameter will be overwritten by the values from the Constant Temperature Sc" +
    "hedule Name (below) if one is present")]
[JsonProperty("constant_temperature")]
public System.Nullable<float> ConstantTemperature { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This coefficient is used even with a Schedule. It should normally be 1.0 in that " +
    "case. This field is ignored if Sinusoidal Variation of Constant Temperature Coef" +
    "ficient = Yes.")]
[JsonProperty("constant_temperature_coefficient")]
public System.Nullable<float> ConstantTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("external_dry_bulb_temperature_coefficient")]
public System.Nullable<float> ExternalDryBulbTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("ground_temperature_coefficient")]
public System.Nullable<float> GroundTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("wind_speed_coefficient")]
public System.Nullable<float> WindSpeedCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("zone_air_temperature_coefficient")]
public System.Nullable<float> ZoneAirTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Name of schedule for values of constant temperature. Schedule values replace any " +
    "value specified in the field Constant Temperature.")]
[JsonProperty("constant_temperature_schedule_name")]
public string ConstantTemperatureScheduleName { get; set; } = "";
        

[Description("Optionally used to vary Constant Temperature Coefficient with unitary sine wave")]
[JsonProperty("sinusoidal_variation_of_constant_temperature_coefficient")]
public EmptyNoYes SinusoidalVariationOfConstantTemperatureCoefficient { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Use with sinusoidal variation to define the time period")]
[JsonProperty("period_of_sinusoidal_variation")]
public System.Nullable<float> PeriodOfSinusoidalVariation { get; set; } = (System.Nullable<float>)Single.Parse("24", CultureInfo.InvariantCulture);
        

[Description("This coefficient multiplies the other side temperature result from the previous z" +
    "one timestep")]
[JsonProperty("previous_other_side_temperature_coefficient")]
public System.Nullable<float> PreviousOtherSideTemperatureCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field specifies a lower limit for the other side temperature result. Blank i" +
    "ndicates no limit")]
[JsonProperty("minimum_other_side_temperature_limit")]
public System.Nullable<float> MinimumOtherSideTemperatureLimit { get; set; } = null;
        

[Description("This field specifies an upper limit for the other side temperature result. Blank " +
    "indicates no limit")]
[JsonProperty("maximum_other_side_temperature_limit")]
public System.Nullable<float> MaximumOtherSideTemperatureLimit { get; set; } = null;
    }
    
    [Description("This object sets up modifying the other side conditions for a surface from other " +
        "model results.")]
    [JsonObject("SurfaceProperty:OtherSideConditionsModel")]
    public class SurfaceProperty_OtherSideConditionsModel : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"GapConvectionRadiation provides boundary conditions for convection and linearized thermal radiation across a gap or cavity on the other side of the surface that are modeled separately. UndergroundPipingSystemSurface provides boundary conditions for surfaces in contact with PipingSystem:Underground domains GroundCoupledSurface provides boundary conditions for surfaces in contact with GroundDomain objects ConvectiveUnderwater provides a connection between a surface and an underwater boundary condition defined using a SurfaceProperty:Underwater object")]
[JsonProperty("type_of_modeling")]
public SurfaceProperty_OtherSideConditionsModel_TypeOfModeling TypeOfModeling { get; set; } = (SurfaceProperty_OtherSideConditionsModel_TypeOfModeling)Enum.Parse(typeof(SurfaceProperty_OtherSideConditionsModel_TypeOfModeling), "GapConvectionRadiation");
    }
    
    public enum SurfaceProperty_OtherSideConditionsModel_TypeOfModeling
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConvectiveUnderwater")]
        ConvectiveUnderwater = 1,
        
        [JsonProperty("GapConvectionRadiation")]
        GapConvectionRadiation = 2,
        
        [JsonProperty("GroundCoupledSurface")]
        GroundCoupledSurface = 3,
        
        [JsonProperty("UndergroundPipingSystemSurface")]
        UndergroundPipingSystemSurface = 4,
    }
    
    [Description("This object sets up a convective water boundary condition for a surface The free " +
        "stream temperature and velocity are scheduled. If the free stream velocity is ze" +
        "ro, the surface will naturally convect with the surrounding water.")]
    [JsonObject("SurfaceProperty:Underwater")]
    public class SurfaceProperty_Underwater : BHoMObject, IEnergyPlusClass
    {
        

[Description("This is the distance from the leading edge of the boundary layer development to t" +
    "he centroid of the surface of interest. The value of this field is used as the d" +
    "istance in the Reynolds number for evaluating the local convection coefficient.")]
[JsonProperty("distance_from_surface_centroid_to_leading_edge_of_boundary_layer")]
public System.Nullable<float> DistanceFromSurfaceCentroidToLeadingEdgeOfBoundaryLayer { get; set; } = null;
        

[JsonProperty("free_stream_water_temperature_schedule")]
public string FreeStreamWaterTemperatureSchedule { get; set; } = "";
        

[JsonProperty("free_stream_water_velocity_schedule")]
public string FreeStreamWaterVelocitySchedule { get; set; } = "";
    }
    
    [Description("Refined definition of the foundation surface construction used to inform two-dime" +
        "nsional heat transfer calculated using the Kiva ground heat transfer methodology" +
        ".")]
    [JsonObject("Foundation:Kiva")]
    public class Foundation_Kiva : BHoMObject, IEnergyPlusClass
    {
        

[Description("Indoor air temperature used for Kiva initialization (prior to warmup period) If l" +
    "eft blank, indoor air temperature will be determined based on zone setpoints")]
[JsonProperty("initial_indoor_air_temperature")]
public System.Nullable<float> InitialIndoorAirTemperature { get; set; } = null;
        

[JsonProperty("interior_horizontal_insulation_material_name")]
public string InteriorHorizontalInsulationMaterialName { get; set; } = "";
        

[Description("Distance from the slab bottom to the top of interior horizontal insulation")]
[JsonProperty("interior_horizontal_insulation_depth")]
public System.Nullable<float> InteriorHorizontalInsulationDepth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Extent of insulation as measured from the wall interior")]
[JsonProperty("interior_horizontal_insulation_width")]
public System.Nullable<float> InteriorHorizontalInsulationWidth { get; set; } = null;
        

[JsonProperty("interior_vertical_insulation_material_name")]
public string InteriorVerticalInsulationMaterialName { get; set; } = "";
        

[Description("Extent of insulation as measured from the wall top to the bottom edge of the inte" +
    "rior vertical insulation")]
[JsonProperty("interior_vertical_insulation_depth")]
public System.Nullable<float> InteriorVerticalInsulationDepth { get; set; } = null;
        

[JsonProperty("exterior_horizontal_insulation_material_name")]
public string ExteriorHorizontalInsulationMaterialName { get; set; } = "";
        

[Description("Distance from the exterior grade to the top of exterior horizontal insulation")]
[JsonProperty("exterior_horizontal_insulation_depth")]
public System.Nullable<float> ExteriorHorizontalInsulationDepth { get; set; } = null;
        

[Description("Extent of insulation as measured from the wall exterior")]
[JsonProperty("exterior_horizontal_insulation_width")]
public System.Nullable<float> ExteriorHorizontalInsulationWidth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("exterior_vertical_insulation_material_name")]
public string ExteriorVerticalInsulationMaterialName { get; set; } = "";
        

[Description("Extent of insulation as measured from the wall top to the bottom edge of the exte" +
    "rior vertical insulation")]
[JsonProperty("exterior_vertical_insulation_depth")]
public System.Nullable<float> ExteriorVerticalInsulationDepth { get; set; } = null;
        

[Description("Distance from the exterior grade to the wall top")]
[JsonProperty("wall_height_above_grade")]
public System.Nullable<float> WallHeightAboveGrade { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Distance from the slab bottom to the bottom of the foundation wall")]
[JsonProperty("wall_depth_below_slab")]
public System.Nullable<float> WallDepthBelowSlab { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Defines the below-grade surface construction for slabs. Required if foundation wa" +
    "ll is not exposed to the zone.")]
[JsonProperty("footing_wall_construction_name")]
public string FootingWallConstructionName { get; set; } = "";
        

[JsonProperty("footing_material_name")]
public string FootingMaterialName { get; set; } = "";
        

[Description("Top-to-bottom dimension of the footing (not to be confused with its depth in the " +
    "ground). The width of the footing is defined by the material\'s thickness.")]
[JsonProperty("footing_depth")]
public System.Nullable<float> FootingDepth { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[JsonProperty("blocks")]
public string Blocks { get; set; } = "";
    }
    
    [Description("Settings applied across all Kiva foundation calculations. Object is not required." +
        " If not defined, defaults will be applied.")]
    [JsonObject("Foundation:Kiva:Settings")]
    public class Foundation_Kiva_Settings : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("soil_conductivity")]
public System.Nullable<float> SoilConductivity { get; set; } = (System.Nullable<float>)Single.Parse("1.73", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_density")]
public System.Nullable<float> SoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("1842", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_specific_heat")]
public System.Nullable<float> SoilSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("419", CultureInfo.InvariantCulture);
        

[JsonProperty("ground_solar_absorptivity")]
public System.Nullable<float> GroundSolarAbsorptivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("ground_thermal_absorptivity")]
public System.Nullable<float> GroundThermalAbsorptivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("ground_surface_roughness")]
public System.Nullable<float> GroundSurfaceRoughness { get; set; } = (System.Nullable<float>)Single.Parse("0.03", CultureInfo.InvariantCulture);
        

[JsonProperty("far_field_width")]
public System.Nullable<float> FarFieldWidth { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
        

[JsonProperty("deep_ground_boundary_condition")]
public Foundation_Kiva_Settings_DeepGroundBoundaryCondition DeepGroundBoundaryCondition { get; set; } = (Foundation_Kiva_Settings_DeepGroundBoundaryCondition)Enum.Parse(typeof(Foundation_Kiva_Settings_DeepGroundBoundaryCondition), "Autoselect");
        

[JsonProperty("deep_ground_depth")]
public string DeepGroundDepth { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("minimum_cell_dimension")]
public System.Nullable<float> MinimumCellDimension { get; set; } = (System.Nullable<float>)Single.Parse("0.02", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_cell_growth_coefficient")]
public System.Nullable<float> MaximumCellGrowthCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

[JsonProperty("simulation_timestep")]
public Foundation_Kiva_Settings_SimulationTimestep SimulationTimestep { get; set; } = (Foundation_Kiva_Settings_SimulationTimestep)Enum.Parse(typeof(Foundation_Kiva_Settings_SimulationTimestep), "Hourly");
    }
    
    public enum Foundation_Kiva_Settings_DeepGroundBoundaryCondition
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Autoselect")]
        Autoselect = 1,
        
        [JsonProperty("GroundWater")]
        GroundWater = 2,
        
        [JsonProperty("ZeroFlux")]
        ZeroFlux = 3,
    }
    
    public enum Foundation_Kiva_Settings_SimulationTimestep
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Hourly")]
        Hourly = 1,
        
        [JsonProperty("Timestep")]
        Timestep = 2,
    }
    
    [Description(@"Defines the perimeter of a foundation floor that is exposed to the exterior environment through the floor. User may either define the total exposed perimeter, fraction of perimeter exposed or individually define which segments of the floor surface perimeter are exposed.")]
    [JsonObject("SurfaceProperty:ExposedFoundationPerimeter")]
    public class SurfaceProperty_ExposedFoundationPerimeter : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[Description(@"Choices: TotalExposedPerimeter => total exposed perimeter in meters ExposedPerimeterFraction => fraction of total perimeter that is exposed. Value * Fraction = Total exposed perimeter BySegment => define whether the segment between each set of consecutive vertices of the floor surface is exposed. SUM(exposed segement lengths) = Total exposed perimeter")]
[JsonProperty("exposed_perimeter_calculation_method")]
public SurfaceProperty_ExposedFoundationPerimeter_ExposedPerimeterCalculationMethod ExposedPerimeterCalculationMethod { get; set; } = (SurfaceProperty_ExposedFoundationPerimeter_ExposedPerimeterCalculationMethod)Enum.Parse(typeof(SurfaceProperty_ExposedFoundationPerimeter_ExposedPerimeterCalculationMethod), "BySegment");
        

[JsonProperty("total_exposed_perimeter")]
public System.Nullable<float> TotalExposedPerimeter { get; set; } = null;
        

[JsonProperty("exposed_perimeter_fraction")]
public System.Nullable<float> ExposedPerimeterFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("surfaces")]
public string Surfaces { get; set; } = "";
    }
    
    public enum SurfaceProperty_ExposedFoundationPerimeter_ExposedPerimeterCalculationMethod
    {
        
        [JsonProperty("BySegment")]
        BySegment = 0,
        
        [JsonProperty("ExposedPerimeterFraction")]
        ExposedPerimeterFraction = 1,
        
        [JsonProperty("TotalExposedPerimeter")]
        TotalExposedPerimeter = 2,
    }
    
    [Description(@"Options to change the individual convection model equations for dynamic selection when using AdaptiveConvectiongAlgorithm This object is only needed to make changes to the default model selections for any or all of the surface categories. This object is for the inside face, the side of the surface facing a thermal zone.")]
    [JsonObject("SurfaceConvectionAlgorithm:Inside:AdaptiveModelSelections")]
    public class SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections : BHoMObject, IEnergyPlusClass
    {
        

[Description("Applies to zone with no HVAC or when HVAC is off This is for vertical walls")]
[JsonProperty("simple_buoyancy_vertical_wall_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyVerticalWallEquationSource SimpleBuoyancyVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyVerticalWallEquationSource), "FohannoPolidoriVerticalWall");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("simple_buoyancy_vertical_wall_user_curve_name")]
public string SimpleBuoyancyVerticalWallUserCurveName { get; set; } = "";
        

[Description("Applies to zone with no HVAC or when HVAC is off This is for horizontal surfaces " +
    "with heat flow directed for stable thermal stratification")]
[JsonProperty("simple_buoyancy_stable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableHorizontalEquationSource SimpleBuoyancyStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("simple_buoyancy_stable_horizontal_equation_user_curve_name")]
public string SimpleBuoyancyStableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with no HVAC or when HVAC is off This is for passive horizontal s" +
    "urfaces with heat flow for unstable thermal stratification")]
[JsonProperty("simple_buoyancy_unstable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableHorizontalEquationSource SimpleBuoyancyUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableHorizontalEquationSource), "AlamdariHammondUnstableHorizontal");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("simple_buoyancy_unstable_horizontal_equation_user_curve_name")]
public string SimpleBuoyancyUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with no HVAC or when HVAC is off This is for tilted surfaces with" +
    " heat flow for stable thermal stratification")]
[JsonProperty("simple_buoyancy_stable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableTiltedEquationSource SimpleBuoyancyStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("simple_buoyancy_stable_tilted_equation_user_curve_name")]
public string SimpleBuoyancyStableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with no HVAC or when HVAC is off This is for tilted surfaces with" +
    " heat flow for unstable thermal stratification")]
[JsonProperty("simple_buoyancy_unstable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableTiltedEquationSource SimpleBuoyancyUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("simple_buoyancy_unstable_tilted_equation_user_curve_name")]
public string SimpleBuoyancyUnstableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with no HVAC or when HVAC is off This is for all window surfaces")]
[JsonProperty("simple_buoyancy_windows_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyWindowsEquationSource SimpleBuoyancyWindowsEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyWindowsEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyWindowsEquationSource), "ISO15099Windows");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("simple_buoyancy_windows_equation_user_curve_name")]
public string SimpleBuoyancyWindowsEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for verti" +
    "cal walls")]
[JsonProperty("floor_heat_ceiling_cool_vertical_wall_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolVerticalWallEquationSource FloorHeatCeilingCoolVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolVerticalWallEquationSource), "KhalifaEq3WallAwayFromHeat");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("floor_heat_ceiling_cool_vertical_wall_equation_user_curve_name")]
public string FloorHeatCeilingCoolVerticalWallEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for passi" +
    "ve horizontal surfaces with heat flow for stable thermal stratification")]
[JsonProperty("floor_heat_ceiling_cool_stable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableHorizontalEquationSource FloorHeatCeilingCoolStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("floor_heat_ceiling_cool_stable_horizontal_equation_user_curve_name")]
public string FloorHeatCeilingCoolStableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for passi" +
    "ve horizontal surfaces with heat flow for unstable thermal stratification")]
[JsonProperty("floor_heat_ceiling_cool_unstable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableHorizontalEquationSource FloorHeatCeilingCoolUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableHorizontalEquationSource), "KhalifaEq4CeilingAwayFromHeat");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("floor_heat_ceiling_cool_unstable_horizontal_equation_user_curve_name")]
public string FloorHeatCeilingCoolUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for a flo" +
    "or with active heating elements")]
[JsonProperty("floor_heat_ceiling_cool_heated_floor_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolHeatedFloorEquationSource FloorHeatCeilingCoolHeatedFloorEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolHeatedFloorEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolHeatedFloorEquationSource), "AwbiHattonHeatedFloor");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("floor_heat_ceiling_cool_heated_floor_equation_user_curve_name")]
public string FloorHeatCeilingCoolHeatedFloorEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for a cei" +
    "ling with active cooling elements")]
[JsonProperty("floor_heat_ceiling_cool_chilled_ceiling_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolChilledCeilingEquationSource FloorHeatCeilingCoolChilledCeilingEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolChilledCeilingEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolChilledCeilingEquationSource), "KaradagChilledCeiling");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("floor_heat_ceiling_cool_chilled_ceiling_equation_user_curve_name")]
public string FloorHeatCeilingCoolChilledCeilingEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for tilte" +
    "d surfaces with heat flow for stable thermal stratification")]
[JsonProperty("floor_heat_ceiling_cool_stable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableTiltedEquationSource FloorHeatCeilingCoolStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("floor_heat_ceiling_cool_stable_tilted_equation_user_curve_name")]
public string FloorHeatCeilingCoolStableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for tilte" +
    "d surfaces with heat flow for unstable thermal stratification")]
[JsonProperty("floor_heat_ceiling_cool_unstable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableTiltedEquationSource FloorHeatCeilingCoolUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("floor_heat_ceiling_cool_unstable_tilted_equation_user_curve_name")]
public string FloorHeatCeilingCoolUnstableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for all w" +
    "indow surfaces")]
[JsonProperty("floor_heat_ceiling_cool_window_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolWindowEquationSource FloorHeatCeilingCoolWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolWindowEquationSource), "ISO15099Windows");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("floor_heat_ceiling_cool_window_equation_user_curve_name")]
public string FloorHeatCeilingCoolWindowEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-wall panel heating This is for vertical walls that are no" +
    "t actively heated")]
[JsonProperty("wall_panel_heating_vertical_wall_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingVerticalWallEquationSource WallPanelHeatingVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingVerticalWallEquationSource), "KhalifaEq6NonHeatedWalls");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("wall_panel_heating_vertical_wall_equation_user_curve_name")]
public string WallPanelHeatingVerticalWallEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-wall panel heating This is for vertical walls that are be" +
    "ing actively heated")]
[JsonProperty("wall_panel_heating_heated_wall_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingHeatedWallEquationSource WallPanelHeatingHeatedWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingHeatedWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingHeatedWallEquationSource), "AwbiHattonHeatedWall");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("wall_panel_heating_heated_wall_equation_user_curve_name")]
public string WallPanelHeatingHeatedWallEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-wall panel heating This is for horizontal surfaces with h" +
    "eat flow directed for stable thermal stratification")]
[JsonProperty("wall_panel_heating_stable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableHorizontalEquationSource WallPanelHeatingStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("wall_panel_heating_stable_horizontal_equation_user_curve_name")]
public string WallPanelHeatingStableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-wall panel heating This is for horizontal surfaces with h" +
    "eat flow directed for unstable thermal stratification")]
[JsonProperty("wall_panel_heating_unstable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableHorizontalEquationSource WallPanelHeatingUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableHorizontalEquationSource), "KhalifaEq7Ceiling");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("wall_panel_heating_unstable_horizontal_equation_user_curve_name")]
public string WallPanelHeatingUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-wall panel heating This is for tilted surfaces with heat " +
    "flow for stable thermal stratification")]
[JsonProperty("wall_panel_heating_stable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableTiltedEquationSource WallPanelHeatingStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("wall_panel_heating_stable_tilted_equation_user_curve_name")]
public string WallPanelHeatingStableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-wall panel heating This is for tilted surfaces with heat " +
    "flow for unstable thermal stratification")]
[JsonProperty("wall_panel_heating_unstable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableTiltedEquationSource WallPanelHeatingUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("wall_panel_heating_unstable_tilted_equation_user_curve_name")]
public string WallPanelHeatingUnstableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with in-wall panel heating This is for all window surfaces")]
[JsonProperty("wall_panel_heating_window_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingWindowEquationSource WallPanelHeatingWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingWindowEquationSource), "ISO15099Windows");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("wall_panel_heating_window_equation_user_curve_name")]
public string WallPanelHeatingWindowEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with convective heater This is for vertical walls not directly af" +
    "fected by heater")]
[JsonProperty("convective_zone_heater_vertical_wall_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallEquationSource ConvectiveZoneHeaterVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallEquationSource), "FohannoPolidoriVerticalWall");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("convective_zone_heater_vertical_wall_equation_user_curve_name")]
public string ConvectiveZoneHeaterVerticalWallEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with convective heater This is for vertical walls that are direct" +
    "ly affected by heater Walls are considered \"near\" when listed in field set for F" +
    "raction of Radiant Energy to Surface")]
[JsonProperty("convective_zone_heater_vertical_walls_near_heater_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource), "KhalifaEq5WallNearHeat");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("convective_zone_heater_vertical_walls_near_heater_equation_user_curve_name")]
public string ConvectiveZoneHeaterVerticalWallsNearHeaterEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with convective heater This is for horizontal surfaces with heat " +
    "flow directed for stable thermal stratification")]
[JsonProperty("convective_zone_heater_stable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableHorizontalEquationSource ConvectiveZoneHeaterStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("convective_zone_heater_stable_horizontal_equation_user_curve_name")]
public string ConvectiveZoneHeaterStableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with convective heater This is for horizontal surfaces with heat " +
    "flow directed for unstable thermal stratification")]
[JsonProperty("convective_zone_heater_unstable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableHorizontalEquationSource ConvectiveZoneHeaterUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableHorizontalEquationSource), "KhalifaEq7Ceiling");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("convective_zone_heater_unstable_horizontal_equation_user_curve_name")]
public string ConvectiveZoneHeaterUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with convective heater This is for tilted surfaces with heat flow" +
    " for stable thermal stratification")]
[JsonProperty("convective_zone_heater_stable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableTiltedEquationSource ConvectiveZoneHeaterStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("convective_zone_heater_stable_tilted_equation_user_curve_name")]
public string ConvectiveZoneHeaterStableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with convective heater This is for tilted surfaces with heat flow" +
    " for unstable thermal stratification")]
[JsonProperty("convective_zone_heater_unstable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableTiltedEquationSource ConvectiveZoneHeaterUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("convective_zone_heater_unstable_tilted_equation_user_curve_name")]
public string ConvectiveZoneHeaterUnstableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with convective heater This is for all window surfaces")]
[JsonProperty("convective_zone_heater_windows_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterWindowsEquationSource ConvectiveZoneHeaterWindowsEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterWindowsEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterWindowsEquationSource), "ISO15099Windows");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("convective_zone_heater_windows_equation_user_curve_name")]
public string ConvectiveZoneHeaterWindowsEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
    " wall surfaces")]
[JsonProperty("central_air_diffuser_wall_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWallEquationSource CentralAirDiffuserWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWallEquationSource), "GoldsteinNovoselacCeilingDiffuserWalls");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("central_air_diffuser_wall_equation_user_curve_name")]
public string CentralAirDiffuserWallEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
    " ceiling surfaces")]
[JsonProperty("central_air_diffuser_ceiling_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserCeilingEquationSource CentralAirDiffuserCeilingEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserCeilingEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserCeilingEquationSource), "FisherPedersenCeilingDiffuserCeiling");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("central_air_diffuser_ceiling_equation_user_curve_name")]
public string CentralAirDiffuserCeilingEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
    " floor surfaces")]
[JsonProperty("central_air_diffuser_floor_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserFloorEquationSource CentralAirDiffuserFloorEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserFloorEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserFloorEquationSource), "GoldsteinNovoselacCeilingDiffuserFloor");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("central_air_diffuser_floor_equation_user_curve_name")]
public string CentralAirDiffuserFloorEquationUserCurveName { get; set; } = "";
        

[Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
    " window surfaces")]
[JsonProperty("central_air_diffuser_window_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWindowEquationSource CentralAirDiffuserWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWindowEquationSource), "GoldsteinNovoselacCeilingDiffuserWindow");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("central_air_diffuser_window_equation_user_curve_name")]
public string CentralAirDiffuserWindowEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mechanical_zone_fan_circulation_vertical_wall_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationVerticalWallEquationSource MechanicalZoneFanCirculationVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationVerticalWallEquationSource), "KhalifaEq3WallAwayFromHeat");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mechanical_zone_fan_circulation_vertical_wall_equation_user_curve_name")]
public string MechanicalZoneFanCirculationVerticalWallEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mechanical_zone_fan_circulation_stable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableHorizontalEquationSource MechanicalZoneFanCirculationStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mechanical_zone_fan_circulation_stable_horizontal_equation_user_curve_name")]
public string MechanicalZoneFanCirculationStableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mechanical_zone_fan_circulation_unstable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableHorizontalEquationSource MechanicalZoneFanCirculationUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableHorizontalEquationSource), "KhalifaEq4CeilingAwayFromHeat");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mechanical_zone_fan_circulation_unstable_horizontal_equation_user_curve_name")]
public string MechanicalZoneFanCirculationUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mechanical_zone_fan_circulation_stable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableTiltedEquationSource MechanicalZoneFanCirculationStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mechanical_zone_fan_circulation_stable_tilted_equation_user_curve_name")]
public string MechanicalZoneFanCirculationStableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mechanical_zone_fan_circulation_unstable_tilted_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableTiltedEquationSource MechanicalZoneFanCirculationUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mechanical_zone_fan_circulation_unstable_tilted_equation_user_curve_name")]
public string MechanicalZoneFanCirculationUnstableTiltedEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mechanical_zone_fan_circulation_window_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationWindowEquationSource MechanicalZoneFanCirculationWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationWindowEquationSource), "ISO15099Windows");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mechanical_zone_fan_circulation_window_equation_user_curve_name")]
public string MechanicalZoneFanCirculationWindowEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mixed_regime_buoyancy_assisting_flow_on_walls_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource), "BeausoleilMorrisonMixedAssistedWall");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mixed_regime_buoyancy_assisting_flow_on_walls_equation_user_curve_name")]
public string MixedRegimeBuoyancyAssistingFlowOnWallsEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mixed_regime_buoyancy_opposing_flow_on_walls_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource), "BeausoleilMorrisonMixedOpposingWall");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mixed_regime_buoyancy_opposing_flow_on_walls_equation_user_curve_name")]
public string MixedRegimeBuoyancyOpposingFlowOnWallsEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mixed_regime_stable_floor_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableFloorEquationSource MixedRegimeStableFloorEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableFloorEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableFloorEquationSource), "BeausoleilMorrisonMixedStableFloor");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mixed_regime_stable_floor_equation_user_curve_name")]
public string MixedRegimeStableFloorEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mixed_regime_unstable_floor_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableFloorEquationSource MixedRegimeUnstableFloorEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableFloorEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableFloorEquationSource), "BeausoleilMorrisonMixedUnstableFloor");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mixed_regime_unstable_floor_equation_user_curve_name")]
public string MixedRegimeUnstableFloorEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mixed_regime_stable_ceiling_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableCeilingEquationSource MixedRegimeStableCeilingEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableCeilingEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableCeilingEquationSource), "BeausoleilMorrisonMixedStableCeiling");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mixed_regime_stable_ceiling_equation_user_curve_name")]
public string MixedRegimeStableCeilingEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mixed_regime_unstable_ceiling_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableCeilingEquationSource MixedRegimeUnstableCeilingEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableCeilingEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableCeilingEquationSource), "BeausoleilMorrisonMixedUnstableCeiling");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mixed_regime_unstable_ceiling_equation_user_curve_name")]
public string MixedRegimeUnstableCeilingEquationUserCurveName { get; set; } = "";
        

[Description("reference choice fields")]
[JsonProperty("mixed_regime_window_equation_source")]
public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeWindowEquationSource MixedRegimeWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeWindowEquationSource), "GoldsteinNovoselacCeilingDiffuserWindow");
        

[Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
    "the previous field is set to UserCurve")]
[JsonProperty("mixed_regime_window_equation_user_curve_name")]
public string MixedRegimeWindowEquationUserCurveName { get; set; } = "";
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 4,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 5,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 6,
        
        [JsonProperty("UserCurve")]
        UserCurve = 7,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyWindowsEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 4,
        
        [JsonProperty("KaradagChilledCeiling")]
        KaradagChilledCeiling = 5,
        
        [JsonProperty("UserCurve")]
        UserCurve = 6,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 4,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 5,
        
        [JsonProperty("UserCurve")]
        UserCurve = 6,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolHeatedFloorEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("AwbiHattonHeatedFloor")]
        AwbiHattonHeatedFloor = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolChilledCeilingEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("KaradagChilledCeiling")]
        KaradagChilledCeiling = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolWindowEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 3,
        
        [JsonProperty("UserCurve")]
        UserCurve = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 4,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 5,
        
        [JsonProperty("UserCurve")]
        UserCurve = 6,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingHeatedWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("AwbiHattonHeatedWall")]
        AwbiHattonHeatedWall = 3,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 4,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 5,
        
        [JsonProperty("KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 6,
        
        [JsonProperty("UserCurve")]
        UserCurve = 7,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 2,
        
        [JsonProperty("KaradagChilledCeiling")]
        KaradagChilledCeiling = 3,
        
        [JsonProperty("KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 4,
        
        [JsonProperty("UserCurve")]
        UserCurve = 5,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 6,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingWindowEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 4,
        
        [JsonProperty("UserCurve")]
        UserCurve = 5,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 4,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 5,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 6,
        
        [JsonProperty("UserCurve")]
        UserCurve = 7,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("AwbiHattonHeatedWall")]
        AwbiHattonHeatedWall = 3,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 4,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 5,
        
        [JsonProperty("KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 6,
        
        [JsonProperty("UserCurve")]
        UserCurve = 7,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 2,
        
        [JsonProperty("KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 3,
        
        [JsonProperty("UserCurve")]
        UserCurve = 4,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 5,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterWindowsEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 4,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 5,
        
        [JsonProperty("UserCurve")]
        UserCurve = 6,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 3,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 4,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 5,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 6,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 7,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 8,
        
        [JsonProperty("UserCurve")]
        UserCurve = 9,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserCeilingEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BeausoleilMorrisonMixedStableCeiling")]
        BeausoleilMorrisonMixedStableCeiling = 1,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableCeiling")]
        BeausoleilMorrisonMixedUnstableCeiling = 2,
        
        [JsonProperty("FisherPedersenCeilingDiffuserCeiling")]
        FisherPedersenCeilingDiffuserCeiling = 3,
        
        [JsonProperty("UserCurve")]
        UserCurve = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserFloorEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BeausoleilMorrisonMixedStableFloor")]
        BeausoleilMorrisonMixedStableFloor = 1,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableFloor")]
        BeausoleilMorrisonMixedUnstableFloor = 2,
        
        [JsonProperty("FisherPedersenCeilingDiffuserFloor")]
        FisherPedersenCeilingDiffuserFloor = 3,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserFloor")]
        GoldsteinNovoselacCeilingDiffuserFloor = 4,
        
        [JsonProperty("UserCurve")]
        UserCurve = 5,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWindowEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 3,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 4,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 5,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 6,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 7,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 8,
        
        [JsonProperty("UserCurve")]
        UserCurve = 9,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 3,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 4,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 5,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 6,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 7,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 8,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 9,
        
        [JsonProperty("UserCurve")]
        UserCurve = 10,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("UserCurve")]
        UserCurve = 1,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 2,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableTiltedEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("UserCurve")]
        UserCurve = 2,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 3,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationWindowEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 4,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 5,
        
        [JsonProperty("UserCurve")]
        UserCurve = 6,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 3,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 4,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 5,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 6,
        
        [JsonProperty("UserCurve")]
        UserCurve = 7,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 3,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 4,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 5,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 6,
        
        [JsonProperty("UserCurve")]
        UserCurve = 7,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableFloorEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("BeausoleilMorrisonMixedStableFloor")]
        BeausoleilMorrisonMixedStableFloor = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableFloorEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableFloor")]
        BeausoleilMorrisonMixedUnstableFloor = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableCeilingEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("BeausoleilMorrisonMixedStableCeiling")]
        BeausoleilMorrisonMixedStableCeiling = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableCeilingEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableCeiling")]
        BeausoleilMorrisonMixedUnstableCeiling = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeWindowEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 1,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
    }
    
    [Description(@"Options to change the individual convection model equations for dynamic selection when using AdaptiveConvectiongAlgorithm This object is only needed to make changes to the default model selections for any or all of the surface categories. This object is for the outside face, the side of the surface facing away from the thermal zone.")]
    [JsonObject("SurfaceConvectionAlgorithm:Outside:AdaptiveModelSelections")]
    public class SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("wind_convection_windward_vertical_wall_equation_source")]
public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionWindwardVerticalWallEquationSource WindConvectionWindwardVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionWindwardVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionWindwardVerticalWallEquationSource), "TARPWindward");
        

[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
    " the previous field is set to UserCurve")]
[JsonProperty("wind_convection_windward_equation_vertical_wall_user_curve_name")]
public string WindConvectionWindwardEquationVerticalWallUserCurveName { get; set; } = "";
        

[JsonProperty("wind_convection_leeward_vertical_wall_equation_source")]
public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionLeewardVerticalWallEquationSource WindConvectionLeewardVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionLeewardVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionLeewardVerticalWallEquationSource), "TARPLeeward");
        

[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
    " the previous field is set to UserCurve")]
[JsonProperty("wind_convection_leeward_vertical_wall_equation_user_curve_name")]
public string WindConvectionLeewardVerticalWallEquationUserCurveName { get; set; } = "";
        

[JsonProperty("wind_convection_horizontal_roof_equation_source")]
public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionHorizontalRoofEquationSource WindConvectionHorizontalRoofEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionHorizontalRoofEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionHorizontalRoofEquationSource), "ClearRoof");
        

[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
    " the previous field is set to UserCurve")]
[JsonProperty("wind_convection_horizontal_roof_user_curve_name")]
public string WindConvectionHorizontalRoofUserCurveName { get; set; } = "";
        

[Description("This is for vertical walls")]
[JsonProperty("natural_convection_vertical_wall_equation_source")]
public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionVerticalWallEquationSource NaturalConvectionVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionVerticalWallEquationSource), "ASHRAEVerticalWall");
        

[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
    " the previous field is set to UserCurve")]
[JsonProperty("natural_convection_vertical_wall_equation_user_curve_name")]
public string NaturalConvectionVerticalWallEquationUserCurveName { get; set; } = "";
        

[Description("This is for horizontal surfaces with heat flow directed for stable thermal strati" +
    "fication")]
[JsonProperty("natural_convection_stable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionStableHorizontalEquationSource NaturalConvectionStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionStableHorizontalEquationSource), "WaltonStableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
    " the previous field is set to UserCurve")]
[JsonProperty("natural_convection_stable_horizontal_equation_user_curve_name")]
public string NaturalConvectionStableHorizontalEquationUserCurveName { get; set; } = "";
        

[JsonProperty("natural_convection_unstable_horizontal_equation_source")]
public SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionUnstableHorizontalEquationSource NaturalConvectionUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionUnstableHorizontalEquationSource), "WaltonUnstableHorizontalOrTilt");
        

[Description("The SurfaceConvectionAlgorithm:Outside:UserCurve named in this field is used when" +
    " the previous field is set to UserCurve")]
[JsonProperty("natural_convection_unstable_horizontal_equation_user_curve_name")]
public string NaturalConvectionUnstableHorizontalEquationUserCurveName { get; set; } = "";
    }
    
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionWindwardVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlockenWindward")]
        BlockenWindward = 1,
        
        [JsonProperty("DOE2Windward")]
        DOE2Windward = 2,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 3,
        
        [JsonProperty("McAdams")]
        McAdams = 4,
        
        [JsonProperty("Mitchell")]
        Mitchell = 5,
        
        [JsonProperty("MoWiTTWindward")]
        MoWiTTWindward = 6,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 7,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 8,
        
        [JsonProperty("TARPWindward")]
        TARPWindward = 9,
        
        [JsonProperty("UserCurve")]
        UserCurve = 10,
    }
    
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionLeewardVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DOE2Leeward")]
        DOE2Leeward = 1,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 2,
        
        [JsonProperty("McAdams")]
        McAdams = 3,
        
        [JsonProperty("Mitchell")]
        Mitchell = 4,
        
        [JsonProperty("MoWiTTLeeward")]
        MoWiTTLeeward = 5,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 6,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 7,
        
        [JsonProperty("TARPLeeward")]
        TARPLeeward = 8,
        
        [JsonProperty("UserCurve")]
        UserCurve = 9,
    }
    
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_WindConvectionHorizontalRoofEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlockenWindward")]
        BlockenWindward = 1,
        
        [JsonProperty("ClearRoof")]
        ClearRoof = 2,
        
        [JsonProperty("DOE2Windward")]
        DOE2Windward = 3,
        
        [JsonProperty("EmmelRoof")]
        EmmelRoof = 4,
        
        [JsonProperty("McAdams")]
        McAdams = 5,
        
        [JsonProperty("Mitchell")]
        Mitchell = 6,
        
        [JsonProperty("MoWiTTWindward")]
        MoWiTTWindward = 7,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 8,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 9,
        
        [JsonProperty("TARPWindward")]
        TARPWindward = 10,
        
        [JsonProperty("UserCurve")]
        UserCurve = 11,
    }
    
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionVerticalWallEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 1,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 2,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 3,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 4,
        
        [JsonProperty("None")]
        None = 5,
        
        [JsonProperty("UserCurve")]
        UserCurve = 6,
    }
    
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionStableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 4,
    }
    
    public enum SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections_NaturalConvectionUnstableHorizontalEquationSource
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("UserCurve")]
        UserCurve = 3,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 4,
    }
    
    [Description("Used to describe a custom model equation for surface convection heat transfer coe" +
        "fficient If more than one curve is referenced they are all used and added togeth" +
        "er.")]
    [JsonObject("SurfaceConvectionAlgorithm:Inside:UserCurve")]
    public class SurfaceConvectionAlgorithm_Inside_UserCurve : BHoMObject, IEnergyPlusClass
    {
        

[Description("Controls which temperature is differenced from surface temperature when using the" +
    " Hc value")]
[JsonProperty("reference_temperature_for_convection_heat_transfer")]
public SurfaceConvectionAlgorithm_Inside_UserCurve_ReferenceTemperatureForConvectionHeatTransfer ReferenceTemperatureForConvectionHeatTransfer { get; set; } = (SurfaceConvectionAlgorithm_Inside_UserCurve_ReferenceTemperatureForConvectionHeatTransfer)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_UserCurve_ReferenceTemperatureForConvectionHeatTransfer), "AdjacentAirTemperature");
        

[Description("Curve\'s \"x\" is absolute value of delta-T (Surface temperature minus reference tem" +
    "perature, (C))")]
[JsonProperty("hc_function_of_temperature_difference_curve_name")]
public string HcFunctionOfTemperatureDifferenceCurveName { get; set; } = "";
        

[Description("Curve\'s \"x\" is absolute value of delta-T/Height (Surface temp minus Air temp)/(ve" +
    "rtical length scale), (C/m) when used for an inside face the vertical length sca" +
    "le is the zone\'s interior height")]
[JsonProperty("hc_function_of_temperature_difference_divided_by_height_curve_name")]
public string HcFunctionOfTemperatureDifferenceDividedByHeightCurveName { get; set; } = "";
        

[Description("Curve\'s \"x\" is mechanical ACH (Air Changes per hour from mechanical air system), " +
    "(1/hr)")]
[JsonProperty("hc_function_of_air_change_rate_curve_name")]
public string HcFunctionOfAirChangeRateCurveName { get; set; } = "";
        

[Description("Curve\'s \"x\" is mechanical system air flow rate (m3/s) divided by zone\'s length al" +
    "ong exterior walls (m).")]
[JsonProperty("hc_function_of_air_system_volume_flow_rate_divided_by_zone_perimeter_length_curve" +
    "_name")]
public string HcFunctionOfAirSystemVolumeFlowRateDividedByZonePerimeterLengthCurveName { get; set; } = "";
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_UserCurve_ReferenceTemperatureForConvectionHeatTransfer
    {
        
        [JsonProperty("AdjacentAirTemperature")]
        AdjacentAirTemperature = 0,
        
        [JsonProperty("MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 2,
    }
    
    [Description("Used to describe a custom model equation for surface convection heat transfer coe" +
        "fficient If more than one curve is referenced they are all used and added togeth" +
        "er.")]
    [JsonObject("SurfaceConvectionAlgorithm:Outside:UserCurve")]
    public class SurfaceConvectionAlgorithm_Outside_UserCurve : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("wind_speed_type_for_curve")]
public SurfaceConvectionAlgorithm_Outside_UserCurve_WindSpeedTypeForCurve WindSpeedTypeForCurve { get; set; } = (SurfaceConvectionAlgorithm_Outside_UserCurve_WindSpeedTypeForCurve)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_UserCurve_WindSpeedTypeForCurve), "HeightAdjust");
        

[Description("Curve\'s \"x\" is wind speed of the type determined in the previous field (m/s)")]
[JsonProperty("hf_function_of_wind_speed_curve_name")]
public string HfFunctionOfWindSpeedCurveName { get; set; } = "";
        

[Description("Curve\'s \"x\" is absolute value of delta-T (Surface temperature minus air temperatu" +
    "re, (C))")]
[JsonProperty("hn_function_of_temperature_difference_curve_name")]
public string HnFunctionOfTemperatureDifferenceCurveName { get; set; } = "";
        

[Description("Curve\'s \"x\" is absolute value of delta-T/Height (Surface temp minus Air temp)/(ve" +
    "rtical length scale), (C/m) when used for an outside face the vertical length sc" +
    "ale is the exterior facade\'s overall height")]
[JsonProperty("hn_function_of_temperature_difference_divided_by_height_curve_name")]
public string HnFunctionOfTemperatureDifferenceDividedByHeightCurveName { get; set; } = "";
    }
    
    public enum SurfaceConvectionAlgorithm_Outside_UserCurve_WindSpeedTypeForCurve
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HeightAdjust")]
        HeightAdjust = 1,
        
        [JsonProperty("ParallelComponent")]
        ParallelComponent = 2,
        
        [JsonProperty("ParallelComponentHeightAdjust")]
        ParallelComponentHeightAdjust = 3,
        
        [JsonProperty("WeatherFile")]
        WeatherFile = 4,
    }
    
    [Description(@"Allow user settable interior and/or exterior convection coefficients. Note that some other factors may limit the lower bounds for these values, such as for windows, the interior convection coefficient must be >.28, for trombe wall algorithm selection (zone), the interior convection coefficient must be >.1 for TARP interior convection, the lower limit is also .1 Minimum and maximum limits are set in HeatBalanceAlgorithm object. Defaults in HeatBalanceAlgorithm object are [.1,1000].")]
    [JsonObject("SurfaceProperty:ConvectionCoefficients")]
    public class SurfaceProperty_ConvectionCoefficients : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[JsonProperty("convection_coefficient_1_location")]
public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location ConvectionCoefficient1Location { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location), "Inside");
        

[JsonProperty("convection_coefficient_1_type")]
public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type ConvectionCoefficient1Type { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type), "ASHRAEVerticalWall");
        

[Description("used if Convection Type=Value, min and max limits are set in HeatBalanceAlgorithm" +
    " object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
[JsonProperty("convection_coefficient_1")]
public System.Nullable<float> ConvectionCoefficient1 { get; set; } = null;
        

[Description("used if Convection Type=Schedule,  min and max limits are set in HeatBalanceAlgor" +
    "ithm object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
[JsonProperty("convection_coefficient_1_schedule_name")]
public string ConvectionCoefficient1ScheduleName { get; set; } = "";
        

[Description("used if Convection Type = UserCurve")]
[JsonProperty("convection_coefficient_1_user_curve_name")]
public string ConvectionCoefficient1UserCurveName { get; set; } = "";
        

[JsonProperty("convection_coefficient_2_location")]
public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location ConvectionCoefficient2Location { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location), "Inside");
        

[JsonProperty("convection_coefficient_2_type")]
public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type ConvectionCoefficient2Type { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type), "ASHRAEVerticalWall");
        

[Description("used if Convection Type=Value, min and max limits are set in HeatBalanceAlgorithm" +
    " object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
[JsonProperty("convection_coefficient_2")]
public System.Nullable<float> ConvectionCoefficient2 { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("used if Convection Type=Schedule,  min and max limits are set in HeatBalanceAlgor" +
    "ithm object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
[JsonProperty("convection_coefficient_2_schedule_name")]
public string ConvectionCoefficient2ScheduleName { get; set; } = "";
        

[Description("used if Convection Type = UserCurve")]
[JsonProperty("convection_coefficient_2_user_curve_name")]
public string ConvectionCoefficient2UserCurveName { get; set; } = "";
    }
    
    public enum SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location
    {
        
        [JsonProperty("Inside")]
        Inside = 0,
        
        [JsonProperty("Outside")]
        Outside = 1,
    }
    
    public enum SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type
    {
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 0,
        
        [JsonProperty("ASTMC1340")]
        ASTMC1340 = 1,
        
        [JsonProperty("AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 2,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 3,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 4,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 5,
        
        [JsonProperty("AwbiHattonHeatedFloor")]
        AwbiHattonHeatedFloor = 6,
        
        [JsonProperty("AwbiHattonHeatedWall")]
        AwbiHattonHeatedWall = 7,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 8,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 9,
        
        [JsonProperty("BeausoleilMorrisonMixedStableCeiling")]
        BeausoleilMorrisonMixedStableCeiling = 10,
        
        [JsonProperty("BeausoleilMorrisonMixedStableFloor")]
        BeausoleilMorrisonMixedStableFloor = 11,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableCeiling")]
        BeausoleilMorrisonMixedUnstableCeiling = 12,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableFloor")]
        BeausoleilMorrisonMixedUnstableFloor = 13,
        
        [JsonProperty("ClearRoof")]
        ClearRoof = 14,
        
        [JsonProperty("DOE-2")]
        DOE2 = 15,
        
        [JsonProperty("EmmelRoof")]
        EmmelRoof = 16,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 17,
        
        [JsonProperty("FisherPedersenCeilingDiffuserCeiling")]
        FisherPedersenCeilingDiffuserCeiling = 18,
        
        [JsonProperty("FisherPedersenCeilingDiffuserFloor")]
        FisherPedersenCeilingDiffuserFloor = 19,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 20,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 21,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserFloor")]
        GoldsteinNovoselacCeilingDiffuserFloor = 22,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 23,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 24,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 25,
        
        [JsonProperty("KaradagChilledCeiling")]
        KaradagChilledCeiling = 26,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 27,
        
        [JsonProperty("KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 28,
        
        [JsonProperty("KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 29,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 30,
        
        [JsonProperty("KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 31,
        
        [JsonProperty("McAdams")]
        McAdams = 32,
        
        [JsonProperty("Mitchell")]
        Mitchell = 33,
        
        [JsonProperty("MoWitt")]
        MoWitt = 34,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 35,
        
        [JsonProperty("Schedule")]
        Schedule = 36,
        
        [JsonProperty("Simple")]
        Simple = 37,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 38,
        
        [JsonProperty("TARP")]
        TARP = 39,
        
        [JsonProperty("UserCurve")]
        UserCurve = 40,
        
        [JsonProperty("Value")]
        Value = 41,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 42,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 43,
    }
    
    public enum SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location
    {
        
        [JsonProperty("Inside")]
        Inside = 0,
        
        [JsonProperty("Outside")]
        Outside = 1,
    }
    
    public enum SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type
    {
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 0,
        
        [JsonProperty("ASTMC1340")]
        ASTMC1340 = 1,
        
        [JsonProperty("AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 2,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 3,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 4,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 5,
        
        [JsonProperty("AwbiHattonHeatedFloor")]
        AwbiHattonHeatedFloor = 6,
        
        [JsonProperty("AwbiHattonHeatedWall")]
        AwbiHattonHeatedWall = 7,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 8,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 9,
        
        [JsonProperty("BeausoleilMorrisonMixedStableCeiling")]
        BeausoleilMorrisonMixedStableCeiling = 10,
        
        [JsonProperty("BeausoleilMorrisonMixedStableFloor")]
        BeausoleilMorrisonMixedStableFloor = 11,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableCeiling")]
        BeausoleilMorrisonMixedUnstableCeiling = 12,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableFloor")]
        BeausoleilMorrisonMixedUnstableFloor = 13,
        
        [JsonProperty("ClearRoof")]
        ClearRoof = 14,
        
        [JsonProperty("DOE-2")]
        DOE2 = 15,
        
        [JsonProperty("EmmelRoof")]
        EmmelRoof = 16,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 17,
        
        [JsonProperty("FisherPedersenCeilingDiffuserCeiling")]
        FisherPedersenCeilingDiffuserCeiling = 18,
        
        [JsonProperty("FisherPedersenCeilingDiffuserFloor")]
        FisherPedersenCeilingDiffuserFloor = 19,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 20,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 21,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserFloor")]
        GoldsteinNovoselacCeilingDiffuserFloor = 22,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 23,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 24,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 25,
        
        [JsonProperty("KaradagChilledCeiling")]
        KaradagChilledCeiling = 26,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 27,
        
        [JsonProperty("KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 28,
        
        [JsonProperty("KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 29,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 30,
        
        [JsonProperty("KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 31,
        
        [JsonProperty("McAdams")]
        McAdams = 32,
        
        [JsonProperty("Mitchell")]
        Mitchell = 33,
        
        [JsonProperty("MoWitt")]
        MoWitt = 34,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 35,
        
        [JsonProperty("Schedule")]
        Schedule = 36,
        
        [JsonProperty("Simple")]
        Simple = 37,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 38,
        
        [JsonProperty("TARP")]
        TARP = 39,
        
        [JsonProperty("UserCurve")]
        UserCurve = 40,
        
        [JsonProperty("Value")]
        Value = 41,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 42,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 43,
    }
    
    [Description(@"Allow user settable interior and/or exterior convection coefficients. Note that some other factors may limit the lower bounds for these values, such as for windows, the interior convection coefficient must be >.28, for trombe wall algorithm selection (zone), the interior convection coefficient must be >.1 for TARP interior convection, the lower limit is also .1 Minimum and maximum limits are set in HeatBalanceAlgorithm object. Defaults in HeatBalanceAlgorithm object are [.1,1000].")]
    [JsonObject("SurfaceProperty:ConvectionCoefficients:MultipleSurface")]
    public class SurfaceProperty_ConvectionCoefficients_MultipleSurface : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_type")]
public SurfaceProperty_ConvectionCoefficients_MultipleSurface_SurfaceType SurfaceType { get; set; } = (SurfaceProperty_ConvectionCoefficients_MultipleSurface_SurfaceType)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_MultipleSurface_SurfaceType), "AllExteriorFloors");
        

[JsonProperty("convection_coefficient_1_location")]
public SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient1Location ConvectionCoefficient1Location { get; set; } = (SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient1Location)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient1Location), "Inside");
        

[JsonProperty("convection_coefficient_1_type")]
public SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient1Type ConvectionCoefficient1Type { get; set; } = (SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient1Type)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient1Type), "ASHRAEVerticalWall");
        

[Description("used if Convection Type=Value, min and max limits are set in HeatBalanceAlgorithm" +
    " object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
[JsonProperty("convection_coefficient_1")]
public System.Nullable<float> ConvectionCoefficient1 { get; set; } = null;
        

[Description("used if Convection Type=Schedule,  min and max limits are set in HeatBalanceAlgor" +
    "ithm object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
[JsonProperty("convection_coefficient_1_schedule_name")]
public string ConvectionCoefficient1ScheduleName { get; set; } = "";
        

[Description("used if Convection Type = UserCurve")]
[JsonProperty("convection_coefficient_1_user_curve_name")]
public string ConvectionCoefficient1UserCurveName { get; set; } = "";
        

[JsonProperty("convection_coefficient_2_location")]
public SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient2Location ConvectionCoefficient2Location { get; set; } = (SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient2Location)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient2Location), "Inside");
        

[JsonProperty("convection_coefficient_2_type")]
public SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient2Type ConvectionCoefficient2Type { get; set; } = (SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient2Type)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient2Type), "ASHRAEVerticalWall");
        

[Description("used if Convection Type=Value, min and max limits are set in HeatBalanceAlgorithm" +
    " object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
[JsonProperty("convection_coefficient_2")]
public System.Nullable<float> ConvectionCoefficient2 { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("used if Convection Type=Schedule,  min and max limits are set in HeatBalanceAlgor" +
    "ithm object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
[JsonProperty("convection_coefficient_2_schedule_name")]
public string ConvectionCoefficient2ScheduleName { get; set; } = "";
        

[Description("used if Convection Type = UserCurve")]
[JsonProperty("convection_coefficient_2_user_curve_name")]
public string ConvectionCoefficient2UserCurveName { get; set; } = "";
    }
    
    public enum SurfaceProperty_ConvectionCoefficients_MultipleSurface_SurfaceType
    {
        
        [JsonProperty("AllExteriorFloors")]
        AllExteriorFloors = 0,
        
        [JsonProperty("AllExteriorRoofs")]
        AllExteriorRoofs = 1,
        
        [JsonProperty("AllExteriorSurfaces")]
        AllExteriorSurfaces = 2,
        
        [JsonProperty("AllExteriorWalls")]
        AllExteriorWalls = 3,
        
        [JsonProperty("AllExteriorWindows")]
        AllExteriorWindows = 4,
        
        [JsonProperty("AllInteriorCeilings")]
        AllInteriorCeilings = 5,
        
        [JsonProperty("AllInteriorFloors")]
        AllInteriorFloors = 6,
        
        [JsonProperty("AllInteriorSurfaces")]
        AllInteriorSurfaces = 7,
        
        [JsonProperty("AllInteriorWalls")]
        AllInteriorWalls = 8,
        
        [JsonProperty("AllInteriorWindows")]
        AllInteriorWindows = 9,
    }
    
    public enum SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient1Location
    {
        
        [JsonProperty("Inside")]
        Inside = 0,
        
        [JsonProperty("Outside")]
        Outside = 1,
    }
    
    public enum SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient1Type
    {
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 0,
        
        [JsonProperty("ASTMC1340")]
        ASTMC1340 = 1,
        
        [JsonProperty("AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 2,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 3,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 4,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 5,
        
        [JsonProperty("AwbiHattonHeatedFloor")]
        AwbiHattonHeatedFloor = 6,
        
        [JsonProperty("AwbiHattonHeatedWall")]
        AwbiHattonHeatedWall = 7,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 8,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 9,
        
        [JsonProperty("BeausoleilMorrisonMixedStableCeiling")]
        BeausoleilMorrisonMixedStableCeiling = 10,
        
        [JsonProperty("BeausoleilMorrisonMixedStableFloor")]
        BeausoleilMorrisonMixedStableFloor = 11,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableCeiling")]
        BeausoleilMorrisonMixedUnstableCeiling = 12,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableFloor")]
        BeausoleilMorrisonMixedUnstableFloor = 13,
        
        [JsonProperty("BlockenWindard")]
        BlockenWindard = 14,
        
        [JsonProperty("ClearRoof")]
        ClearRoof = 15,
        
        [JsonProperty("DOE-2")]
        DOE2 = 16,
        
        [JsonProperty("EmmelRoof")]
        EmmelRoof = 17,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 18,
        
        [JsonProperty("FisherPedersenCeilingDiffuserCeiling")]
        FisherPedersenCeilingDiffuserCeiling = 19,
        
        [JsonProperty("FisherPedersenCeilingDiffuserFloor")]
        FisherPedersenCeilingDiffuserFloor = 20,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 21,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 22,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserFloor")]
        GoldsteinNovoselacCeilingDiffuserFloor = 23,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 24,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 25,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 26,
        
        [JsonProperty("KaradagChilledCeiling")]
        KaradagChilledCeiling = 27,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 28,
        
        [JsonProperty("KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 29,
        
        [JsonProperty("KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 30,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 31,
        
        [JsonProperty("KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 32,
        
        [JsonProperty("McAdams")]
        McAdams = 33,
        
        [JsonProperty("Mitchell")]
        Mitchell = 34,
        
        [JsonProperty("MoWitt")]
        MoWitt = 35,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 36,
        
        [JsonProperty("Schedule")]
        Schedule = 37,
        
        [JsonProperty("Simple")]
        Simple = 38,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 39,
        
        [JsonProperty("TARP")]
        TARP = 40,
        
        [JsonProperty("UserCurve")]
        UserCurve = 41,
        
        [JsonProperty("Value")]
        Value = 42,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 43,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 44,
    }
    
    public enum SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient2Location
    {
        
        [JsonProperty("Inside")]
        Inside = 0,
        
        [JsonProperty("Outside")]
        Outside = 1,
    }
    
    public enum SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient2Type
    {
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 0,
        
        [JsonProperty("ASTMC1340")]
        ASTMC1340 = 1,
        
        [JsonProperty("AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 2,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 3,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 4,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 5,
        
        [JsonProperty("AwbiHattonHeatedFloor")]
        AwbiHattonHeatedFloor = 6,
        
        [JsonProperty("AwbiHattonHeatedWall")]
        AwbiHattonHeatedWall = 7,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 8,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 9,
        
        [JsonProperty("BeausoleilMorrisonMixedStableCeiling")]
        BeausoleilMorrisonMixedStableCeiling = 10,
        
        [JsonProperty("BeausoleilMorrisonMixedStableFloor")]
        BeausoleilMorrisonMixedStableFloor = 11,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableCeiling")]
        BeausoleilMorrisonMixedUnstableCeiling = 12,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableFloor")]
        BeausoleilMorrisonMixedUnstableFloor = 13,
        
        [JsonProperty("BlockenWindard")]
        BlockenWindard = 14,
        
        [JsonProperty("ClearRoof")]
        ClearRoof = 15,
        
        [JsonProperty("DOE-2")]
        DOE2 = 16,
        
        [JsonProperty("EmmelRoof")]
        EmmelRoof = 17,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 18,
        
        [JsonProperty("FisherPedersenCeilingDiffuserCeiling")]
        FisherPedersenCeilingDiffuserCeiling = 19,
        
        [JsonProperty("FisherPedersenCeilingDiffuserFloor")]
        FisherPedersenCeilingDiffuserFloor = 20,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 21,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 22,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserFloor")]
        GoldsteinNovoselacCeilingDiffuserFloor = 23,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 24,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 25,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 26,
        
        [JsonProperty("KaradagChilledCeiling")]
        KaradagChilledCeiling = 27,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 28,
        
        [JsonProperty("KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 29,
        
        [JsonProperty("KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 30,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 31,
        
        [JsonProperty("KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 32,
        
        [JsonProperty("McAdams")]
        McAdams = 33,
        
        [JsonProperty("Mitchell")]
        Mitchell = 34,
        
        [JsonProperty("MoWitt")]
        MoWitt = 35,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 36,
        
        [JsonProperty("Schedule")]
        Schedule = 37,
        
        [JsonProperty("Simple")]
        Simple = 38,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 39,
        
        [JsonProperty("TARP")]
        TARP = 40,
        
        [JsonProperty("UserCurve")]
        UserCurve = 41,
        
        [JsonProperty("Value")]
        Value = 42,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 43,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 44,
    }
    
    [Description(@"The interior and external vapor transfer coefficients. Normally these value are calculated using the heat convection coefficient values. Use this object to used fixed constant values. Units are kg/Pa.s.m2 This will only work with the CombinedHeatAndMoistureFiniteElement algorithm for surfaces. Other algorithms will ignore these coefficients")]
    [JsonObject("SurfaceProperties:VaporCoefficients")]
    public class SurfaceProperties_VaporCoefficients : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[JsonProperty("constant_external_vapor_transfer_coefficient")]
public EmptyNoYes ConstantExternalVaporTransferCoefficient { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("external_vapor_coefficient_value")]
public System.Nullable<float> ExternalVaporCoefficientValue { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("constant_internal_vapor_transfer_coefficient")]
public EmptyNoYes ConstantInternalVaporTransferCoefficient { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("internal_vapor_coefficient_value")]
public System.Nullable<float> InternalVaporCoefficientValue { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("Used to describe the decoupled layer, or baffle, and the characteristics of the c" +
        "avity and openings for naturally ventilated exterior surfaces. This object is al" +
        "so used in conjunction with the OtherSideConditionsModel.")]
    [JsonObject("SurfaceProperty:ExteriorNaturalVentedCavity")]
    public class SurfaceProperty_ExteriorNaturalVentedCavity : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of a SurfaceProperty:OtherSideConditionsModel object")]
[JsonProperty("boundary_conditions_model_name")]
public string BoundaryConditionsModelName { get; set; } = "";
        

[JsonProperty("area_fraction_of_openings")]
public System.Nullable<float> AreaFractionOfOpenings { get; set; } = null;
        

[JsonProperty("thermal_emissivity_of_exterior_baffle_material")]
public System.Nullable<float> ThermalEmissivityOfExteriorBaffleMaterial { get; set; } = null;
        

[JsonProperty("solar_absorbtivity_of_exterior_baffle")]
public System.Nullable<float> SolarAbsorbtivityOfExteriorBaffle { get; set; } = null;
        

[JsonProperty("height_scale_for_buoyancy_driven_ventilation")]
public System.Nullable<float> HeightScaleForBuoyancyDrivenVentilation { get; set; } = null;
        

[Description("if corrugated, use average depth")]
[JsonProperty("effective_thickness_of_cavity_behind_exterior_baffle")]
public System.Nullable<float> EffectiveThicknessOfCavityBehindExteriorBaffle { get; set; } = null;
        

[Description("this parameter is used to help account for corrugations in the collector")]
[JsonProperty("ratio_of_actual_surface_area_to_projected_surface_area")]
public System.Nullable<float> RatioOfActualSurfaceAreaToProjectedSurfaceArea { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("roughness_of_exterior_surface")]
public SurfaceProperty_ExteriorNaturalVentedCavity_RoughnessOfExteriorSurface RoughnessOfExteriorSurface { get; set; } = (SurfaceProperty_ExteriorNaturalVentedCavity_RoughnessOfExteriorSurface)Enum.Parse(typeof(SurfaceProperty_ExteriorNaturalVentedCavity_RoughnessOfExteriorSurface), "MediumRough");
        

[JsonProperty("effectiveness_for_perforations_with_respect_to_wind")]
public System.Nullable<float> EffectivenessForPerforationsWithRespectToWind { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

[JsonProperty("discharge_coefficient_for_openings_with_respect_to_buoyancy_driven_flow")]
public System.Nullable<float> DischargeCoefficientForOpeningsWithRespectToBuoyancyDrivenFlow { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[JsonProperty("surface")]
public string Surface { get; set; } = "";
    }
    
    public enum SurfaceProperty_ExteriorNaturalVentedCavity_RoughnessOfExteriorSurface
    {
        
        [JsonProperty("MediumRough")]
        MediumRough = 0,
        
        [JsonProperty("MediumSmooth")]
        MediumSmooth = 1,
        
        [JsonProperty("Rough")]
        Rough = 2,
        
        [JsonProperty("Smooth")]
        Smooth = 3,
        
        [JsonProperty("VeryRough")]
        VeryRough = 4,
        
        [JsonProperty("VerySmooth")]
        VerySmooth = 5,
    }
    
    [Description("Used to provide incident solar radiation on the inside of the surface. Reference " +
        "surface-construction pair and if that pair is used in a simulation, then program" +
        " will use value provided in schedule instead of calculating it.")]
    [JsonObject("SurfaceProperty:SolarIncidentInside")]
    public class SurfaceProperty_SolarIncidentInside : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Values in schedule are expected to be in W/m2")]
[JsonProperty("inside_surface_incident_sun_solar_radiation_schedule_name")]
public string InsideSurfaceIncidentSunSolarRadiationScheduleName { get; set; } = "";
    }
    
    [Description("This object defines the local environment properties of an exterior surface. One " +
        "or more environment properties have to be defined and linked to the exterior sur" +
        "face.")]
    [JsonObject("SurfaceProperty:LocalEnvironment")]
    public class SurfaceProperty_LocalEnvironment : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an exterior surface object")]
[JsonProperty("exterior_surface_name")]
public string ExteriorSurfaceName { get; set; } = "";
        

[Description("Enter the name of a Schedule object")]
[JsonProperty("external_shading_fraction_schedule_name")]
public string ExternalShadingFractionScheduleName { get; set; } = "";
        

[Description("Enter the name of a SurfaceProperty:SurroundingSurfaces object")]
[JsonProperty("surrounding_surfaces_object_name")]
public string SurroundingSurfacesObjectName { get; set; } = "";
        

[Description("Enter the name of an OutdoorAir:Node object")]
[JsonProperty("outdoor_air_node_name")]
public string OutdoorAirNodeName { get; set; } = "";
    }
    
    [Description("This object defines the local environment properties of a zone object. A correspo" +
        "nding outdoor air node should be defined and linked to the zone object.")]
    [JsonObject("ZoneProperty:LocalEnvironment")]
    public class ZoneProperty_LocalEnvironment : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of a zone object")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the name of an OutdoorAir:Node object")]
[JsonProperty("outdoor_air_node_name")]
public string OutdoorAirNodeName { get; set; } = "";
    }
    
    [Description("This object defines a list of surrounding surfaces for an exterior surface.")]
    [JsonObject("SurfaceProperty:SurroundingSurfaces")]
    public class SurfaceProperty_SurroundingSurfaces : BHoMObject, IEnergyPlusClass
    {
        

[Description("optional")]
[JsonProperty("sky_view_factor")]
public System.Nullable<float> SkyViewFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Schedule values are real numbers, -100.0 to 100.0, units C optional")]
[JsonProperty("sky_temperature_schedule_name")]
public string SkyTemperatureScheduleName { get; set; } = "";
        

[Description("optional")]
[JsonProperty("ground_view_factor")]
public System.Nullable<float> GroundViewFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Schedule values are real numbers, -100.0 to 100.0, units C optional")]
[JsonProperty("ground_temperature_schedule_name")]
public string GroundTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("surfaces")]
public string Surfaces { get; set; } = "";
    }
    
    [Description("Used to provide solar radiation absorbed in fenestration layers. References surfa" +
        "ce-construction pair and if that pair is used in a simulation, then program will" +
        " use value provided in schedules instead of calculating it.")]
    [JsonObject("ComplexFenestrationProperty:SolarAbsorbedLayers")]
    public class ComplexFenestrationProperty_SolarAbsorbedLayers : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("fenestration_surface")]
public string FenestrationSurface { get; set; } = "";
        

[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("Values in schedule are expected to be in W/m2")]
[JsonProperty("layer_1_solar_radiation_absorbed_schedule_name")]
public string Layer1SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

[Description("Values in schedule are expected to be in W/m2")]
[JsonProperty("layer_2_solar_radiation_absorbed_schedule_name")]
public string Layer2SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

[Description("Values in schedule are expected to be in W/m2")]
[JsonProperty("layer_3_solar_radiation_absorbed_schedule_name")]
public string Layer3SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

[Description("Values in schedule are expected to be in W/m2")]
[JsonProperty("layer_4_solar_radiation_absorbed_schedule_name")]
public string Layer4SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

[Description("Values in schedule are expected to be in W/m2")]
[JsonProperty("layer_5_solar_radiation_absorbed_schedule_name")]
public string Layer5SolarRadiationAbsorbedScheduleName { get; set; } = "";
    }
    
    [Description("View factors for Surface to Surface in a zone. (Number of Surfaces)**2 are expect" +
        "ed. Any omitted surface pairs will be assumed to have a view factor of zero.")]
    [JsonObject("ZoneProperty:UserViewFactors:BySurfaceName")]
    public class ZoneProperty_UserViewFactors_BySurfaceName : BHoMObject, IEnergyPlusClass
    {
        

[Description("View factors may be entered for a single zone or for a group of zones connected b" +
    "y Construction:AirBoundary")]
[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[JsonProperty("view_factors")]
public string ViewFactors { get; set; } = "";
    }
}
