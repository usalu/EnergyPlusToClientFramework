namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
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
    
    
    [Description("This object describes outdoor air temperature sensor offset")]
    [JsonObject("FaultModel:TemperatureSensorOffset:OutdoorAir")]
    public class FaultModel_TemperatureSensorOffset_OutdoorAir : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[JsonProperty("controller_object_type")]
public FaultModel_TemperatureSensorOffset_OutdoorAir_ControllerObjectType ControllerObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_OutdoorAir_ControllerObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_OutdoorAir_ControllerObjectType), "ControllerOutdoorAir");
        

[JsonProperty("controller_object_name")]
public string ControllerObjectName { get; set; } = "";
        

[JsonProperty("temperature_sensor_offset")]
public System.Nullable<float> TemperatureSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_TemperatureSensorOffset_OutdoorAir_ControllerObjectType
    {
        
        [JsonProperty("Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
    }
    
    [Description("This object describes outdoor air humidity sensor offset")]
    [JsonObject("FaultModel:HumiditySensorOffset:OutdoorAir")]
    public class FaultModel_HumiditySensorOffset_OutdoorAir : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[JsonProperty("controller_object_type")]
public FaultModel_HumiditySensorOffset_OutdoorAir_ControllerObjectType ControllerObjectType { get; set; } = (FaultModel_HumiditySensorOffset_OutdoorAir_ControllerObjectType)Enum.Parse(typeof(FaultModel_HumiditySensorOffset_OutdoorAir_ControllerObjectType), "ControllerOutdoorAir");
        

[JsonProperty("controller_object_name")]
public string ControllerObjectName { get; set; } = "";
        

[JsonProperty("humidity_sensor_offset")]
public System.Nullable<float> HumiditySensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_HumiditySensorOffset_OutdoorAir_ControllerObjectType
    {
        
        [JsonProperty("Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
    }
    
    [Description("This object describes outdoor air enthalpy sensor offset")]
    [JsonObject("FaultModel:EnthalpySensorOffset:OutdoorAir")]
    public class FaultModel_EnthalpySensorOffset_OutdoorAir : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[JsonProperty("controller_object_type")]
public FaultModel_EnthalpySensorOffset_OutdoorAir_ControllerObjectType ControllerObjectType { get; set; } = (FaultModel_EnthalpySensorOffset_OutdoorAir_ControllerObjectType)Enum.Parse(typeof(FaultModel_EnthalpySensorOffset_OutdoorAir_ControllerObjectType), "ControllerOutdoorAir");
        

[JsonProperty("controller_object_name")]
public string ControllerObjectName { get; set; } = "";
        

[JsonProperty("enthalpy_sensor_offset")]
public System.Nullable<float> EnthalpySensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_EnthalpySensorOffset_OutdoorAir_ControllerObjectType
    {
        
        [JsonProperty("Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
    }
    
    [Description("This object describes return air temperature sensor offset")]
    [JsonObject("FaultModel:TemperatureSensorOffset:ReturnAir")]
    public class FaultModel_TemperatureSensorOffset_ReturnAir : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[JsonProperty("controller_object_type")]
public FaultModel_TemperatureSensorOffset_ReturnAir_ControllerObjectType ControllerObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_ReturnAir_ControllerObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_ReturnAir_ControllerObjectType), "ControllerOutdoorAir");
        

[JsonProperty("controller_object_name")]
public string ControllerObjectName { get; set; } = "";
        

[JsonProperty("temperature_sensor_offset")]
public System.Nullable<float> TemperatureSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_TemperatureSensorOffset_ReturnAir_ControllerObjectType
    {
        
        [JsonProperty("Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
    }
    
    [Description("This object describes return air enthalpy sensor offset")]
    [JsonObject("FaultModel:EnthalpySensorOffset:ReturnAir")]
    public class FaultModel_EnthalpySensorOffset_ReturnAir : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[JsonProperty("controller_object_type")]
public FaultModel_EnthalpySensorOffset_ReturnAir_ControllerObjectType ControllerObjectType { get; set; } = (FaultModel_EnthalpySensorOffset_ReturnAir_ControllerObjectType)Enum.Parse(typeof(FaultModel_EnthalpySensorOffset_ReturnAir_ControllerObjectType), "ControllerOutdoorAir");
        

[JsonProperty("controller_object_name")]
public string ControllerObjectName { get; set; } = "";
        

[JsonProperty("enthalpy_sensor_offset")]
public System.Nullable<float> EnthalpySensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_EnthalpySensorOffset_ReturnAir_ControllerObjectType
    {
        
        [JsonProperty("Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
    }
    
    [Description("This object describes fault of chiller supply water temperature sensor offset")]
    [JsonObject("FaultModel:TemperatureSensorOffset:ChillerSupplyWater")]
    public class FaultModel_TemperatureSensorOffset_ChillerSupplyWater : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[Description("Enter the type of a chiller object")]
[JsonProperty("chiller_object_type")]
public FaultModel_TemperatureSensorOffset_ChillerSupplyWater_ChillerObjectType ChillerObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_ChillerSupplyWater_ChillerObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_ChillerSupplyWater_ChillerObjectType), "ChillerAbsorption");
        

[Description("Enter the name of a chiller object")]
[JsonProperty("chiller_object_name")]
public string ChillerObjectName { get; set; } = "";
        

[JsonProperty("reference_sensor_offset")]
public System.Nullable<float> ReferenceSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_TemperatureSensorOffset_ChillerSupplyWater_ChillerObjectType
    {
        
        [JsonProperty("Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [JsonProperty("Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [JsonProperty("Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [JsonProperty("Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [JsonProperty("Chiller:Electric")]
        ChillerElectric = 4,
        
        [JsonProperty("Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [JsonProperty("Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [JsonProperty("Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
    }
    
    [Description("This object describes fault of coil supply air temperature sensor offset")]
    [JsonObject("FaultModel:TemperatureSensorOffset:CoilSupplyAir")]
    public class FaultModel_TemperatureSensorOffset_CoilSupplyAir : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[Description("Enter the type of the coil affected")]
[JsonProperty("coil_object_type")]
public FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType CoilObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType), "AirLoopHVACUnitarySystem");
        

[Description("Enter the name of the coil affected")]
[JsonProperty("coil_object_name")]
public string CoilObjectName { get; set; } = "";
        

[Description("Enter the name of controller for the water coil affected Required for water coils" +
    "")]
[JsonProperty("water_coil_controller_name")]
public string WaterCoilControllerName { get; set; } = "";
        

[JsonProperty("reference_sensor_offset")]
public System.Nullable<float> ReferenceSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType
    {
        
        [JsonProperty("AirLoopHVAC:UnitarySystem")]
        AirLoopHVACUnitarySystem = 0,
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 1,
        
        [JsonProperty("Coil:Cooling:Water:Detailedgeometry")]
        CoilCoolingWaterDetailedgeometry = 2,
        
        [JsonProperty("Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 3,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 4,
        
        [JsonProperty("Coil:Heating:Gas")]
        CoilHeatingGas = 5,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 6,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 7,
        
        [JsonProperty("CoilSystem:Cooling:DX")]
        CoilSystemCoolingDX = 8,
        
        [JsonProperty("CoilSystem:Heating:DX")]
        CoilSystemHeatingDX = 9,
    }
    
    [Description("This object describes fault of condenser supply water temperature sensor offset")]
    [JsonObject("FaultModel:TemperatureSensorOffset:CondenserSupplyWater")]
    public class FaultModel_TemperatureSensorOffset_CondenserSupplyWater : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[Description("Enter the type of the cooling tower affected")]
[JsonProperty("cooling_tower_object_type")]
public FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType CoolingTowerObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType), "CoolingTowerSingleSpeed");
        

[Description("Enter the name of the cooling tower affected")]
[JsonProperty("cooling_tower_object_name")]
public string CoolingTowerObjectName { get; set; } = "";
        

[JsonProperty("reference_sensor_offset")]
public System.Nullable<float> ReferenceSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType
    {
        
        [JsonProperty("CoolingTower:SingleSpeed")]
        CoolingTowerSingleSpeed = 0,
        
        [JsonProperty("CoolingTower:TwoSpeed")]
        CoolingTowerTwoSpeed = 1,
        
        [JsonProperty("CoolingTower:VariableSpeed")]
        CoolingTowerVariableSpeed = 2,
        
        [JsonProperty("CoolingTower:VariableSpeed:MERKEL")]
        CoolingTowerVariableSpeedMERKEL = 3,
    }
    
    [Description("This object describes fault of thermostat offset")]
    [JsonObject("FaultModel:ThermostatOffset")]
    public class FaultModel_ThermostatOffset : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of a ZoneControl:Thermostat object.")]
[JsonProperty("thermostat_name")]
public string ThermostatName { get; set; } = "";
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[JsonProperty("reference_thermostat_offset")]
public System.Nullable<float> ReferenceThermostatOffset { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
    
    [Description("This object describes fault of humidistat offset")]
    [JsonObject("FaultModel:HumidistatOffset")]
    public class FaultModel_HumidistatOffset : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of a ZoneControl:Humidistat object.")]
[JsonProperty("humidistat_name")]
public string HumidistatName { get; set; } = "";
        

[Description("Two types are available: Type ThermostatOffsetIndependent Type ThermostatOffsetDe" +
    "pendent")]
[JsonProperty("humidistat_offset_type")]
public FaultModel_HumidistatOffset_HumidistatOffsetType HumidistatOffsetType { get; set; } = (FaultModel_HumidistatOffset_HumidistatOffsetType)Enum.Parse(typeof(FaultModel_HumidistatOffset_HumidistatOffsetType), "ThermostatOffsetIndependent");
        

[Description("This field is applicable for Type ThermostatOffsetIndependent")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("This field is applicable for Type ThermostatOffsetIndependent")]
[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[Description("Required field for Type ThermostatOffsetIndependent")]
[JsonProperty("reference_humidistat_offset")]
public System.Nullable<float> ReferenceHumidistatOffset { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("Enter the name of a FaultModel:ThermostatOffset object Required field for Type Th" +
    "ermostatOffsetDependent")]
[JsonProperty("related_thermostat_offset_fault_name")]
public string RelatedThermostatOffsetFaultName { get; set; } = "";
    }
    
    public enum FaultModel_HumidistatOffset_HumidistatOffsetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ThermostatOffsetDependent")]
        ThermostatOffsetDependent = 1,
        
        [JsonProperty("ThermostatOffsetIndependent")]
        ThermostatOffsetIndependent = 2,
    }
    
    [Description("This object describes fault of dirty air filters")]
    [JsonObject("FaultModel:Fouling:AirFilter")]
    public class FaultModel_Fouling_AirFilter : BHoMObject, IEnergyPlusClass
    {
        

[Description("Choose the type of the fan Support for Fan:SystemModel is pending")]
[JsonProperty("fan_object_type")]
public FaultModel_Fouling_AirFilter_FanObjectType FanObjectType { get; set; } = (FaultModel_Fouling_AirFilter_FanObjectType)Enum.Parse(typeof(FaultModel_Fouling_AirFilter_FanObjectType), "FanConstantVolume");
        

[Description("Enter the name of a fan object")]
[JsonProperty("fan_name")]
public string FanName { get; set; } = "";
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Enter the name of a schedule describing the variations of the fan pressure rise i" +
    "n terms of multipliers to the fan design pressure rise")]
[JsonProperty("pressure_fraction_schedule_name")]
public string PressureFractionScheduleName { get; set; } = "";
        

[Description("The curve describes the relationship between the fan pressure rise and air flow r" +
    "ate")]
[JsonProperty("fan_curve_name")]
public string FanCurveName { get; set; } = "";
    }
    
    public enum FaultModel_Fouling_AirFilter_FanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
        
        [JsonProperty("Fan:VariableVolume")]
        FanVariableVolume = 2,
    }
    
    [Description("This object describes the fouling fault of boilers with water-based heat exchange" +
        "rs")]
    [JsonObject("FaultModel:Fouling:Boiler")]
    public class FaultModel_Fouling_Boiler : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[Description("Enter the type of a boiler object The fault applies to the hot-water boilers")]
[JsonProperty("boiler_object_type")]
public FaultModel_Fouling_Boiler_BoilerObjectType BoilerObjectType { get; set; } = (FaultModel_Fouling_Boiler_BoilerObjectType)Enum.Parse(typeof(FaultModel_Fouling_Boiler_BoilerObjectType), "BoilerHotWater");
        

[Description("Enter the name of a Boiler object")]
[JsonProperty("boiler_object_name")]
public string BoilerObjectName { get; set; } = "";
        

[Description("The factor indicates the decrease of the nominal capacity of the boiler It is the" +
    " ratio between the nominal capacity at fouling case and that at fault free case")]
[JsonProperty("fouling_factor")]
public System.Nullable<float> FoulingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_Fouling_Boiler_BoilerObjectType
    {
        
        [JsonProperty("Boiler:HotWater")]
        BoilerHotWater = 0,
    }
    
    [Description("This object describes the fouling fault of the wetted coil evaporative cooler")]
    [JsonObject("FaultModel:Fouling:EvaporativeCooler")]
    public class FaultModel_Fouling_EvaporativeCooler : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[Description("Enter the type of a Evaporative Cooler object The fault applies to the wetted coi" +
    "l evaporative cooler The fault does not apply to direct evaporative coolers or t" +
    "he dry coil indirect evaporative coolers")]
[JsonProperty("evaporative_cooler_object_type")]
public FaultModel_Fouling_EvaporativeCooler_EvaporativeCoolerObjectType EvaporativeCoolerObjectType { get; set; } = (FaultModel_Fouling_EvaporativeCooler_EvaporativeCoolerObjectType)Enum.Parse(typeof(FaultModel_Fouling_EvaporativeCooler_EvaporativeCoolerObjectType), "EvaporativeCoolerIndirectWetCoil");
        

[Description("Enter the name of aN Evaporative Cooler object")]
[JsonProperty("evaporative_cooler_object_name")]
public string EvaporativeCoolerObjectName { get; set; } = "";
        

[Description("The factor indicates the decrease of the indirect stage efficiency It is the rati" +
    "o between the indirect stage efficiency at fouling case and that at fault free c" +
    "ase")]
[JsonProperty("fouling_factor")]
public System.Nullable<float> FoulingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_Fouling_EvaporativeCooler_EvaporativeCoolerObjectType
    {
        
        [JsonProperty("EvaporativeCooler:Indirect:WetCoil")]
        EvaporativeCoolerIndirectWetCoil = 0,
    }
    
    [Description("This object describes the fouling fault of chillers with water-cooled condensers")]
    [JsonObject("FaultModel:Fouling:Chiller")]
    public class FaultModel_Fouling_Chiller : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[Description("Enter the type of a chiller object The fault applies to the chillers with water-c" +
    "ooled condensers")]
[JsonProperty("chiller_object_type")]
public FaultModel_Fouling_Chiller_ChillerObjectType ChillerObjectType { get; set; } = (FaultModel_Fouling_Chiller_ChillerObjectType)Enum.Parse(typeof(FaultModel_Fouling_Chiller_ChillerObjectType), "ChillerCombustionTurbine");
        

[Description("Enter the name of a chiller object")]
[JsonProperty("chiller_object_name")]
public string ChillerObjectName { get; set; } = "";
        

[Description("The factor indicates the decrease of the nominal capacity of the chiller It is th" +
    "e ratio between the nominal capacity at fouling case and that at fault free case" +
    "")]
[JsonProperty("fouling_factor")]
public System.Nullable<float> FoulingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_Fouling_Chiller_ChillerObjectType
    {
        
        [JsonProperty("Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 0,
        
        [JsonProperty("Chiller:ConstantCOP")]
        ChillerConstantCOP = 1,
        
        [JsonProperty("Chiller:Electric")]
        ChillerElectric = 2,
        
        [JsonProperty("Chiller:Electric:EIR")]
        ChillerElectricEIR = 3,
        
        [JsonProperty("Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 4,
        
        [JsonProperty("Chiller:EngineDriven")]
        ChillerEngineDriven = 5,
    }
    
    [Description("This object describes the fault of fouling cooling towers")]
    [JsonObject("FaultModel:Fouling:CoolingTower")]
    public class FaultModel_Fouling_CoolingTower : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[Description("Enter the type of the cooling tower affected")]
[JsonProperty("cooling_tower_object_type")]
public FaultModel_Fouling_CoolingTower_CoolingTowerObjectType CoolingTowerObjectType { get; set; } = (FaultModel_Fouling_CoolingTower_CoolingTowerObjectType)Enum.Parse(typeof(FaultModel_Fouling_CoolingTower_CoolingTowerObjectType), "CoolingTowerSingleSpeed");
        

[Description("Enter the name of the cooling tower affected")]
[JsonProperty("cooling_tower_object_name")]
public string CoolingTowerObjectName { get; set; } = "";
        

[Description("Factor describing the tower UA reduction due to fouling It is the ratio between t" +
    "he UA value at fouling case and that at fault free case It is applicable to both" +
    " the Design UA and Free Convection UA of the tower")]
[JsonProperty("reference_ua_reduction_factor")]
public System.Nullable<float> ReferenceUaReductionFactor { get; set; } = null;
    }
    
    public enum FaultModel_Fouling_CoolingTower_CoolingTowerObjectType
    {
        
        [JsonProperty("CoolingTower:SingleSpeed")]
        CoolingTowerSingleSpeed = 0,
        
        [JsonProperty("CoolingTower:TwoSpeed")]
        CoolingTowerTwoSpeed = 1,
        
        [JsonProperty("CoolingTower:VariableSpeed:MERKEL")]
        CoolingTowerVariableSpeedMERKEL = 2,
    }
    
    [Description("This object describes fouling water heating or cooling coils")]
    [JsonObject("FaultModel:Fouling:Coil")]
    public class FaultModel_Fouling_Coil : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("coil_name")]
public string CoilName { get; set; } = "";
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("severity_schedule_name")]
public string SeverityScheduleName { get; set; } = "";
        

[JsonProperty("fouling_input_method")]
public FaultModel_Fouling_Coil_FoulingInputMethod FoulingInputMethod { get; set; } = (FaultModel_Fouling_Coil_FoulingInputMethod)Enum.Parse(typeof(FaultModel_Fouling_Coil_FoulingInputMethod), "FouledUARated");
        

[Description("Fouling coil UA value under rating conditions For Fouling Input Method: FouledUAR" +
    "ated")]
[JsonProperty("uafouled")]
public System.Nullable<float> Uafouled { get; set; } = null;
        

[Description("For Fouling Input Method: FoulingFactor")]
[JsonProperty("water_side_fouling_factor")]
public System.Nullable<float> WaterSideFoulingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("For Fouling Input Method: FoulingFactor")]
[JsonProperty("air_side_fouling_factor")]
public System.Nullable<float> AirSideFoulingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("For Fouling Input Method: FoulingFactor")]
[JsonProperty("outside_coil_surface_area")]
public System.Nullable<float> OutsideCoilSurfaceArea { get; set; } = null;
        

[Description("For Fouling Input Method: FoulingFactor")]
[JsonProperty("inside_to_outside_coil_surface_area_ratio")]
public System.Nullable<float> InsideToOutsideCoilSurfaceAreaRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.07", CultureInfo.InvariantCulture);
    }
    
    public enum FaultModel_Fouling_Coil_FoulingInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FouledUARated")]
        FouledUARated = 1,
        
        [JsonProperty("FoulingFactor")]
        FoulingFactor = 2,
    }
}
