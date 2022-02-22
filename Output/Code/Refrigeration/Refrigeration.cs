namespace BH.oM.Adapters.EnergyPlus.Refrigeration
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
    
    
    [Description(@"The Refrigeration Case object works in conjunction with a compressor rack, a refrigeration system, or a secondary loop to simulate the performance of a refrigerated case system. The object calculates the energy use for lights, fans and anti-sweat heaters and accounts for the sensible and latent heat exchange with the surrounding environment (termed ""case credits"") which impacts the temperature and humidity in the zone where the case is located.")]
    [JsonObject("Refrigeration:Case")]
    public class Refrigeration_Case : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections obje" +
    "ct.")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("rated_ambient_temperature")]
public System.Nullable<float> RatedAmbientTemperature { get; set; } = (System.Nullable<float>)Single.Parse("23.9", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_ambient_relative_humidity")]
public System.Nullable<float> RatedAmbientRelativeHumidity { get; set; } = (System.Nullable<float>)Single.Parse("55", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_total_cooling_capacity_per_unit_length")]
public System.Nullable<float> RatedTotalCoolingCapacityPerUnitLength { get; set; } = (System.Nullable<float>)Single.Parse("1900", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_latent_heat_ratio")]
public System.Nullable<float> RatedLatentHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_runtime_fraction")]
public System.Nullable<float> RatedRuntimeFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("case_length")]
public System.Nullable<float> CaseLength { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty("case_operating_temperature")]
public System.Nullable<float> CaseOperatingTemperature { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

[JsonProperty("latent_case_credit_curve_type")]
public Refrigeration_Case_LatentCaseCreditCurveType LatentCaseCreditCurveType { get; set; } = (Refrigeration_Case_LatentCaseCreditCurveType)Enum.Parse(typeof(Refrigeration_Case_LatentCaseCreditCurveType), "CaseTemperatureMethod");
        

[JsonProperty("latent_case_credit_curve_name")]
public string LatentCaseCreditCurveName { get; set; } = "";
        

[JsonProperty("standard_case_fan_power_per_unit_length")]
public System.Nullable<float> StandardCaseFanPowerPerUnitLength { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

[JsonProperty("operating_case_fan_power_per_unit_length")]
public System.Nullable<float> OperatingCaseFanPowerPerUnitLength { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

[JsonProperty("standard_case_lighting_power_per_unit_length")]
public System.Nullable<float> StandardCaseLightingPowerPerUnitLength { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[Description("default set equal to Standard Case Lighting Power per Unit Length")]
[JsonProperty("installed_case_lighting_power_per_unit_length")]
public System.Nullable<float> InstalledCaseLightingPowerPerUnitLength { get; set; } = null;
        

[JsonProperty("case_lighting_schedule_name")]
public string CaseLightingScheduleName { get; set; } = "";
        

[JsonProperty("fraction_of_lighting_energy_to_case")]
public System.Nullable<float> FractionOfLightingEnergyToCase { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("case_anti_sweat_heater_power_per_unit_length")]
public System.Nullable<float> CaseAntiSweatHeaterPowerPerUnitLength { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field is only applicable to the Linear, Dewpoint Method, and Heat Balance Me" +
    "thod anti-sweat heater control types")]
[JsonProperty("minimum_anti_sweat_heater_power_per_unit_length")]
public System.Nullable<float> MinimumAntiSweatHeaterPowerPerUnitLength { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("anti_sweat_heater_control_type")]
public Refrigeration_Case_AntiSweatHeaterControlType AntiSweatHeaterControlType { get; set; } = (Refrigeration_Case_AntiSweatHeaterControlType)Enum.Parse(typeof(Refrigeration_Case_AntiSweatHeaterControlType), "None");
        

[Description("This field is only applicable to Linear AS heater control type Zone relative humi" +
    "dity (%) where anti-sweat heater energy is zero")]
[JsonProperty("humidity_at_zero_anti_sweat_heater_energy")]
public System.Nullable<float> HumidityAtZeroAntiSweatHeaterEnergy { get; set; } = (System.Nullable<float>)Single.Parse("-10", CultureInfo.InvariantCulture);
        

[Description("This field only applicable to Heat Balance Method AS heater control type Height m" +
    "ust be greater than zero if Heat Balance Method AS heater control is selected")]
[JsonProperty("case_height")]
public System.Nullable<float> CaseHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_of_anti_sweat_heater_energy_to_case")]
public System.Nullable<float> FractionOfAntiSweatHeaterEnergyToCase { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Used to evaluate load on case as well as power or heat consumption")]
[JsonProperty("case_defrost_power_per_unit_length")]
public System.Nullable<float> CaseDefrostPowerPerUnitLength { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("case_defrost_type")]
public Refrigeration_Case_CaseDefrostType CaseDefrostType { get; set; } = (Refrigeration_Case_CaseDefrostType)Enum.Parse(typeof(Refrigeration_Case_CaseDefrostType), "OffCycle");
        

[Description("A case defrost schedule name is required unless case defrost type = None")]
[JsonProperty("case_defrost_schedule_name")]
public string CaseDefrostScheduleName { get; set; } = "";
        

[Description(@"If left blank, the defrost schedule will be used The start time for each defrost period in this drip-down schedule should coincide with the start time for each defrost period in the case defrost schedule (previous input field). The length of each defrost drip-down period must be greater than or equal to the corresponding defrost period specified in the case defrost schedule. This extra time allows the melted frost to drip from the coil before refrigeration is restarted.")]
[JsonProperty("case_defrost_drip_down_schedule_name")]
public string CaseDefrostDripDownScheduleName { get; set; } = "";
        

[Description("Case Temperature, Relative Humidity, and Dewpoint Method are applicable to case d" +
    "efrost types with temperature termination only.")]
[JsonProperty("defrost_energy_correction_curve_type")]
public Refrigeration_Case_DefrostEnergyCorrectionCurveType DefrostEnergyCorrectionCurveType { get; set; } = (Refrigeration_Case_DefrostEnergyCorrectionCurveType)Enum.Parse(typeof(Refrigeration_Case_DefrostEnergyCorrectionCurveType), "None");
        

[Description("Defrost Energy Correction Curve Name is applicable to case defrost types with tem" +
    "perature termination only.")]
[JsonProperty("defrost_energy_correction_curve_name")]
public string DefrostEnergyCorrectionCurveName { get; set; } = "";
        

[JsonProperty("under_case_hvac_return_air_fraction")]
public System.Nullable<float> UnderCaseHvacReturnAirFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Schedule values should be in units of Watts per unit case length (W/m) Leave this" +
    " field blank if no restocking is to be modeled")]
[JsonProperty("refrigerated_case_restocking_schedule_name")]
public string RefrigeratedCaseRestockingScheduleName { get; set; } = "";
        

[Description("Schedule values should be from 0 to 1 Leave this field blank if no case credit fr" +
    "action is to be applied")]
[JsonProperty("case_credit_fraction_schedule_name")]
public string CaseCreditFractionScheduleName { get; set; } = "";
        

[Description(@"Required for detailed refrigeration system, not for compressor rack For a DX system, enter the saturated temperature for refrigerant pressure leaving case For a brine-cooled cooled (secondary system) case, enter the brine inlet temperature Default is 5 C less than case operating temperature")]
[JsonProperty("design_evaporator_temperature_or_brine_inlet_temperature")]
public System.Nullable<float> DesignEvaporatorTemperatureOrBrineInletTemperature { get; set; } = null;
        

[JsonProperty("average_refrigerant_charge_inventory")]
public System.Nullable<float> AverageRefrigerantChargeInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Name of the return air node for this case. If left blank, defaults to the first r" +
    "eturn air node for this zone.")]
[JsonProperty("under_case_hvac_return_air_node_name")]
public string UnderCaseHvacReturnAirNodeName { get; set; } = "";
    }
    
    public enum Refrigeration_Case_LatentCaseCreditCurveType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CaseTemperatureMethod")]
        CaseTemperatureMethod = 1,
        
        [JsonProperty("DewpointMethod")]
        DewpointMethod = 2,
        
        [JsonProperty("RelativeHumidityMethod")]
        RelativeHumidityMethod = 3,
    }
    
    public enum Refrigeration_Case_AntiSweatHeaterControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("DewpointMethod")]
        DewpointMethod = 2,
        
        [JsonProperty("HeatBalanceMethod")]
        HeatBalanceMethod = 3,
        
        [JsonProperty("Linear")]
        Linear = 4,
        
        [JsonProperty("None")]
        None = 5,
    }
    
    public enum Refrigeration_Case_CaseDefrostType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("ElectricWithTemperatureTermination")]
        ElectricWithTemperatureTermination = 2,
        
        [JsonProperty("HotFluid")]
        HotFluid = 3,
        
        [JsonProperty("HotFluidWithTemperatureTermination")]
        HotFluidWithTemperatureTermination = 4,
        
        [JsonProperty("HotGas")]
        HotGas = 5,
        
        [JsonProperty("HotGasWithTemperatureTermination")]
        HotGasWithTemperatureTermination = 6,
        
        [JsonProperty("None")]
        None = 7,
        
        [JsonProperty("OffCycle")]
        OffCycle = 8,
    }
    
    public enum Refrigeration_Case_DefrostEnergyCorrectionCurveType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CaseTemperatureMethod")]
        CaseTemperatureMethod = 1,
        
        [JsonProperty("DewpointMethod")]
        DewpointMethod = 2,
        
        [JsonProperty("None")]
        None = 3,
        
        [JsonProperty("RelativeHumidityMethod")]
        RelativeHumidityMethod = 4,
    }
    
    [Description(@"Works in conjunction with the refrigeration case and walk-in objects to simulate the performance of a refrigerated case system. This object models the electric consumption of the rack compressors and the condenser fans. Heat can be rejected either outdoors or to a zone. Compressor rack waste heat can also be reclaimed for use by an optional air- or water-heating coil (Coil:Heating:Desuperheater and Coil:WaterHeating:Desuperheater).")]
    [JsonObject("Refrigeration:CompressorRack")]
    public class Refrigeration_CompressorRack : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("heat_rejection_location")]
public Refrigeration_CompressorRack_HeatRejectionLocation HeatRejectionLocation { get; set; } = (Refrigeration_CompressorRack_HeatRejectionLocation)Enum.Parse(typeof(Refrigeration_CompressorRack_HeatRejectionLocation), "Outdoors");
        

[Description("It is important that this COP correspond to the lowest saturated suction temperat" +
    "ure needed to serve all refrigeration loads")]
[JsonProperty("design_compressor_rack_cop")]
public System.Nullable<float> DesignCompressorRackCop { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("It is important that this COP curve correspond to the lowest saturated suction te" +
    "mperature needed to serve all refrigeration loads")]
[JsonProperty("compressor_rack_cop_function_of_temperature_curve_name")]
public string CompressorRackCopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Design power for condenser fan(s).")]
[JsonProperty("design_condenser_fan_power")]
public System.Nullable<float> DesignCondenserFanPower { get; set; } = (System.Nullable<float>)Single.Parse("250", CultureInfo.InvariantCulture);
        

[JsonProperty("condenser_fan_power_function_of_temperature_curve_name")]
public string CondenserFanPowerFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Applicable only when Heat Rejection Location is Outdoors.")]
[JsonProperty("condenser_type")]
public Refrigeration_CompressorRack_CondenserType CondenserType { get; set; } = (Refrigeration_CompressorRack_CondenserType)Enum.Parse(typeof(Refrigeration_CompressorRack_CondenserType), "AirCooled");
        

[JsonProperty("water_cooled_condenser_inlet_node_name")]
public string WaterCooledCondenserInletNodeName { get; set; } = "";
        

[JsonProperty("water_cooled_condenser_outlet_node_name")]
public string WaterCooledCondenserOutletNodeName { get; set; } = "";
        

[Description("Applicable only when Condenser Type is WaterCooled.")]
[JsonProperty("water_cooled_loop_flow_type")]
public Refrigeration_CompressorRack_WaterCooledLoopFlowType WaterCooledLoopFlowType { get; set; } = (Refrigeration_CompressorRack_WaterCooledLoopFlowType)Enum.Parse(typeof(Refrigeration_CompressorRack_WaterCooledLoopFlowType), "VariableFlow");
        

[Description("Applicable only when loop Flow type is VariableFlow.")]
[JsonProperty("water_cooled_condenser_outlet_temperature_schedule_name")]
public string WaterCooledCondenserOutletTemperatureScheduleName { get; set; } = "";
        

[Description("Applicable only when loop flow type is ConstantFlow.")]
[JsonProperty("water_cooled_condenser_design_flow_rate")]
public System.Nullable<float> WaterCooledCondenserDesignFlowRate { get; set; } = null;
        

[JsonProperty("water_cooled_condenser_maximum_flow_rate")]
public System.Nullable<float> WaterCooledCondenserMaximumFlowRate { get; set; } = null;
        

[JsonProperty("water_cooled_condenser_maximum_water_outlet_temperature")]
public System.Nullable<float> WaterCooledCondenserMaximumWaterOutletTemperature { get; set; } = (System.Nullable<float>)Single.Parse("55", CultureInfo.InvariantCulture);
        

[JsonProperty("water_cooled_condenser_minimum_water_inlet_temperature")]
public System.Nullable<float> WaterCooledCondenserMinimumWaterInletTemperature { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 indicate that evaporative cooling of the condenser is available. This schedule allows the user to define seasonal shutdown/draining of the water cooling system in cold climate applications. For periods with schedule values of 0, the condenser operates as AirCooled.")]
[JsonProperty("evaporative_condenser_availability_schedule_name")]
public string EvaporativeCondenserAvailabilityScheduleName { get; set; } = "";
        

[Description("Applicable only for Condenser Type = EvaporativlyCooled.")]
[JsonProperty("evaporative_condenser_effectiveness")]
public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Applicable only for Condenser Type = EvaporativelyCooled. Used to calculate evapo" +
    "rative condenser water use.")]
[JsonProperty("evaporative_condenser_air_flow_rate")]
public string EvaporativeCondenserAirFlowRate { get; set; } = (System.String)"Autocalculate";
        

[Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the evaporatively cooled condenser is available (field Evaporative Condenser Availability Schedule Name). For this situation, the heater heats the basin water when the outdoor air dry-bulb temperature falls below the setpoint temperature, but only when the condenser fans are off (i.e., no refrigerated case load).")]
[JsonProperty("basin_heater_capacity")]
public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("200", CultureInfo.InvariantCulture);
        

[Description("Enter the outdoor dry-bulb temperature at which the basin heater turns on.")]
[JsonProperty("basin_heater_setpoint_temperature")]
public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("Design recirc water pump power for Condenser Type = EvaporativelyCooled. Applicab" +
    "le only for Condenser Type = EvaporativelyCooled.")]
[JsonProperty("design_evaporative_condenser_water_pump_power")]
public string DesignEvaporativeCondenserWaterPumpPower { get; set; } = (System.String)"1000";
        

[Description("If blank, water supply is from Mains. Applicable only for Condenser Type = Evapor" +
    "ativelyCooled.")]
[JsonProperty("evaporative_water_supply_tank_name")]
public string EvaporativeWaterSupplyTankName { get; set; } = "";
        

[Description(@"Applicable only when Heat Rejection Location is Outdoors and Condenser Type is not WaterCooled; otherwise, leave field blank. If field is left blank with Heat Rejection Location = Outdoors, then the model assumes that the Inlet Air conditions are the outdoor air conditions for the current timestep (e.g., no adjustment for height above ground).")]
[JsonProperty("condenser_air_inlet_node_name")]
public string CondenserAirInletNodeName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[Description("Enter the name of a Refrigeration:Case or Refrigeration:Walkin or Refrigeration:C" +
    "aseAndWalkinList object.")]
[JsonProperty("refrigeration_case_name_or_walkin_name_or_caseandwalkinlist_name")]
public string RefrigerationCaseNameOrWalkinNameOrCaseandwalkinlistName { get; set; } = "";
        

[Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections obje" +
    "ct. Required only if walk-in[s] are connected to this rack AND the heat rejectio" +
    "n location is \"Zone\"")]
[JsonProperty("heat_rejection_zone_name")]
public string HeatRejectionZoneName { get; set; } = "";
    }
    
    public enum Refrigeration_CompressorRack_HeatRejectionLocation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Outdoors")]
        Outdoors = 1,
        
        [JsonProperty("Zone")]
        Zone = 2,
    }
    
    public enum Refrigeration_CompressorRack_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
        
        [JsonProperty("WaterCooled")]
        WaterCooled = 3,
    }
    
    public enum Refrigeration_CompressorRack_WaterCooledLoopFlowType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantFlow")]
        ConstantFlow = 1,
        
        [JsonProperty("VariableFlow")]
        VariableFlow = 2,
    }
    
    [Description(@"Provides a list of all the refrigerated cases, walk in coolers, or air chillers cooled by a single refrigeration system. Note that the names of all cases, walk-ins ,air chillers, and CaseAndWalkInLists must be unique. That is, you cannot give a list the same name as one of list items. This list may contain a combination of case and walk-in names OR a list of air chiller names. Air chillers may not be included in any list that also includes cases or walk-ins.")]
    [JsonObject("Refrigeration:CaseAndWalkInList")]
    public class Refrigeration_CaseAndWalkInList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("cases_and_walkins")]
public string CasesAndWalkins { get; set; } = "";
    }
    
    [Description("Air cooled condenser for a refrigeration system (Refrigeration:System).")]
    [JsonObject("Refrigeration:Condenser:AirCooled")]
    public class Refrigeration_Condenser_AirCooled : BHoMObject, IEnergyPlusClass
    {
        

[Description("Rating as per ARI 460 Be sure the rating corresponds to the correct refrigerant H" +
    "eatRejection(W)=C1 +C2(Condensing Temp - Entering Air Temp, deg C) Will be adjus" +
    "ted for elevation automatically")]
[JsonProperty("rated_effective_total_heat_rejection_rate_curve_name")]
public string RatedEffectiveTotalHeatRejectionRateCurveName { get; set; } = "";
        

[Description("must correspond to rating given for total heat rejection effect")]
[JsonProperty("rated_subcooling_temperature_difference")]
public System.Nullable<float> RatedSubcoolingTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("condenser_fan_speed_control_type")]
public Refrigeration_Condenser_AirCooled_CondenserFanSpeedControlType CondenserFanSpeedControlType { get; set; } = (Refrigeration_Condenser_AirCooled_CondenserFanSpeedControlType)Enum.Parse(typeof(Refrigeration_Condenser_AirCooled_CondenserFanSpeedControlType), "Fixed");
        

[Description("Power for condenser fan(s) corresponding to rated total heat rejection effect.")]
[JsonProperty("rated_fan_power")]
public System.Nullable<float> RatedFanPower { get; set; } = (System.Nullable<float>)Single.Parse("250", CultureInfo.InvariantCulture);
        

[Description("Minimum air flow fraction through condenser fan")]
[JsonProperty("minimum_fan_air_flow_ratio")]
public System.Nullable<float> MinimumFanAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description(@"If field is left blank, then the model assumes that the inlet air conditions are the outdoor air conditions for the current timestep (e.g., no adjustment for height above ground). If the condenser rejects heat to a conditioned zone, enter the zone name here.")]
[JsonProperty("air_inlet_node_name_or_zone_name")]
public string AirInletNodeNameOrZoneName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[Description("optional input")]
[JsonProperty("condenser_refrigerant_operating_charge_inventory")]
public System.Nullable<float> CondenserRefrigerantOperatingChargeInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("optional input")]
[JsonProperty("condensate_receiver_refrigerant_inventory")]
public System.Nullable<float> CondensateReceiverRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("optional input")]
[JsonProperty("condensate_piping_refrigerant_inventory")]
public System.Nullable<float> CondensatePipingRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum Refrigeration_Condenser_AirCooled_CondenserFanSpeedControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Fixed")]
        Fixed = 1,
        
        [JsonProperty("FixedLinear")]
        FixedLinear = 2,
        
        [JsonProperty("TwoSpeed")]
        TwoSpeed = 3,
        
        [JsonProperty("VariableSpeed")]
        VariableSpeed = 4,
    }
    
    [Description("Evaporative-cooled condenser for a refrigeration system (Refrigeration:System).")]
    [JsonObject("Refrigeration:Condenser:EvaporativeCooled")]
    public class Refrigeration_Condenser_EvaporativeCooled : BHoMObject, IEnergyPlusClass
    {
        

[Description("Rating as per ARI 490 Be sure the rating corresponds to the correct refrigerant")]
[JsonProperty("rated_effective_total_heat_rejection_rate")]
public System.Nullable<float> RatedEffectiveTotalHeatRejectionRate { get; set; } = null;
        

[Description("must correspond to rating given for total heat rejection effect")]
[JsonProperty("rated_subcooling_temperature_difference")]
public System.Nullable<float> RatedSubcoolingTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fan_speed_control_type")]
public Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType FanSpeedControlType { get; set; } = (Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType)Enum.Parse(typeof(Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType), "Fixed");
        

[Description("Power for condenser fan(s) corresponding to rated total heat rejection effect.")]
[JsonProperty("rated_fan_power")]
public System.Nullable<float> RatedFanPower { get; set; } = null;
        

[Description("Minimum air flow fraction through condenser fan")]
[JsonProperty("minimum_fan_air_flow_ratio")]
public System.Nullable<float> MinimumFanAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("A1 in delta T = A1 + A2(hrcf) + A3/(hrcf) + A4(Twb)")]
[JsonProperty("approach_temperature_constant_term")]
public System.Nullable<float> ApproachTemperatureConstantTerm { get; set; } = (System.Nullable<float>)Single.Parse("6.63", CultureInfo.InvariantCulture);
        

[Description("A2 in delta T = A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
[JsonProperty("approach_temperature_coefficient_2")]
public System.Nullable<float> ApproachTemperatureCoefficient2 { get; set; } = (System.Nullable<float>)Single.Parse("0.468", CultureInfo.InvariantCulture);
        

[Description("A3 in delta T = A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
[JsonProperty("approach_temperature_coefficient_3")]
public System.Nullable<float> ApproachTemperatureCoefficient3 { get; set; } = (System.Nullable<float>)Single.Parse("17.93", CultureInfo.InvariantCulture);
        

[Description("A4 in deltaT=A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
[JsonProperty("approach_temperature_coefficient_4")]
public System.Nullable<float> ApproachTemperatureCoefficient4 { get; set; } = (System.Nullable<float>)Single.Parse("-0.322", CultureInfo.InvariantCulture);
        

[Description("taken from manufacturer\'s Heat Rejection Capacity Factor Table")]
[JsonProperty("minimum_capacity_factor")]
public System.Nullable<float> MinimumCapacityFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("taken from manufacturer\'s Heat Rejection Capacity Factor Table")]
[JsonProperty("maximum_capacity_factor")]
public System.Nullable<float> MaximumCapacityFactor { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("If field is left blank, then the model assumes that the inlet air conditions are " +
    "the outdoor air conditions for the current timestep (e.g., no adjustment for hei" +
    "ght above ground).")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[Description("Used to calculate evaporative condenser water use and fan energy use.")]
[JsonProperty("rated_air_flow_rate")]
public string RatedAirFlowRate { get; set; } = (System.String)"Autocalculate";
        

[Description(@"This field is only used for periods when the evap condenser is available (field Evaporative Condenser Availability Schedule). For this situation, the heater heats the basin water when the outdoor air dry-bulb temperature falls below the set point temperature, but only when the condenser fans are off (i.e., no refrigerated case load).")]
[JsonProperty("basin_heater_capacity")]
public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("200", CultureInfo.InvariantCulture);
        

[Description("Enter the outdoor dry-bulb temperature at which the basin heater turns on.")]
[JsonProperty("basin_heater_setpoint_temperature")]
public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("Design recirculating water pump power.")]
[JsonProperty("rated_water_pump_power")]
public string RatedWaterPumpPower { get; set; } = (System.String)"1000";
        

[Description("If blank, water supply is from Mains.")]
[JsonProperty("evaporative_water_supply_tank_name")]
public string EvaporativeWaterSupplyTankName { get; set; } = "";
        

[Description(@"Schedule values greater than 0 indicate that evaporative cooling of the condenser is available. This schedule allows the user to define seasonal shutdown/draining of the water cooling system in cold climate applications. For periods with schedule values of 0, the condenser operates as Air Cooled.")]
[JsonProperty("evaporative_condenser_availability_schedule_name")]
public string EvaporativeCondenserAvailabilityScheduleName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[Description("optional input")]
[JsonProperty("condenser_refrigerant_operating_charge_inventory")]
public System.Nullable<float> CondenserRefrigerantOperatingChargeInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("optional input")]
[JsonProperty("condensate_receiver_refrigerant_inventory")]
public System.Nullable<float> CondensateReceiverRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("optional input")]
[JsonProperty("condensate_piping_refrigerant_inventory")]
public System.Nullable<float> CondensatePipingRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Fixed")]
        Fixed = 1,
        
        [JsonProperty("FixedLinear")]
        FixedLinear = 2,
        
        [JsonProperty("TwoSpeed")]
        TwoSpeed = 3,
        
        [JsonProperty("VariableSpeed")]
        VariableSpeed = 4,
    }
    
    [Description("Water cooled condenser for a refrigeration system (Refrigeration:System).")]
    [JsonObject("Refrigeration:Condenser:WaterCooled")]
    public class Refrigeration_Condenser_WaterCooled : BHoMObject, IEnergyPlusClass
    {
        

[Description("Rating as per ARI 450 Be sure the rating corresponds to the correct refrigerant n" +
    "ot used in calculations, only for identification and output")]
[JsonProperty("rated_effective_total_heat_rejection_rate")]
public System.Nullable<float> RatedEffectiveTotalHeatRejectionRate { get; set; } = null;
        

[Description("must correspond to rating given for total heat rejection effect")]
[JsonProperty("rated_condensing_temperature")]
public System.Nullable<float> RatedCondensingTemperature { get; set; } = null;
        

[Description("must correspond to rating given for total heat rejection effect")]
[JsonProperty("rated_subcooling_temperature_difference")]
public System.Nullable<float> RatedSubcoolingTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("must correspond to rating given for total heat rejection effect")]
[JsonProperty("rated_water_inlet_temperature")]
public System.Nullable<float> RatedWaterInletTemperature { get; set; } = null;
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("water_cooled_loop_flow_type")]
public Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType WaterCooledLoopFlowType { get; set; } = (Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType)Enum.Parse(typeof(Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType), "VariableFlow");
        

[Description("Applicable only when loop flow type is Variable Flow.")]
[JsonProperty("water_outlet_temperature_schedule_name")]
public string WaterOutletTemperatureScheduleName { get; set; } = "";
        

[Description("note required units must be converted from L/s as specified in ARI 450-2007 Appli" +
    "cable only when loop flow type is Constant Flow.")]
[JsonProperty("water_design_flow_rate")]
public System.Nullable<float> WaterDesignFlowRate { get; set; } = null;
        

[JsonProperty("water_maximum_flow_rate")]
public System.Nullable<float> WaterMaximumFlowRate { get; set; } = null;
        

[JsonProperty("water_maximum_water_outlet_temperature")]
public System.Nullable<float> WaterMaximumWaterOutletTemperature { get; set; } = (System.Nullable<float>)Single.Parse("55", CultureInfo.InvariantCulture);
        

[Description("related to the minimum allowed refrigeration system condensing temperature")]
[JsonProperty("water_minimum_water_inlet_temperature")]
public System.Nullable<float> WaterMinimumWaterInletTemperature { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[Description("optional input")]
[JsonProperty("condenser_refrigerant_operating_charge_inventory")]
public System.Nullable<float> CondenserRefrigerantOperatingChargeInventory { get; set; } = null;
        

[Description("optional input")]
[JsonProperty("condensate_receiver_refrigerant_inventory")]
public System.Nullable<float> CondensateReceiverRefrigerantInventory { get; set; } = null;
        

[Description("optional input")]
[JsonProperty("condensate_piping_refrigerant_inventory")]
public System.Nullable<float> CondensatePipingRefrigerantInventory { get; set; } = null;
    }
    
    public enum Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantFlow")]
        ConstantFlow = 1,
        
        [JsonProperty("VariableFlow")]
        VariableFlow = 2,
    }
    
    [Description(@"Cascade condenser for a refrigeration system (Refrigeration:System). The cascade condenser is unlike the other condenser options because it rejects heat to another, higher-temperature, refrigeration system. That is, the cascade condenser acts as a heat rejection object for one system, but acts as a refrigeration load for another system.")]
    [JsonObject("Refrigeration:Condenser:Cascade")]
    public class Refrigeration_Condenser_Cascade : BHoMObject, IEnergyPlusClass
    {
        

[Description("This is the condensing temperature for the lower temperature secondary loop")]
[JsonProperty("rated_condensing_temperature")]
public System.Nullable<float> RatedCondensingTemperature { get; set; } = null;
        

[Description("This is the difference between the condensing and evaporating temperatures")]
[JsonProperty("rated_approach_temperature_difference")]
public System.Nullable<float> RatedApproachTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("used for identification and rough system size error checking")]
[JsonProperty("rated_effective_total_heat_rejection_rate")]
public System.Nullable<float> RatedEffectiveTotalHeatRejectionRate { get; set; } = null;
        

[Description("Fixed keeps condensing temperature constant Float sets the condensing temperature" +
    " according to the other loads on the higher temperature system")]
[JsonProperty("condensing_temperature_control_type")]
public Refrigeration_Condenser_Cascade_CondensingTemperatureControlType CondensingTemperatureControlType { get; set; } = (Refrigeration_Condenser_Cascade_CondensingTemperatureControlType)Enum.Parse(typeof(Refrigeration_Condenser_Cascade_CondensingTemperatureControlType), "Fixed");
        

[Description("optional input")]
[JsonProperty("condenser_refrigerant_operating_charge_inventory")]
public System.Nullable<float> CondenserRefrigerantOperatingChargeInventory { get; set; } = null;
        

[Description("optional input")]
[JsonProperty("condensate_receiver_refrigerant_inventory")]
public System.Nullable<float> CondensateReceiverRefrigerantInventory { get; set; } = null;
        

[Description("optional input")]
[JsonProperty("condensate_piping_refrigerant_inventory")]
public System.Nullable<float> CondensatePipingRefrigerantInventory { get; set; } = null;
    }
    
    public enum Refrigeration_Condenser_Cascade_CondensingTemperatureControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Fixed")]
        Fixed = 1,
        
        [JsonProperty("Float")]
        Float = 2,
    }
    
    [Description("The transcritical refrigeration system requires a single gas cooler to reject the" +
        " system heat.")]
    [JsonObject("Refrigeration:GasCooler:AirCooled")]
    public class Refrigeration_GasCooler_AirCooled : BHoMObject, IEnergyPlusClass
    {
        

[Description("Be sure the rating corresponds to the correct refrigerant (R744) HeatRejection(W)" +
    "=C1 +C2(Gas Cooler Outlet Temp - Entering Air Temp, deg C) Will be adjusted for " +
    "elevation automatically")]
[JsonProperty("rated_total_heat_rejection_rate_curve_name")]
public string RatedTotalHeatRejectionRateCurveName { get; set; } = "";
        

[JsonProperty("gas_cooler_fan_speed_control_type")]
public Refrigeration_GasCooler_AirCooled_GasCoolerFanSpeedControlType GasCoolerFanSpeedControlType { get; set; } = (Refrigeration_GasCooler_AirCooled_GasCoolerFanSpeedControlType)Enum.Parse(typeof(Refrigeration_GasCooler_AirCooled_GasCoolerFanSpeedControlType), "Fixed");
        

[Description("Power for gas cooler fan(s) corresponding to rated total heat rejection effect.")]
[JsonProperty("rated_fan_power")]
public System.Nullable<float> RatedFanPower { get; set; } = (System.Nullable<float>)Single.Parse("5000", CultureInfo.InvariantCulture);
        

[Description("Minimum air flow fraction through gas cooler fan")]
[JsonProperty("minimum_fan_air_flow_ratio")]
public System.Nullable<float> MinimumFanAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Temperature at which system transitions between subcritical and transcritical ope" +
    "ration.")]
[JsonProperty("transition_temperature")]
public System.Nullable<float> TransitionTemperature { get; set; } = (System.Nullable<float>)Single.Parse("27", CultureInfo.InvariantCulture);
        

[Description("Temperature difference between the CO2 exiting the gas cooler and the air enterin" +
    "g the gas cooler during transcritical operation.")]
[JsonProperty("transcritical_approach_temperature")]
public System.Nullable<float> TranscriticalApproachTemperature { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Temperature difference between the saturated condensing temperature and the air t" +
    "emperature during subcritical operation.")]
[JsonProperty("subcritical_temperature_difference")]
public System.Nullable<float> SubcriticalTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Minimum saturated condensing temperature during subcritical operation.")]
[JsonProperty("minimum_condensing_temperature")]
public System.Nullable<float> MinimumCondensingTemperature { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("If field is left blank, then the model assumes that the inlet air conditions are " +
    "the outdoor air conditions for the current timestep (e.g., no adjustment for hei" +
    "ght above ground).")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[Description("optional input")]
[JsonProperty("gas_cooler_refrigerant_operating_charge_inventory")]
public System.Nullable<float> GasCoolerRefrigerantOperatingChargeInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("optional input")]
[JsonProperty("gas_cooler_receiver_refrigerant_inventory")]
public System.Nullable<float> GasCoolerReceiverRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("optional input")]
[JsonProperty("gas_cooler_outlet_piping_refrigerant_inventory")]
public System.Nullable<float> GasCoolerOutletPipingRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum Refrigeration_GasCooler_AirCooled_GasCoolerFanSpeedControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Fixed")]
        Fixed = 1,
        
        [JsonProperty("FixedLinear")]
        FixedLinear = 2,
        
        [JsonProperty("TwoSpeed")]
        TwoSpeed = 3,
        
        [JsonProperty("VariableSpeed")]
        VariableSpeed = 4,
    }
    
    [Description(@"A refrigeration system may provide cooling to other, secondary, systems through either a secondary loop or a cascade condenser. If multiple transfer loads are served by a single primary system, use this list to group them together for reference by the primary system (see the field ""Refrigeration Transfer Load or TransferLoad List Name"" in the Refrigeration:System object).")]
    [JsonObject("Refrigeration:TransferLoadList")]
    public class Refrigeration_TransferLoadList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("transfer_loads")]
public string TransferLoads { get; set; } = "";
    }
    
    [Description(@"Two types of subcoolers are modeled by the detailed refrigeration system. The liquid suction heat exchanger uses cool suction gas to subcool the hot condensate after it leaves the condenser and before it reaches the thermal expansion valve. A mechanical subcooler is used to transfer cooling capacity from one refrigeration system to another.")]
    [JsonObject("Refrigeration:Subcooler")]
    public class Refrigeration_Subcooler : BHoMObject, IEnergyPlusClass
    {
        

[Description("plan to add ambient subcoolers at future time")]
[JsonProperty("subcooler_type")]
public Refrigeration_Subcooler_SubcoolerType SubcoolerType { get; set; } = (Refrigeration_Subcooler_SubcoolerType)Enum.Parse(typeof(Refrigeration_Subcooler_SubcoolerType), "LiquidSuction");
        

[Description("Applicable only and required for liquid suction heat exchangers design liquid suc" +
    "tion subcooling")]
[JsonProperty("liquid_suction_design_subcooling_temperature_difference")]
public System.Nullable<float> LiquidSuctionDesignSubcoolingTemperatureDifference { get; set; } = null;
        

[Description("design inlet temperature on liquid side Applicable only and required for liquid s" +
    "uction heat exchangers (LSHX)")]
[JsonProperty("design_liquid_inlet_temperature")]
public System.Nullable<float> DesignLiquidInletTemperature { get; set; } = null;
        

[Description("design inlet temperature on vapor side Applicable only and required for liquid su" +
    "ction heat exchangers (LSHX) Design vapor inlet temperature must be less than or" +
    " equal to the Liquid inlet design temp")]
[JsonProperty("design_vapor_inlet_temperature")]
public System.Nullable<float> DesignVaporInletTemperature { get; set; } = null;
        

[Description("Name of the Detailed Refrigeration System providing cooling capacity Applicable o" +
    "nly and required for mechanical subcoolers")]
[JsonProperty("capacity_providing_system")]
public string CapacityProvidingSystem { get; set; } = "";
        

[Description("Control Temperature Out for subcooled liquid Applicable only and required for mec" +
    "hanical subcoolers")]
[JsonProperty("outlet_control_temperature")]
public System.Nullable<float> OutletControlTemperature { get; set; } = null;
    }
    
    public enum Refrigeration_Subcooler_SubcoolerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LiquidSuction")]
        LiquidSuction = 1,
        
        [JsonProperty("Mechanical")]
        Mechanical = 2,
    }
    
    [Description("Refrigeration system compressor. Data is available for many compressors in the Re" +
        "frigerationCompressor.idf dataset")]
    [JsonObject("Refrigeration:Compressor")]
    public class Refrigeration_Compressor : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"the input order for the Curve:Bicubic does not match the ARI 540-2004 Eq. 1 coefficient order N1 is ARI_C1, N2 is ARI_C2, N3 is ARI_C4, N4 is ARI_C3, N5 is ARI_C6, N6 is ARI_C5, N7 is ARI_C7, N8 is ARI_C10, N9 is ARI_C8, N10 is ARI_C9, N11 is Minimum Suction dewpoint temperature, N12 is Maximum Suction dewpoint temperature, N13 is Minimum Discharge dewpoint temperature, N14 is Maximum Discharge dewpoint temperature")]
[JsonProperty("refrigeration_compressor_power_curve_name")]
public string RefrigerationCompressorPowerCurveName { get; set; } = "";
        

[Description(@"the input order for the Curve:Bicubic does not match the ARI 540-2004 Eq. 1 coefficient order N1 is ARI_C1, N2 is ARI_C2, N3 is ARI_C4, N4 is ARI_C3, N5 is ARI_C6, N6 is ARI_C5, N7 is ARI_C7, N8 is ARI_C10, N9 is ARI_C8, N10 is ARI_C9, N11 is Minimum Suction dewpoint temperature, N12 is Maximum Suction dewpoint temperature, N13 is Minimum Discharge dewpoint temperature, N14 is Maximum Discharge dewpoint temperature")]
[JsonProperty("refrigeration_compressor_capacity_curve_name")]
public string RefrigerationCompressorCapacityCurveName { get; set; } = "";
        

[Description("Use this input field OR the next, not both This is used if the compressor rating " +
    "is based upon degrees of superheat")]
[JsonProperty("rated_superheat")]
public System.Nullable<float> RatedSuperheat { get; set; } = null;
        

[Description("Use this input field OR the previous, not both This is used if the compressor rat" +
    "ing is based upon rated return gas temperature (Rated Suction Temperature)")]
[JsonProperty("rated_return_gas_temperature")]
public System.Nullable<float> RatedReturnGasTemperature { get; set; } = null;
        

[Description("Use this input field OR the next, not both This is used if the compressor rating " +
    "is based upon rated liquid temperature at the expansion valve")]
[JsonProperty("rated_liquid_temperature")]
public System.Nullable<float> RatedLiquidTemperature { get; set; } = null;
        

[Description("Use this input field OR the previous, not both This is used if the compressor rat" +
    "ing is based upon degrees of subcooling")]
[JsonProperty("rated_subcooling")]
public System.Nullable<float> RatedSubcooling { get; set; } = null;
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[JsonProperty("mode_of_operation")]
public Refrigeration_Compressor_ModeOfOperation ModeOfOperation { get; set; } = (Refrigeration_Compressor_ModeOfOperation)Enum.Parse(typeof(Refrigeration_Compressor_ModeOfOperation), "Subcritical");
        

[JsonProperty("transcritical_compressor_power_curve_name")]
public string TranscriticalCompressorPowerCurveName { get; set; } = "";
        

[JsonProperty("transcritical_compressor_capacity_curve_name")]
public string TranscriticalCompressorCapacityCurveName { get; set; } = "";
    }
    
    public enum Refrigeration_Compressor_ModeOfOperation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Subcritical")]
        Subcritical = 1,
        
        [JsonProperty("Transcritical")]
        Transcritical = 2,
    }
    
    [Description(@"List of all the compressors included within a single refrigeration system (Refrigeration:System). Each list must contain at least one compressor. The order in which the individual compressors are listed here will be the order in which the compressors are dispatched to meet the system load. IMPORTANT: List compressor names in the order in which the compressors will be loaded Data is available for many compressors in the RefrigerationCompressor.idf dataset")]
    [JsonObject("Refrigeration:CompressorList")]
    public class Refrigeration_CompressorList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("compressors")]
public string Compressors { get; set; } = "";
    }
    
    [Description("Simulates the performance of a supermarket refrigeration system when used along w" +
        "ith other objects to define the refrigeration load(s), the compressor(s), and th" +
        "e condenser.")]
    [JsonObject("Refrigeration:System")]
    public class Refrigeration_System : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there is more than one refrigerated case or walk-in served by this system, enter the name of a Refrigeration:CaseAndWalkInList object. Only cases and walkins served directly by the system should be included in this list. Any cases served indirectly via a secondary chiller should NOT be included in this list")]
[JsonProperty("refrigerated_case_or_walkin_or_caseandwalkinlist_name")]
public string RefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

[Description(@"Enter the name of a Refrigeration:SecondarySystem object OR a Refrigeration:Condenser:Cascade object OR, a Refrigeration:TransferLoadList object. A transfer load is identified as one which moves the load from one system to another. So if you have more than one such load (including cascade condensers and secondary loops) served by the same system, use a TransferLoadList object.")]
[JsonProperty("refrigeration_transfer_load_or_transferload_list_name")]
public string RefrigerationTransferLoadOrTransferloadListName { get; set; } = "";
        

[JsonProperty("refrigeration_condenser_name")]
public string RefrigerationCondenserName { get; set; } = "";
        

[JsonProperty("compressor_or_compressorlist_name")]
public string CompressorOrCompressorlistName { get; set; } = "";
        

[Description("related to the proper operation of the thermal expansion valves and compressors")]
[JsonProperty("minimum_condensing_temperature")]
public System.Nullable<float> MinimumCondensingTemperature { get; set; } = null;
        

[Description(@"Fluid property data for the refrigerant must be entered. The fluid property data, including the objects: FluidProperties:Name, FluidProperties:Temperatures, FluidProperties:Saturated and FluidProperties:Superheated can be copied from the FluidPropertiesRefData.idf dataset")]
[JsonProperty("refrigeration_system_working_fluid_type")]
public string RefrigerationSystemWorkingFluidType { get; set; } = "";
        

[JsonProperty("suction_temperature_control_type")]
public Refrigeration_System_SuctionTemperatureControlType SuctionTemperatureControlType { get; set; } = (Refrigeration_System_SuctionTemperatureControlType)Enum.Parse(typeof(Refrigeration_System_SuctionTemperatureControlType), "ConstantSuctionTemperature");
        

[Description("Optional Field Recipient of refrigeration capacity, that is receives cool liquid " +
    "from another refrigeration system to help meet aggregate case loads")]
[JsonProperty("mechanical_subcooler_name")]
public string MechanicalSubcoolerName { get; set; } = "";
        

[Description("Optional Field Liquid Suction Heat Exchanger Name, or leave blank")]
[JsonProperty("liquid_suction_heat_exchanger_subcooler_name")]
public string LiquidSuctionHeatExchangerSubcoolerName { get; set; } = "";
        

[Description("Use only if you want to include suction piping heat gain in refrigeration load")]
[JsonProperty("sum_ua_suction_piping")]
public System.Nullable<float> SumUaSuctionPiping { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This will be used to determine the temperature used for distribution piping heat " +
    "gain and the pipe heat gains  as cooling credit for the zone. Required only if S" +
    "um UA Distribution Piping >0.0")]
[JsonProperty("suction_piping_zone_name")]
public string SuctionPipingZoneName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[JsonProperty("number_of_compressor_stages")]
public string NumberOfCompressorStages { get; set; } = (System.String)"1";
        

[JsonProperty("intercooler_type")]
public Refrigeration_System_IntercoolerType IntercoolerType { get; set; } = (Refrigeration_System_IntercoolerType)Enum.Parse(typeof(Refrigeration_System_IntercoolerType), "None");
        

[JsonProperty("shell_and_coil_intercooler_effectiveness")]
public System.Nullable<float> ShellAndCoilIntercoolerEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("high_stage_compressor_or_compressorlist_name")]
public string HighStageCompressorOrCompressorlistName { get; set; } = "";
    }
    
    public enum Refrigeration_System_SuctionTemperatureControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantSuctionTemperature")]
        ConstantSuctionTemperature = 1,
        
        [JsonProperty("FloatSuctionTemperature")]
        FloatSuctionTemperature = 2,
    }
    
    public enum Refrigeration_System_IntercoolerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Flash Intercooler")]
        FlashIntercooler = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Shell-and-Coil Intercooler")]
        ShellandCoilIntercooler = 3,
    }
    
    [Description("Detailed transcritical carbon dioxide (CO2) booster refrigeration systems used in" +
        " supermarkets. The object allows for modeling either a single stage system with " +
        "medium-temperature loads or a two stage system with both medium- and low-tempera" +
        "ture loads.")]
    [JsonObject("Refrigeration:TranscriticalSystem")]
    public class Refrigeration_TranscriticalSystem : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("system_type")]
public Refrigeration_TranscriticalSystem_SystemType SystemType { get; set; } = (Refrigeration_TranscriticalSystem_SystemType)Enum.Parse(typeof(Refrigeration_TranscriticalSystem_SystemType), "SingleStage");
        

[Description(@"Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there is more than one refrigerated case or walk-in served by this system, enter the name of a Refrigeration:CaseAndWalkInList object. Only medium temperature cases and walk-ins served directly by the system should be included in this list.")]
[JsonProperty("medium_temperature_refrigerated_case_or_walkin_or_caseandwalkinlist_name")]
public string MediumTemperatureRefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

[Description(@"Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there is more than one refrigerated case or walk-in served by this system, enter the name of a Refrigeration:CaseAndWalkInList object. Only low temperature cases and walkins served directly by the system should be included in this list.")]
[JsonProperty("low_temperature_refrigerated_case_or_walkin_or_caseandwalkinlist_name")]
public string LowTemperatureRefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

[JsonProperty("refrigeration_gas_cooler_name")]
public string RefrigerationGasCoolerName { get; set; } = "";
        

[JsonProperty("high_pressure_compressor_or_compressorlist_name")]
public string HighPressureCompressorOrCompressorlistName { get; set; } = "";
        

[JsonProperty("low_pressure_compressor_or_compressorlist_name")]
public string LowPressureCompressorOrCompressorlistName { get; set; } = "";
        

[JsonProperty("receiver_pressure")]
public System.Nullable<float> ReceiverPressure { get; set; } = (System.Nullable<float>)Single.Parse("4000000", CultureInfo.InvariantCulture);
        

[JsonProperty("subcooler_effectiveness")]
public System.Nullable<float> SubcoolerEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[Description(@"Fluid property data for the refrigerant must be entered. The fluid property data, including the objects: FluidProperties:Name, FluidProperties:Temperatures, FluidProperties:Saturated and FluidProperties:Superheated can be copied from the FluidPropertiesRefData.idf dataset")]
[JsonProperty("refrigeration_system_working_fluid_type")]
public string RefrigerationSystemWorkingFluidType { get; set; } = "";
        

[Description("Use only if you want to include suction piping heat gain in refrigeration load")]
[JsonProperty("sum_ua_suction_piping_for_medium_temperature_loads")]
public System.Nullable<float> SumUaSuctionPipingForMediumTemperatureLoads { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This will be used to determine the temperature used for distribution piping heat " +
    "gain and the pipe heat gains as cooling credit for the zone. Required only if Su" +
    "m UA Distribution Piping for Medium Temperature Loads > 0.0")]
[JsonProperty("medium_temperature_suction_piping_zone_name")]
public string MediumTemperatureSuctionPipingZoneName { get; set; } = "";
        

[Description("Use only if you want to include suction piping heat gain in refrigeration load")]
[JsonProperty("sum_ua_suction_piping_for_low_temperature_loads")]
public System.Nullable<float> SumUaSuctionPipingForLowTemperatureLoads { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This will be used to determine the temperature used for distribution piping heat " +
    "gain and the pipe heat gains as cooling credit for the zone. Required only if Su" +
    "m UA Distribution Piping for Low Temperature Loads > 0.0")]
[JsonProperty("low_temperature_suction_piping_zone_name")]
public string LowTemperatureSuctionPipingZoneName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Refrigeration_TranscriticalSystem_SystemType
    {
        
        [JsonProperty("SingleStage")]
        SingleStage = 0,
        
        [JsonProperty("TwoStage")]
        TwoStage = 1,
    }
    
    [Description(@"Works in conjunction with refrigerated cases and walkins to simulate the performance of a secondary loop supermarket refrigeration system. Heat from the refrigeration loads served by the secondary loop is absorbed by a primary refrigeration system (Refrigeration:System). The SecondarySystem object simulates a heat exchanger that is an evaporator, or refrigeration load, on the primary refrigeration system.")]
    [JsonObject("Refrigeration:SecondarySystem")]
    public class Refrigeration_SecondarySystem : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there i" +
    "s more than one refrigerated case or walk-in served by this secondary system, en" +
    "ter the name of a Refrigeration:CaseAndWalkInList object.")]
[JsonProperty("refrigerated_case_or_walkin_or_caseandwalkinlist_name")]
public string RefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

[Description(@"If ""FluidAlwaysLiquid"" is selected, the fluid properties must be input using the objects: FluidProperties:Name, FluidProperties:GlycolConcentration, and, if user defined fluid type, FluidProperties:Temperatures and FluidProperties:Concentration. Many sets of fluid properties can be found in GlycolPropertiesRefData.idf. If ""FluidPhaseChange"" is selected, the refrigerant properties must be input using the objects: (if user defined fluid type): FluidProperties:Name, FluidProperties:Temperatures, FluidProperties:Saturated, and FluidProperties:Superheated. Many sets of refrigerant data can be found in FluidPropertiesRefData.idf.")]
[JsonProperty("circulating_fluid_type")]
public Refrigeration_SecondarySystem_CirculatingFluidType CirculatingFluidType { get; set; } = (Refrigeration_SecondarySystem_CirculatingFluidType)Enum.Parse(typeof(Refrigeration_SecondarySystem_CirculatingFluidType), "FluidAlwaysLiquid");
        

[Description("This must correspond to a name in the FluidProperties:Name object.")]
[JsonProperty("circulating_fluid_name")]
public string CirculatingFluidName { get; set; } = "";
        

[Description(@"For ""FluidAlwaysLiquid"", at least one of the two, Evaporator Capacity OR Evaporator Flow Rate for Secondary Fluid, is required. For ""FluidPhaseChange"", the default capacity is the sum of the rated capacities of the Cases and Walk-ins served by the secondary loop.")]
[JsonProperty("evaporator_capacity")]
public System.Nullable<float> EvaporatorCapacity { get; set; } = null;
        

[Description("For \"FluidAlwaysLiquid\", at least one of the two, Evaporator Capacity OR Evaporat" +
    "or Flow Rate for Secondary Fluid, is required. For \"FluidPhaseChange\" loops, thi" +
    "s input is not used. (see PhaseChange Circulating Rate)")]
[JsonProperty("evaporator_flow_rate_for_secondary_fluid")]
public System.Nullable<float> EvaporatorFlowRateForSecondaryFluid { get; set; } = null;
        

[Description("This is the evaporating temperature in the heat exchanger used to chill or conden" +
    "se the secondary loop circulating fluid. It is NOT the temperature in any cases " +
    "or walk-ins served by the secondary loop.")]
[JsonProperty("evaporator_evaporating_temperature")]
public System.Nullable<float> EvaporatorEvaporatingTemperature { get; set; } = null;
        

[Description(@"For ""FluidAlwaysLiquid"", this is the rated difference between the temperature of the circulating fluid leaving the heat exchanger and the heat exchanger's rated evaporating temperature. For ""FluidPhaseChange"", this is the difference between the temperature of the evaporating and condensing temperatures in the heat exchanger.")]
[JsonProperty("evaporator_approach_temperature_difference")]
public System.Nullable<float> EvaporatorApproachTemperatureDifference { get; set; } = null;
        

[Description(@"For ""FluidAlwaysLiquid"", this is the rated difference between the temperature of the circulating fluid entering the heat exchanger and the temperature of the circulating fluid leaving the heat exchanger, and is Required. For ""FluidPhaseChange"", this input is not used.")]
[JsonProperty("evaporator_range_temperature_difference")]
public System.Nullable<float> EvaporatorRangeTemperatureDifference { get; set; } = null;
        

[JsonProperty("number_of_pumps_in_loop")]
public System.Nullable<float> NumberOfPumpsInLoop { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("For \"FluidAlwaysLiquid\",if not input, Evaporator Flow Rate for Secondary Fluid wi" +
    "ll be used. For \"FluidPhaseChange\", if not input, this will be calculated using " +
    "the PhaseChange Circulating Rate.")]
[JsonProperty("total_pump_flow_rate")]
public System.Nullable<float> TotalPumpFlowRate { get; set; } = null;
        

[Description("Either the Total Pump Power or the Total Pump Head is required.")]
[JsonProperty("total_pump_power")]
public System.Nullable<float> TotalPumpPower { get; set; } = null;
        

[Description("Either the Total Pump Power or the Total Pump Head is required.")]
[JsonProperty("total_pump_head")]
public System.Nullable<float> TotalPumpHead { get; set; } = null;
        

[Description("This is the total mass flow at the pump divided by the gaseous mass flow leaving " +
    "the refrigeration load.")]
[JsonProperty("phasechange_circulating_rate")]
public System.Nullable<float> PhasechangeCirculatingRate { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

[JsonProperty("pump_drive_type")]
public Refrigeration_SecondarySystem_PumpDriveType PumpDriveType { get; set; } = (Refrigeration_SecondarySystem_PumpDriveType)Enum.Parse(typeof(Refrigeration_SecondarySystem_PumpDriveType), "Constant");
        

[Description("Variable Speed Pump Curve Name is applicable to variable speed pumps only.")]
[JsonProperty("variable_speed_pump_cubic_curve_name")]
public string VariableSpeedPumpCubicCurveName { get; set; } = "";
        

[Description("This is the portion of the pump motor heat added to secondary circulating fluid a" +
    "nd is equal to the motor efficiency for non-hermetic motor. Enter 1.0 for a semi" +
    "-hermetic motor.")]
[JsonProperty("pump_motor_heat_to_fluid")]
public System.Nullable<float> PumpMotorHeatToFluid { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[Description("Use only if you want to include distribution piping heat gain in refrigeration lo" +
    "ad.")]
[JsonProperty("sum_ua_distribution_piping")]
public System.Nullable<float> SumUaDistributionPiping { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This will be used to determine the temperature used for distribution piping heat " +
    "gain. The pipe heat gains are also counted as cooling credit for the zone. Requi" +
    "red only if Sum UA Distribution Piping >0.0")]
[JsonProperty("distribution_piping_zone_name")]
public string DistributionPipingZoneName { get; set; } = "";
        

[Description("Use only if you want to include Receiver/Separator Shell heat gain in refrigerati" +
    "on load.")]
[JsonProperty("sum_ua_receiver_separator_shell")]
public System.Nullable<float> SumUaReceiverSeparatorShell { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This will be used to determine the temperature used for Receiver/Separator Shell " +
    "heat gain. The shell heat gains are also counted as cooling credit for the zone." +
    " Required only if Sum UA Receiver/Separator Shell >0.0")]
[JsonProperty("receiver_separator_zone_name")]
public string ReceiverSeparatorZoneName { get; set; } = "";
        

[Description("This value refers to the refrigerant circulating within the primary system provid" +
    "ing cooling to the chiller for the secondary loop, not to the fluid circulating " +
    "within the secondary loop itself.")]
[JsonProperty("evaporator_refrigerant_inventory")]
public System.Nullable<float> EvaporatorRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Refrigeration_SecondarySystem_CirculatingFluidType
    {
        
        [JsonProperty("FluidAlwaysLiquid")]
        FluidAlwaysLiquid = 0,
        
        [JsonProperty("FluidPhaseChange")]
        FluidPhaseChange = 1,
    }
    
    public enum Refrigeration_SecondarySystem_PumpDriveType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("Variable")]
        Variable = 2,
    }
    
    [Description(@"Works in conjunction with a compressor rack, a refrigeration system, or a refrigeration secondary system to simulate the performance of a walk-in cooler. The walk-in cooler model uses information at rated conditions along with input descriptions for heat transfer surfaces facing multiple zones to determine performance.")]
    [JsonObject("Refrigeration:WalkIn")]
    public class Refrigeration_WalkIn : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("rated_coil_cooling_capacity")]
public System.Nullable<float> RatedCoilCoolingCapacity { get; set; } = null;
        

[JsonProperty("operating_temperature")]
public System.Nullable<float> OperatingTemperature { get; set; } = null;
        

[Description("If DXEvaporator, use evaporating temperature (saturated suction temperature) If B" +
    "rineCoil, use Brine entering temperature used to set minimum suction pressure fo" +
    "r DX systems and minimum brine temp for secondary systems")]
[JsonProperty("rated_cooling_source_temperature")]
public System.Nullable<float> RatedCoolingSourceTemperature { get; set; } = null;
        

[Description("Include total for all anti-sweat, door, drip-pan, and floor heater power Do not i" +
    "nclude defrost heater power")]
[JsonProperty("rated_total_heating_power")]
public System.Nullable<float> RatedTotalHeatingPower { get; set; } = null;
        

[Description("Values will be used to multiply the total heating power Values in the schedule sh" +
    "ould be between 0.0 and 1.0 For example, this could be used if display door anti" +
    "sweat heaters are turned off at night Defaults to always on if schedule name lef" +
    "t blank.")]
[JsonProperty("heating_power_schedule_name")]
public string HeatingPowerScheduleName { get; set; } = "";
        

[JsonProperty("rated_cooling_coil_fan_power")]
public System.Nullable<float> RatedCoolingCoilFanPower { get; set; } = (System.Nullable<float>)Single.Parse("375", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_circulation_fan_power")]
public System.Nullable<float> RatedCirculationFanPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the total (display + task) installed lighting power.")]
[JsonProperty("rated_total_lighting_power")]
public System.Nullable<float> RatedTotalLightingPower { get; set; } = null;
        

[Description("The schedule should contain values between 0 and 1 Defaults to always on if sched" +
    "ule name left blank.")]
[JsonProperty("lighting_schedule_name")]
public string LightingScheduleName { get; set; } = "";
        

[Description("HotFluid includes either hot gas defrost for a DX system or Hot Brine defrost if " +
    "this walk in is cooled by brine from a secondary chiller")]
[JsonProperty("defrost_type")]
public Refrigeration_WalkIn_DefrostType DefrostType { get; set; } = (Refrigeration_WalkIn_DefrostType)Enum.Parse(typeof(Refrigeration_WalkIn_DefrostType), "Electric");
        

[JsonProperty("defrost_control_type")]
public Refrigeration_WalkIn_DefrostControlType DefrostControlType { get; set; } = (Refrigeration_WalkIn_DefrostControlType)Enum.Parse(typeof(Refrigeration_WalkIn_DefrostControlType), "TimeSchedule");
        

[Description("The schedule values should be 0 (off) or 1 (on)")]
[JsonProperty("defrost_schedule_name")]
public string DefrostScheduleName { get; set; } = "";
        

[Description(@"The schedule values should be 0 (off) or 1 (on) The start time for each defrost period in this drip-down schedule should coincide with the start time for each defrost period in the defrost schedule (previous input field). The length of each defrost drip-down period must be greater than or equal to the corresponding defrost period specified in the defrost schedule. This extra time allows the melted frost to drip from the coil before refrigeration is restarted.")]
[JsonProperty("defrost_drip_down_schedule_name")]
public string DefrostDripDownScheduleName { get; set; } = "";
        

[Description("needed for all defrost types except none and offcycle")]
[JsonProperty("defrost_power")]
public System.Nullable<float> DefrostPower { get; set; } = null;
        

[Description("This is the portion of the defrost energy that is available to melt frost Needed " +
    "only for defrost control type TemperatureTermination defaults to 0.7 for electri" +
    "c defrost and to 0.3 for hot fluid defrost")]
[JsonProperty("temperature_termination_defrost_fraction_to_ice")]
public System.Nullable<float> TemperatureTerminationDefrostFractionToIce { get; set; } = null;
        

[Description("Schedule values should be in units of Watts Leave this field blank if no restocki" +
    "ng is to be modeled")]
[JsonProperty("restocking_schedule_name")]
public string RestockingScheduleName { get; set; } = "";
        

[Description("This value is only used if the Cooling Source Type is DXEvaporator")]
[JsonProperty("average_refrigerant_charge_inventory")]
public System.Nullable<float> AverageRefrigerantChargeInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("floor area of walk-in cooler")]
[JsonProperty("insulated_floor_surface_area")]
public System.Nullable<float> InsulatedFloorSurfaceArea { get; set; } = null;
        

[Description("The default value corresponds to R18 [ft2-F-hr/Btu] To convert other IP R-values " +
    "to U, divide 5.678 by the R-value Some examples: R15 is U 0.3785 W/m2-K R5 is U " +
    "1.136 W/m2-K")]
[JsonProperty("insulated_floor_u_value")]
public System.Nullable<float> InsulatedFloorUValue { get; set; } = (System.Nullable<float>)Single.Parse("0.3154", CultureInfo.InvariantCulture);
        

[JsonProperty("zone_data")]
public string ZoneData { get; set; } = "";
    }
    
    public enum Refrigeration_WalkIn_DefrostType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotFluid")]
        HotFluid = 2,
        
        [JsonProperty("None")]
        None = 3,
        
        [JsonProperty("OffCycle")]
        OffCycle = 4,
    }
    
    public enum Refrigeration_WalkIn_DefrostControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("TemperatureTermination")]
        TemperatureTermination = 1,
        
        [JsonProperty("TimeSchedule")]
        TimeSchedule = 2,
    }
    
    [Description(@"Works in conjunction with a refrigeration chiller set, compressor rack, a refrigeration system, or a refrigeration secondary system to simulate the performance of an air chiller, similar to one found in a refrigerated warehouse. Energy use for fans and heaters is modeled based on inputs for nominal power, schedules, and control type. The air chiller model accounts for the sensible and latent heat exchange with the surrounding environment.")]
    [JsonObject("Refrigeration:AirChiller")]
    public class Refrigeration_AirChiller : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description(@"In each case, select the rating option that corresponds to the expected service conditions. For example, U.S. manufacturers quote a separate Unit Load Factor for wet or frosted coils. If the evaporating temperature is less than 0C, input the frosted coil value. Within the European convention, select SC1, 2, 3, 4, or 5 depending upon the expected evaporating temperature.")]
[JsonProperty("capacity_rating_type")]
public Refrigeration_AirChiller_CapacityRatingType CapacityRatingType { get; set; } = (Refrigeration_AirChiller_CapacityRatingType)Enum.Parse(typeof(Refrigeration_AirChiller_CapacityRatingType), "CapacityTotalSpecificConditions");
        

[Description(@"The sensible cooling capacity in watts (W/C) at rated conditions. The value entered for this field must be greater than zero, with no default value. This value is only used if the Capacity Rating Type is UnitLoadFactorSensibleOnly. The value given must be based upon the difference between the chiller inlet and outlet air temperatures, not on the difference between the zone mean temperature and the outlet air temperature")]
[JsonProperty("rated_unit_load_factor")]
public System.Nullable<float> RatedUnitLoadFactor { get; set; } = null;
        

[Description(@"This value is only used if the Capacity Rating Type is NOT UnitLoadFactorSensibleOnly. For CapacityTotalSpecificConditions, this capacity includes both sensible and latent at the conditions given in the next two fields. Note that the European Standard ratings are sensible only and the European Nominal ratings include latent capacity as well. The value given here must correspond to the capacity rating type given previously")]
[JsonProperty("rated_capacity")]
public System.Nullable<float> RatedCapacity { get; set; } = null;
        

[Description("This field is ONLY used if the Capacity Rating Type is CapacityTotalSpecificCondi" +
    "tions and represents the relative humidity at rated conditions. The default is 8" +
    "5.")]
[JsonProperty("rated_relative_humidity")]
public System.Nullable<float> RatedRelativeHumidity { get; set; } = (System.Nullable<float>)Single.Parse("85", CultureInfo.InvariantCulture);
        

[Description("If DXEvaporator, use evaporating temperature (saturated suction temperature) If B" +
    "rineCoil, use Brine entering temperature used to set minimum suction pressure fo" +
    "r DX systems and minimum brine temp for secondary systems")]
[JsonProperty("rated_cooling_source_temperature")]
public System.Nullable<float> RatedCoolingSourceTemperature { get; set; } = null;
        

[Description("The rated difference between the air entering the refrigeration chiller and the c" +
    "ooling source temperature in degC.")]
[JsonProperty("rated_temperature_difference_dt1")]
public System.Nullable<float> RatedTemperatureDifferenceDt1 { get; set; } = null;
        

[Description("The maximum difference between the air entering the refrigeration chiller and the" +
    " cooling source temperature in degC used to limit capacity during pull-down. def" +
    "aults to 1.3 times the Rated Temperature Difference DT1")]
[JsonProperty("maximum_temperature_difference_between_inlet_air_and_evaporating_temperature")]
public System.Nullable<float> MaximumTemperatureDifferenceBetweenInletAirAndEvaporatingTemperature { get; set; } = null;
        

[Description("This is the manufacturer\'s correction factor for coil material corresponding to r" +
    "ating")]
[JsonProperty("coil_material_correction_factor")]
public System.Nullable<float> CoilMaterialCorrectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This is the manufacturer\'s correction factor for refrigerant corresponding to rat" +
    "ing")]
[JsonProperty("refrigerant_correction_factor")]
public System.Nullable<float> RefrigerantCorrectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("In each case, select the correction curve type that corresponds to the rating typ" +
    "e. default LinearSHR60 unless Capacity Rating Type = CapacityTotalSpecificCondit" +
    "ions")]
[JsonProperty("capacity_correction_curve_type")]
public Refrigeration_AirChiller_CapacityCorrectionCurveType CapacityCorrectionCurveType { get; set; } = (Refrigeration_AirChiller_CapacityCorrectionCurveType)Enum.Parse(typeof(Refrigeration_AirChiller_CapacityCorrectionCurveType), "European");
        

[Description("Should be blank for LinearSHR60 correction curve type")]
[JsonProperty("capacity_correction_curve_name")]
public string CapacityCorrectionCurveName { get; set; } = "";
        

[Description("only used when the capacity correction curve type is LinearSHR60")]
[JsonProperty("shr60_correction_factor")]
public System.Nullable<float> Shr60CorrectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.48", CultureInfo.InvariantCulture);
        

[Description("Include total for all heater power Do not include defrost heater power")]
[JsonProperty("rated_total_heating_power")]
public System.Nullable<float> RatedTotalHeatingPower { get; set; } = null;
        

[Description("Values will be used to multiply the total heating power Values in the schedule sh" +
    "ould be between 0.0 and 1.0 Defaults to always on if schedule name left blank.")]
[JsonProperty("heating_power_schedule_name")]
public string HeatingPowerScheduleName { get; set; } = "";
        

[JsonProperty("fan_speed_control_type")]
public Refrigeration_AirChiller_FanSpeedControlType FanSpeedControlType { get; set; } = (Refrigeration_AirChiller_FanSpeedControlType)Enum.Parse(typeof(Refrigeration_AirChiller_FanSpeedControlType), "Fixed");
        

[JsonProperty("rated_fan_power")]
public System.Nullable<float> RatedFanPower { get; set; } = (System.Nullable<float>)Single.Parse("375", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_air_flow")]
public System.Nullable<float> RatedAirFlow { get; set; } = null;
        

[Description("Minimum air flow fraction through fan")]
[JsonProperty("minimum_fan_air_flow_ratio")]
public System.Nullable<float> MinimumFanAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("HotFluid includes either hot gas defrost for a DX system or Hot Brine defrost if " +
    "this walk in is cooled by brine from a secondary chiller")]
[JsonProperty("defrost_type")]
public Refrigeration_AirChiller_DefrostType DefrostType { get; set; } = (Refrigeration_AirChiller_DefrostType)Enum.Parse(typeof(Refrigeration_AirChiller_DefrostType), "Electric");
        

[JsonProperty("defrost_control_type")]
public Refrigeration_AirChiller_DefrostControlType DefrostControlType { get; set; } = (Refrigeration_AirChiller_DefrostControlType)Enum.Parse(typeof(Refrigeration_AirChiller_DefrostControlType), "TimeSchedule");
        

[Description("The schedule values should be 0 (off) or 1 (on)")]
[JsonProperty("defrost_schedule_name")]
public string DefrostScheduleName { get; set; } = "";
        

[Description(@"The schedule values should be 0 (off) or 1 (on) The start time for each defrost period in this drip-down schedule should coincide with the start time for each defrost period in the defrost schedule (previous input field). The length of each defrost drip-down period must be greater than or equal to the corresponding defrost period specified in the defrost schedule. This extra time allows the melted frost to drip from the coil before refrigeration is restarted.")]
[JsonProperty("defrost_drip_down_schedule_name")]
public string DefrostDripDownScheduleName { get; set; } = "";
        

[Description("needed for all defrost types except none and offcycle")]
[JsonProperty("defrost_power")]
public System.Nullable<float> DefrostPower { get; set; } = null;
        

[Description("This is the portion of the defrost energy that is available to melt frost Needed " +
    "only for defrost control type TemperatureTermination defaults to 0.7 for electri" +
    "c defrost and to 0.3 for hot fluid defrost")]
[JsonProperty("temperature_termination_defrost_fraction_to_ice")]
public System.Nullable<float> TemperatureTerminationDefrostFractionToIce { get; set; } = null;
        

[JsonProperty("vertical_location")]
public Refrigeration_AirChiller_VerticalLocation VerticalLocation { get; set; } = (Refrigeration_AirChiller_VerticalLocation)Enum.Parse(typeof(Refrigeration_AirChiller_VerticalLocation), "Middle");
        

[Description("This value is only used if the Cooling Source Type is DXEvaporator")]
[JsonProperty("average_refrigerant_charge_inventory")]
public System.Nullable<float> AverageRefrigerantChargeInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum Refrigeration_AirChiller_CapacityRatingType
    {
        
        [JsonProperty("CapacityTotalSpecificConditions")]
        CapacityTotalSpecificConditions = 0,
        
        [JsonProperty("EuropeanSC1NominalWet")]
        EuropeanSC1NominalWet = 1,
        
        [JsonProperty("EuropeanSC1Standard")]
        EuropeanSC1Standard = 2,
        
        [JsonProperty("EuropeanSC2NominalWet")]
        EuropeanSC2NominalWet = 3,
        
        [JsonProperty("EuropeanSC2Standard")]
        EuropeanSC2Standard = 4,
        
        [JsonProperty("EuropeanSC3NominalWet")]
        EuropeanSC3NominalWet = 5,
        
        [JsonProperty("EuropeanSC3Standard")]
        EuropeanSC3Standard = 6,
        
        [JsonProperty("EuropeanSC4NominalWet")]
        EuropeanSC4NominalWet = 7,
        
        [JsonProperty("EuropeanSC4Standard")]
        EuropeanSC4Standard = 8,
        
        [JsonProperty("EuropeanSC5NominalWet")]
        EuropeanSC5NominalWet = 9,
        
        [JsonProperty("EuropeanSC5Standard")]
        EuropeanSC5Standard = 10,
        
        [JsonProperty("FixedLinear")]
        FixedLinear = 11,
        
        [JsonProperty("UnitLoadFactorSensibleOnly")]
        UnitLoadFactorSensibleOnly = 12,
    }
    
    public enum Refrigeration_AirChiller_CapacityCorrectionCurveType
    {
        
        [JsonProperty("European")]
        European = 0,
        
        [JsonProperty("LinearSHR60")]
        LinearSHR60 = 1,
        
        [JsonProperty("QuadraticSHR")]
        QuadraticSHR = 2,
        
        [JsonProperty("TabularRHxDT1xTRoom")]
        TabularRHxDT1xTRoom = 3,
    }
    
    public enum Refrigeration_AirChiller_FanSpeedControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Fixed")]
        Fixed = 1,
        
        [JsonProperty("FixedLinear")]
        FixedLinear = 2,
        
        [JsonProperty("TwoSpeed")]
        TwoSpeed = 3,
        
        [JsonProperty("VariableSpeed")]
        VariableSpeed = 4,
    }
    
    public enum Refrigeration_AirChiller_DefrostType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotFluid")]
        HotFluid = 2,
        
        [JsonProperty("None")]
        None = 3,
        
        [JsonProperty("OffCycle")]
        OffCycle = 4,
    }
    
    public enum Refrigeration_AirChiller_DefrostControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("TemperatureTermination")]
        TemperatureTermination = 1,
        
        [JsonProperty("TimeSchedule")]
        TimeSchedule = 2,
    }
    
    public enum Refrigeration_AirChiller_VerticalLocation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Ceiling")]
        Ceiling = 1,
        
        [JsonProperty("Floor")]
        Floor = 2,
        
        [JsonProperty("Middle")]
        Middle = 3,
    }
    
    [Description(@"Works in conjunction with one or multiple air chillers, compressor racks, refrigeration systems, or refrigeration secondary system objects to simulate the performance of a group of air chillers cooling a single zone. The chiller set model passes information about the zone conditions to determine the performance of individual chiller coils within the set, thus providing the sensible and latent heat exchange with the zone environment.")]
    [JsonObject("ZoneHVAC:RefrigerationChillerSet")]
    public class ZoneHVAC_RefrigerationChillerSet : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections obje" +
    "ct.")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Not used - reserved for future use Name of the zone exhaust node (see Node) from " +
    "which the refrigeration chiller draws its indoor air. This should be one of the " +
    "zone exhaust nodes for the zone cooled by the chiller set.")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[Description("Not used - reserved for future use The name of the node where the chiller coil se" +
    "nds its outlet air, which must be one of the inlet air nodes for the zone which " +
    "is being cooled.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("chillers")]
public string Chillers { get; set; } = "";
    }
}
