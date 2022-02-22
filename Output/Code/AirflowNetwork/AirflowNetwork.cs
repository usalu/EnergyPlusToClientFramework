namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
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
    
    
    [Description("This object defines the global parameters used in an Airflow Network simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_SimulationControl : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description(@"NoMultizoneOrDistribution: Only perform Simple calculations (objects ZoneInfiltration:*, ZoneVentilation:*, ZoneMixing, ZoneCrossMixing, ZoneRefrigerationDoorMixing, ZoneAirBalance:OutdoorAir, ZoneEarthtube, ZoneThermalChimney, and ZoneCoolTower:Shower); MultizoneWithoutDistribution: Use AirflowNetwork objects to simulate multizone Airflows driven by wind during simulation time, and objects of ZoneInfiltration:*, ZoneVentilation:*, ZoneMixing, ZoneCrossMixing ZoneRefrigerationDoorMixing, ZoneAirBalance:OutdoorAir, ZoneEarthtube, ZoneThermalChimney, and ZoneCoolTower:Shower are ignored; MultizoneWithDistributionOnlyDuringFanOperation: Perform distribution system calculations during system fan on time and Simple calculations during system Fan off time; MultizoneWithDistribution: Perform distribution system calculations during system fan on time and multizone Airflow driven by wind during system fan off time.")]
[JsonProperty("airflownetwork_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_SimulationControl_AirflownetworkControl AirflownetworkControl { get; set; } = (AirflowNetwork_SimulationControl_AirflownetworkControl)Enum.Parse(typeof(AirflowNetwork_SimulationControl_AirflownetworkControl), "NoMultizoneOrDistribution");
        

[Description(@"Input: User must enter AirflowNetwork:MultiZone:WindPressureCoefficientArray, AirflowNetwork:MultiZone:ExternalNode, and AirflowNetwork:MultiZone:WindPressureCoefficientValues objects. SurfaceAverageCalculation: used only for rectangular buildings. If SurfaceAverageCalculation is selected, AirflowNetwork:MultiZone:WindPressureCoefficientArray, AirflowNetwork:MultiZone:ExternalNode, and AirflowNetwork:MultiZone:WindPressureCoefficientValues objects are not used.")]
[JsonProperty("wind_pressure_coefficient_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_SimulationControl_WindPressureCoefficientType WindPressureCoefficientType { get; set; } = (AirflowNetwork_SimulationControl_WindPressureCoefficientType)Enum.Parse(typeof(AirflowNetwork_SimulationControl_WindPressureCoefficientType), "SurfaceAverageCalculation");
        

[Description(@"If ExternalNode is selected, the height given in the AirflowNetwork:MultiZone:ExternalNode object will be used. If OpeningHeight is selected, the surface opening height (centroid) will be used to calculate local wind pressure This field is ignored when the choice of the Wind Pressure Coefficient Type field is SurfaceAverageCalculation.")]
[JsonProperty("height_selection_for_local_wind_pressure_calculation")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_SimulationControl_HeightSelectionForLocalWindPressureCalculation HeightSelectionForLocalWindPressureCalculation { get; set; } = (AirflowNetwork_SimulationControl_HeightSelectionForLocalWindPressureCalculation)Enum.Parse(typeof(AirflowNetwork_SimulationControl_HeightSelectionForLocalWindPressureCalculation), "OpeningHeight");
        

[Description("Used only if Wind Pressure Coefficient Type = SurfaceAverageCalculation, otherwis" +
    "e this field may be left blank.")]
[JsonProperty("building_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_SimulationControl_BuildingType BuildingType { get; set; } = (AirflowNetwork_SimulationControl_BuildingType)Enum.Parse(typeof(AirflowNetwork_SimulationControl_BuildingType), "LowRise");
        

[Description("Determines the maximum number of iterations used to converge on a solution. If th" +
    "is limit is exceeded, the program terminates.")]
[JsonProperty("maximum_number_of_iterations")]
public System.Nullable<float> MaximumNumberOfIterations { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

[JsonProperty("initialization_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_SimulationControl_InitializationType InitializationType { get; set; } = (AirflowNetwork_SimulationControl_InitializationType)Enum.Parse(typeof(AirflowNetwork_SimulationControl_InitializationType), "ZeroNodePressures");
        

[Description(@"This tolerance is defined as the absolute value of the sum of the mass Flow Rates divided by the sum of the absolute value of the mass Flow Rates. The mass Flow Rates described here refer to the mass Flow Rates at all Nodes in the AirflowNetwork model. The solution converges when both this tolerance and the tolerance in the next field (Absolute Airflow Convergence Tolerance) are satisfied.")]
[JsonProperty("relative_airflow_convergence_tolerance")]
public System.Nullable<float> RelativeAirflowConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.0001", CultureInfo.InvariantCulture);
        

[Description(@"This tolerance is defined as the absolute value of the sum of the mass flow rates. The mass flow rates described here refer to the mass flow rates at all nodes in the AirflowNetwork model. The solution converges when both this tolerance and the tolerance in the previous field (Relative Airflow Convergence Tolerance) are satisfied.")]
[JsonProperty("absolute_airflow_convergence_tolerance")]
public System.Nullable<float> AbsoluteAirflowConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Used only for AirflowNetwork:SimulationControl")]
[JsonProperty("convergence_acceleration_limit")]
public System.Nullable<float> ConvergenceAccelerationLimit { get; set; } = (System.Nullable<float>)Single.Parse("-0.5", CultureInfo.InvariantCulture);
        

[Description("Degrees clockwise from true North. Used only if Wind Pressure Coefficient Type = " +
    "SurfaceAverageCalculation.")]
[JsonProperty("azimuth_angle_of_long_axis_of_building")]
public System.Nullable<float> AzimuthAngleOfLongAxisOfBuilding { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only if Wind Pressure Coefficient Type = SurfaceAverageCalculation.")]
[JsonProperty("ratio_of_building_width_along_short_axis_to_width_along_long_axis")]
public System.Nullable<float> RatioOfBuildingWidthAlongShortAxisToWidthAlongLongAxis { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("If Yes, external node temperature is height dependent. If No, external node tempe" +
    "rature is based on zero height.")]
[JsonProperty("height_dependence_of_external_node_temperature")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes HeightDependenceOfExternalNodeTemperature { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Select the solver to use for the pressure network solution")]
[JsonProperty("solver")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_SimulationControl_Solver Solver { get; set; } = (AirflowNetwork_SimulationControl_Solver)Enum.Parse(typeof(AirflowNetwork_SimulationControl_Solver), "SkylineLU");
        

[Description(@"Set this input to Yes to have zone equipment that are currently unsupported in the AirflowNetwork model allowed in the simulation if present. Setting this field to Yes, allows the following equipments to be modeled along an AirflowNetwork model: ZoneHVAC:Dehumidifier, ZoneHVAC:EnergyRecoveryVentilator, WaterHeater:HeatPump:*.")]
[JsonProperty("allow_unsupported_zone_equipment")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes AllowUnsupportedZoneEquipment { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
    
    public enum AirflowNetwork_SimulationControl_AirflownetworkControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MultizoneWithDistribution")]
        MultizoneWithDistribution = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MultizoneWithDistributionOnlyDuringFanOperation")]
        MultizoneWithDistributionOnlyDuringFanOperation = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MultizoneWithoutDistribution")]
        MultizoneWithoutDistribution = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="NoMultizoneOrDistribution")]
        NoMultizoneOrDistribution = 4,
    }
    
    public enum AirflowNetwork_SimulationControl_WindPressureCoefficientType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Input")]
        Input = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceAverageCalculation")]
        SurfaceAverageCalculation = 2,
    }
    
    public enum AirflowNetwork_SimulationControl_HeightSelectionForLocalWindPressureCalculation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ExternalNode")]
        ExternalNode = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OpeningHeight")]
        OpeningHeight = 2,
    }
    
    public enum AirflowNetwork_SimulationControl_BuildingType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HighRise")]
        HighRise = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LowRise")]
        LowRise = 2,
    }
    
    public enum AirflowNetwork_SimulationControl_InitializationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LinearInitializationMethod")]
        LinearInitializationMethod = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZeroNodePressures")]
        ZeroNodePressures = 2,
    }
    
    public enum AirflowNetwork_SimulationControl_Solver
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConjugateGradient")]
        ConjugateGradient = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SkylineLU")]
        SkylineLU = 2,
    }
    
    [Description("This object is used to simultaneously control a thermal zone\'s window and door op" +
        "enings, both exterior and interior.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Zone : BHoMObject
    {
        

[Description("Enter the zone name where ventilation control is required.")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description(@"When Ventilation Control Mode = Temperature or Enthalpy, the following fields are used to modulate the Ventilation Open Factor for all window and door openings in the zone according to the zone's indoor-outdoor temperature or enthalpy difference. Constant: controlled by field Venting Schedule Name. NoVent: control will not open window or door during simulation (Ventilation Open Factor = 0).")]
[JsonProperty("ventilation_control_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_MultiZone_Zone_VentilationControlMode VentilationControlMode { get; set; } = (AirflowNetwork_MultiZone_Zone_VentilationControlMode)Enum.Parse(typeof(AirflowNetwork_MultiZone_Zone_VentilationControlMode), "NoVent");
        

[Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
[JsonProperty("ventilation_control_zone_temperature_setpoint_schedule_name")]
public string VentilationControlZoneTemperatureSetpointScheduleName { get; set; } = "";
        

[Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
[JsonProperty("minimum_venting_open_factor")]
public System.Nullable<float> MinimumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Ventilation Control Mode = Temperature. This value must be les" +
    "s than the corresponding upper value (next field).")]
[JsonProperty("indoor_and_outdoor_temperature_difference_lower_limit_for_maximum_venting_open_fa" +
    "ctor")]
public System.Nullable<float> IndoorAndOutdoorTemperatureDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Ventilation Control Mode = Temperature. This value must be gre" +
    "ater than the corresponding lower value (previous field).")]
[JsonProperty("indoor_and_outdoor_temperature_difference_upper_limit_for_minimum_venting_open_fa" +
    "ctor")]
public System.Nullable<float> IndoorAndOutdoorTemperatureDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Ventilation Control Mode = Enthalpy. This value must be less t" +
    "han the corresponding upper value (next field).")]
[JsonProperty("indoor_and_outdoor_enthalpy_difference_lower_limit_for_maximum_venting_open_facto" +
    "r")]
public System.Nullable<float> IndoorAndOutdoorEnthalpyDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Ventilation Control Mode = Enthalpy. This value must be greate" +
    "r than the corresponding lower value (previous field).")]
[JsonProperty("indoor_and_outdoor_enthalpy_difference_upper_limit_for_minimum_venting_open_facto" +
    "r")]
public System.Nullable<float> IndoorAndOutdoorEnthalpyDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("300000", CultureInfo.InvariantCulture);
        

[Description(@"Non-zero Schedule value means venting is allowed if other venting control conditions are satisfied. A zero (or negative) Schedule value means venting is not allowed under any The Schedule values should be greater than or equal to 0 and less than or equal to 1. circumstances. If this Schedule is not specified then venting is allowed if other venting control conditions are satisfied. Not used if Ventilation Control Mode = NoVent.")]
[JsonProperty("venting_availability_schedule_name")]
public string VentingAvailabilityScheduleName { get; set; } = "";
        

[Description(@"Selecting Advanced results in EnergyPlus calculating modified Wind Pressure Coefficients to account for wind direction and turbulence effects on single sided ventilation rates. Model is only valid for zones with 2 openings, both of which are on a single facade.")]
[JsonProperty("single_sided_wind_pressure_coefficient_algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_MultiZone_Zone_SingleSidedWindPressureCoefficientAlgorithm SingleSidedWindPressureCoefficientAlgorithm { get; set; } = (AirflowNetwork_MultiZone_Zone_SingleSidedWindPressureCoefficientAlgorithm)Enum.Parse(typeof(AirflowNetwork_MultiZone_Zone_SingleSidedWindPressureCoefficientAlgorithm), "Standard");
        

[Description("This is the whole building width along the direction of the facade of this zone.")]
[JsonProperty("facade_width")]
public System.Nullable<float> FacadeWidth { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Enter the name where Occupancy Ventilation Control is required.")]
[JsonProperty("occupant_ventilation_control_name")]
public string OccupantVentilationControlName { get; set; } = "";
    }
    
    public enum AirflowNetwork_MultiZone_Zone_VentilationControlMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAE55Adaptive")]
        ASHRAE55Adaptive = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CEN15251Adaptive")]
        CEN15251Adaptive = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Enthalpy")]
        Enthalpy = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="NoVent")]
        NoVent = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 6,
    }
    
    public enum AirflowNetwork_MultiZone_Zone_SingleSidedWindPressureCoefficientAlgorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Advanced")]
        Advanced = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Standard")]
        Standard = 2,
    }
    
    [Description("This object specifies the properties of a surface linkage through which air flows" +
        ". Airflow Report: Node 1 as an inside face zone; Node 2 as an outside face zone " +
        "or external node.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Surface : BHoMObject
    {
        

[Description("Enter the name of a heat transfer surface.")]
[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[Description(@"Enter the name of an Airflow Network leakage component. A leakage component is one of the following AirflowNetwork:Multizone objects: AirflowNetwork:MultiZone:Component:DetailedOpening, AirflowNetwork:MultiZone:Component:SimpleOpening, AirflowNetwork:MultiZone:Surface:Crack, AirflowNetwork:MultiZone:Surface:EffectiveLeakageArea, AirflowNetwork:MultiZone:Component:HorizontalOpening, or AirflowNetwork:MultiZone:Component:ZoneExhaustFan. When the zone exhaust fan name is entered, any surface control fields below A3 are ignored when the zone exhaust fan turns on.")]
[JsonProperty("leakage_component_name")]
public string LeakageComponentName { get; set; } = "";
        

[Description("Used if Wind Pressure Coefficient Type = Input in the AirflowNetwork:SimulationCo" +
    "ntrol object, otherwise this field may be left blank.")]
[JsonProperty("external_node_name")]
public string ExternalNodeName { get; set; } = "";
        

[Description("This field specifies a multiplier for a crack, window, or door.")]
[JsonProperty("window_door_opening_factor_or_crack_factor")]
public System.Nullable<float> WindowDoorOpeningFactorOrCrackFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"When Ventilation Control Mode = Temperature or Enthalpy, the following fields are used to modulate the Ventilation Open Factor for a window or door opening according to the parent zone's indoor-outdoor temperature or enthalpy difference. When Ventilation Control Mode = AdjacentTemperature or AdjacentEnthalpy, the following fields are used to modulate the Ventilation Open Factor for an interior window or door opening according to temperature or enthalpy difference between the parent zone and the adjacent zone. Constant: controlled by field Venting Schedule Name. NoVent: control will not open window or door during simulation (Ventilation Open Factor = 0). ZoneLevel: control will be controlled by AirflowNetwork:MultiZone:Zone Mode.")]
[JsonProperty("ventilation_control_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_MultiZone_Surface_VentilationControlMode VentilationControlMode { get; set; } = (AirflowNetwork_MultiZone_Surface_VentilationControlMode)Enum.Parse(typeof(AirflowNetwork_MultiZone_Surface_VentilationControlMode), "ZoneLevel");
        

[Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
[JsonProperty("ventilation_control_zone_temperature_setpoint_schedule_name")]
public string VentilationControlZoneTemperatureSetpointScheduleName { get; set; } = "";
        

[Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
[JsonProperty("minimum_venting_open_factor")]
public System.Nullable<float> MinimumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Ventilation Control Mode = Temperature")]
[JsonProperty("indoor_and_outdoor_temperature_difference_lower_limit_for_maximum_venting_open_fa" +
    "ctor")]
public System.Nullable<float> IndoorAndOutdoorTemperatureDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Ventilation Control Mode = Temperature. This value must be gre" +
    "ater than the corresponding lower value (previous field).")]
[JsonProperty("indoor_and_outdoor_temperature_difference_upper_limit_for_minimum_venting_open_fa" +
    "ctor")]
public System.Nullable<float> IndoorAndOutdoorTemperatureDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Ventilation Control Mode = Enthalpy. This value must be less t" +
    "han the corresponding upper value (next field).")]
[JsonProperty("indoor_and_outdoor_enthalpy_difference_lower_limit_for_maximum_venting_open_facto" +
    "r")]
public System.Nullable<float> IndoorAndOutdoorEnthalpyDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Ventilation Control Mode = Enthalpy. This value must be greate" +
    "r than the corresponding lower value (previous field).")]
[JsonProperty("indoor_and_outdoor_enthalpy_difference_upper_limit_for_minimum_venting_open_facto" +
    "r")]
public System.Nullable<float> IndoorAndOutdoorEnthalpyDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = (System.Nullable<float>)Single.Parse("300000", CultureInfo.InvariantCulture);
        

[Description(@"Non-zero schedule value means venting is allowed if other venting control conditions are satisfied. A zero (or negative) schedule value means venting is not allowed under any circumstances. The schedule values should be greater than or equal to 0 and less than or equal to 1. If this schedule is not specified then venting is allowed if other venting control conditions are satisfied. Not used if Ventilation Control Mode = NoVent or ZoneLevel.")]
[JsonProperty("venting_availability_schedule_name")]
public string VentingAvailabilityScheduleName { get; set; } = "";
        

[Description("Enter the name where Occupancy Ventilation Control is required.")]
[JsonProperty("occupant_ventilation_control_name")]
public string OccupantVentilationControlName { get; set; } = "";
        

[Description("This field is applied to a non-rectangular window or door. The equivalent shape h" +
    "as the same area as a polygonal window or door.")]
[JsonProperty("equivalent_rectangle_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_MultiZone_Surface_EquivalentRectangleMethod EquivalentRectangleMethod { get; set; } = (AirflowNetwork_MultiZone_Surface_EquivalentRectangleMethod)Enum.Parse(typeof(AirflowNetwork_MultiZone_Surface_EquivalentRectangleMethod), "PolygonHeight");
        

[Description("This field is used when UserDefinedAspectRatio is entered in the Equivalent Recta" +
    "ngle Method field.")]
[JsonProperty("equivalent_rectangle_aspect_ratio")]
public System.Nullable<float> EquivalentRectangleAspectRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum AirflowNetwork_MultiZone_Surface_VentilationControlMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAE55Adaptive")]
        ASHRAE55Adaptive = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjacentEnthalpy")]
        AdjacentEnthalpy = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjacentTemperature")]
        AdjacentTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="CEN15251Adaptive")]
        CEN15251Adaptive = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Enthalpy")]
        Enthalpy = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="NoVent")]
        NoVent = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneLevel")]
        ZoneLevel = 9,
    }
    
    public enum AirflowNetwork_MultiZone_Surface_EquivalentRectangleMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BaseSurfaceAspectRatio")]
        BaseSurfaceAspectRatio = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PolygonHeight")]
        PolygonHeight = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefinedAspectRatio")]
        UserDefinedAspectRatio = 3,
    }
    
    [Description("This object specifies the conditions under which the air mass flow coefficient wa" +
        "s measured.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_ReferenceCrackConditions : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the reference temperature under which the surface crack data were obtained." +
    "")]
[JsonProperty("reference_temperature")]
public System.Nullable<float> ReferenceTemperature { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[Description("Enter the reference barometric pressure under which the surface crack data were o" +
    "btained.")]
[JsonProperty("reference_barometric_pressure")]
public System.Nullable<float> ReferenceBarometricPressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
        

[Description("Enter the reference humidity ratio under which the surface crack data were obtain" +
    "ed.")]
[JsonProperty("reference_humidity_ratio")]
public System.Nullable<float> ReferenceHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("This object specifies the properties of airflow through a crack.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Surface_Crack : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the air mass flow coefficient at the conditions defined in the Reference Cr" +
    "ack Conditions object. Defined at 1 Pa pressure difference across this crack.")]
[JsonProperty("air_mass_flow_coefficient_at_reference_conditions")]
public System.Nullable<float> AirMassFlowCoefficientAtReferenceConditions { get; set; } = null;
        

[Description("Enter the air mass flow exponent for the surface crack.")]
[JsonProperty("air_mass_flow_exponent")]
public System.Nullable<float> AirMassFlowExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description("Select a AirflowNetwork:MultiZone:ReferenceCrackConditions name associated with t" +
    "he air mass flow coefficient entered above.")]
[JsonProperty("reference_crack_conditions")]
public string ReferenceCrackConditions { get; set; } = "";
    }
    
    [Description("This object is used to define surface air leakage.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the effective leakage area.")]
[JsonProperty("effective_leakage_area")]
public System.Nullable<float> EffectiveLeakageArea { get; set; } = null;
        

[Description("Enter the coefficient used in the air mass flow equation.")]
[JsonProperty("discharge_coefficient")]
public System.Nullable<float> DischargeCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Enter the pressure difference used to define the air mass flow coefficient and ex" +
    "ponent.")]
[JsonProperty("reference_pressure_difference")]
public System.Nullable<float> ReferencePressureDifference { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

[Description("Enter the exponent used in the air mass flow equation.")]
[JsonProperty("air_mass_flow_exponent")]
public System.Nullable<float> AirMassFlowExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
    }
    
    [Description("This object specifies the properties of airflow through windows and doors (window" +
        ", door and glass door heat transfer subsurfaces) when they are closed or open.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Component_DetailedOpening : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Defined at 1 Pa per meter of crack length. Enter the coefficient used in the foll" +
    "owing equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow " +
    "Exponent. Used only when opening (window or door) is closed.")]
[JsonProperty("air_mass_flow_coefficient_when_opening_is_closed")]
public System.Nullable<float> AirMassFlowCoefficientWhenOpeningIsClosed { get; set; } = null;
        

[Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
    " Coefficient * (dP)^Air Mass Flow Exponent. Used only when opening (window or do" +
    "or) is closed.")]
[JsonProperty("air_mass_flow_exponent_when_opening_is_closed")]
public System.Nullable<float> AirMassFlowExponentWhenOpeningIsClosed { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description("Select the type of vertical opening: Non-pivoted opening or Horizontally pivoted " +
    "opening.")]
[JsonProperty("type_of_rectangular_large_vertical_opening_lvo_")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_MultiZone_Component_DetailedOpening_TypeOfRectangularLargeVerticalOpeningLvo TypeOfRectangularLargeVerticalOpeningLvo { get; set; } = (AirflowNetwork_MultiZone_Component_DetailedOpening_TypeOfRectangularLargeVerticalOpeningLvo)Enum.Parse(typeof(AirflowNetwork_MultiZone_Component_DetailedOpening_TypeOfRectangularLargeVerticalOpeningLvo), "NonPivoted");
        

[Description(@"Extra crack length is used for LVO Non-pivoted type with multiple openable parts. Height of pivoting axis is used for LVO Horizontally pivoted type. Specifies window or door characteristics that depend on the LVO type. For Non-pivoted Type (rectangular windows and doors), this field is the extra crack length in meters due to multiple openable parts, if present. Extra here means in addition to the length of the cracks on the top, bottom and sides of the window/door. For Horizontally pivoted Type, this field gives the height of the pivoting axis measured from the bottom of the glazed part of the window (m).")]
[JsonProperty("extra_crack_length_or_height_of_pivoting_axis")]
public System.Nullable<float> ExtraCrackLengthOrHeightOfPivotingAxis { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the number of the following sets of data for opening factor, discharge coef" +
    "ficient, width factor, height factor, and start height factor.")]
[JsonProperty("number_of_sets_of_opening_factor_data")]
public System.Nullable<float> NumberOfSetsOfOpeningFactorData { get; set; } = null;
        

[Description("This value must be specified as 0.")]
[JsonProperty("opening_factor_1")]
public System.Nullable<float> OpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
    "ough a window or door at that Opening Factor.")]
[JsonProperty("discharge_coefficient_for_opening_factor_1")]
public System.Nullable<float> DischargeCoefficientForOpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[Description("The Width Factor is the opening width divided by the window or door width.")]
[JsonProperty("width_factor_for_opening_factor_1")]
public System.Nullable<float> WidthFactorForOpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The Height Factor is the opening height divided by the window or door height.")]
[JsonProperty("height_factor_for_opening_factor_1")]
public System.Nullable<float> HeightFactorForOpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"The Start Height Factor is the Start Height divided by the window or door height. Start Height is the distance between the bottom of the window or door and the bottom of the window or door opening. The sum of the Height Factor and the Start Height Factor must be less than 1.0 in order to have the opening within the window or door dimensions.")]
[JsonProperty("start_height_factor_for_opening_factor_1")]
public System.Nullable<float> StartHeightFactorForOpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"If Number of Sets of Opening Factor Data = 2, this value must be 1.0. If Number of Sets of Opening Factor Data = 3, this value must be less than 1.0. If Number of Sets of Opening Factor Data = 4, this value must be less than the value entered for Opening factor 3 and greater than the value entered for Opening factor 1.")]
[JsonProperty("opening_factor_2")]
public System.Nullable<float> OpeningFactor2 { get; set; } = null;
        

[Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
    "ough a window or door at that Opening Factor.")]
[JsonProperty("discharge_coefficient_for_opening_factor_2")]
public System.Nullable<float> DischargeCoefficientForOpeningFactor2 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("The Width Factor is the opening width divided by the window or door width.")]
[JsonProperty("width_factor_for_opening_factor_2")]
public System.Nullable<float> WidthFactorForOpeningFactor2 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("The Height Factor is the opening height divided by the window or door height.")]
[JsonProperty("height_factor_for_opening_factor_2")]
public System.Nullable<float> HeightFactorForOpeningFactor2 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"The Start Height Factor is the Start Height divided by the window or door height. Start Height is the distance between the bottom of the window or door and the bottom of the window or door opening. The sum of the Height Factor and the Start Height Factor must be less than 1.0 in order to have the opening within the window or door dimensions.")]
[JsonProperty("start_height_factor_for_opening_factor_2")]
public System.Nullable<float> StartHeightFactorForOpeningFactor2 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If Number of Sets of Opening Factor Data = 3, this value must be 1.0. If Number o" +
    "f Sets of Opening Factor Data = 4, this value must be less than 1.0, and greater" +
    " than value entered for Opening factor 2.")]
[JsonProperty("opening_factor_3")]
public System.Nullable<float> OpeningFactor3 { get; set; } = null;
        

[Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
    "ough a window or door at that Opening Factor.")]
[JsonProperty("discharge_coefficient_for_opening_factor_3")]
public System.Nullable<float> DischargeCoefficientForOpeningFactor3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The Width Factor is the opening width divided by the window or door width.")]
[JsonProperty("width_factor_for_opening_factor_3")]
public System.Nullable<float> WidthFactorForOpeningFactor3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The Height Factor is the opening height divided by the window or door height.")]
[JsonProperty("height_factor_for_opening_factor_3")]
public System.Nullable<float> HeightFactorForOpeningFactor3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"The Start Height Factor is the Start Height divided by the window or door height. Start Height is the distance between the bottom of the window or door and the bottom of the window or door opening. The sum of the Height Factor and the Start Height Factor must be less than 1.0 in order to have the opening within the window or door dimensions.")]
[JsonProperty("start_height_factor_for_opening_factor_3")]
public System.Nullable<float> StartHeightFactorForOpeningFactor3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If Number of Sets of Opening Factor Data = 4, this value must be 1.0")]
[JsonProperty("opening_factor_4")]
public System.Nullable<float> OpeningFactor4 { get; set; } = null;
        

[Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
    "ough a window or door at that Opening Factor.")]
[JsonProperty("discharge_coefficient_for_opening_factor_4")]
public System.Nullable<float> DischargeCoefficientForOpeningFactor4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The Width Factor is the opening width divided by the window or door width.")]
[JsonProperty("width_factor_for_opening_factor_4")]
public System.Nullable<float> WidthFactorForOpeningFactor4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The Height Factor is the opening height divided by the window or door height.")]
[JsonProperty("height_factor_for_opening_factor_4")]
public System.Nullable<float> HeightFactorForOpeningFactor4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"The Start Height Factor is the Start Height divided by the window or door height. Start Height is the distance between the bottom of the window or door and the bottom of the window or door opening. The sum of the Height Factor and the Start Height Factor must be less than 1.0 in order to have the opening within the window or door dimensions.")]
[JsonProperty("start_height_factor_for_opening_factor_4")]
public System.Nullable<float> StartHeightFactorForOpeningFactor4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum AirflowNetwork_MultiZone_Component_DetailedOpening_TypeOfRectangularLargeVerticalOpeningLvo
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HorizontallyPivoted")]
        HorizontallyPivoted = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NonPivoted")]
        NonPivoted = 2,
    }
    
    [Description("This object specifies the properties of air flow through windows and doors (windo" +
        "w, door and glass door heat transfer subsurfaces) when they are closed or open.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Component_SimpleOpening : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Defined at 1 Pa pressure difference. Enter the coefficient used in the following " +
    "equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Expone" +
    "nt. Used only when opening (window or door) is closed.")]
[JsonProperty("air_mass_flow_coefficient_when_opening_is_closed")]
public System.Nullable<float> AirMassFlowCoefficientWhenOpeningIsClosed { get; set; } = null;
        

[Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
    " Coefficient * (dP)^Air Mass Flow Exponent. Used only when opening (window or do" +
    "or) is closed.")]
[JsonProperty("air_mass_flow_exponent_when_opening_is_closed")]
public System.Nullable<float> AirMassFlowExponentWhenOpeningIsClosed { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description("Enter the minimum density difference above which two-way flow may occur due to st" +
    "ack effect.")]
[JsonProperty("minimum_density_difference_for_two_way_flow")]
public System.Nullable<float> MinimumDensityDifferenceForTwoWayFlow { get; set; } = null;
        

[Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
    "ough a window or door at that Opening Factor.")]
[JsonProperty("discharge_coefficient")]
public System.Nullable<float> DischargeCoefficient { get; set; } = null;
    }
    
    [Description("This object specifies the properties of air flow through a horizontal opening")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Component_HorizontalOpening : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Defined at 1 Pa pressure difference. Enter the coefficient used in the following " +
    "equation: Mass flow rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Expone" +
    "nt. Used only when opening is closed.")]
[JsonProperty("air_mass_flow_coefficient_when_opening_is_closed")]
public System.Nullable<float> AirMassFlowCoefficientWhenOpeningIsClosed { get; set; } = null;
        

[Description("Enter the exponent used in the following equation: Mass flow rate = Air Mass Flow" +
    " Coefficient * (dP)^Air Mass Flow Exponent. Used only when opening is closed.")]
[JsonProperty("air_mass_flow_exponent_when_opening_is_closed")]
public System.Nullable<float> AirMassFlowExponentWhenOpeningIsClosed { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description("Sloping plane angle = 90 is equivalent to fully open.")]
[JsonProperty("sloping_plane_angle")]
public System.Nullable<float> SlopingPlaneAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
    "ough the opening at that Opening Factor.")]
[JsonProperty("discharge_coefficient")]
public System.Nullable<float> DischargeCoefficient { get; set; } = null;
    }
    
    [Description("This object specifies the additional properties for a zone exhaust fan to perform" +
        " multizone airflow calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Component_ZoneExhaustFan : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description(@"Enter the air mass flow coefficient at the conditions defined in the Reference Crack Conditions object. Defined at 1 Pa pressure difference. Enter the coefficient used in the following equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Exponent. Used only when the fan is off.")]
[JsonProperty("air_mass_flow_coefficient_when_the_zone_exhaust_fan_is_off_at_reference_condition" +
    "s")]
public System.Nullable<float> AirMassFlowCoefficientWhenTheZoneExhaustFanIsOffAtReferenceConditions { get; set; } = null;
        

[Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
    " Coefficient * (dP)^Air Mass Flow Exponent. Used only when the fan is off.")]
[JsonProperty("air_mass_flow_exponent_when_the_zone_exhaust_fan_is_off")]
public System.Nullable<float> AirMassFlowExponentWhenTheZoneExhaustFanIsOff { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description("Select a AirflowNetwork:MultiZone:ReferenceCrackConditions name associated with t" +
    "he air mass flow coefficient entered above.")]
[JsonProperty("reference_crack_conditions")]
public string ReferenceCrackConditions { get; set; } = "";
    }
    
    [Description("This object defines outdoor environmental conditions outside of the building.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_ExternalNode : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Designates the reference height used to calculate relative pressure.")]
[JsonProperty("external_node_height")]
public System.Nullable<float> ExternalNodeHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The name of the AirflowNetwork:MultiZone:WindPressureCoefficientValues, curve, or" +
    " table object specifying the wind pressure coefficient.")]
[JsonProperty("wind_pressure_coefficient_curve_name")]
public string WindPressureCoefficientCurveName { get; set; } = "";
        

[Description("Specify whether the pressure curve is symmetric or not. Specify Yes for curves th" +
    "at should be evaluated from 0 to 180 degrees Specify No for curves that should b" +
    "e evaluated from 0 to 360 degrees")]
[JsonProperty("symmetric_wind_pressure_coefficient_curve")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes SymmetricWindPressureCoefficientCurve { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Specify whether the angle used to compute the wind pressure coefficient is absolu" +
    "te or relative Specify Relative to compute the angle between the wind direction " +
    "and the surface azimuth Specify Absolute to use the wind direction angle directl" +
    "y")]
[JsonProperty("wind_angle_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_MultiZone_ExternalNode_WindAngleType WindAngleType { get; set; } = (AirflowNetwork_MultiZone_ExternalNode_WindAngleType)Enum.Parse(typeof(AirflowNetwork_MultiZone_ExternalNode_WindAngleType), "Absolute");
    }
    
    public enum AirflowNetwork_MultiZone_ExternalNode_WindAngleType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Absolute")]
        Absolute = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Relative")]
        Relative = 2,
    }
    
    [Description(@"Used only if Wind Pressure Coefficient (WPC) Type = Input in the AirflowNetwork:SimulationControl object. Number of WPC Values in the corresponding AirflowNetwork:MultiZone:WindPressureCoefficientValues object must be the same as the number of wind directions specified for this AirflowNetwork:MultiZone:WindPressureCoefficientArray object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_WindPressureCoefficientArray : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the wind direction corresponding to the 1st WPC Array value.")]
[JsonProperty("wind_direction_1")]
public System.Nullable<float> WindDirection1 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 2nd WPC Array value.")]
[JsonProperty("wind_direction_2")]
public System.Nullable<float> WindDirection2 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 3rd WPC Array value.")]
[JsonProperty("wind_direction_3")]
public System.Nullable<float> WindDirection3 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 4th WPC Array value.")]
[JsonProperty("wind_direction_4")]
public System.Nullable<float> WindDirection4 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 5th WPC Array value.")]
[JsonProperty("wind_direction_5")]
public System.Nullable<float> WindDirection5 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 6th WPC Array value.")]
[JsonProperty("wind_direction_6")]
public System.Nullable<float> WindDirection6 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 7th WPC Array value.")]
[JsonProperty("wind_direction_7")]
public System.Nullable<float> WindDirection7 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 8th WPC Array value.")]
[JsonProperty("wind_direction_8")]
public System.Nullable<float> WindDirection8 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 9th WPC Array value.")]
[JsonProperty("wind_direction_9")]
public System.Nullable<float> WindDirection9 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 10th WPC Array value.")]
[JsonProperty("wind_direction_10")]
public System.Nullable<float> WindDirection10 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 11th WPC Array value.")]
[JsonProperty("wind_direction_11")]
public System.Nullable<float> WindDirection11 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 12th WPC Array value.")]
[JsonProperty("wind_direction_12")]
public System.Nullable<float> WindDirection12 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 13th WPC Array value.")]
[JsonProperty("wind_direction_13")]
public System.Nullable<float> WindDirection13 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 14th WPC Array value.")]
[JsonProperty("wind_direction_14")]
public System.Nullable<float> WindDirection14 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 15th WPC Array value.")]
[JsonProperty("wind_direction_15")]
public System.Nullable<float> WindDirection15 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 16th WPC Array value.")]
[JsonProperty("wind_direction_16")]
public System.Nullable<float> WindDirection16 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 17th WPC Array value.")]
[JsonProperty("wind_direction_17")]
public System.Nullable<float> WindDirection17 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 18th WPC Array value.")]
[JsonProperty("wind_direction_18")]
public System.Nullable<float> WindDirection18 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 19th WPC Array value.")]
[JsonProperty("wind_direction_19")]
public System.Nullable<float> WindDirection19 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 20th WPC Array value.")]
[JsonProperty("wind_direction_20")]
public System.Nullable<float> WindDirection20 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 21st WPC Array value.")]
[JsonProperty("wind_direction_21")]
public System.Nullable<float> WindDirection21 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 22nd WPC Array value.")]
[JsonProperty("wind_direction_22")]
public System.Nullable<float> WindDirection22 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 23rd WPC Array value.")]
[JsonProperty("wind_direction_23")]
public System.Nullable<float> WindDirection23 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 24th WPC Array value.")]
[JsonProperty("wind_direction_24")]
public System.Nullable<float> WindDirection24 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 25th WPC Array value.")]
[JsonProperty("wind_direction_25")]
public System.Nullable<float> WindDirection25 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 26th WPC Array value.")]
[JsonProperty("wind_direction_26")]
public System.Nullable<float> WindDirection26 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 27th WPC Array value.")]
[JsonProperty("wind_direction_27")]
public System.Nullable<float> WindDirection27 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 28th WPC Array value.")]
[JsonProperty("wind_direction_28")]
public System.Nullable<float> WindDirection28 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 29th WPC Array value.")]
[JsonProperty("wind_direction_29")]
public System.Nullable<float> WindDirection29 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 30th WPC Array value.")]
[JsonProperty("wind_direction_30")]
public System.Nullable<float> WindDirection30 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 31st WPC Array value.")]
[JsonProperty("wind_direction_31")]
public System.Nullable<float> WindDirection31 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 32nd WPC Array value.")]
[JsonProperty("wind_direction_32")]
public System.Nullable<float> WindDirection32 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 33rd WPC Array value.")]
[JsonProperty("wind_direction_33")]
public System.Nullable<float> WindDirection33 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 34th WPC Array value.")]
[JsonProperty("wind_direction_34")]
public System.Nullable<float> WindDirection34 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 35th WPC Array value.")]
[JsonProperty("wind_direction_35")]
public System.Nullable<float> WindDirection35 { get; set; } = null;
        

[Description("Enter the wind direction corresponding to the 36th WPC Array value.")]
[JsonProperty("wind_direction_36")]
public System.Nullable<float> WindDirection36 { get; set; } = null;
    }
    
    [Description(@"Used only if Wind Pressure Coefficient (WPC) Type = INPUT in the AirflowNetwork:SimulationControl object. The number of WPC numeric inputs must correspond to the number of wind direction inputs in the AirflowNetwork:Multizone:WindPressureCoefficientArray object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_WindPressureCoefficientValues : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the name of the AirflowNetwork:Multizone:WindPressureCoefficientArray objec" +
    "t.")]
[JsonProperty("airflownetwork_multizone_windpressurecoefficientarray_name")]
public string AirflownetworkMultizoneWindpressurecoefficientarrayName { get; set; } = "";
        

[Description("Enter the WPC Value corresponding to the 1st wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_1")]
public System.Nullable<float> WindPressureCoefficientValue1 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 2nd wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_2")]
public System.Nullable<float> WindPressureCoefficientValue2 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 3rd wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_3")]
public System.Nullable<float> WindPressureCoefficientValue3 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 4th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_4")]
public System.Nullable<float> WindPressureCoefficientValue4 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 5th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_5")]
public System.Nullable<float> WindPressureCoefficientValue5 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 6th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_6")]
public System.Nullable<float> WindPressureCoefficientValue6 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 7th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_7")]
public System.Nullable<float> WindPressureCoefficientValue7 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 8th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_8")]
public System.Nullable<float> WindPressureCoefficientValue8 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 9th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_9")]
public System.Nullable<float> WindPressureCoefficientValue9 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 10th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_10")]
public System.Nullable<float> WindPressureCoefficientValue10 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 11th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_11")]
public System.Nullable<float> WindPressureCoefficientValue11 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 12th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_12")]
public System.Nullable<float> WindPressureCoefficientValue12 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 13th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_13")]
public System.Nullable<float> WindPressureCoefficientValue13 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 14th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_14")]
public System.Nullable<float> WindPressureCoefficientValue14 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 15th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_15")]
public System.Nullable<float> WindPressureCoefficientValue15 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 16th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_16")]
public System.Nullable<float> WindPressureCoefficientValue16 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 17th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_17")]
public System.Nullable<float> WindPressureCoefficientValue17 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 18th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_18")]
public System.Nullable<float> WindPressureCoefficientValue18 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 19th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_19")]
public System.Nullable<float> WindPressureCoefficientValue19 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 20th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_20")]
public System.Nullable<float> WindPressureCoefficientValue20 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 21st wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_21")]
public System.Nullable<float> WindPressureCoefficientValue21 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 22nd wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_22")]
public System.Nullable<float> WindPressureCoefficientValue22 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 23rd wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_23")]
public System.Nullable<float> WindPressureCoefficientValue23 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 24th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_24")]
public System.Nullable<float> WindPressureCoefficientValue24 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 25th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_25")]
public System.Nullable<float> WindPressureCoefficientValue25 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 26th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_26")]
public System.Nullable<float> WindPressureCoefficientValue26 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 27th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_27")]
public System.Nullable<float> WindPressureCoefficientValue27 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 28th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_28")]
public System.Nullable<float> WindPressureCoefficientValue28 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 29th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_29")]
public System.Nullable<float> WindPressureCoefficientValue29 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 30th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_30")]
public System.Nullable<float> WindPressureCoefficientValue30 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 31st wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_31")]
public System.Nullable<float> WindPressureCoefficientValue31 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 32nd wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_32")]
public System.Nullable<float> WindPressureCoefficientValue32 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 33rd wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_33")]
public System.Nullable<float> WindPressureCoefficientValue33 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 34th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_34")]
public System.Nullable<float> WindPressureCoefficientValue34 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 35th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_35")]
public System.Nullable<float> WindPressureCoefficientValue35 { get; set; } = null;
        

[Description("Enter the WPC Value corresponding to the 36th wind direction.")]
[JsonProperty("wind_pressure_coefficient_value_36")]
public System.Nullable<float> WindPressureCoefficientValue36 { get; set; } = null;
    }
    
    [Description("This object is used to control a zone to a specified indoor pressure using the Ai" +
        "rflowNetwork model. The specified pressure setpoint is used to control the zone " +
        "exhaust fan flow rate in a controlled zone or the relief air flow rate in an air" +
        " loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_ZoneControl_PressureController : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("control_zone_name")]
public string ControlZoneName { get; set; } = "";
        

[Description("The current selection is AirflowNetwork:MultiZone:Component:ZoneExhaustFan or Air" +
    "flowNetwork:Distribution:Component:ReliefAirFlow.")]
[JsonProperty("control_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_ZoneControl_PressureController_ControlObjectType ControlObjectType { get; set; } = (AirflowNetwork_ZoneControl_PressureController_ControlObjectType)Enum.Parse(typeof(AirflowNetwork_ZoneControl_PressureController_ControlObjectType), "AirflowNetworkDistributionComponentReliefAirFlow");
        

[Description("Control names are names of individual control objects")]
[JsonProperty("control_object_name")]
public string ControlObjectName { get; set; } = "";
        

[Description("Availability schedule name for pressure controller. Schedule value > 0 means the " +
    "pressure controller is enabled. If this field is blank, then pressure controller" +
    " is always enabled.")]
[JsonProperty("pressure_control_availability_schedule_name")]
public string PressureControlAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("pressure_setpoint_schedule_name")]
public string PressureSetpointScheduleName { get; set; } = "";
    }
    
    public enum AirflowNetwork_ZoneControl_PressureController_ControlObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirflowNetwork:Distribution:Component:ReliefAirFlow")]
        AirflowNetworkDistributionComponentReliefAirFlow = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirflowNetwork:MultiZone:Component:ZoneExhaustFan")]
        AirflowNetworkMultiZoneComponentZoneExhaustFan = 1,
    }
    
    [Description("This object represents an air distribution node in the AirflowNetwork model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Node : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description(@"Designates node names defined in another object. The node name may occur in air branches. Enter a node name to represent a node already defined in an air loop. Leave this field blank if the Node or Object Type field below is entered as AirLoopHVAC:ZoneMixer, AirLoopHVAC:ZoneSplitter, AirLoopHVAC:OutdoorAirSystem, or Other.")]
[JsonProperty("component_name_or_node_name")]
public string ComponentNameOrNodeName { get; set; } = "";
        

[Description(@"Designates Node type for the Node or Component Name defined in the field above. AirLoopHVAC:ZoneMixer -- Represents a AirLoopHVAC:ZoneMixer object. AirLoopHVAC:ZoneSplitter -- Represents a AirLoopHVAC:ZoneSplitter object. AirLoopHVAC:OutdoorAirSystem -- Represents an AirLoopHVAC:OutdoorAirSystem object. OAMixerOutdoorAirStreamNode -- Represents an external node used in the OutdoorAir:Mixer OutdoorAir:NodeList -- Represents an external node when a heat exchanger is used before the OutdoorAir:Mixer OutdoorAir:Node -- Represents an external node when a heat exchanger is used before the OutdoorAir:Mixer Other -- none of the above, the Node name already defined in the previous field is part of an air loop.")]
[JsonProperty("component_object_type_or_node_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_Distribution_Node_ComponentObjectTypeOrNodeType ComponentObjectTypeOrNodeType { get; set; } = (AirflowNetwork_Distribution_Node_ComponentObjectTypeOrNodeType)Enum.Parse(typeof(AirflowNetwork_Distribution_Node_ComponentObjectTypeOrNodeType), "Other");
        

[Description("Enter the reference height used to calculate the relative pressure.")]
[JsonProperty("node_height")]
public System.Nullable<float> NodeHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum AirflowNetwork_Distribution_Node_ComponentObjectTypeOrNodeType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:OutdoorAirSystem")]
        AirLoopHVACOutdoorAirSystem = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:ZoneMixer")]
        AirLoopHVACZoneMixer = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:ZoneSplitter")]
        AirLoopHVACZoneSplitter = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OAMixerOutdoorAirStreamNode")]
        OAMixerOutdoorAirStreamNode = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Other")]
        Other = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAir:Node")]
        OutdoorAirNode = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAir:NodeList")]
        OutdoorAirNodeList = 7,
    }
    
    [Description("This object defines the characteristics of a supply or return air leak.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_Leak : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Defined at 1 Pa pressure difference across this component. Enter the coefficient " +
    "used in the following equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP" +
    ")^Air Mass Flow Exponent")]
[JsonProperty("air_mass_flow_coefficient")]
public System.Nullable<float> AirMassFlowCoefficient { get; set; } = null;
        

[Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
    " Coefficient * (dP)^Air Mass Flow Exponent")]
[JsonProperty("air_mass_flow_exponent")]
public System.Nullable<float> AirMassFlowExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
    }
    
    [Description("This object is used to define supply and return air leaks with respect to the fan" +
        "\'s maximum air flow rate.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_LeakageRatio : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Defined as a ratio of leak flow rate to the maximum flow rate.")]
[JsonProperty("effective_leakage_ratio")]
public System.Nullable<float> EffectiveLeakageRatio { get; set; } = null;
        

[Description("Enter the maximum air flow rate in this air loop.")]
[JsonProperty("maximum_flow_rate")]
public System.Nullable<float> MaximumFlowRate { get; set; } = null;
        

[Description("Enter the pressure corresponding to the Effective leakage ratio entered above.")]
[JsonProperty("reference_pressure_difference")]
public System.Nullable<float> ReferencePressureDifference { get; set; } = null;
        

[Description("Enter the exponent used in the air mass flow equation.")]
[JsonProperty("air_mass_flow_exponent")]
public System.Nullable<float> AirMassFlowExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
    }
    
    [Description("This object defines the relationship between pressure and air flow through the du" +
        "ct.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_Duct : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the length of the duct.")]
[JsonProperty("duct_length")]
public System.Nullable<float> DuctLength { get; set; } = null;
        

[Description("Enter the hydraulic diameter of the duct. Hydraulic diameter is defined as 4 mult" +
    "iplied by cross section area divided by perimeter")]
[JsonProperty("hydraulic_diameter")]
public System.Nullable<float> HydraulicDiameter { get; set; } = null;
        

[Description("Enter the cross section area of the duct.")]
[JsonProperty("cross_section_area")]
public System.Nullable<float> CrossSectionArea { get; set; } = null;
        

[Description("Enter the inside surface roughness of the duct.")]
[JsonProperty("surface_roughness")]
public System.Nullable<float> SurfaceRoughness { get; set; } = (System.Nullable<float>)Single.Parse("0.0009", CultureInfo.InvariantCulture);
        

[Description("Enter the coefficient used to calculate dynamic losses of fittings (e.g. elbows)." +
    "")]
[JsonProperty("coefficient_for_local_dynamic_loss_due_to_fitting")]
public System.Nullable<float> CoefficientForLocalDynamicLossDueToFitting { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("conduction only Default value of 0.943 is equivalent to 1.06 m2-K/W (R6) duct ins" +
    "ulation.")]
[JsonProperty("heat_transmittance_coefficient_u_factor_for_duct_wall_construction")]
public System.Nullable<float> HeatTransmittanceCoefficientUFactorForDuctWallConstruction { get; set; } = (System.Nullable<float>)Single.Parse("0.943", CultureInfo.InvariantCulture);
        

[Description("Enter the overall moisture transmittance coefficient including moisture film coef" +
    "ficients at both surfaces.")]
[JsonProperty("overall_moisture_transmittance_coefficient_from_air_to_air")]
public System.Nullable<float> OverallMoistureTransmittanceCoefficientFromAirToAir { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[Description("optional. convection coefficient calculated automatically, unless specified")]
[JsonProperty("outside_convection_coefficient")]
public System.Nullable<float> OutsideConvectionCoefficient { get; set; } = null;
        

[Description("optional. convection coefficient calculated automatically, unless specified")]
[JsonProperty("inside_convection_coefficient")]
public System.Nullable<float> InsideConvectionCoefficient { get; set; } = null;
    }
    
    [Description("This object defines the name of the supply Air Fan used in an Air loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_Fan : BHoMObject
    {
        

[Description("Enter the name of the fan in the primary air loop.")]
[JsonProperty("fan_name")]
public string FanName { get; set; } = "";
        

[JsonProperty("supply_fan_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType), "Empty");
    }
    
    public enum AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:ConstantVolume")]
        FanConstantVolume = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:OnOff")]
        FanOnOff = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:SystemModel")]
        FanSystemModel = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:VariableVolume")]
        FanVariableVolume = 4,
    }
    
    [Description("This object defines the name of a coil used in an air loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_Coil : BHoMObject
    {
        

[Description("Enter the name of a cooling or heating coil in the primary Air loop.")]
[JsonProperty("coil_name")]
public string CoilName { get; set; } = "";
        

[Description("Select the type of coil corresponding to the name entered in the field above.")]
[JsonProperty("coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_Distribution_Component_Coil_CoilObjectType CoilObjectType { get; set; } = (AirflowNetwork_Distribution_Component_Coil_CoilObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_Coil_CoilObjectType), "CoilCoolingDX");
        

[Description("Enter the air path length (depth) for the coil.")]
[JsonProperty("air_path_length")]
public System.Nullable<float> AirPathLength { get; set; } = null;
        

[Description("Enter the hydraulic diameter of this coil. The hydraulic diameter is defined as 4" +
    " multiplied by the cross section area divided by perimeter.")]
[JsonProperty("air_path_hydraulic_diameter")]
public System.Nullable<float> AirPathHydraulicDiameter { get; set; } = null;
    }
    
    public enum AirflowNetwork_Distribution_Component_Coil_CoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX")]
        CoilCoolingDX = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water")]
        CoilCoolingWater = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:MultiSpeed")]
        CoilHeatingDXMultiSpeed = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Electric")]
        CoilHeatingElectric = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Fuel")]
        CoilHeatingFuel = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Water")]
        CoilHeatingWater = 12,
    }
    
    [Description("This object defines the name of an air-to-air heat exchanger used in an air loop." +
        "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_HeatExchanger : BHoMObject
    {
        

[Description("Enter the name of an air-to-air heat exchanger in the primary Air loop.")]
[JsonProperty("heatexchanger_name")]
public string HeatexchangerName { get; set; } = "";
        

[Description("Select the type of heat exchanger corresponding to the name entered in the field " +
    "above.")]
[JsonProperty("heatexchanger_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_Distribution_Component_HeatExchanger_HeatexchangerObjectType HeatexchangerObjectType { get; set; } = (AirflowNetwork_Distribution_Component_HeatExchanger_HeatexchangerObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_HeatExchanger_HeatexchangerObjectType), "HeatExchangerAirToAirFlatPlate");
        

[Description("Enter the air path length (depth) for the heat exchanger.")]
[JsonProperty("air_path_length")]
public System.Nullable<float> AirPathLength { get; set; } = null;
        

[Description("Enter the hydraulic diameter of this heat exchanger. The hydraulic diameter is de" +
    "fined as 4 multiplied by the cross section area divided by perimeter.")]
[JsonProperty("air_path_hydraulic_diameter")]
public System.Nullable<float> AirPathHydraulicDiameter { get; set; } = null;
    }
    
    public enum AirflowNetwork_Distribution_Component_HeatExchanger_HeatexchangerObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:AirToAir:FlatPlate")]
        HeatExchangerAirToAirFlatPlate = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:AirToAir:SensibleAndLatent")]
        HeatExchangerAirToAirSensibleAndLatent = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:Desiccant:BalancedFlow")]
        HeatExchangerDesiccantBalancedFlow = 2,
    }
    
    [Description("This object defines the name of a terminal unit in an air loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_TerminalUnit : BHoMObject
    {
        

[Description("Enter the name of a terminal unit in the AirLoopHVAC.")]
[JsonProperty("terminal_unit_name")]
public string TerminalUnitName { get; set; } = "";
        

[Description("Select the type of terminal unit corresponding to the name entered in the field a" +
    "bove.")]
[JsonProperty("terminal_unit_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirflowNetwork_Distribution_Component_TerminalUnit_TerminalUnitObjectType TerminalUnitObjectType { get; set; } = (AirflowNetwork_Distribution_Component_TerminalUnit_TerminalUnitObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_TerminalUnit_TerminalUnitObjectType), "AirTerminalSingleDuctConstantVolumeReheat");
        

[Description("Enter the air path length (depth) for the terminal unit.")]
[JsonProperty("air_path_length")]
public System.Nullable<float> AirPathLength { get; set; } = null;
        

[Description("Enter the hydraulic diameter of this terminal unit. The hydraulic diameter is def" +
    "ined as 4 multiplied by the cross section area divided by perimeter.")]
[JsonProperty("air_path_hydraulic_diameter")]
public System.Nullable<float> AirPathHydraulicDiameter { get; set; } = null;
    }
    
    public enum AirflowNetwork_Distribution_Component_TerminalUnit_TerminalUnitObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:Reheat")]
        AirTerminalSingleDuctConstantVolumeReheat = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:Reheat")]
        AirTerminalSingleDuctVAVReheat = 1,
    }
    
    [Description(@"This object defines the characteristics of a constant pressure drop component (e.g. filter). Each node connected to this object can not be a node of mixer, splitter, a node of air primary loop, or zone equipment loop. It is recommended to connect to a duct component at both ends.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_ConstantPressureDrop : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the pressure drop across this component.")]
[JsonProperty("pressure_difference_across_the_component")]
public System.Nullable<float> PressureDifferenceAcrossTheComponent { get; set; } = null;
    }
    
    [Description("This object includes the outdoor air flow rate set by the Controller:OutdoorAir o" +
        "bject in the airflow network.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_OutdoorAirFlow : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("outdoor_air_mixer_name")]
public string OutdoorAirMixerName { get; set; } = "";
        

[Description(@"Enter the air mass flow coefficient at the conditions defined in the Reference Crack Conditions object. Defined at 1 Pa pressure difference. Enter the coefficient used in the following equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Exponent. Used only when no outdoor air flow rate.")]
[JsonProperty("air_mass_flow_coefficient_when_no_outdoor_air_flow_at_reference_conditions")]
public System.Nullable<float> AirMassFlowCoefficientWhenNoOutdoorAirFlowAtReferenceConditions { get; set; } = null;
        

[Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
    " Coefficient * (dP)^Air Mass Flow Exponent. Used only when no outdoor air flow r" +
    "ate.")]
[JsonProperty("air_mass_flow_exponent_when_no_outdoor_air_flow")]
public System.Nullable<float> AirMassFlowExponentWhenNoOutdoorAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description("Select a AirflowNetwork:MultiZone:ReferenceCrackConditions name associated with t" +
    "he air mass flow coefficient entered above.")]
[JsonProperty("reference_crack_conditions")]
public string ReferenceCrackConditions { get; set; } = "";
    }
    
    [Description("This object allows variation of air flow rate to perform pressure.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_ReliefAirFlow : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("outdoor_air_mixer_name")]
public string OutdoorAirMixerName { get; set; } = "";
        

[Description(@"Enter the air mass flow coefficient at the conditions defined in the Reference Crack Conditions object. Defined at 1 Pa pressure difference. Enter the coefficient used in the following equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Exponent. Used only when no outdoor air flow rate.")]
[JsonProperty("air_mass_flow_coefficient_when_no_outdoor_air_flow_at_reference_conditions")]
public System.Nullable<float> AirMassFlowCoefficientWhenNoOutdoorAirFlowAtReferenceConditions { get; set; } = null;
        

[Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
    " Coefficient * (dP)^Air Mass Flow Exponent. Used only when no outdoor air flow r" +
    "ate.")]
[JsonProperty("air_mass_flow_exponent_when_no_outdoor_air_flow")]
public System.Nullable<float> AirMassFlowExponentWhenNoOutdoorAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description("Select a AirflowNetwork:MultiZone:ReferenceCrackConditions name associated with t" +
    "he air mass flow coefficient entered above.")]
[JsonProperty("reference_crack_conditions")]
public string ReferenceCrackConditions { get; set; } = "";
    }
    
    [Description("This object defines the connection between two nodes and a component.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Linkage : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the name of zone or AirflowNetwork Node.")]
[JsonProperty("node_1_name")]
public string Node1Name { get; set; } = "";
        

[Description("Enter the name of zone or AirflowNetwork Node.")]
[JsonProperty("node_2_name")]
public string Node2Name { get; set; } = "";
        

[Description("Enter the name of an AirflowNetwork component. A component is one of the followin" +
    "g AirflowNetwork:Distribution:Component objects: Leak, LeakageRatio, Duct, Const" +
    "antVolumeFan, Coil, TerminalUnit, ConstantPressureDrop, or HeatExchanger.")]
[JsonProperty("component_name")]
public string ComponentName { get; set; } = "";
        

[Description("Only used if component = AirflowNetwork:Distribution:Component:Duct The zone name" +
    " is where AirflowNetwork:Distribution:Component:Duct is exposed. Leave this fiel" +
    "d blank if the duct conduction loss is ignored.")]
[JsonProperty("thermal_zone_name")]
public string ThermalZoneName { get; set; } = "";
    }
    
    [Description("This object is used to allow user-defined view factors to be used for duct-surfac" +
        "e radiation calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_DuctViewFactors : BHoMObject
    {
        

[JsonProperty("linkage_name")]
public string LinkageName { get; set; } = "";
        

[JsonProperty("duct_surface_exposure_fraction")]
public System.Nullable<float> DuctSurfaceExposureFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("duct_surface_emittance")]
public System.Nullable<float> DuctSurfaceEmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("surfaces")]
public string Surfaces { get; set; } = "";
    }
    
    [Description("This object is used to provide advanced thermal comfort control of window opening" +
        " and closing for both exterior and interior windows.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_OccupantVentilationControl : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("minimum_opening_time")]
public System.Nullable<float> MinimumOpeningTime { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_closing_time")]
public System.Nullable<float> MinimumClosingTime { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Enter a curve name that represents thermal comfort temperature as a function of outdoor dry-bulb temperature. Up to two curves are allowed if the performance cannot be represented by a single curve. The following two fields are used if two curves are required.")]
[JsonProperty("thermal_comfort_low_temperature_curve_name")]
public string ThermalComfortLowTemperatureCurveName { get; set; } = "";
        

[Description("This point is used to allow separate low and high thermal comfort temperature cur" +
    "ves. If a single performance curve is used, leave this field blank.")]
[JsonProperty("thermal_comfort_temperature_boundary_point")]
public System.Nullable<float> ThermalComfortTemperatureBoundaryPoint { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description(@"Enter a curve name that represents thermal comfort temperature as a function of outdoor dry-bulb temperature. Up to two curves are allowed if the performance cannot be represented by a single curve. If a single performance curve is used, leave this field blank.")]
[JsonProperty("thermal_comfort_high_temperature_curve_name")]
public string ThermalComfortHighTemperatureCurveName { get; set; } = "";
        

[JsonProperty("maximum_threshold_for_persons_dissatisfied_ppd")]
public System.Nullable<float> MaximumThresholdForPersonsDissatisfiedPpd { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("If Yes, occupancy check will be performed as part of the opening probability chec" +
    "k.")]
[JsonProperty("occupancy_check")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OccupancyCheck { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("If this field is blank, the opening probability check is bypassed and opening is " +
    "true.")]
[JsonProperty("opening_probability_schedule_name")]
public string OpeningProbabilityScheduleName { get; set; } = "";
        

[Description("If this field is blank, the closing probability check is bypassed and closing is " +
    "true.")]
[JsonProperty("closing_probability_schedule_name")]
public string ClosingProbabilityScheduleName { get; set; } = "";
    }
    
    [Description("This object represents a node in a zone in the combination of RoomAir and Airflow" +
        "Network model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_IntraZone_Node : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the name of a RoomAir:Node object defined in a RoomAirSettings:AirflowNetwo" +
    "rk object.")]
[JsonProperty("roomair_node_airflownetwork_name")]
public string RoomairNodeAirflownetworkName { get; set; } = "";
        

[Description("Enter the name of a zone object defined in a AirflowNetwork:MultiZone:Zone object" +
    ".")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the reference height used to calculate the relative pressure")]
[JsonProperty("node_height")]
public System.Nullable<float> NodeHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("This object defines the connection between two nodes and a component used in the " +
        "combination of RoomAir and AirflowNetwork model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_IntraZone_Linkage : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Enter the name of zone or AirflowNetwork Node.")]
[JsonProperty("node_1_name")]
public string Node1Name { get; set; } = "";
        

[Description("Enter the name of zone or AirflowNetwork Node.")]
[JsonProperty("node_2_name")]
public string Node2Name { get; set; } = "";
        

[Description(@"Enter the name of an AirflowNetwork component. A component is one of the following AirflowNetwork:Multizone:Component objects: AirflowNetwork:MultiZone:Surface:Crack, AirflowNetwork:MultiZone:Surface:EffectiveLeakageArea, If the next field is specified, this field can be either blank or ignored.")]
[JsonProperty("component_name")]
public string ComponentName { get; set; } = "";
        

[Description("Only used when one of two nodes defined above are not located in the same zone, a" +
    "nd the input of the Component Name field in this object is ignored")]
[JsonProperty("airflownetwork_multizone_surface_name")]
public string AirflownetworkMultizoneSurfaceName { get; set; } = "";
    }
}
