namespace BH.oM.Adapters.EnergyPlus.WaterSystems
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
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description(@"A generalized object for simulating all water end uses. Hot and cold water uses are included, as well as controlled mixing of hot and cold water at the tap. The WaterUse:Equipment object can be used stand-alone, or coupled into a plant loop using the WaterUse:Connections object (see below). The WaterUse:Connections object allows water uses to be linked to WaterUse:Storage objects to store and draw reclaimed water. The object can also simulate drainwater heat recovery.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterUse_Equipment : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[JsonProperty("peak_flow_rate")]
public System.Nullable<float> PeakFlowRate { get; set; } = null;
        

[Description("Defaults to 1.0 at all times")]
[JsonProperty("flow_rate_fraction_schedule_name")]
public string FlowRateFractionScheduleName { get; set; } = "";
        

[Description("Defaults to hot water supply temperature")]
[JsonProperty("target_temperature_schedule_name")]
public string TargetTemperatureScheduleName { get; set; } = "";
        

[Description("Defaults to cold water supply temperature")]
[JsonProperty("hot_water_supply_temperature_schedule_name")]
public string HotWaterSupplyTemperatureScheduleName { get; set; } = "";
        

[Description("Defaults to water temperatures calculated by Site:WaterMainsTemperature object")]
[JsonProperty("cold_water_supply_temperature_schedule_name")]
public string ColdWaterSupplyTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Defaults to 0.0 at all times")]
[JsonProperty("sensible_fraction_schedule_name")]
public string SensibleFractionScheduleName { get; set; } = "";
        

[Description("Defaults to 0.0 at all times")]
[JsonProperty("latent_fraction_schedule_name")]
public string LatentFractionScheduleName { get; set; } = "";
    }
    
    [Description(@"A subsystem that groups together multiple WaterUse:Equipment components. As its name suggests, the object provides connections that are shared by these components, including: 1. Inlet node and outlet node connections to a plant loop 2. Connections to WaterUse:Storage objects to store and draw reclaimed water 3. Internal connections to simulate drainwater heat recovery.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterUse_Connections : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[Description("If blank, or tank is empty, defaults to fresh water from the mains")]
[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[JsonProperty("reclamation_water_storage_tank_name")]
public string ReclamationWaterStorageTankName { get; set; } = "";
        

[Description("Defaults to cold water supply temperature")]
[JsonProperty("hot_water_supply_temperature_schedule_name")]
public string HotWaterSupplyTemperatureScheduleName { get; set; } = "";
        

[Description("Defaults to water temperatures calculated by Site:WaterMainsTemperature object")]
[JsonProperty("cold_water_supply_temperature_schedule_name")]
public string ColdWaterSupplyTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("drain_water_heat_exchanger_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterUse_Connections_DrainWaterHeatExchangerType DrainWaterHeatExchangerType { get; set; } = (WaterUse_Connections_DrainWaterHeatExchangerType)Enum.Parse(typeof(WaterUse_Connections_DrainWaterHeatExchangerType), "None");
        

[JsonProperty("drain_water_heat_exchanger_destination")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterUse_Connections_DrainWaterHeatExchangerDestination DrainWaterHeatExchangerDestination { get; set; } = (WaterUse_Connections_DrainWaterHeatExchangerDestination)Enum.Parse(typeof(WaterUse_Connections_DrainWaterHeatExchangerDestination), "Plant");
        

[JsonProperty("drain_water_heat_exchanger_u_factor_times_area")]
public System.Nullable<float> DrainWaterHeatExchangerUFactorTimesArea { get; set; } = null;
        

[JsonProperty("connections")]
public string Connections { get; set; } = "";
    }
    
    public enum WaterUse_Connections_DrainWaterHeatExchangerType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CounterFlow")]
        CounterFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CrossFlow")]
        CrossFlow = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Ideal")]
        Ideal = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
    
    public enum WaterUse_Connections_DrainWaterHeatExchangerDestination
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Equipment")]
        Equipment = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Plant")]
        Plant = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantAndEquipment")]
        PlantAndEquipment = 3,
    }
    
    [Description(@"A water storage tank. If the building model is to include any on-site water collection, wells, or storing and reuse of graywater, then a WaterUse:Storage object is needed. Each WaterUse:Storage can serve as a central node and make connections to numerous sources of supply or numerous components with demand. If a maximum capacity is not specified, the tank is assumed to have unlimited capacity.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterUse_Storage : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("water_quality_subcategory")]
public string WaterQualitySubcategory { get; set; } = "";
        

[Description("Defaults to unlimited capacity.")]
[JsonProperty("maximum_capacity")]
public System.Nullable<float> MaximumCapacity { get; set; } = null;
        

[JsonProperty("initial_volume")]
public System.Nullable<float> InitialVolume { get; set; } = null;
        

[Description("Defaults to unlimited flow.")]
[JsonProperty("design_in_flow_rate")]
public System.Nullable<float> DesignInFlowRate { get; set; } = null;
        

[Description("Defaults to unlimited flow.")]
[JsonProperty("design_out_flow_rate")]
public System.Nullable<float> DesignOutFlowRate { get; set; } = null;
        

[Description("If blank, overflow is discarded")]
[JsonProperty("overflow_destination")]
public string OverflowDestination { get; set; } = "";
        

[JsonProperty("type_of_supply_controlled_by_float_valve")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterUse_Storage_TypeOfSupplyControlledByFloatValve TypeOfSupplyControlledByFloatValve { get; set; } = (WaterUse_Storage_TypeOfSupplyControlledByFloatValve)Enum.Parse(typeof(WaterUse_Storage_TypeOfSupplyControlledByFloatValve), "GroundwaterWell");
        

[Description("Lower range of target storage level e.g. float valve kicks on")]
[JsonProperty("float_valve_on_capacity")]
public System.Nullable<float> FloatValveOnCapacity { get; set; } = null;
        

[Description("Upper range of target storage level e.g. float valve kicks off")]
[JsonProperty("float_valve_off_capacity")]
public System.Nullable<float> FloatValveOffCapacity { get; set; } = null;
        

[Description("Lower range of secondary target storage level used to keep tanks at a minimum lev" +
    "el using mains water if well can\'t keep up")]
[JsonProperty("backup_mains_capacity")]
public System.Nullable<float> BackupMainsCapacity { get; set; } = null;
        

[JsonProperty("other_tank_name")]
public string OtherTankName { get; set; } = "";
        

[JsonProperty("water_thermal_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterUse_Storage_WaterThermalMode WaterThermalMode { get; set; } = (WaterUse_Storage_WaterThermalMode)Enum.Parse(typeof(WaterUse_Storage_WaterThermalMode), "ScheduledTemperature");
        

[JsonProperty("water_temperature_schedule_name")]
public string WaterTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("ambient_temperature_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterUse_Storage_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (WaterUse_Storage_AmbientTemperatureIndicator)Enum.Parse(typeof(WaterUse_Storage_AmbientTemperatureIndicator), "Outdoors");
        

[JsonProperty("ambient_temperature_schedule_name")]
public string AmbientTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("tank_surface_area")]
public System.Nullable<float> TankSurfaceArea { get; set; } = null;
        

[JsonProperty("tank_u_value")]
public System.Nullable<float> TankUValue { get; set; } = null;
        

[JsonProperty("tank_outside_surface_material_name")]
public string TankOutsideSurfaceMaterialName { get; set; } = "";
    }
    
    public enum WaterUse_Storage_TypeOfSupplyControlledByFloatValve
    {
        
        [System.Runtime.Serialization.EnumMember(Value="GroundwaterWell")]
        GroundwaterWell = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Mains")]
        Mains = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherTank")]
        OtherTank = 3,
    }
    
    public enum WaterUse_Storage_WaterThermalMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ScheduledTemperature")]
        ScheduledTemperature = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalModel")]
        ThermalModel = 1,
    }
    
    public enum WaterUse_Storage_AmbientTemperatureIndicator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    [Description(@"Simulates on-site water supply from a well. Well water is pumped out of the ground into a WaterUse:Storage. The operation of the ground water well is controlled by the associated WaterUse:Storage which is assumed to be operated as a vented cistern with no pressure tank.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterUse_Well : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("storage_tank_name")]
public string StorageTankName { get; set; } = "";
        

[JsonProperty("pump_depth")]
public System.Nullable<float> PumpDepth { get; set; } = null;
        

[JsonProperty("pump_rated_flow_rate")]
public System.Nullable<float> PumpRatedFlowRate { get; set; } = null;
        

[JsonProperty("pump_rated_head")]
public System.Nullable<float> PumpRatedHead { get; set; } = null;
        

[JsonProperty("pump_rated_power_consumption")]
public System.Nullable<float> PumpRatedPowerConsumption { get; set; } = null;
        

[JsonProperty("pump_efficiency")]
public System.Nullable<float> PumpEfficiency { get; set; } = null;
        

[JsonProperty("well_recovery_rate")]
public System.Nullable<float> WellRecoveryRate { get; set; } = null;
        

[JsonProperty("nominal_well_storage_volume")]
public System.Nullable<float> NominalWellStorageVolume { get; set; } = null;
        

[JsonProperty("water_table_depth_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterUse_Well_WaterTableDepthMode WaterTableDepthMode { get; set; } = (WaterUse_Well_WaterTableDepthMode)Enum.Parse(typeof(WaterUse_Well_WaterTableDepthMode), "Constant");
        

[JsonProperty("water_table_depth")]
public System.Nullable<float> WaterTableDepth { get; set; } = null;
        

[JsonProperty("water_table_depth_schedule_name")]
public string WaterTableDepthScheduleName { get; set; } = "";
    }
    
    public enum WaterUse_Well_WaterTableDepthMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 1,
    }
    
    [Description("Used for harvesting rainwater falling on building surfaces. The rainwater is sent" +
        " to a WaterUse:Storage object. In order to use this object it is necessary to al" +
        "so include a Site:Precipitation object to describe the rates of rainfall.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterUse_RainCollector : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("storage_tank_name")]
public string StorageTankName { get; set; } = "";
        

[JsonProperty("loss_factor_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterUse_RainCollector_LossFactorMode LossFactorMode { get; set; } = (WaterUse_RainCollector_LossFactorMode)Enum.Parse(typeof(WaterUse_RainCollector_LossFactorMode), "Constant");
        

[Description("this is the portion of rain that is lost in the process of collecting it the rain" +
    " collected is one minus this factor")]
[JsonProperty("collection_loss_factor")]
public System.Nullable<float> CollectionLossFactor { get; set; } = null;
        

[JsonProperty("collection_loss_factor_schedule_name")]
public string CollectionLossFactorScheduleName { get; set; } = "";
        

[Description("Defaults to unlimited flow.")]
[JsonProperty("maximum_collection_rate")]
public System.Nullable<float> MaximumCollectionRate { get; set; } = null;
        

[JsonProperty("surfaces")]
public string Surfaces { get; set; } = "";
    }
    
    public enum WaterUse_RainCollector_LossFactorMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 1,
    }
}
