namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
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
    
    
    [Description(null)]
    public class ZoneHVAC_Baseboard_RadiantConvective_Water_Design : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Enter the method used to determine the heating design capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_Baseboard_RadiantConvective_Water_Design_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_Baseboard_RadiantConvective_Water_Design_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_Baseboard_RadiantConvective_Water_Design_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
    "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
    "ity.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("convergence_tolerance")]
public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = null;
        

[JsonProperty("fraction_of_radiant_energy_incident_on_people")]
public System.Nullable<float> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
    }
    
    public enum ZoneHVAC_Baseboard_RadiantConvective_Water_Design_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
    
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
        "roups to the end of the list")]
    public class ZoneHVAC_Baseboard_RadiantConvective_Water : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("design_object")]
public string DesignObject { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[Description("Rated average water temperature is the average of the inlet and outlet water temp" +
    "eratures at rated conditions.")]
[JsonProperty("rated_average_water_temperature")]
public System.Nullable<float> RatedAverageWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("87.78", CultureInfo.InvariantCulture);
        

[Description(@"Standard is I=B=R Rating document where all baseboards are rated at either 0.063 kg/s (1 gpm) or 0.252 kg/s (4 gpm). It is recommended that users find data for the baseboard heater that corresponds to performance at 0.063 kg/s unless the flow rate is expected to be above 0.252 kg/s. If the flow rate is expected to be above 0.252 kg/s, this field should be 0.252 kg/s.")]
[JsonProperty("rated_water_mass_flow_rate")]
public System.Nullable<float> RatedWaterMassFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0.063", CultureInfo.InvariantCulture);
        

[Description(@"Enter the design heating capacity. Required field when the heating design capacity method HeatingDesignCapacity. This input field is rated heating capacity. Users must multiply the actual finned length published in the literature to determine the rated capacity. Rated Capacity is for an inlet air dry-bulb temperature of 18.0C, the Rated Water Mass Flow Rate of 0.063kg/s or 0.252kg/s, and the Rated Average Water Temperature between 32.2C and 115.6C.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("maximum_water_flow_rate")]
public string MaximumWaterFlowRate { get; set; } = "";
        

[JsonProperty("surface_fractions")]
public string SurfaceFractions { get; set; } = "";
    }
    
    [Description(null)]
    public class ZoneHVAC_Baseboard_RadiantConvective_Steam_Design : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Enter the method used to determine the heating design capacity. HeatingDesignCapacity is selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea is selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
    "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
    "ity.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("convergence_tolerance")]
public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = null;
        

[JsonProperty("fraction_of_radiant_energy_incident_on_people")]
public System.Nullable<float> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
    }
    
    public enum ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
    
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
        "roups to the end of the list.")]
    public class ZoneHVAC_Baseboard_RadiantConvective_Steam : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("design_object")]
public string DesignObject { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[Description("Enter the design heating capacity. Required field when the heating design capacit" +
    "y method HeatingDesignCapacity.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("degree_of_subcooling")]
public System.Nullable<float> DegreeOfSubcooling { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_steam_flow_rate")]
public string MaximumSteamFlowRate { get; set; } = "";
        

[JsonProperty("surface_fractions")]
public string SurfaceFractions { get; set; } = "";
    }
    
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
        "roups to the end of the list")]
    public class ZoneHVAC_Baseboard_RadiantConvective_Electric : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description(@"Enter the method used to determine the heating design capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_Baseboard_RadiantConvective_Electric_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_Baseboard_RadiantConvective_Electric_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_Baseboard_RadiantConvective_Electric_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

[Description("Enter the design heating capacity. Required field when the heating design capacit" +
    "y method HeatingDesignCapacity.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
    "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
    "ity.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("efficiency")]
public System.Nullable<float> Efficiency { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = null;
        

[JsonProperty("fraction_of_radiant_energy_incident_on_people")]
public System.Nullable<float> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
        

[JsonProperty("surface_fractions")]
public string SurfaceFractions { get; set; } = "";
    }
    
    public enum ZoneHVAC_Baseboard_RadiantConvective_Electric_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
    
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
        "roups to the end of the list")]
    public class ZoneHVAC_CoolingPanel_RadiantConvective_Water : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("rated_inlet_water_temperature")]
public System.Nullable<float> RatedInletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_inlet_space_temperature")]
public System.Nullable<float> RatedInletSpaceTemperature { get; set; } = (System.Nullable<float>)Single.Parse("24", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_water_mass_flow_rate")]
public System.Nullable<float> RatedWaterMassFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0.063", CultureInfo.InvariantCulture);
        

[Description(@"Enter the method used to determine the cooling design capacity for scalable sizing. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determined from user specified cooling capacity per floor area and total floor area of cooled zone served by the hydrolic unit. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity of the system.")]
[JsonProperty("cooling_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod), "CoolingDesignCapacity");
        

[Description("Enter the design cooling capacity. Required field when the cooling design capacit" +
    "y method CoolingDesignCapacity.")]
[JsonProperty("cooling_design_capacity")]
public string CoolingDesignCapacity { get; set; } = "";
        

[Description("Enter the cooling design capacity per total floor area of cooled zones served by " +
    "the unit. Required field when the cooling design capacity method field is Capaci" +
    "tyPerFloorArea.")]
[JsonProperty("cooling_design_capacity_per_floor_area")]
public System.Nullable<float> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
    " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
[JsonProperty("fraction_of_autosized_cooling_design_capacity")]
public System.Nullable<float> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

[JsonProperty("maximum_chilled_water_flow_rate")]
public string MaximumChilledWaterFlowRate { get; set; } = "";
        

[Description("Temperature on which unit is controlled")]
[JsonProperty("control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType ControlType { get; set; } = (ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType)Enum.Parse(typeof(ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType), "MeanAirTemperature");
        

[JsonProperty("cooling_control_throttling_range")]
public System.Nullable<float> CoolingControlThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_control_temperature_schedule_name")]
public string CoolingControlTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("condensation_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType CondensationControlType { get; set; } = (ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType)Enum.Parse(typeof(ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType), "SimpleOff");
        

[JsonProperty("condensation_control_dewpoint_offset")]
public System.Nullable<float> CondensationControlDewpointOffset { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = null;
        

[JsonProperty("fraction_of_radiant_energy_incident_on_people")]
public System.Nullable<float> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
        

[JsonProperty("surface_fractions")]
public string SurfaceFractions { get; set; } = "";
    }
    
    public enum ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingDesignCapacity")]
        CoolingDesignCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingCapacity")]
        FractionOfAutosizedCoolingCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
    
    public enum ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperature")]
        MeanRadiantTemperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperature")]
        OperativeTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneConvectiveLoad")]
        ZoneConvectiveLoad = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneTotalLoad")]
        ZoneTotalLoad = 7,
    }
    
    public enum ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Off")]
        Off = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleOff")]
        SimpleOff = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableOff")]
        VariableOff = 3,
    }
    
    [Description("Hot water baseboard heater, convection-only. Natural convection hydronic heating " +
        "unit.")]
    public class ZoneHVAC_Baseboard_Convective_Water : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[Description(@"Enter the method used to determine the heating design capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_Baseboard_Convective_Water_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_Baseboard_Convective_Water_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_Baseboard_Convective_Water_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

[Description("Enter the design heating capacity. Required field when the heating design capacit" +
    "y method HeatingDesignCapacity.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
    "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
    "ity.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("u_factor_times_area_value")]
public string UFactorTimesAreaValue { get; set; } = "";
        

[JsonProperty("maximum_water_flow_rate")]
public string MaximumWaterFlowRate { get; set; } = "";
        

[JsonProperty("convergence_tolerance")]
public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
    }
    
    public enum ZoneHVAC_Baseboard_Convective_Water_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
    
    [Description("Electric baseboard heater, convection-only. Natural convection electric heating u" +
        "nit.")]
    public class ZoneHVAC_Baseboard_Convective_Electric : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description(@"Enter the method used to determine the heating design capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_Baseboard_Convective_Electric_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_Baseboard_Convective_Electric_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_Baseboard_Convective_Electric_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

[Description("Enter the design heating capacity. Required field when the heating design capacit" +
    "y method HeatingDesignCapacity.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
    "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
    "ity.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("efficiency")]
public System.Nullable<float> Efficiency { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum ZoneHVAC_Baseboard_Convective_Electric_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
    
    [Description("Low temperature hydronic radiant heating and/or cooling system embedded in a buil" +
        "ding surface (wall, ceiling, or floor). Controlled by varying the hot or chilled" +
        " water flow to the unit.")]
    public class ZoneHVAC_LowTemperatureRadiant_VariableFlow : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("design_object")]
public string DesignObject { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Name of zone system is serving")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Identifies surfaces that radiant system is embedded in. For a system with multipl" +
    "e surfaces, enter the name of a ZoneHVAC:LowTemperatureRadiant:SurfaceGroup obje" +
    "ct.")]
[JsonProperty("surface_name_or_radiant_surface_group_name")]
public string SurfaceNameOrRadiantSurfaceGroupName { get; set; } = "";
        

[Description("(total length of pipe embedded in surface)")]
[JsonProperty("hydronic_tubing_length")]
public string HydronicTubingLength { get; set; } = (System.String)"Autosize";
        

[Description("Enter the design heating capacity. Required field when the heating design capacit" +
    "y method HeatingDesignCapacity.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("maximum_hot_water_flow")]
public string MaximumHotWaterFlow { get; set; } = "";
        

[JsonProperty("heating_water_inlet_node_name")]
public string HeatingWaterInletNodeName { get; set; } = "";
        

[JsonProperty("heating_water_outlet_node_name")]
public string HeatingWaterOutletNodeName { get; set; } = "";
        

[Description("Enter the design cooling capacity. Required field when the cooling design capacit" +
    "y method CoolingDesignCapacity.")]
[JsonProperty("cooling_design_capacity")]
public string CoolingDesignCapacity { get; set; } = "";
        

[JsonProperty("maximum_cold_water_flow")]
public string MaximumColdWaterFlow { get; set; } = "";
        

[JsonProperty("cooling_water_inlet_node_name")]
public string CoolingWaterInletNodeName { get; set; } = "";
        

[JsonProperty("cooling_water_outlet_node_name")]
public string CoolingWaterOutletNodeName { get; set; } = "";
        

[JsonProperty("number_of_circuits")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_VariableFlow_NumberOfCircuits NumberOfCircuits { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_NumberOfCircuits)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_NumberOfCircuits), "OnePerSurface");
        

[JsonProperty("circuit_length")]
public System.Nullable<float> CircuitLength { get; set; } = (System.Nullable<float>)Single.Parse("106.7", CultureInfo.InvariantCulture);
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_NumberOfCircuits
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CalculateFromCircuitLength")]
        CalculateFromCircuitLength = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OnePerSurface")]
        OnePerSurface = 2,
    }
    
    [Description(null)]
    public class ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"This parameter identifies how the heat transfer between fluid being circulated through the radiant system and the radiant system (slab) is modeled. ConvectionOnly means that only convection between the fluid and the inside surface of the pipe is modeled using a conventional equation for flow inside a pipe. ISOStandard models convection between the fluid and the inside of of the pipe and conduction through the pipe material using equations specific to ISO Standard 11855-2.")]
[JsonProperty("fluid_to_radiant_surface_heat_transfer_model")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_FluidToRadiantSurfaceHeatTransferModel FluidToRadiantSurfaceHeatTransferModel { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_FluidToRadiantSurfaceHeatTransferModel)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_FluidToRadiantSurfaceHeatTransferModel), "ConvectionOnly");
        

[JsonProperty("hydronic_tubing_inside_diameter")]
public System.Nullable<float> HydronicTubingInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.013", CultureInfo.InvariantCulture);
        

[JsonProperty("hydronic_tubing_outside_diameter")]
public System.Nullable<float> HydronicTubingOutsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.016", CultureInfo.InvariantCulture);
        

[Description("Conductivity of the tubing/piping material")]
[JsonProperty("hydronic_tubing_conductivity")]
public System.Nullable<float> HydronicTubingConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
        

[Description("(Temperature on which unit is controlled)")]
[JsonProperty("temperature_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_TemperatureControlType), "MeanAirTemperature");
        

[Description("How setpoint temperature is defined")]
[JsonProperty("setpoint_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_SetpointControlType SetpointControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_SetpointControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_SetpointControlType), "HalfFlowPower");
        

[Description(@"Enter the method used to determine the heating design capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
    "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
    "ity.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_control_throttling_range")]
public System.Nullable<float> HeatingControlThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_control_temperature_schedule_name")]
public string HeatingControlTemperatureScheduleName { get; set; } = "";
        

[Description(@"Enter the method used to determine the cooling design capacity for scalable sizing. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determined from user specified cooling capacity per floor area and total floor area of cooled zone served by the hydrolic unit. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity of the system.")]
[JsonProperty("cooling_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CoolingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CoolingDesignCapacityMethod), "CoolingDesignCapacity");
        

[Description("Enter the cooling design capacity per total floor area of cooled zones served by " +
    "the unit. Required field when the cooling design capacity method field is Capaci" +
    "tyPerFloorArea.")]
[JsonProperty("cooling_design_capacity_per_floor_area")]
public System.Nullable<float> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
    " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
[JsonProperty("fraction_of_autosized_cooling_design_capacity")]
public System.Nullable<float> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

[JsonProperty("cooling_control_throttling_range")]
public System.Nullable<float> CoolingControlThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_control_temperature_schedule_name")]
public string CoolingControlTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("condensation_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CondensationControlType CondensationControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CondensationControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CondensationControlType), "SimpleOff");
        

[JsonProperty("condensation_control_dewpoint_offset")]
public System.Nullable<float> CondensationControlDewpointOffset { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Changeover delay schedule name for this system. Schedule value <= 0 allows change" +
    "over with no delay The schedule values are interpretted as hours. If this field " +
    "is blank, the system allows changeover with no delay")]
[JsonProperty("changeover_delay_time_period_schedule")]
public string ChangeoverDelayTimePeriodSchedule { get; set; } = "";
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_FluidToRadiantSurfaceHeatTransferModel
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvectionOnly")]
        ConvectionOnly = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ISOStandard")]
        ISOStandard = 2,
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_TemperatureControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperature")]
        MeanRadiantTemperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperature")]
        OperativeTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceFaceTemperature")]
        SurfaceFaceTemperature = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceInteriorTemperature")]
        SurfaceInteriorTemperature = 7,
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_SetpointControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HalfFlowPower")]
        HalfFlowPower = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZeroFlowPower")]
        ZeroFlowPower = 2,
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CoolingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingDesignCapacity")]
        CoolingDesignCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingCapacity")]
        FractionOfAutosizedCoolingCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CondensationControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Off")]
        Off = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleOff")]
        SimpleOff = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableOff")]
        VariableOff = 3,
    }
    
    [Description("Low temperature hydronic radiant heating and/or cooling system embedded in a buil" +
        "ding surface (wall, ceiling, or floor). Controlled by varying the hot or chilled" +
        " water temperature circulating through the unit.")]
    public class ZoneHVAC_LowTemperatureRadiant_ConstantFlow : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("design_object")]
public string DesignObject { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Name of zone system is serving")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Identifies surfaces that radiant system is embedded in. For a system with multipl" +
    "e surfaces, enter the name of a ZoneHVAC:LowTemperatureRadiant:SurfaceGroup obje" +
    "ct.")]
[JsonProperty("surface_name_or_radiant_surface_group_name")]
public string SurfaceNameOrRadiantSurfaceGroupName { get; set; } = "";
        

[Description("(total length of pipe embedded in surface)")]
[JsonProperty("hydronic_tubing_length")]
public string HydronicTubingLength { get; set; } = (System.String)"Autosize";
        

[JsonProperty("rated_flow_rate")]
public string RatedFlowRate { get; set; } = "";
        

[Description(@"Modifies the Rated Flow Rate of the pump on a time basis the default is that the pump is ON and runs according to its other operational requirements specified above. The schedule is for special pump operations. Values here are between 0 and 1 and are multipliers on the previous field (Rated Flow Rate).")]
[JsonProperty("pump_flow_rate_schedule_name")]
public string PumpFlowRateScheduleName { get; set; } = "";
        

[Description("default head is 60 feet")]
[JsonProperty("rated_pump_head")]
public System.Nullable<float> RatedPumpHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_power_consumption")]
public System.Nullable<float> RatedPowerConsumption { get; set; } = null;
        

[JsonProperty("heating_water_inlet_node_name")]
public string HeatingWaterInletNodeName { get; set; } = "";
        

[JsonProperty("heating_water_outlet_node_name")]
public string HeatingWaterOutletNodeName { get; set; } = "";
        

[Description(@"Water and control temperatures for heating work together to provide a linear function that determines the water temperature sent to the radiant system. The current control temperature (see Temperature Control Type above) is compared to the high and low control temperatures at the current time. If the control temperature is above the high temperature, then the inlet water temperature is set to the low water temperature. If the control temperature is below the low temperature, then the inlet water temperature is set to the high water temperature. If the control temperature is between the high and low value, then the inlet water temperature is linearly interpolated between the low and high water temperature values.")]
[JsonProperty("heating_high_water_temperature_schedule_name")]
public string HeatingHighWaterTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("heating_low_water_temperature_schedule_name")]
public string HeatingLowWaterTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("heating_high_control_temperature_schedule_name")]
public string HeatingHighControlTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("heating_low_control_temperature_schedule_name")]
public string HeatingLowControlTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("cooling_water_inlet_node_name")]
public string CoolingWaterInletNodeName { get; set; } = "";
        

[JsonProperty("cooling_water_outlet_node_name")]
public string CoolingWaterOutletNodeName { get; set; } = "";
        

[Description("See note for Heating High Water Temperature Schedule above for interpretation inf" +
    "ormation (or see the Input/Output Reference).")]
[JsonProperty("cooling_high_water_temperature_schedule_name")]
public string CoolingHighWaterTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("cooling_low_water_temperature_schedule_name")]
public string CoolingLowWaterTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("cooling_high_control_temperature_schedule_name")]
public string CoolingHighControlTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("cooling_low_control_temperature_schedule_name")]
public string CoolingLowControlTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("number_of_circuits")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_NumberOfCircuits NumberOfCircuits { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_NumberOfCircuits)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_NumberOfCircuits), "OnePerSurface");
        

[JsonProperty("circuit_length")]
public System.Nullable<float> CircuitLength { get; set; } = (System.Nullable<float>)Single.Parse("106.7", CultureInfo.InvariantCulture);
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_ConstantFlow_NumberOfCircuits
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CalculateFromCircuitLength")]
        CalculateFromCircuitLength = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OnePerSurface")]
        OnePerSurface = 2,
    }
    
    [Description(null)]
    public class ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"This parameter identifies how the heat transfer between fluid being circulated through the radiant system and the radiant system (slab) is modeled. ConvectionOnly means that only convection between the fluid and the inside surface of the pipe is modeled using a conventional equation for flow inside a pipe. ISOStandard models convection between the fluid and the inside of of the pipe and conduction through the pipe material using equations specific to ISO Standard 11855-2.")]
[JsonProperty("fluid_to_radiant_surface_heat_transfer_model")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel FluidToRadiantSurfaceHeatTransferModel { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel), "ConvectionOnly");
        

[JsonProperty("hydronic_tubing_inside_diameter")]
public System.Nullable<float> HydronicTubingInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.013", CultureInfo.InvariantCulture);
        

[JsonProperty("hydronic_tubing_outside_diameter")]
public System.Nullable<float> HydronicTubingOutsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.016", CultureInfo.InvariantCulture);
        

[Description("Conductivity of the tubing/piping material")]
[JsonProperty("hydronic_tubing_conductivity")]
public System.Nullable<float> HydronicTubingConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
        

[Description("Temperature used to control system")]
[JsonProperty("temperature_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType), "MeanAirTemperature");
        

[Description(@"this is the weighting factor in the equation that calculate the running mean outdoor dry-bulb temperature as a weighted average of the previous dayâ€™s running mean outdoor dry-bulb temperature and the previous dayâ€™s average outdoor dry-bulb temperature this value is only used by EnergyPlus when the user elects to use the RunningMeanOutdoorDryBulbTemperature control type")]
[JsonProperty("running_mean_outdoor_dry_bulb_temperature_weighting_factor")]
public System.Nullable<float> RunningMeanOutdoorDryBulbTemperatureWeightingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("motor_efficiency")]
public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_of_motor_inefficiencies_to_fluid_stream")]
public System.Nullable<float> FractionOfMotorInefficienciesToFluidStream { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("condensation_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType CondensationControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType), "SimpleOff");
        

[JsonProperty("condensation_control_dewpoint_offset")]
public System.Nullable<float> CondensationControlDewpointOffset { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Changeover delay schedule name for this system. Schedule value <= 0 allows change" +
    "over with no delay The schedule values are interpretted as hours. If this field " +
    "is blank, the system allows changeover with no delay")]
[JsonProperty("changeover_delay_time_period_schedule")]
public string ChangeoverDelayTimePeriodSchedule { get; set; } = "";
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvectionOnly")]
        ConvectionOnly = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ISOStandard")]
        ISOStandard = 2,
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperature")]
        MeanRadiantTemperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperature")]
        OperativeTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="RunningMeanOutdoorDryBulbTemperature")]
        RunningMeanOutdoorDryBulbTemperature = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceFaceTemperature")]
        SurfaceFaceTemperature = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceInteriorTemperature")]
        SurfaceInteriorTemperature = 8,
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Off")]
        Off = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleOff")]
        SimpleOff = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableOff")]
        VariableOff = 3,
    }
    
    [Description("Electric resistance low temperature radiant system")]
    public class ZoneHVAC_LowTemperatureRadiant_Electric : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Name of zone system is serving")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Identifies surfaces that radiant system is embedded in. For a system with multipl" +
    "e surfaces, enter the name of a ZoneHVAC:LowTemperatureRadiant:SurfaceGroup obje" +
    "ct.")]
[JsonProperty("surface_name_or_radiant_surface_group_name")]
public string SurfaceNameOrRadiantSurfaceGroupName { get; set; } = "";
        

[Description(@"Enter the method used to determine the maximum electrical heating design capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_Electric_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_LowTemperatureRadiant_Electric_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_Electric_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

[Description("Enter the design heating capacity. Required field when the heating design capacit" +
    "y method HeatingDesignCapacity.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
    "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
    "ity.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Temperature used to control unit")]
[JsonProperty("temperature_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_Electric_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_Electric_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_Electric_TemperatureControlType), "MeanAirTemperature");
        

[Description("How setpoint temperature is defined")]
[JsonProperty("setpoint_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_LowTemperatureRadiant_Electric_SetpointControlType SetpointControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_Electric_SetpointControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_Electric_SetpointControlType), "HalfFlowPower");
        

[JsonProperty("heating_throttling_range")]
public System.Nullable<float> HeatingThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_setpoint_temperature_schedule_name")]
public string HeatingSetpointTemperatureScheduleName { get; set; } = "";
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_Electric_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_Electric_TemperatureControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperature")]
        MeanRadiantTemperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperature")]
        OperativeTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceFaceTemperature")]
        SurfaceFaceTemperature = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceInteriorTemperature")]
        SurfaceInteriorTemperature = 7,
    }
    
    public enum ZoneHVAC_LowTemperatureRadiant_Electric_SetpointControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HalfFlowPower")]
        HalfFlowPower = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZeroFlowPower")]
        ZeroFlowPower = 2,
    }
    
    [Description("This is used to allow the coordinate control of several radiant system surfaces. " +
        "Note that the following flow fractions must sum up to 1.0 The number of surfaces" +
        " can be expanded beyond 100, if necessary, by adding more groups to the end of t" +
        "he list")]
    public class ZoneHVAC_LowTemperatureRadiant_SurfaceGroup : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("surface_fractions")]
public string SurfaceFractions { get; set; } = "";
    }
    
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
        "roups to the end of the list")]
    public class ZoneHVAC_HighTemperatureRadiant : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Name of zone system is serving")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description(@"Enter the method used to determine the maximum heating power input capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

[Description("Enter the design heating capacity. Required field when the heating design capacit" +
    "y method HeatingDesignCapacity.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
    "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
    "ity.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Natural gas or electricity")]
[JsonProperty("fuel_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_HighTemperatureRadiant_FuelType FuelType { get; set; } = (ZoneHVAC_HighTemperatureRadiant_FuelType)Enum.Parse(typeof(ZoneHVAC_HighTemperatureRadiant_FuelType), "Electricity");
        

[Description("Not used for non-gas radiant heaters")]
[JsonProperty("combustion_efficiency")]
public System.Nullable<float> CombustionEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Radiant+latent+lost fractions must sum to 1 or less, remainder is considered conv" +
    "ective heat")]
[JsonProperty("fraction_of_input_converted_to_radiant_energy")]
public System.Nullable<float> FractionOfInputConvertedToRadiantEnergy { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_of_input_converted_to_latent_energy")]
public System.Nullable<float> FractionOfInputConvertedToLatentEnergy { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Fraction of input vented to outdoor environment")]
[JsonProperty("fraction_of_input_that_is_lost")]
public System.Nullable<float> FractionOfInputThatIsLost { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Temperature type used to control unit")]
[JsonProperty("temperature_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_HighTemperatureRadiant_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_HighTemperatureRadiant_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_HighTemperatureRadiant_TemperatureControlType), "OperativeTemperature");
        

[JsonProperty("heating_throttling_range")]
public System.Nullable<float> HeatingThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("This setpoint is an \"operative temperature\" setpoint")]
[JsonProperty("heating_setpoint_temperature_schedule_name")]
public string HeatingSetpointTemperatureScheduleName { get; set; } = "";
        

[Description("This will affect thermal comfort but from an energy balance standpoint this value" +
    " gets added to the convective gains from the radiant heater")]
[JsonProperty("fraction_of_radiant_energy_incident_on_people")]
public System.Nullable<float> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
        

[JsonProperty("surface_fractions")]
public string SurfaceFractions { get; set; } = "";
    }
    
    public enum ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
    
    public enum ZoneHVAC_HighTemperatureRadiant_FuelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 1,
    }
    
    public enum ZoneHVAC_HighTemperatureRadiant_TemperatureControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperatureSetpoint")]
        MeanAirTemperatureSetpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperature")]
        MeanRadiantTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperatureSetpoint")]
        MeanRadiantTemperatureSetpoint = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperature")]
        OperativeTemperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperatureSetpoint")]
        OperativeTemperatureSetpoint = 6,
    }
    
    [Description("Ventilated slab system where outdoor air flows through hollow cores in a building" +
        " surface (wall, ceiling, or floor).")]
    public class ZoneHVAC_VentilatedSlab : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("(name of zone system is serving)")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("(name of surface system is embedded in) or list of surfaces")]
[JsonProperty("surface_name_or_radiant_surface_group_name")]
public string SurfaceNameOrRadiantSurfaceGroupName { get; set; } = "";
        

[JsonProperty("maximum_air_flow_rate")]
public string MaximumAirFlowRate { get; set; } = "";
        

[JsonProperty("outdoor_air_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_VentilatedSlab_OutdoorAirControlType OutdoorAirControlType { get; set; } = (ZoneHVAC_VentilatedSlab_OutdoorAirControlType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_OutdoorAirControlType), "FixedAmount");
        

[JsonProperty("minimum_outdoor_air_flow_rate")]
public string MinimumOutdoorAirFlowRate { get; set; } = "";
        

[JsonProperty("minimum_outdoor_air_schedule_name")]
public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

[Description("schedule values multiply the minimum outdoor air flow rate")]
[JsonProperty("maximum_outdoor_air_flow_rate")]
public string MaximumOutdoorAirFlowRate { get; set; } = "";
        

[Description("Note that this depends on the control type as to whether schedule values are a fr" +
    "action or temperature")]
[JsonProperty("maximum_outdoor_air_fraction_or_temperature_schedule_name")]
public string MaximumOutdoorAirFractionOrTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("system_configuration_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_VentilatedSlab_SystemConfigurationType SystemConfigurationType { get; set; } = (ZoneHVAC_VentilatedSlab_SystemConfigurationType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_SystemConfigurationType), "SlabOnly");
        

[JsonProperty("hollow_core_inside_diameter")]
public System.Nullable<float> HollowCoreInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[Description("(length of core cavity embedded in surface)")]
[JsonProperty("hollow_core_length")]
public System.Nullable<float> HollowCoreLength { get; set; } = null;
        

[Description("flow will be divided evenly among the cores")]
[JsonProperty("number_of_cores")]
public System.Nullable<float> NumberOfCores { get; set; } = null;
        

[Description("(temperature on which unit is controlled)")]
[JsonProperty("temperature_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_VentilatedSlab_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_VentilatedSlab_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_TemperatureControlType), "OutdoorDryBulbTemperature");
        

[Description(@"Air and control temperatures for heating work together to provide a linear function that determines the air temperature sent to the radiant system. The current control temperature (see A14) is compared to the high and low control temperatures at the current time. If the control temperature is above the high temperature, then the inlet air temperature is set to the low air temperature. If the control temperature is below the low temperature, then the inlet air temperature is set to the high air temperature. If the control temperature is between the high and low value, then the inlet air temperature is linearly interpolated between the low and high air temperature values.")]
[JsonProperty("heating_high_air_temperature_schedule_name")]
public string HeatingHighAirTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("heating_low_air_temperature_schedule_name")]
public string HeatingLowAirTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("heating_high_control_temperature_schedule_name")]
public string HeatingHighControlTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("heating_low_control_temperature_schedule_name")]
public string HeatingLowControlTemperatureScheduleName { get; set; } = "";
        

[Description("See note for heating high air temperature schedule above for interpretation infor" +
    "mation (or see the Input/Output Reference).")]
[JsonProperty("cooling_high_air_temperature_schedule_name")]
public string CoolingHighAirTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("cooling_low_air_temperature_schedule_name")]
public string CoolingLowAirTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("cooling_high_control_temperature_schedule_name")]
public string CoolingHighControlTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("cooling_low_control_temperature_schedule_name")]
public string CoolingLowControlTemperatureScheduleName { get; set; } = "";
        

[Description("This is the zone return air inlet to the ventilated slab system outdoor air mixer" +
    ". This node is typically a zone exhaust node (do not connect to \"Zone Return Air" +
    " Node\").")]
[JsonProperty("return_air_node_name")]
public string ReturnAirNodeName { get; set; } = "";
        

[Description("This is the node entering the slab or series of slabs after the fan and coil(s).")]
[JsonProperty("slab_in_node_name")]
public string SlabInNodeName { get; set; } = "";
        

[Description("This is the node name exiting the slab. This node is typically a zone inlet node." +
    " Leave blank when the system configuration is SlabOnly or SeriesSlabs.")]
[JsonProperty("zone_supply_air_node_name")]
public string ZoneSupplyAirNodeName { get; set; } = "";
        

[Description("This node is the outdoor air inlet to the ventilated slab oa mixer. This node sho" +
    "uld also be specified in an OutdoorAir:Node or OutdoorAir:NodeList object.")]
[JsonProperty("outdoor_air_node_name")]
public string OutdoorAirNodeName { get; set; } = "";
        

[Description("This node is the relief air node from the ventilated slab outdoor air mixer.")]
[JsonProperty("relief_air_node_name")]
public string ReliefAirNodeName { get; set; } = "";
        

[Description("This is the node name leaving the outdoor air mixer and entering the fan and coil" +
    "(s).")]
[JsonProperty("outdoor_air_mixer_outlet_node_name")]
public string OutdoorAirMixerOutletNodeName { get; set; } = "";
        

[Description("This is the node name of the fan outlet.")]
[JsonProperty("fan_outlet_node_name")]
public string FanOutletNodeName { get; set; } = "";
        

[Description("Allowable fan types are Fan:SystemModel and Fan:ConstantVolume")]
[JsonProperty("fan_name")]
public string FanName { get; set; } = "";
        

[JsonProperty("coil_option_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_VentilatedSlab_CoilOptionType CoilOptionType { get; set; } = (ZoneHVAC_VentilatedSlab_CoilOptionType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_CoilOptionType), "Cooling");
        

[JsonProperty("heating_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_VentilatedSlab_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_VentilatedSlab_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_HeatingCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[JsonProperty("hot_water_or_steam_inlet_node_name")]
public string HotWaterOrSteamInletNodeName { get; set; } = "";
        

[JsonProperty("cooling_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_VentilatedSlab_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_VentilatedSlab_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_CoolingCoilObjectType), "CoilCoolingWater");
        

[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[JsonProperty("cold_water_inlet_node_name")]
public string ColdWaterInletNodeName { get; set; } = "";
        

[Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
[JsonProperty("availability_manager_list_name")]
public string AvailabilityManagerListName { get; set; } = "";
        

[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
[JsonProperty("design_specification_zonehvac_sizing_object_name")]
public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
    
    public enum ZoneHVAC_VentilatedSlab_OutdoorAirControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FixedAmount")]
        FixedAmount = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedTemperature")]
        FixedTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="VariablePercent")]
        VariablePercent = 2,
    }
    
    public enum ZoneHVAC_VentilatedSlab_SystemConfigurationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SeriesSlabs")]
        SeriesSlabs = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SlabAndZone")]
        SlabAndZone = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SlabOnly")]
        SlabOnly = 3,
    }
    
    public enum ZoneHVAC_VentilatedSlab_TemperatureControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperature")]
        MeanRadiantTemperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperature")]
        OperativeTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceTemperature")]
        SurfaceTemperature = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAirDewPointTemperature")]
        ZoneAirDewPointTemperature = 7,
    }
    
    public enum ZoneHVAC_VentilatedSlab_CoilOptionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingAndCooling")]
        HeatingAndCooling = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
    }
    
    public enum ZoneHVAC_VentilatedSlab_HeatingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
    
    public enum ZoneHVAC_VentilatedSlab_CoolingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water")]
        CoilCoolingWater = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Cooling:Water:HeatExchangerAssisted")]
        CoilSystemCoolingWaterHeatExchangerAssisted = 2,
    }
    
    [Description("This is used to allow the coordinate control of several ventilated slab system su" +
        "rfaces. Note that the flow fractions must sum up to 1.0. The number of surfaces " +
        "can be expanded beyond 10, if necessary, by adding more groups to the end of the" +
        " list")]
    public class ZoneHVAC_VentilatedSlab_SlabGroup : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("data")]
public string Data { get; set; } = "";
    }
}
