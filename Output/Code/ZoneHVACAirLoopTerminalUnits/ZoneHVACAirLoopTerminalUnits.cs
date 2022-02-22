namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
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
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Central air system terminal unit, single duct, constant volume, with reheat coil " +
        "(hot water, electric, gas, or steam).")]
    public class AirTerminal_SingleDuct_ConstantVolume_Reheat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("maximum_air_flow_rate")]
public string MaximumAirFlowRate { get; set; } = "";
        

[JsonProperty("reheat_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_ConstantVolume_Reheat_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirTerminal_SingleDuct_ConstantVolume_Reheat_ReheatCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_ConstantVolume_Reheat_ReheatCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("reheat_coil_name")]
public string ReheatCoilName { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("maximum_hot_water_or_steam_flow_rate")]
public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("minimum_hot_water_or_steam_flow_rate")]
public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("convergence_tolerance")]
public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[Description("Specifies the maximum allowable supply air temperature leaving the reheat coil. I" +
    "f left blank, there is no limit and no default. If unknown, 35C (95F) is recomme" +
    "nded.")]
[JsonProperty("maximum_reheat_air_temperature")]
public System.Nullable<float> MaximumReheatAirTemperature { get; set; } = null;
    }
    
    public enum AirTerminal_SingleDuct_ConstantVolume_Reheat_ReheatCoilObjectType
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
    
    [Description("Central air system terminal unit, single duct, constant volume, without reheat co" +
        "il")]
    public class AirTerminal_SingleDuct_ConstantVolume_NoReheat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("The air-inlet node name that connects the air splitter to the individual zone air" +
    " distribution unit. This node should also be one of the outlet air node of an Ai" +
    "rLoopHVAC:ZoneSplitter or AirLoopHVAC:SupplyPlenum component.")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[Description("This is an air outlet node from the air distribution unit. This node name should " +
    "be one of the supply air inlet node names of a zone served by this component.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("maximum_air_flow_rate")]
public string MaximumAirFlowRate { get; set; } = "";
        

[Description(@"This field is used to modulate the terminal unit flow rate based on the specified outdoor air requirement. When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will adjust flow to meet this outdoor air requirement and no more. There is no control for zone load. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on either the current or design occupancy as specified in the Per Person Ventilation Rate Mode field. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. The requested flow rate may not be fully met if the system is operating with cycling fan. If this field is blank, then the terminal unit will not be controlled for outdoor air flow. This field is optional.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("CurrentOccupancy uses current number of people in the zone which may vary DesignO" +
    "ccupancy uses the total number of people in the zone and is constant")]
[JsonProperty("per_person_ventilation_rate_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_ConstantVolume_NoReheat_PerPersonVentilationRateMode PerPersonVentilationRateMode { get; set; } = (AirTerminal_SingleDuct_ConstantVolume_NoReheat_PerPersonVentilationRateMode)Enum.Parse(typeof(AirTerminal_SingleDuct_ConstantVolume_NoReheat_PerPersonVentilationRateMode), "CurrentOccupancy");
    }
    
    public enum AirTerminal_SingleDuct_ConstantVolume_NoReheat_PerPersonVentilationRateMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CurrentOccupancy")]
        CurrentOccupancy = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignOccupancy")]
        DesignOccupancy = 2,
    }
    
    [Description("Central air system terminal unit, single duct, variable volume, with no reheat co" +
        "il.")]
    public class AirTerminal_SingleDuct_VAV_NoReheat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("maximum_air_flow_rate")]
public string MaximumAirFlowRate { get; set; } = "";
        

[Description("Constant = Constant Minimum Air Flow Fraction (a fraction of Maximum Air Flow Rat" +
    "e) FixedFlowRate = Fixed Minimum Air Flow Rate (a fixed minimum air volume flow " +
    "rate) Scheduled = Scheduled Minimum Air Flow Fraction (a fraction of Maximum Air" +
    " Flow")]
[JsonProperty("zone_minimum_air_flow_input_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_VAV_NoReheat_ZoneMinimumAirFlowInputMethod ZoneMinimumAirFlowInputMethod { get; set; } = (AirTerminal_SingleDuct_VAV_NoReheat_ZoneMinimumAirFlowInputMethod)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_NoReheat_ZoneMinimumAirFlowInputMethod), "Constant");
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Constant If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional; if a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the following field are entered, the larger result is used. The values for autosizing are picked up from the Sizing:Zone input fields ""Cooling Minimum Air Flow per Zone Floor Area"", ""Cooling Minimum Air Flow"", and ""Cooling Minimum Air Flow Fraction"". If there is no sizing calculation a default of 0.000762 m3/s-m2 (0.15 cfm/ft2) is used.")]
[JsonProperty("constant_minimum_air_flow_fraction")]
public string ConstantMinimumAirFlowFraction { get; set; } = (System.String)"Autosize";
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is FixedFlowRate. If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional; if a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the previous field are entered, the larger result is used. The values for autosizing are picked up from the Sizing:Zone input fields ""Cooling Minimum Air Flow per Zone Floor Area"", ""Cooling Minimum Air Flow"", and ""Cooling Minimum Air Flow Fraction"". If there is no sizing calculation a default of 0.000762 m3/s-m2 (0.15 cfm/ft2) is used.")]
[JsonProperty("fixed_minimum_air_flow_rate")]
public string FixedMinimumAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Scheduled Schedule values are fractions, 0.0 to 1.0. If the field Constant Minimum Air Flow Fraction is blank, then the average of the minimum and maximum schedule values is used for sizing normal-action reheat coils.")]
[JsonProperty("minimum_air_flow_fraction_schedule_name")]
public string MinimumAirFlowFractionScheduleName { get; set; } = "";
        

[Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. If this field is blank, then the terminal unit will not be controlled for outdoor air flow.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field can be used with any of the three ""Zone Minimum Air Flow Input Method"". Schedule values are fractions, 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1.")]
[JsonProperty("minimum_air_flow_turndown_schedule_name")]
public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
    
    public enum AirTerminal_SingleDuct_VAV_NoReheat_ZoneMinimumAirFlowInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedFlowRate")]
        FixedFlowRate = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 3,
    }
    
    [Description("Central air system terminal unit, single duct, variable volume, with reheat coil " +
        "(hot water, electric, gas, or steam).")]
    public class AirTerminal_SingleDuct_VAV_Reheat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("the outlet node of the damper and the inlet node of the reheat coil this is an in" +
    "ternal node to the terminal unit and connects the damper and reheat coil")]
[JsonProperty("damper_air_outlet_node_name")]
public string DamperAirOutletNodeName { get; set; } = "";
        

[Description("the inlet node to the terminal unit and the damper")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("maximum_air_flow_rate")]
public string MaximumAirFlowRate { get; set; } = "";
        

[Description("Constant = Constant Minimum Air Flow Fraction (a fraction of Maximum Air Flow Rat" +
    "e) FixedFlowRate = Fixed Minimum Air Flow Rate (a fixed minimum air volume flow " +
    "rate) Scheduled = Scheduled Minimum Air Flow Fraction (a fraction of Maximum Air" +
    " Flow")]
[JsonProperty("zone_minimum_air_flow_input_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_VAV_Reheat_ZoneMinimumAirFlowInputMethod ZoneMinimumAirFlowInputMethod { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_ZoneMinimumAirFlowInputMethod)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_ZoneMinimumAirFlowInputMethod), "Constant");
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Constant If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional; if a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the following field are entered, the larger result is used. The values for autosizing are picked up from the Sizing:Zone input fields ""Cooling Minimum Air Flow per Zone Floor Area"", ""Cooling Minimum Air Flow"", and ""Cooling Minimum Air Flow Fraction"". If there is no sizing calculation a default of 0.000762 m3/s-m2 (0.15 cfm/ft2) is used.")]
[JsonProperty("constant_minimum_air_flow_fraction")]
public string ConstantMinimumAirFlowFraction { get; set; } = (System.String)"Autosize";
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is FixedFlowRate. If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional; if a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the previous field are entered, the larger result is used. The values for autosizing are picked up from the Sizing:Zone input fields ""Cooling Minimum Air Flow per Zone Floor Area"", ""Cooling Minimum Air Flow"", and ""Cooling Minimum Air Flow Fraction"". If there is no sizing calculation a default of 0.000762 m3/s-m2 (0.15 cfm/ft2) is used.")]
[JsonProperty("fixed_minimum_air_flow_rate")]
public string FixedMinimumAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Scheduled Schedule values are fractions, 0.0 to 1.0. If the field Constant Minimum Air Flow Fraction is blank, then the average of the minimum and maximum schedule values is used for sizing normal-action reheat coils.")]
[JsonProperty("minimum_air_flow_fraction_schedule_name")]
public string MinimumAirFlowFractionScheduleName { get; set; } = "";
        

[JsonProperty("reheat_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_VAV_Reheat_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_ReheatCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_ReheatCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("reheat_coil_name")]
public string ReheatCoilName { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("maximum_hot_water_or_steam_flow_rate")]
public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("minimum_hot_water_or_steam_flow_rate")]
public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The outlet node of the terminal unit and the reheat coil. This is also the zone i" +
    "nlet node.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("convergence_tolerance")]
public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[Description("Normal means the damper is fixed at the minimum position in heating mode Reverse " +
    "means the damper can open fully during reheat ReverseWithLimits means the damper" +
    " will open partially during reheat as specified in the following 2 fields")]
[JsonProperty("damper_heating_action")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_VAV_Reheat_DamperHeatingAction DamperHeatingAction { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_DamperHeatingAction)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_DamperHeatingAction), "ReverseWithLimits");
        

[Description(@"Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = ReverseWithLimits When autocalculating, the maximum flow per zone is set to 0.002032 m3/s-m2 (0.4 cfm/sqft) This optional field limits the maximum flow allowed in reheat mode. At no time will the maximum flow rate calculated here exceed the value of Maximum Air Flow Rate.")]
[JsonProperty("maximum_flow_per_zone_floor_area_during_reheat")]
public string MaximumFlowPerZoneFloorAreaDuringReheat { get; set; } = (System.String)"Autosize";
        

[Description(@"Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = ReverseWithLimits When autocalculating, the maximum flow fraction is set to the ratio of 0.002032 m3/s-m2 (0.4 cfm/sqft) multiplied by the zone floor area and the Maximum Air Flow Rate. This optional field limits the maximum flow allowed in reheat mode. At no time will the maximum flow rate calculated here exceed the value of Maximum Air Flow Rate.")]
[JsonProperty("maximum_flow_fraction_during_reheat")]
public string MaximumFlowFractionDuringReheat { get; set; } = (System.String)"Autosize";
        

[Description("Specifies the maximum allowable supply air temperature leaving the reheat coil. I" +
    "f left blank, there is no limit and no default. If unknown, 35C (95F) is recomme" +
    "nded.")]
[JsonProperty("maximum_reheat_air_temperature")]
public System.Nullable<float> MaximumReheatAirTemperature { get; set; } = null;
        

[Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. If this field is blank, then the terminal unit will not be controlled for outdoor air flow.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field can be used with any of the three ""Zone Minimum Air Flow Input Method"". Schedule values are fractions, 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1.")]
[JsonProperty("minimum_air_flow_turndown_schedule_name")]
public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
    
    public enum AirTerminal_SingleDuct_VAV_Reheat_ZoneMinimumAirFlowInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedFlowRate")]
        FixedFlowRate = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 3,
    }
    
    public enum AirTerminal_SingleDuct_VAV_Reheat_ReheatCoilObjectType
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
    
    public enum AirTerminal_SingleDuct_VAV_Reheat_DamperHeatingAction
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Normal")]
        Normal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Reverse")]
        Reverse = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ReverseWithLimits")]
        ReverseWithLimits = 3,
    }
    
    [Description(@"Central air system terminal unit, single duct, variable volume, with reheat coil (hot water, electric, gas, or steam) and variable-speed fan. These units are usually employed in underfloor air distribution (UFAD) systems where the air is supplied at low static pressure through an underfloor plenum. The fan is used to control the flow of conditioned air that enters the space.")]
    public class AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("maximum_cooling_air_flow_rate")]
public string MaximumCoolingAirFlowRate { get; set; } = "";
        

[JsonProperty("maximum_heating_air_flow_rate")]
public string MaximumHeatingAirFlowRate { get; set; } = "";
        

[Description("fraction of cooling air flow rate")]
[JsonProperty("zone_minimum_air_flow_fraction")]
public System.Nullable<float> ZoneMinimumAirFlowFraction { get; set; } = null;
        

[Description("The name of the HVAC system node that is the air inlet node for the terminal unit" +
    ". This is also the air inlet node for the unit\'s fan.")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[Description("The name of the HVAC system node that is the air outlet node for the terminal uni" +
    "t. This is also the air outlet node for the unit\'s heating coil\'s air outlet nod" +
    "e. This node is also a zone inlet node.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("fan_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_FanObjectType FanObjectType { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_FanObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_FanObjectType), "FanSystemModel");
        

[JsonProperty("fan_name")]
public string FanName { get; set; } = "";
        

[JsonProperty("heating_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_HeatingCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_HeatingCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[Description("Not used when heating coil type is gas or electric")]
[JsonProperty("maximum_hot_water_or_steam_flow_rate")]
public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

[Description("Not used when heating coil type is gas or electric")]
[JsonProperty("minimum_hot_water_or_steam_flow_rate")]
public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_convergence_tolerance")]
public System.Nullable<float> HeatingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[Description(@"This field adjusts the fan-off minimum flow rate by multiplying it using this scheduled fraction values. This field is used with ""Zone Minimum Air Flow Fraction"". Schedule values are fractions 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1 and the model uses the fixed fraction specified in in the field ""Zone Minimum Air Flow Fraction"".")]
[JsonProperty("minimum_air_flow_turndown_schedule_name")]
public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
    
    public enum AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_FanObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:SystemModel")]
        FanSystemModel = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:VariableVolume")]
        FanVariableVolume = 1,
    }
    
    public enum AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_HeatingCoilObjectType
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
    
    [Description("Central air system terminal unit, single duct, variable volume for both cooling a" +
        "nd heating, with no reheat coil.")]
    public class AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("The outlet node of the terminal unit. This is also the zone inlet node.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("maximum_air_flow_rate")]
public string MaximumAirFlowRate { get; set; } = "";
        

[Description("fraction of maximum air flow")]
[JsonProperty("zone_minimum_air_flow_fraction")]
public System.Nullable<float> ZoneMinimumAirFlowFraction { get; set; } = null;
        

[Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field is used with ""Zone Minimum Air Flow Fraction"". Schedule values are fractions 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1 and the model uses the fixed fraction specified in in the field ""Zone Minimum Air Flow Fraction"".")]
[JsonProperty("minimum_air_flow_turndown_schedule_name")]
public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
    
    [Description("Central air system terminal unit, single duct, variable volume for both cooling a" +
        "nd heating, with reheat coil (hot water, electric, gas, or steam).")]
    public class AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("the outlet node of the damper and the inlet node of the reheat coil this is an in" +
    "ternal node to the terminal unit and connects the damper and reheat coil")]
[JsonProperty("damper_air_outlet_node_name")]
public string DamperAirOutletNodeName { get; set; } = "";
        

[Description("the inlet node to the terminal unit and the damper")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("maximum_air_flow_rate")]
public string MaximumAirFlowRate { get; set; } = "";
        

[Description("fraction of maximum air flow")]
[JsonProperty("zone_minimum_air_flow_fraction")]
public System.Nullable<float> ZoneMinimumAirFlowFraction { get; set; } = null;
        

[JsonProperty("reheat_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_ReheatCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_ReheatCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("reheat_coil_name")]
public string ReheatCoilName { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("maximum_hot_water_or_steam_flow_rate")]
public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("minimum_hot_water_or_steam_flow_rate")]
public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The outlet node of the terminal unit and the reheat coil. This is also the zone i" +
    "nlet node.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("convergence_tolerance")]
public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[Description("Specifies the maximum allowable supply air temperature leaving the reheat coil. I" +
    "f left blank, there is no limit and no default. If unknown, 35C (95F) is recomme" +
    "nded.")]
[JsonProperty("maximum_reheat_air_temperature")]
public System.Nullable<float> MaximumReheatAirTemperature { get; set; } = null;
        

[Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field is used with ""Zone Minimum Air Flow Fraction"". Schedule values are fractions 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1 and the model uses the fixed fraction specified in in the field ""Zone Minimum Air Flow Fraction"".")]
[JsonProperty("minimum_air_flow_turndown_schedule_name")]
public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
    
    public enum AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_ReheatCoilObjectType
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
    
    [Description("Central air system terminal unit, single duct, variable volume, series powered in" +
        "duction unit (PIU), with reheat coil (hot water, electric, gas, or steam).")]
    public class AirTerminal_SingleDuct_SeriesPIU_Reheat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("maximum_air_flow_rate")]
public string MaximumAirFlowRate { get; set; } = "";
        

[JsonProperty("maximum_primary_air_flow_rate")]
public string MaximumPrimaryAirFlowRate { get; set; } = "";
        

[JsonProperty("minimum_primary_air_flow_fraction")]
public string MinimumPrimaryAirFlowFraction { get; set; } = "";
        

[JsonProperty("supply_air_inlet_node_name")]
public string SupplyAirInletNodeName { get; set; } = "";
        

[JsonProperty("secondary_air_inlet_node_name")]
public string SecondaryAirInletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("reheat_coil_air_inlet_node_name")]
public string ReheatCoilAirInletNodeName { get; set; } = "";
        

[JsonProperty("zone_mixer_name")]
public string ZoneMixerName { get; set; } = "";
        

[Description("Fan type must be Fan:SystemModel or Fan:ConstantVolume")]
[JsonProperty("fan_name")]
public string FanName { get; set; } = "";
        

[JsonProperty("reheat_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_SeriesPIU_Reheat_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirTerminal_SingleDuct_SeriesPIU_Reheat_ReheatCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_SeriesPIU_Reheat_ReheatCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("reheat_coil_name")]
public string ReheatCoilName { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("maximum_hot_water_or_steam_flow_rate")]
public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("minimum_hot_water_or_steam_flow_rate")]
public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("convergence_tolerance")]
public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
    }
    
    public enum AirTerminal_SingleDuct_SeriesPIU_Reheat_ReheatCoilObjectType
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
    
    [Description("Central air system terminal unit, single duct, variable volume, parallel powered " +
        "induction unit (PIU), with reheat coil (hot water, electric, gas, or steam).")]
    public class AirTerminal_SingleDuct_ParallelPIU_Reheat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("maximum_primary_air_flow_rate")]
public string MaximumPrimaryAirFlowRate { get; set; } = "";
        

[JsonProperty("maximum_secondary_air_flow_rate")]
public string MaximumSecondaryAirFlowRate { get; set; } = "";
        

[JsonProperty("minimum_primary_air_flow_fraction")]
public string MinimumPrimaryAirFlowFraction { get; set; } = "";
        

[Description("the fraction of the primary air flow at which fan turns on")]
[JsonProperty("fan_on_flow_fraction")]
public string FanOnFlowFraction { get; set; } = "";
        

[JsonProperty("supply_air_inlet_node_name")]
public string SupplyAirInletNodeName { get; set; } = "";
        

[JsonProperty("secondary_air_inlet_node_name")]
public string SecondaryAirInletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[Description("mixer outlet node")]
[JsonProperty("reheat_coil_air_inlet_node_name")]
public string ReheatCoilAirInletNodeName { get; set; } = "";
        

[JsonProperty("zone_mixer_name")]
public string ZoneMixerName { get; set; } = "";
        

[Description("Fan type must be Fan:SystemModel or Fan:ConstantVolume")]
[JsonProperty("fan_name")]
public string FanName { get; set; } = "";
        

[JsonProperty("reheat_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_ParallelPIU_Reheat_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirTerminal_SingleDuct_ParallelPIU_Reheat_ReheatCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_ParallelPIU_Reheat_ReheatCoilObjectType), "CoilHeatingElectric");
        

[JsonProperty("reheat_coil_name")]
public string ReheatCoilName { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("maximum_hot_water_or_steam_flow_rate")]
public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

[Description("Not used when reheat coil type is gas or electric")]
[JsonProperty("minimum_hot_water_or_steam_flow_rate")]
public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("convergence_tolerance")]
public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
    }
    
    public enum AirTerminal_SingleDuct_ParallelPIU_Reheat_ReheatCoilObjectType
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
    
    [Description("Central air system terminal unit, single duct, variable volume, induction unit wi" +
        "th hot water reheat coil and chilled water recool coil.")]
    public class AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("maximum_total_air_flow_rate")]
public string MaximumTotalAirFlowRate { get; set; } = "";
        

[Description("ratio of induced air flow rate to primary air flow rate")]
[JsonProperty("induction_ratio")]
public System.Nullable<float> InductionRatio { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_air_inlet_node_name")]
public string SupplyAirInletNodeName { get; set; } = "";
        

[Description("should be a zone exhaust node, also the heating coil inlet node")]
[JsonProperty("induced_air_inlet_node_name")]
public string InducedAirInletNodeName { get; set; } = "";
        

[Description("should be a zone inlet node")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("heating_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_HeatingCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_HeatingCoilObjectType), "CoilHeatingWater");
        

[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
        

[Description("Not used when heating coil type is gas or electric")]
[JsonProperty("maximum_hot_water_flow_rate")]
public string MaximumHotWaterFlowRate { get; set; } = "";
        

[Description("Not used when heating coil type is gas or electric")]
[JsonProperty("minimum_hot_water_flow_rate")]
public System.Nullable<float> MinimumHotWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_convergence_tolerance")]
public System.Nullable<float> HeatingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_CoolingCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_CoolingCoilObjectType), "CoilCoolingWater");
        

[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[JsonProperty("maximum_cold_water_flow_rate")]
public string MaximumColdWaterFlowRate { get; set; } = "";
        

[JsonProperty("minimum_cold_water_flow_rate")]
public System.Nullable<float> MinimumColdWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_convergence_tolerance")]
public System.Nullable<float> CoolingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

[JsonProperty("zone_mixer_name")]
public string ZoneMixerName { get; set; } = "";
    }
    
    public enum AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_HeatingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Water")]
        CoilHeatingWater = 0,
    }
    
    public enum AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_CoolingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water")]
        CoilCoolingWater = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 1,
    }
    
    [Description("Central air system terminal unit, single duct, constant volume, with heating and/" +
        "or cooling. Operates as two-pipe unit if heating or cooling water is omitted. He" +
        "ating and/or cooling can be scheduled off for dedicated ventilation.")]
    public class AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam : BHoMObject, IEnergyPlusClass
    {
        

[Description("Primary air is supplied by central air handling unit and must be on for heating o" +
    "r cooling. Schedule value > 0 means the primary air supply is available. If this" +
    " field is blank, the primary air supply is always available.")]
[JsonProperty("primary_air_availability_schedule_name")]
public string PrimaryAirAvailabilityScheduleName { get; set; } = "";
        

[Description("Cooling operation can be controlled separately using this availability schedule. " +
    "Schedule value > 0 means beam cooling is available. If this field is blank, the " +
    "beam cooling is always available (as long as primary air is also available).")]
[JsonProperty("cooling_availability_schedule_name")]
public string CoolingAvailabilityScheduleName { get; set; } = "";
        

[Description("Heating operation can be controlled separately using this availability schedule. " +
    "Schedule value > 0 means beam heating is available. If this field is blank, the " +
    "beam heating is always available (as long as primary air is also available).")]
[JsonProperty("heating_availability_schedule_name")]
public string HeatingAvailabilityScheduleName { get; set; } = "";
        

[Description("Name of the air system node for primary supply air entering the air distribution " +
    "unit.")]
[JsonProperty("primary_air_inlet_node_name")]
public string PrimaryAirInletNodeName { get; set; } = "";
        

[Description("Name of the air system node for primary supply air leaving the air distribution u" +
    "nit and entering the zone.")]
[JsonProperty("primary_air_outlet_node_name")]
public string PrimaryAirOutletNodeName { get; set; } = "";
        

[Description("Name of the plant system node for chilled water entering the beam. The two chille" +
    "d water nodes can (only) be omitted to model a two-pipe heating only beam.")]
[JsonProperty("chilled_water_inlet_node_name")]
public string ChilledWaterInletNodeName { get; set; } = "";
        

[Description("Name of the plant system node for chilled water leaving the beam.")]
[JsonProperty("chilled_water_outlet_node_name")]
public string ChilledWaterOutletNodeName { get; set; } = "";
        

[Description("Name of the plant system node for hot water entering the beam. The two hot water " +
    "nodes can (only) be omitted to model a two-pipe cooling-only beam.")]
[JsonProperty("hot_water_inlet_node_name")]
public string HotWaterInletNodeName { get; set; } = "";
        

[Description("Name of the plant system node for hot water leaving the beam.")]
[JsonProperty("hot_water_outlet_node_name")]
public string HotWaterOutletNodeName { get; set; } = "";
        

[JsonProperty("design_primary_air_volume_flow_rate")]
public string DesignPrimaryAirVolumeFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_chilled_water_volume_flow_rate")]
public string DesignChilledWaterVolumeFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_hot_water_volume_flow_rate")]
public string DesignHotWaterVolumeFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Sum of the length of all the beam units in the zone represented by this terminal " +
    "unit.")]
[JsonProperty("zone_total_beam_length")]
public string ZoneTotalBeamLength { get; set; } = (System.String)"Autosize";
        

[Description("Primary air supply flow rate normalized by beam length.")]
[JsonProperty("rated_primary_air_flow_rate_per_beam_length")]
public System.Nullable<float> RatedPrimaryAirFlowRatePerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("0.035", CultureInfo.InvariantCulture);
        

[Description("Sensible cooling capacity per meter of beam length at the rating point.")]
[JsonProperty("beam_rated_cooling_capacity_per_beam_length")]
public System.Nullable<float> BeamRatedCoolingCapacityPerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

[Description("Difference in temperature between the zone air and the entering chilled water at " +
    "the rating point.")]
[JsonProperty("beam_rated_cooling_room_air_chilled_water_temperature_difference")]
public System.Nullable<float> BeamRatedCoolingRoomAirChilledWaterTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("The volume flow rate of chilled water per meter of beam length at the rating poin" +
    "t.")]
[JsonProperty("beam_rated_chilled_water_volume_flow_rate_per_beam_length")]
public System.Nullable<float> BeamRatedChilledWaterVolumeFlowRatePerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("5E-05", CultureInfo.InvariantCulture);
        

[Description(@"Adjusts beam cooling capacity when the temperature difference between entering water and zone air is different than at the rating point. Single independent variable is the ratio of the current temperature difference divided by the rating point temperature difference. This field is required when beam is connected to a chilled water plant.")]
[JsonProperty("beam_cooling_capacity_temperature_difference_modification_factor_curve_name")]
public string BeamCoolingCapacityTemperatureDifferenceModificationFactorCurveName { get; set; } = "";
        

[Description(@"Adjusts beam cooling capacity when the primary air supply flow rate is different than at the rating point. The single independent variable is the current normalized air flow rate divided by the normalized air flow rate at the rating point. This field is required when beam is connected to a chilled water plant.")]
[JsonProperty("beam_cooling_capacity_air_flow_modification_factor_curve_name")]
public string BeamCoolingCapacityAirFlowModificationFactorCurveName { get; set; } = "";
        

[Description(@"Adjusts beam cooling capacity when the normalized chilled water flow rate is different than at the rating point. The single independent variable is the current normalized chilled water flow rate divided by the normalized chilled water flow rate at the rating point. This field is required when beam is connected to a chilled water plant.")]
[JsonProperty("beam_cooling_capacity_chilled_water_flow_modification_factor_curve_name")]
public string BeamCoolingCapacityChilledWaterFlowModificationFactorCurveName { get; set; } = "";
        

[Description("Sensible heating capacity per meter of beam length at the rating point.")]
[JsonProperty("beam_rated_heating_capacity_per_beam_length")]
public System.Nullable<float> BeamRatedHeatingCapacityPerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("1500", CultureInfo.InvariantCulture);
        

[Description("Difference in temperature between the zone air and the entering hot water at the " +
    "rating point.")]
[JsonProperty("beam_rated_heating_room_air_hot_water_temperature_difference")]
public System.Nullable<float> BeamRatedHeatingRoomAirHotWaterTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("27.8", CultureInfo.InvariantCulture);
        

[Description("The volume flow rate of hoy water per meter of beam length at the rating point.")]
[JsonProperty("beam_rated_hot_water_volume_flow_rate_per_beam_length")]
public System.Nullable<float> BeamRatedHotWaterVolumeFlowRatePerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("5E-05", CultureInfo.InvariantCulture);
        

[Description(@"Adjusts beam heating capacity when the temperature difference between entering water and zone air is different than at the rating point. Single independent variable is the ratio of the current temperature difference divided by the rating point temperature difference. This field is required when beam is connected to a hot water plant.")]
[JsonProperty("beam_heating_capacity_temperature_difference_modification_factor_curve_name")]
public string BeamHeatingCapacityTemperatureDifferenceModificationFactorCurveName { get; set; } = "";
        

[Description(@"Adjusts beam heating capacity when the primary air supply flow rate is different than at the rating point. The single independent variable is the current normalized air flow rate divided by the normalized air flow rate at the rating point. This field is required when beam is connected to a hot water plant.")]
[JsonProperty("beam_heating_capacity_air_flow_modification_factor_curve_name")]
public string BeamHeatingCapacityAirFlowModificationFactorCurveName { get; set; } = "";
        

[Description(@"Adjusts beam heating capacity when the normalized hot water flow rate is different than at the rating point. The single independent variable is the current normalized hot water flow rate divided by the normalized hot water flow rate at the rating point. This field is required when beam is connected to a hot water plant.")]
[JsonProperty("beam_heating_capacity_hot_water_flow_modification_factor_curve_name")]
public string BeamHeatingCapacityHotWaterFlowModificationFactorCurveName { get; set; } = "";
    }
    
    [Description("Central air system terminal unit, single duct, constant volume, with cooled beam " +
        "(active or passive).")]
    public class AirTerminal_SingleDuct_ConstantVolume_CooledBeam : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("cooled_beam_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_ConstantVolume_CooledBeam_CooledBeamType CooledBeamType { get; set; } = (AirTerminal_SingleDuct_ConstantVolume_CooledBeam_CooledBeamType)Enum.Parse(typeof(AirTerminal_SingleDuct_ConstantVolume_CooledBeam_CooledBeamType), "Active");
        

[JsonProperty("supply_air_inlet_node_name")]
public string SupplyAirInletNodeName { get; set; } = "";
        

[JsonProperty("supply_air_outlet_node_name")]
public string SupplyAirOutletNodeName { get; set; } = "";
        

[JsonProperty("chilled_water_inlet_node_name")]
public string ChilledWaterInletNodeName { get; set; } = "";
        

[JsonProperty("chilled_water_outlet_node_name")]
public string ChilledWaterOutletNodeName { get; set; } = "";
        

[JsonProperty("supply_air_volumetric_flow_rate")]
public string SupplyAirVolumetricFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("maximum_total_chilled_water_volumetric_flow_rate")]
public string MaximumTotalChilledWaterVolumetricFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Number of individual beam units in the zone")]
[JsonProperty("number_of_beams")]
public string NumberOfBeams { get; set; } = (System.String)"Autosize";
        

[Description("Length of an individual beam unit")]
[JsonProperty("beam_length")]
public string BeamLength { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_inlet_water_temperature")]
public System.Nullable<float> DesignInletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[JsonProperty("design_outlet_water_temperature")]
public System.Nullable<float> DesignOutletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("17", CultureInfo.InvariantCulture);
        

[JsonProperty("coil_surface_area_per_coil_length")]
public System.Nullable<float> CoilSurfaceAreaPerCoilLength { get; set; } = (System.Nullable<float>)Single.Parse("5.422", CultureInfo.InvariantCulture);
        

[JsonProperty("model_parameter_a")]
public System.Nullable<float> ModelParameterA { get; set; } = (System.Nullable<float>)Single.Parse("15.3", CultureInfo.InvariantCulture);
        

[JsonProperty("model_parameter_n1")]
public System.Nullable<float> ModelParameterN1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("model_parameter_n2")]
public System.Nullable<float> ModelParameterN2 { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty("model_parameter_n3")]
public System.Nullable<float> ModelParameterN3 { get; set; } = (System.Nullable<float>)Single.Parse("0.12", CultureInfo.InvariantCulture);
        

[Description("Free area of the coil in plan view per unit beam length")]
[JsonProperty("model_parameter_a0")]
public System.Nullable<float> ModelParameterA0 { get; set; } = (System.Nullable<float>)Single.Parse("0.171", CultureInfo.InvariantCulture);
        

[JsonProperty("model_parameter_k1")]
public System.Nullable<float> ModelParameterK1 { get; set; } = (System.Nullable<float>)Single.Parse("0.0057", CultureInfo.InvariantCulture);
        

[JsonProperty("model_parameter_n")]
public System.Nullable<float> ModelParameterN { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[JsonProperty("coefficient_of_induction_kin")]
public string CoefficientOfInductionKin { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("leaving_pipe_inside_diameter")]
public System.Nullable<float> LeavingPipeInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.0145", CultureInfo.InvariantCulture);
    }
    
    public enum AirTerminal_SingleDuct_ConstantVolume_CooledBeam_CooledBeamType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Active")]
        Active = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Passive")]
        Passive = 1,
    }
    
    [Description(@"The mixer air terminal unit provides a means of supplying central system air to the air inlet or outlet side of a zoneHVAC equipment such as a four pipe fan coil unit. Normally the central air would be ventilation air from a dedicated outdoor air system (DOAS).")]
    public class AirTerminal_SingleDuct_Mixer : BHoMObject, IEnergyPlusClass
    {
        

[Description("The type of ZoneHVAC equipment to which this terminal mixer will be connected.")]
[JsonProperty("zonehvac_unit_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_Mixer_ZonehvacUnitObjectType ZonehvacUnitObjectType { get; set; } = (AirTerminal_SingleDuct_Mixer_ZonehvacUnitObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_Mixer_ZonehvacUnitObjectType), "AirLoopHVACUnitarySystem");
        

[Description("The name of ZoneHVAC equipment to which this terminal mixer will be connected.")]
[JsonProperty("zonehvac_unit_object_name")]
public string ZonehvacUnitObjectName { get; set; } = "";
        

[Description(@"This is the outlet air node name of the mixer. This will be the inlet air node name of the ZoneHVAC equipment if the connection type in the input field Mixer Connection Type below is InletSide, else this will be an inlet air node name of the conditioned zone if the connection type in the input field Mixer Connection Type below is SupplySide.")]
[JsonProperty("mixer_outlet_node_name")]
public string MixerOutletNodeName { get; set; } = "";
        

[Description("The primary air (treated outdoor air) inlet node name of the mixer. This will be " +
    "an outlet air node name of an AirLoopHVAC:ZoneSplitter or AirLoopHVAC:SupplyPlen" +
    "um providing the connection to the DOA system.")]
[JsonProperty("mixer_primary_air_inlet_node_name")]
public string MixerPrimaryAirInletNodeName { get; set; } = "";
        

[Description(@"The secondary air (recirculating air) inlet node name of the mixer. This will be the outlet air node name of the ZoneHVAC equipment if the connection type in the input field mixer Connection Type below is SupplySide, or else this will be an exhaust air node name of the conditioned zone if the connection type in the input field Mixer Connection Type below is InletSide.")]
[JsonProperty("mixer_secondary_air_inlet_node_name")]
public string MixerSecondaryAirInletNodeName { get; set; } = "";
        

[Description(@"This input field allows user to specify the mixer connection type. Valid choices are InletSide or SupplySide. This is a required input field. If the mixer connection type selected is InletSide, then the mixer is connected on the inlet side of the ZoneHVAC equipment, or else if the mixer connection type selected is SupplySide, then the mixer is connected at the outlet side of the ZoneHVAC equipment.")]
[JsonProperty("mixer_connection_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_Mixer_MixerConnectionType MixerConnectionType { get; set; } = (AirTerminal_SingleDuct_Mixer_MixerConnectionType)Enum.Parse(typeof(AirTerminal_SingleDuct_Mixer_MixerConnectionType), "InletSide");
        

[Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will adjust flow to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone, as for demand controlled ventilation. If this field is blank, then the terminal unit will be controlled using the DesignSpecification:OutdoorAir objec referenced in the Sizing:Zone object.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("CurrentOccupancy models demand controlled ventilation using the current number of" +
    " people DesignOccupancy uses the total Number of People in the zone and is const" +
    "ant")]
[JsonProperty("per_person_ventilation_rate_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_SingleDuct_Mixer_PerPersonVentilationRateMode PerPersonVentilationRateMode { get; set; } = (AirTerminal_SingleDuct_Mixer_PerPersonVentilationRateMode)Enum.Parse(typeof(AirTerminal_SingleDuct_Mixer_PerPersonVentilationRateMode), "CurrentOccupancy");
    }
    
    public enum AirTerminal_SingleDuct_Mixer_ZonehvacUnitObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:UnitarySystem")]
        AirLoopHVACUnitarySystem = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:FourPipeFanCoil")]
        ZoneHVACFourPipeFanCoil = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:PackagedTerminalAirConditioner")]
        ZoneHVACPackagedTerminalAirConditioner = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:PackagedTerminalHeatPump")]
        ZoneHVACPackagedTerminalHeatPump = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:TerminalUnit:VariableRefrigerantFlow")]
        ZoneHVACTerminalUnitVariableRefrigerantFlow = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:UnitVentilator")]
        ZoneHVACUnitVentilator = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:WaterToAirHeatPump")]
        ZoneHVACWaterToAirHeatPump = 6,
    }
    
    public enum AirTerminal_SingleDuct_Mixer_MixerConnectionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="InletSide")]
        InletSide = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplySide")]
        SupplySide = 1,
    }
    
    public enum AirTerminal_SingleDuct_Mixer_PerPersonVentilationRateMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CurrentOccupancy")]
        CurrentOccupancy = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignOccupancy")]
        DesignOccupancy = 2,
    }
    
    [Description("Central air system terminal unit, dual duct, constant volume.")]
    public class AirTerminal_DualDuct_ConstantVolume : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("The outlet node of the terminal unit. This is also the zone inlet node.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("hot_air_inlet_node_name")]
public string HotAirInletNodeName { get; set; } = "";
        

[JsonProperty("cold_air_inlet_node_name")]
public string ColdAirInletNodeName { get; set; } = "";
        

[JsonProperty("maximum_air_flow_rate")]
public string MaximumAirFlowRate { get; set; } = "";
    }
    
    [Description("Central air system terminal unit, dual duct, variable volume.")]
    public class AirTerminal_DualDuct_VAV : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("The outlet node of the terminal unit. This is also the zone inlet node.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("hot_air_inlet_node_name")]
public string HotAirInletNodeName { get; set; } = "";
        

[JsonProperty("cold_air_inlet_node_name")]
public string ColdAirInletNodeName { get; set; } = "";
        

[JsonProperty("maximum_damper_air_flow_rate")]
public string MaximumDamperAirFlowRate { get; set; } = "";
        

[Description("fraction of maximum air flow")]
[JsonProperty("zone_minimum_air_flow_fraction")]
public System.Nullable<float> ZoneMinimumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. If this field is blank, then the terminal unit will not be controlled for outdoor air flow.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description(@"This field adjusts the design minimum flow rate by multiplying it using this schedule of fraction values. This field is used with ""Zone Minimum Air Flow Fraction"". Schedule values are fractions 0.0 to 1.0. This field adjusts the minimum airflow turndown below the design minimum air flow and is intended for use with ASHRAE Standard 170. If this field is left blank, then the turndown minimum air flow fraction value is set to 1 and the VAV air terminal uses fixed fraction specified in the field ""Zone Minimum Air Flow Fraction"".")]
[JsonProperty("minimum_air_flow_turndown_schedule_name")]
public string MinimumAirFlowTurndownScheduleName { get; set; } = "";
    }
    
    [Description("Central air system terminal unit, dual duct, variable volume with special control" +
        "s. One VAV duct is controlled to supply ventilation air and the other VAV duct i" +
        "s controlled to meet the zone cooling load.")]
    public class AirTerminal_DualDuct_VAV_OutdoorAir : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("The outlet node of the terminal unit. This is also the zone inlet node.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("recirculated_air_inlet_node_name")]
public string RecirculatedAirInletNodeName { get; set; } = "";
        

[Description("If autosized this is the sum of flow needed for cooling and maximum required outd" +
    "oor air")]
[JsonProperty("maximum_terminal_air_flow_rate")]
public string MaximumTerminalAirFlowRate { get; set; } = "";
        

[Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based mode selected in the next field. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("CurrentOccupancy models demand controlled ventilation using the current number of" +
    " people DesignOccupancy uses the total Number of People in the zone and is const" +
    "ant")]
[JsonProperty("per_person_ventilation_rate_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirTerminal_DualDuct_VAV_OutdoorAir_PerPersonVentilationRateMode PerPersonVentilationRateMode { get; set; } = (AirTerminal_DualDuct_VAV_OutdoorAir_PerPersonVentilationRateMode)Enum.Parse(typeof(AirTerminal_DualDuct_VAV_OutdoorAir_PerPersonVentilationRateMode), "CurrentOccupancy");
    }
    
    public enum AirTerminal_DualDuct_VAV_OutdoorAir_PerPersonVentilationRateMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="CurrentOccupancy")]
        CurrentOccupancy = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignOccupancy")]
        DesignOccupancy = 1,
    }
    
    [Description("Central air system air distribution unit, serves as a wrapper for a specific type" +
        " of air terminal unit. This object is referenced in a ZoneHVAC:EquipmentList.")]
    public class ZoneHVAC_AirDistributionUnit : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("air_distribution_unit_outlet_node_name")]
public string AirDistributionUnitOutletNodeName { get; set; } = "";
        

[JsonProperty("air_terminal_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneHVAC_AirDistributionUnit_AirTerminalObjectType AirTerminalObjectType { get; set; } = (ZoneHVAC_AirDistributionUnit_AirTerminalObjectType)Enum.Parse(typeof(ZoneHVAC_AirDistributionUnit_AirTerminalObjectType), "AirTerminalDualDuctConstantVolume");
        

[JsonProperty("air_terminal_name")]
public string AirTerminalName { get; set; } = "";
        

[Description("fraction at system design Flow; leakage Flow constant, leakage fraction varies wi" +
    "th variable system Flow Rate.")]
[JsonProperty("nominal_upstream_leakage_fraction")]
public System.Nullable<float> NominalUpstreamLeakageFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("constant_downstream_leakage_fraction")]
public System.Nullable<float> ConstantDownstreamLeakageFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This optional field is the name of a DesignSpecification:AirTerminal:Sizing objec" +
    "t which specifies sizing adjustments to be made for this terminal unit.")]
[JsonProperty("design_specification_air_terminal_sizing_object_name")]
public string DesignSpecificationAirTerminalSizingObjectName { get; set; } = "";
    }
    
    public enum ZoneHVAC_AirDistributionUnit_AirTerminalObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:DualDuct:ConstantVolume")]
        AirTerminalDualDuctConstantVolume = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:DualDuct:VAV")]
        AirTerminalDualDuctVAV = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:DualDuct:VAV:OutdoorAir")]
        AirTerminalDualDuctVAVOutdoorAir = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:CooledBeam")]
        AirTerminalSingleDuctConstantVolumeCooledBeam = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:FourPipeBeam")]
        AirTerminalSingleDuctConstantVolumeFourPipeBeam = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:FourPipeInduction")]
        AirTerminalSingleDuctConstantVolumeFourPipeInduction = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:NoReheat")]
        AirTerminalSingleDuctConstantVolumeNoReheat = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:Reheat")]
        AirTerminalSingleDuctConstantVolumeReheat = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:Mixer")]
        AirTerminalSingleDuctMixer = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ParallelPIU:Reheat")]
        AirTerminalSingleDuctParallelPIUReheat = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:SeriesPIU:Reheat")]
        AirTerminalSingleDuctSeriesPIUReheat = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:UserDefined")]
        AirTerminalSingleDuctUserDefined = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:HeatAndCool:NoReheat")]
        AirTerminalSingleDuctVAVHeatAndCoolNoReheat = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat")]
        AirTerminalSingleDuctVAVHeatAndCoolReheat = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:NoReheat")]
        AirTerminalSingleDuctVAVNoReheat = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:Reheat")]
        AirTerminalSingleDuctVAVReheat = 15,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:Reheat:VariableSpeedFan")]
        AirTerminalSingleDuctVAVReheatVariableSpeedFan = 16,
    }
}
