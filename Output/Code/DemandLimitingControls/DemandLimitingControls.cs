namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
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
    
    
    [Description("a list of meters that can be reported are available after a run on the meter dict" +
        "ionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    public class DemandManagerAssignmentList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("meter_name")]
public string MeterName { get; set; } = "";
        

[JsonProperty("demand_limit_schedule_name")]
public string DemandLimitScheduleName { get; set; } = "";
        

[JsonProperty("demand_limit_safety_fraction")]
public System.Nullable<float> DemandLimitSafetyFraction { get; set; } = null;
        

[Description("This field should reference the same schedule as the month schedule name field of" +
    " the UtilityCost:Tariff object, if used. If blank, defaults to regular divisions" +
    " between months.")]
[JsonProperty("billing_period_schedule_name")]
public string BillingPeriodScheduleName { get; set; } = "";
        

[Description("This field should reference the same schedule as the period schedule name field o" +
    "f the UtilityCost:Tariff object, if used. If blank, defaults to always on peak.")]
[JsonProperty("peak_period_schedule_name")]
public string PeakPeriodScheduleName { get; set; } = "";
        

[JsonProperty("demand_window_length")]
public System.Nullable<float> DemandWindowLength { get; set; } = null;
        

[JsonProperty("demand_manager_priority")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManagerAssignmentList_DemandManagerPriority DemandManagerPriority { get; set; } = (DemandManagerAssignmentList_DemandManagerPriority)Enum.Parse(typeof(DemandManagerAssignmentList_DemandManagerPriority), "All");
        

[JsonProperty("manager_data")]
public string ManagerData { get; set; } = "";
    }
    
    public enum DemandManagerAssignmentList_DemandManagerPriority
    {
        
        [System.Runtime.Serialization.EnumMember(Value="All")]
        All = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Sequential")]
        Sequential = 1,
    }
    
    [Description("used for demand limiting Exterior:Lights objects.")]
    public class DemandManager_ExteriorLights : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("limit_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_ExteriorLights_LimitControl LimitControl { get; set; } = (DemandManager_ExteriorLights_LimitControl)Enum.Parse(typeof(DemandManager_ExteriorLights_LimitControl), "Fixed");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("minimum_limit_duration")]
public System.Nullable<float> MinimumLimitDuration { get; set; } = null;
        

[JsonProperty("maximum_limit_fraction")]
public System.Nullable<float> MaximumLimitFraction { get; set; } = null;
        

[Description("Not yet implemented")]
[JsonProperty("limit_step_change")]
public System.Nullable<float> LimitStepChange { get; set; } = null;
        

[JsonProperty("selection_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_ExteriorLights_SelectionControl SelectionControl { get; set; } = (DemandManager_ExteriorLights_SelectionControl)Enum.Parse(typeof(DemandManager_ExteriorLights_SelectionControl), "All");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("rotation_duration")]
public System.Nullable<float> RotationDuration { get; set; } = null;
        

[JsonProperty("lights")]
public string Lights { get; set; } = "";
    }
    
    public enum DemandManager_ExteriorLights_LimitControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Off")]
        Off = 1,
    }
    
    public enum DemandManager_ExteriorLights_SelectionControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="All")]
        All = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateMany")]
        RotateMany = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateOne")]
        RotateOne = 2,
    }
    
    [Description("used for demand limiting Lights objects.")]
    public class DemandManager_Lights : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("limit_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_Lights_LimitControl LimitControl { get; set; } = (DemandManager_Lights_LimitControl)Enum.Parse(typeof(DemandManager_Lights_LimitControl), "Fixed");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("minimum_limit_duration")]
public System.Nullable<float> MinimumLimitDuration { get; set; } = null;
        

[JsonProperty("maximum_limit_fraction")]
public System.Nullable<float> MaximumLimitFraction { get; set; } = null;
        

[Description("Not yet implemented")]
[JsonProperty("limit_step_change")]
public System.Nullable<float> LimitStepChange { get; set; } = null;
        

[JsonProperty("selection_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_Lights_SelectionControl SelectionControl { get; set; } = (DemandManager_Lights_SelectionControl)Enum.Parse(typeof(DemandManager_Lights_SelectionControl), "All");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("rotation_duration")]
public System.Nullable<float> RotationDuration { get; set; } = null;
        

[JsonProperty("lights")]
public string Lights { get; set; } = "";
    }
    
    public enum DemandManager_Lights_LimitControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Off")]
        Off = 1,
    }
    
    public enum DemandManager_Lights_SelectionControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="All")]
        All = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateMany")]
        RotateMany = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateOne")]
        RotateOne = 2,
    }
    
    [Description("used for demand limiting ElectricEquipment objects.")]
    public class DemandManager_ElectricEquipment : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("limit_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_ElectricEquipment_LimitControl LimitControl { get; set; } = (DemandManager_ElectricEquipment_LimitControl)Enum.Parse(typeof(DemandManager_ElectricEquipment_LimitControl), "Fixed");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("minimum_limit_duration")]
public System.Nullable<float> MinimumLimitDuration { get; set; } = null;
        

[JsonProperty("maximum_limit_fraction")]
public System.Nullable<float> MaximumLimitFraction { get; set; } = null;
        

[Description("Not yet implemented")]
[JsonProperty("limit_step_change")]
public System.Nullable<float> LimitStepChange { get; set; } = null;
        

[JsonProperty("selection_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_ElectricEquipment_SelectionControl SelectionControl { get; set; } = (DemandManager_ElectricEquipment_SelectionControl)Enum.Parse(typeof(DemandManager_ElectricEquipment_SelectionControl), "All");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("rotation_duration")]
public System.Nullable<float> RotationDuration { get; set; } = null;
        

[JsonProperty("equipment")]
public string Equipment { get; set; } = "";
    }
    
    public enum DemandManager_ElectricEquipment_LimitControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Off")]
        Off = 1,
    }
    
    public enum DemandManager_ElectricEquipment_SelectionControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="All")]
        All = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateMany")]
        RotateMany = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateOne")]
        RotateOne = 2,
    }
    
    [Description("used for demand limiting ZoneControl:Thermostat objects.")]
    public class DemandManager_Thermostats : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("reset_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_Thermostats_ResetControl ResetControl { get; set; } = (DemandManager_Thermostats_ResetControl)Enum.Parse(typeof(DemandManager_Thermostats_ResetControl), "Fixed");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("minimum_reset_duration")]
public System.Nullable<float> MinimumResetDuration { get; set; } = null;
        

[JsonProperty("maximum_heating_setpoint_reset")]
public System.Nullable<float> MaximumHeatingSetpointReset { get; set; } = null;
        

[JsonProperty("maximum_cooling_setpoint_reset")]
public System.Nullable<float> MaximumCoolingSetpointReset { get; set; } = null;
        

[Description("Not yet implemented")]
[JsonProperty("reset_step_change")]
public System.Nullable<float> ResetStepChange { get; set; } = null;
        

[JsonProperty("selection_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_Thermostats_SelectionControl SelectionControl { get; set; } = (DemandManager_Thermostats_SelectionControl)Enum.Parse(typeof(DemandManager_Thermostats_SelectionControl), "All");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("rotation_duration")]
public System.Nullable<float> RotationDuration { get; set; } = null;
        

[JsonProperty("thermostats")]
public string Thermostats { get; set; } = "";
    }
    
    public enum DemandManager_Thermostats_ResetControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Off")]
        Off = 1,
    }
    
    public enum DemandManager_Thermostats_SelectionControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="All")]
        All = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateMany")]
        RotateMany = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateOne")]
        RotateOne = 2,
    }
    
    [Description("used for demand limiting Controller:OutdoorAir objects.")]
    public class DemandManager_Ventilation : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this demand manager. Schedule value > 0 means the " +
    "demand manager is available. If this field is blank, the DR is always available." +
    "")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("limit_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_Ventilation_LimitControl LimitControl { get; set; } = (DemandManager_Ventilation_LimitControl)Enum.Parse(typeof(DemandManager_Ventilation_LimitControl), "FixedRate");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("minimum_limit_duration")]
public System.Nullable<float> MinimumLimitDuration { get; set; } = null;
        

[Description("Used in case when Limit strategy is set to FixedRate")]
[JsonProperty("fixed_rate")]
public System.Nullable<float> FixedRate { get; set; } = null;
        

[Description("Used in case when Limit Control is set to ReductionRatio")]
[JsonProperty("reduction_ratio")]
public System.Nullable<float> ReductionRatio { get; set; } = null;
        

[Description("Not yet implemented")]
[JsonProperty("limit_step_change")]
public System.Nullable<float> LimitStepChange { get; set; } = null;
        

[JsonProperty("selection_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DemandManager_Ventilation_SelectionControl SelectionControl { get; set; } = (DemandManager_Ventilation_SelectionControl)Enum.Parse(typeof(DemandManager_Ventilation_SelectionControl), "All");
        

[Description("If blank, duration defaults to the timestep")]
[JsonProperty("rotation_duration")]
public System.Nullable<float> RotationDuration { get; set; } = null;
        

[JsonProperty("controllers")]
public string Controllers { get; set; } = "";
    }
    
    public enum DemandManager_Ventilation_LimitControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FixedRate")]
        FixedRate = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Off")]
        Off = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ReductionRatio")]
        ReductionRatio = 2,
    }
    
    public enum DemandManager_Ventilation_SelectionControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="All")]
        All = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateMany")]
        RotateMany = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="RotateOne")]
        RotateOne = 3,
    }
}
