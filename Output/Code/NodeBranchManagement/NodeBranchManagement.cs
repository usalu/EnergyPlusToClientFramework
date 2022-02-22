namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
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
    
    
    [Description("List components on the branch in simulation and connection order Note: this shoul" +
        "d NOT include splitters or mixers which define endpoints of branches")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Branch : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description(@"Optional field to include this branch in plant pressure drop calculations This field is only relevant for branches in PlantLoops and CondenserLoops Air loops do not account for pressure drop using this field Valid curve types are: Curve:Functional:PressureDrop or one of Curve:{Linear,Quadratic,Cubic,Exponent}')")]
[JsonProperty("pressure_drop_curve_name")]
public string PressureDropCurveName { get; set; } = "";
        

[JsonProperty("components")]
public string Components { get; set; } = "";
    }
    
    [Description("Branches MUST be listed in Flow order: Inlet branch, then parallel branches, then" +
        " Outlet branch. Branches are simulated in the order listed. Branch names cannot " +
        "be duplicated within a single branch list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class BranchList : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("branches")]
public string Branches { get; set; } = "";
    }
    
    [Description("Split one air/water stream into N outlet streams. Branch names cannot be duplicat" +
        "ed within a single Splitter list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Connector_Splitter : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_branch_name")]
public string InletBranchName { get; set; } = "";
        

[JsonProperty("branches")]
public string Branches { get; set; } = "";
    }
    
    [Description("Mix N inlet air/water streams into one. Branch names cannot be duplicated within " +
        "a single mixer list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Connector_Mixer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("outlet_branch_name")]
public string OutletBranchName { get; set; } = "";
        

[JsonProperty("branches")]
public string Branches { get; set; } = "";
    }
    
    [Description("only two connectors allowed per loop if two entered, one must be Connector:Splitt" +
        "er and one must be Connector:Mixer")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ConnectorList : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("connector_1_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ConnectorList_Connector1ObjectType Connector1ObjectType { get; set; } = (ConnectorList_Connector1ObjectType)Enum.Parse(typeof(ConnectorList_Connector1ObjectType), "ConnectorMixer");
        

[JsonProperty("connector_1_name")]
public string Connector1Name { get; set; } = "";
        

[JsonProperty("connector_2_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ConnectorList_Connector2ObjectType Connector2ObjectType { get; set; } = (ConnectorList_Connector2ObjectType)Enum.Parse(typeof(ConnectorList_Connector2ObjectType), "ConnectorMixer");
        

[JsonProperty("connector_2_name")]
public string Connector2Name { get; set; } = "";
    }
    
    public enum ConnectorList_Connector1ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Connector:Mixer")]
        ConnectorMixer = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Connector:Splitter")]
        ConnectorSplitter = 1,
    }
    
    public enum ConnectorList_Connector2ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Connector:Mixer")]
        ConnectorMixer = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Connector:Splitter")]
        ConnectorSplitter = 1,
    }
    
    [Description("This object is used in places where lists of nodes may be needed, e.g. ZoneHVAC:E" +
        "quipmentConnections field Zone Air Inlet Node or NodeList Name")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class NodeList : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("nodes")]
public string Nodes { get; set; } = "";
    }
    
    [Description(@"This object sets the temperature and humidity conditions for an outdoor air node. It allows the height above ground to be specified. This object may be used more than once. The same node name may not appear in both an OutdoorAir:Node object and an OutdoorAir:NodeList object. This object defines local outdoor air environmental conditions.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutdoorAir_Node : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("A value less than zero indicates that the height will be ignored and the weather " +
    "file conditions will be used.")]
[JsonProperty("height_above_ground")]
public System.Nullable<float> HeightAboveGround { get; set; } = (System.Nullable<float>)Single.Parse("-1", CultureInfo.InvariantCulture);
        

[Description("Schedule values are real numbers, -100.0 to 100.0, units C")]
[JsonProperty("drybulb_temperature_schedule_name")]
public string DrybulbTemperatureScheduleName { get; set; } = "";
        

[Description("Schedule values are real numbers, -100.0 to 100.0, units C")]
[JsonProperty("wetbulb_temperature_schedule_name")]
public string WetbulbTemperatureScheduleName { get; set; } = "";
        

[Description("Schedule values are real numbers, 0.0 to 40.0, units m/s")]
[JsonProperty("wind_speed_schedule_name")]
public string WindSpeedScheduleName { get; set; } = "";
        

[Description("Schedule values are real numbers, 0.0 to 360.0, units degree")]
[JsonProperty("wind_direction_schedule_name")]
public string WindDirectionScheduleName { get; set; } = "";
        

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
public OutdoorAir_Node_WindAngleType WindAngleType { get; set; } = (OutdoorAir_Node_WindAngleType)Enum.Parse(typeof(OutdoorAir_Node_WindAngleType), "Absolute");
    }
    
    public enum OutdoorAir_Node_WindAngleType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Absolute")]
        Absolute = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Relative")]
        Relative = 2,
    }
    
    [Description(@"This object sets the temperature and humidity conditions for an outdoor air node using the weather data values. to vary outdoor air node conditions with height above ground use OutdoorAir:Node instead of this object. This object may be used more than once. The same node name may not appear in both an OutdoorAir:Node object and an OutdoorAir:NodeList object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutdoorAir_NodeList : BHoMObject
    {
        

[JsonProperty("nodes")]
public string Nodes { get; set; } = "";
    }
    
    [Description("Passes Inlet Node state variables to Outlet Node state variables")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pipe_Adiabatic : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
    }
    
    [Description("Passes Inlet Node state variables to Outlet Node state variables")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pipe_Adiabatic_Steam : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
    }
    
    [Description("Pipe model with transport delay and heat transfer to the environment.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pipe_Indoor : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[JsonProperty("fluid_inlet_node_name")]
public string FluidInletNodeName { get; set; } = "";
        

[JsonProperty("fluid_outlet_node_name")]
public string FluidOutletNodeName { get; set; } = "";
        

[JsonProperty("environment_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Pipe_Indoor_EnvironmentType EnvironmentType { get; set; } = (Pipe_Indoor_EnvironmentType)Enum.Parse(typeof(Pipe_Indoor_EnvironmentType), "Zone");
        

[JsonProperty("ambient_temperature_zone_name")]
public string AmbientTemperatureZoneName { get; set; } = "";
        

[JsonProperty("ambient_temperature_schedule_name")]
public string AmbientTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("ambient_air_velocity_schedule_name")]
public string AmbientAirVelocityScheduleName { get; set; } = "";
        

[JsonProperty("pipe_inside_diameter")]
public System.Nullable<float> PipeInsideDiameter { get; set; } = null;
        

[JsonProperty("pipe_length")]
public System.Nullable<float> PipeLength { get; set; } = null;
    }
    
    public enum Pipe_Indoor_EnvironmentType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    [Description("Pipe model with transport delay and heat transfer to the environment.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pipe_Outdoor : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[JsonProperty("fluid_inlet_node_name")]
public string FluidInletNodeName { get; set; } = "";
        

[JsonProperty("fluid_outlet_node_name")]
public string FluidOutletNodeName { get; set; } = "";
        

[JsonProperty("ambient_temperature_outdoor_air_node_name")]
public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

[JsonProperty("pipe_inside_diameter")]
public System.Nullable<float> PipeInsideDiameter { get; set; } = null;
        

[JsonProperty("pipe_length")]
public System.Nullable<float> PipeLength { get; set; } = null;
    }
    
    [Description("Buried Pipe model: For pipes buried at a depth less than one meter, this is an al" +
        "ternative object to: HeatExchanger:Surface")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pipe_Underground : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[JsonProperty("fluid_inlet_node_name")]
public string FluidInletNodeName { get; set; } = "";
        

[JsonProperty("fluid_outlet_node_name")]
public string FluidOutletNodeName { get; set; } = "";
        

[JsonProperty("sun_exposure")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Pipe_Underground_SunExposure SunExposure { get; set; } = (Pipe_Underground_SunExposure)Enum.Parse(typeof(Pipe_Underground_SunExposure), "NoSun");
        

[Description("pipe thickness is defined in the Construction object")]
[JsonProperty("pipe_inside_diameter")]
public System.Nullable<float> PipeInsideDiameter { get; set; } = null;
        

[JsonProperty("pipe_length")]
public System.Nullable<float> PipeLength { get; set; } = null;
        

[JsonProperty("soil_material_name")]
public string SoilMaterialName { get; set; } = "";
        

[JsonProperty("undisturbed_ground_temperature_model_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Pipe_Underground_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (Pipe_Underground_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(Pipe_Underground_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

[JsonProperty("undisturbed_ground_temperature_model_name")]
public string UndisturbedGroundTemperatureModelName { get; set; } = "";
    }
    
    public enum Pipe_Underground_SunExposure
    {
        
        [System.Runtime.Serialization.EnumMember(Value="NoSun")]
        NoSun = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SunExposed")]
        SunExposed = 1,
    }
    
    public enum Pipe_Underground_UndisturbedGroundTemperatureModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:FiniteDifference")]
        SiteGroundTemperatureUndisturbedFiniteDifference = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:KusudaAchenbach")]
        SiteGroundTemperatureUndisturbedKusudaAchenbach = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:Xing")]
        SiteGroundTemperatureUndisturbedXing = 2,
    }
    
    [Description("The ground domain object for underground piping system simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PipingSystem_Underground_Domain : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Domain extent in the local \'X\' direction")]
[JsonProperty("xmax")]
public System.Nullable<float> Xmax { get; set; } = null;
        

[Description("Domain extent in the local \'Y\' direction")]
[JsonProperty("ymax")]
public System.Nullable<float> Ymax { get; set; } = null;
        

[Description("Domain extent in the local \'Y\' direction")]
[JsonProperty("zmax")]
public System.Nullable<float> Zmax { get; set; } = null;
        

[Description("If mesh type is symmetric geometric, this should be an even number.")]
[JsonProperty("x_direction_mesh_density_parameter")]
public System.Nullable<float> XDirectionMeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

[JsonProperty("x_direction_mesh_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PipingSystem_Underground_Domain_XDirectionMeshType XDirectionMeshType { get; set; } = (PipingSystem_Underground_Domain_XDirectionMeshType)Enum.Parse(typeof(PipingSystem_Underground_Domain_XDirectionMeshType), "SymmetricGeometric");
        

[Description("optional Only used if mesh type is symmetric geometric")]
[JsonProperty("x_direction_geometric_coefficient")]
public System.Nullable<float> XDirectionGeometricCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.3", CultureInfo.InvariantCulture);
        

[Description("If mesh type is symmetric geometric, this should be an even number.")]
[JsonProperty("y_direction_mesh_density_parameter")]
public System.Nullable<float> YDirectionMeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

[JsonProperty("y_direction_mesh_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PipingSystem_Underground_Domain_YDirectionMeshType YDirectionMeshType { get; set; } = (PipingSystem_Underground_Domain_YDirectionMeshType)Enum.Parse(typeof(PipingSystem_Underground_Domain_YDirectionMeshType), "SymmetricGeometric");
        

[Description("optional Only used if mesh type is symmetric geometric")]
[JsonProperty("y_direction_geometric_coefficient")]
public System.Nullable<float> YDirectionGeometricCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.3", CultureInfo.InvariantCulture);
        

[Description("If mesh type is symmetric geometric, this should be an even number.")]
[JsonProperty("z_direction_mesh_density_parameter")]
public System.Nullable<float> ZDirectionMeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

[JsonProperty("z_direction_mesh_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PipingSystem_Underground_Domain_ZDirectionMeshType ZDirectionMeshType { get; set; } = (PipingSystem_Underground_Domain_ZDirectionMeshType)Enum.Parse(typeof(PipingSystem_Underground_Domain_ZDirectionMeshType), "SymmetricGeometric");
        

[Description("optional Only used if mesh type is symmetric geometric")]
[JsonProperty("z_direction_geometric_coefficient")]
public System.Nullable<float> ZDirectionGeometricCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.3", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_thermal_conductivity")]
public System.Nullable<float> SoilThermalConductivity { get; set; } = null;
        

[JsonProperty("soil_density")]
public System.Nullable<float> SoilDensity { get; set; } = null;
        

[Description("This is a dry soil property, which is adjusted for freezing effects by the simula" +
    "tion algorithm.")]
[JsonProperty("soil_specific_heat")]
public System.Nullable<float> SoilSpecificHeat { get; set; } = null;
        

[JsonProperty("soil_moisture_content_volume_fraction")]
public System.Nullable<float> SoilMoistureContentVolumeFraction { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_moisture_content_volume_fraction_at_saturation")]
public System.Nullable<float> SoilMoistureContentVolumeFractionAtSaturation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[JsonProperty("undisturbed_ground_temperature_model_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

[JsonProperty("undisturbed_ground_temperature_model_name")]
public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

[Description("if Yes, then the following basement inputs are used if No, then the following bas" +
    "ement inputs are *ignored*")]
[JsonProperty("this_domain_includes_basement_surface_interaction")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes ThisDomainIncludesBasementSurfaceInteraction { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Required only if Domain Has Basement Interaction")]
[JsonProperty("width_of_basement_floor_in_ground_domain")]
public System.Nullable<float> WidthOfBasementFloorInGroundDomain { get; set; } = null;
        

[Description("Required only if Domain Has Basement Interaction")]
[JsonProperty("depth_of_basement_wall_in_ground_domain")]
public System.Nullable<float> DepthOfBasementWallInGroundDomain { get; set; } = null;
        

[Description("Required only if Domain Has Basement Interaction")]
[JsonProperty("shift_pipe_x_coordinates_by_basement_width")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth ShiftPipeXCoordinatesByBasementWidth { get; set; } = (PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth)Enum.Parse(typeof(PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth), "No");
        

[Description("Required only if Domain Has Basement Interaction")]
[JsonProperty("name_of_basement_wall_boundary_condition_model")]
public string NameOfBasementWallBoundaryConditionModel { get; set; } = "";
        

[Description("Required only if Domain Has Basement Interaction")]
[JsonProperty("name_of_basement_floor_boundary_condition_model")]
public string NameOfBasementFloorBoundaryConditionModel { get; set; } = "";
        

[JsonProperty("convergence_criterion_for_the_outer_cartesian_domain_iteration_loop")]
public System.Nullable<float> ConvergenceCriterionForTheOuterCartesianDomainIterationLoop { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_iterations_in_the_outer_cartesian_domain_iteration_loop")]
public System.Nullable<float> MaximumIterationsInTheOuterCartesianDomainIterationLoop { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

[Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
[JsonProperty("evapotranspiration_ground_cover_parameter")]
public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[JsonProperty("number_of_pipe_circuits_entered_for_this_domain")]
public System.Nullable<float> NumberOfPipeCircuitsEnteredForThisDomain { get; set; } = null;
        

[JsonProperty("pipe_circuits")]
public string PipeCircuits { get; set; } = "";
    }
    
    public enum PipingSystem_Underground_Domain_XDirectionMeshType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="SymmetricGeometric")]
        SymmetricGeometric = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Uniform")]
        Uniform = 1,
    }
    
    public enum PipingSystem_Underground_Domain_YDirectionMeshType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="SymmetricGeometric")]
        SymmetricGeometric = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Uniform")]
        Uniform = 1,
    }
    
    public enum PipingSystem_Underground_Domain_ZDirectionMeshType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="SymmetricGeometric")]
        SymmetricGeometric = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Uniform")]
        Uniform = 1,
    }
    
    public enum PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:FiniteDifference")]
        SiteGroundTemperatureUndisturbedFiniteDifference = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:KusudaAchenbach")]
        SiteGroundTemperatureUndisturbedKusudaAchenbach = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:Xing")]
        SiteGroundTemperatureUndisturbedXing = 2,
    }
    
    public enum PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth
    {
        
        [System.Runtime.Serialization.EnumMember(Value="No")]
        No = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Yes")]
        Yes = 1,
    }
    
    [Description("The pipe circuit object in an underground piping system. This object is simulated" +
        " within an underground piping domain object and connected on a branch on a plant" +
        " loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PipingSystem_Underground_PipeCircuit : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("pipe_thermal_conductivity")]
public System.Nullable<float> PipeThermalConductivity { get; set; } = null;
        

[JsonProperty("pipe_density")]
public System.Nullable<float> PipeDensity { get; set; } = null;
        

[JsonProperty("pipe_specific_heat")]
public System.Nullable<float> PipeSpecificHeat { get; set; } = null;
        

[JsonProperty("pipe_inner_diameter")]
public System.Nullable<float> PipeInnerDiameter { get; set; } = null;
        

[JsonProperty("pipe_outer_diameter")]
public System.Nullable<float> PipeOuterDiameter { get; set; } = null;
        

[JsonProperty("design_flow_rate")]
public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

[JsonProperty("circuit_inlet_node")]
public string CircuitInletNode { get; set; } = "";
        

[JsonProperty("circuit_outlet_node")]
public string CircuitOutletNode { get; set; } = "";
        

[JsonProperty("convergence_criterion_for_the_inner_radial_iteration_loop")]
public System.Nullable<float> ConvergenceCriterionForTheInnerRadialIterationLoop { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_iterations_in_the_inner_radial_iteration_loop")]
public System.Nullable<float> MaximumIterationsInTheInnerRadialIterationLoop { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

[JsonProperty("number_of_soil_nodes_in_the_inner_radial_near_pipe_mesh_region")]
public System.Nullable<float> NumberOfSoilNodesInTheInnerRadialNearPipeMeshRegion { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Required because it must be selected by user instead of being inferred from circu" +
    "it/domain object inputs.")]
[JsonProperty("radial_thickness_of_inner_radial_near_pipe_mesh_region")]
public System.Nullable<float> RadialThicknessOfInnerRadialNearPipeMeshRegion { get; set; } = null;
        

[JsonProperty("number_of_pipe_segments_entered_for_this_pipe_circuit")]
public System.Nullable<float> NumberOfPipeSegmentsEnteredForThisPipeCircuit { get; set; } = null;
        

[JsonProperty("pipe_segments")]
public string PipeSegments { get; set; } = "";
    }
    
    [Description("The pipe segment to be used in an underground piping system This object represent" +
        "s a single pipe leg positioned axially in the local z-direction, at a given x, y" +
        " location in the domain")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PipingSystem_Underground_PipeSegment : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("This segment will be centered at this distance from the x=0 domain surface or the" +
    " basement wall surface, based on whether a basement exists in this domain and th" +
    "e selection of the shift input field found in the domain object.")]
[JsonProperty("x_position")]
public System.Nullable<float> XPosition { get; set; } = null;
        

[Description("This segment will be centered at this distance away from the ground surface; thus" +
    " this value represents the burial depth of this pipe segment.")]
[JsonProperty("y_position")]
public System.Nullable<float> YPosition { get; set; } = null;
        

[Description("This segment will be simulated such that the flow is in the selected direction. T" +
    "his can allow for detailed analysis of circuiting effects in a single domain.")]
[JsonProperty("flow_direction")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PipingSystem_Underground_PipeSegment_FlowDirection FlowDirection { get; set; } = (PipingSystem_Underground_PipeSegment_FlowDirection)Enum.Parse(typeof(PipingSystem_Underground_PipeSegment_FlowDirection), "DecreasingZ");
    }
    
    public enum PipingSystem_Underground_PipeSegment_FlowDirection
    {
        
        [System.Runtime.Serialization.EnumMember(Value="DecreasingZ")]
        DecreasingZ = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IncreasingZ")]
        IncreasingZ = 1,
    }
    
    [Description("Passes inlet node state variables to outlet node state variables")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Duct : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
    }
}
