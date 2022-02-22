namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
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
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description(@"Ideal system used to calculate loads without modeling a full HVAC system. All that is required for the ideal system are zone controls, zone equipment configurations, and the ideal loads system component. This component can be thought of as an ideal unit that mixes zone air with the specified amount of outdoor air and then adds or removes heat and moisture at 100% efficiency in order to meet the specified controls. Energy use is reported as DistrictHeating and DistrictCooling.")]
    [JsonObject("ZoneHVAC:IdealLoadsAirSystem")]
    public class ZoneHVAC_IdealLoadsAirSystem : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Must match a zone air inlet node name.")]
[JsonProperty("zone_supply_air_node_name")]
public string ZoneSupplyAirNodeName { get; set; } = "";
        

[Description("Should match a zone air exhaust node name. This field is optional, but is require" +
    "d if this this object is used with other forced air equipment.")]
[JsonProperty("zone_exhaust_air_node_name")]
public string ZoneExhaustAirNodeName { get; set; } = "";
        

[Description(@"This field is only required when the Ideal Loads Air System is connected to an AirloopHVAC:ZoneReturnPlenum, otherwise leave this field blank. When connected to a plenum the return plenum Outlet Node Name (or Induced Air Outlet Node Name when connecting multiple ideal loads air sytems) is entered here. The two ideal loads air system node name fields described above, the Zone Supply Air Node Name and the Zone Exhaust Air Node Name must also be entered. The Zone Supply Air Node Name must match a zone inlet air node name for the zone where this Ideal Loads Air System is connected. The Zone Exhaust Air Node Name must match an inlet air node name of an AirloopHVAC:ReturnAirPlenum object.")]
[JsonProperty("system_inlet_air_node_name")]
public string SystemInletAirNodeName { get; set; } = "";
        

[JsonProperty("maximum_heating_supply_air_temperature")]
public System.Nullable<float> MaximumHeatingSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_cooling_supply_air_temperature")]
public System.Nullable<float> MinimumCoolingSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_heating_supply_air_humidity_ratio")]
public System.Nullable<float> MaximumHeatingSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.0156", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_cooling_supply_air_humidity_ratio")]
public System.Nullable<float> MinimumCoolingSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.0077", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_limit")]
public ZoneHVAC_IdealLoadsAirSystem_HeatingLimit HeatingLimit { get; set; } = (ZoneHVAC_IdealLoadsAirSystem_HeatingLimit)Enum.Parse(typeof(ZoneHVAC_IdealLoadsAirSystem_HeatingLimit), "NoLimit");
        

[Description("This field is ignored if Heating Limit = NoLimit If this field is blank, there is" +
    " no limit.")]
[JsonProperty("maximum_heating_air_flow_rate")]
public string MaximumHeatingAirFlowRate { get; set; } = "";
        

[Description("This field is ignored if Heating Limit = NoLimit If this field is blank, there is" +
    " no limit.")]
[JsonProperty("maximum_sensible_heating_capacity")]
public string MaximumSensibleHeatingCapacity { get; set; } = "";
        

[JsonProperty("cooling_limit")]
public ZoneHVAC_IdealLoadsAirSystem_CoolingLimit CoolingLimit { get; set; } = (ZoneHVAC_IdealLoadsAirSystem_CoolingLimit)Enum.Parse(typeof(ZoneHVAC_IdealLoadsAirSystem_CoolingLimit), "NoLimit");
        

[Description("This field is ignored if Cooling Limit = NoLimit This field is required if Outdoo" +
    "r Air Economizer Type is anything other than NoEconomizer.")]
[JsonProperty("maximum_cooling_air_flow_rate")]
public string MaximumCoolingAirFlowRate { get; set; } = "";
        

[Description("This field is ignored if Cooling Limit = NoLimit")]
[JsonProperty("maximum_total_cooling_capacity")]
public string MaximumTotalCoolingCapacity { get; set; } = "";
        

[Description("If blank, heating is always available.")]
[JsonProperty("heating_availability_schedule_name")]
public string HeatingAvailabilityScheduleName { get; set; } = "";
        

[Description("If blank, cooling is always available.")]
[JsonProperty("cooling_availability_schedule_name")]
public string CoolingAvailabilityScheduleName { get; set; } = "";
        

[Description(@"ConstantSensibleHeatRatio means that the ideal loads system will be controlled to meet the sensible cooling load, and the latent cooling rate will be computed using a constant sensible heat ratio (SHR) Humidistat means that there is a ZoneControl:Humidistat for this zone and the ideal loads system will attempt to satisfy the humidistat. None means that there is no dehumidification. ConstantSupplyHumidityRatio means that during cooling the supply air will always be at the Minimum Cooling Supply Humidity Ratio.")]
[JsonProperty("dehumidification_control_type")]
public ZoneHVAC_IdealLoadsAirSystem_DehumidificationControlType DehumidificationControlType { get; set; } = (ZoneHVAC_IdealLoadsAirSystem_DehumidificationControlType)Enum.Parse(typeof(ZoneHVAC_IdealLoadsAirSystem_DehumidificationControlType), "ConstantSensibleHeatRatio");
        

[Description("This field is applicable only when Dehumidification Control Type is ConstantSensi" +
    "bleHeatRatio")]
[JsonProperty("cooling_sensible_heat_ratio")]
public System.Nullable<float> CoolingSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description(@"None means that there is no humidification. Humidistat means that there is a ZoneControl:Humidistat for this zone and the ideal loads system will attempt to satisfy the humidistat. ConstantSupplyHumidityRatio means that during heating the supply air will always be at the Maximum Heating Supply Humidity Ratio.")]
[JsonProperty("humidification_control_type")]
public ZoneHVAC_IdealLoadsAirSystem_HumidificationControlType HumidificationControlType { get; set; } = (ZoneHVAC_IdealLoadsAirSystem_HumidificationControlType)Enum.Parse(typeof(ZoneHVAC_IdealLoadsAirSystem_HumidificationControlType), "None");
        

[Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the minimum outdoor air flow rate will be computed using these specifications. The outdoor air flow rate will also be affected by the next two fields. If this field is blank, there will be no outdoor air and the remaining fields will be ignored.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("This field is required if the system provides outdoor air Enter the name of an ou" +
    "tdoor air node. This node name is also specified in an OutdoorAir:Node or Outdoo" +
    "rAir:NodeList object.")]
[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
        

[Description(@"This field controls how the minimum outdoor air flow rate is calculated. None means that design occupancy will be used to compute the minimum outdoor air flow rate OccupancySchedule means that current occupancy level will be used. CO2Setpoint means that the design occupancy will be used to compute the minimum outdoor air flow rate and the outdoor air flow rate may be increased if necessary to maintain the indoor air carbon dioxide setpoint defined in a ZoneControl:ContaminantController object.")]
[JsonProperty("demand_controlled_ventilation_type")]
public ZoneHVAC_IdealLoadsAirSystem_DemandControlledVentilationType DemandControlledVentilationType { get; set; } = (ZoneHVAC_IdealLoadsAirSystem_DemandControlledVentilationType)Enum.Parse(typeof(ZoneHVAC_IdealLoadsAirSystem_DemandControlledVentilationType), "None");
        

[Description("DifferentialDryBulb and DifferentialEnthalpy will increase the outdoor air flow r" +
    "ate when there is a cooling load and the outdoor air temperature or enthalpy is " +
    "below the zone exhaust air temperature or enthalpy.")]
[JsonProperty("outdoor_air_economizer_type")]
public ZoneHVAC_IdealLoadsAirSystem_OutdoorAirEconomizerType OutdoorAirEconomizerType { get; set; } = (ZoneHVAC_IdealLoadsAirSystem_OutdoorAirEconomizerType)Enum.Parse(typeof(ZoneHVAC_IdealLoadsAirSystem_OutdoorAirEconomizerType), "NoEconomizer");
        

[JsonProperty("heat_recovery_type")]
public ZoneHVAC_IdealLoadsAirSystem_HeatRecoveryType HeatRecoveryType { get; set; } = (ZoneHVAC_IdealLoadsAirSystem_HeatRecoveryType)Enum.Parse(typeof(ZoneHVAC_IdealLoadsAirSystem_HeatRecoveryType), "None");
        

[JsonProperty("sensible_heat_recovery_effectiveness")]
public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Heat Recovery Type is Enthalpy.")]
[JsonProperty("latent_heat_recovery_effectiveness")]
public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
[JsonProperty("design_specification_zonehvac_sizing_object_name")]
public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}
