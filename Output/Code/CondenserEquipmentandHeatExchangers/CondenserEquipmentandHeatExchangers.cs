namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
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
    
    
    [Description(@"This tower model is based on Merkel's theory, which is also the basis for the tower model in ASHRAE's HVAC1 Toolkit. The open wet cooling tower is modeled as a counter flow heat exchanger with a single-speed fan drawing air through the tower (induced-draft configuration). Added fluid bypass as an additional capacity control. 8/2008. For a multi-cell tower, the capacity and air/water flow rate inputs are for the entire tower.")]
    [JsonObject("CoolingTower:SingleSpeed")]
    public class CoolingTower_SingleSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Name of tower water inlet node")]
[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[Description("Name of tower water outlet node")]
[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[Description("Leave field blank if tower performance input method is NominalCapacity")]
[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = "";
        

[JsonProperty("design_air_flow_rate")]
public string DesignAirFlowRate { get; set; } = "";
        

[Description("This is the fan motor electric input power")]
[JsonProperty("design_fan_power")]
public string DesignFanPower { get; set; } = "";
        

[Description("Leave field blank if tower performance input method is NominalCapacity")]
[JsonProperty("design_u_factor_times_area_value")]
public string DesignUFactorTimesAreaValue { get; set; } = "";
        

[JsonProperty("free_convection_regime_air_flow_rate")]
public string FreeConvectionRegimeAirFlowRate { get; set; } = (System.String)"0";
        

[Description("This field is only used if the previous field is set to autocalculate.")]
[JsonProperty("free_convection_regime_air_flow_rate_sizing_factor")]
public System.Nullable<float> FreeConvectionRegimeAirFlowRateSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[JsonProperty("free_convection_regime_u_factor_times_area_value")]
public string FreeConvectionRegimeUFactorTimesAreaValue { get; set; } = (System.String)"0";
        

[Description("This field is only used if the previous field is set to autocalculate and the Per" +
    "formance Input Method is UFactorTimesAreaAndDesignWaterFlowRate")]
[JsonProperty("free_convection_u_factor_times_area_value_sizing_factor")]
public System.Nullable<float> FreeConvectionUFactorTimesAreaValueSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("User can define tower thermal performance by specifying the tower UA, the Design " +
    "Air Flow Rate and the Design Water Flow Rate, or by specifying the tower nominal" +
    " capacity")]
[JsonProperty("performance_input_method")]
public CoolingTower_SingleSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (CoolingTower_SingleSpeed_PerformanceInputMethod)Enum.Parse(typeof(CoolingTower_SingleSpeed_PerformanceInputMethod), "UFactorTimesAreaAndDesignWaterFlowRate");
        

[JsonProperty("heat_rejection_capacity_and_nominal_capacity_sizing_ratio")]
public System.Nullable<float> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt (3 gpm/ton). Nominal tower capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty("nominal_capacity")]
public System.Nullable<float> NominalCapacity { get; set; } = null;
        

[Description(@"Tower capacity in free convection regime with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt of nominal tower capacity (3 gpm/ton). Tower free convection capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty("free_convection_capacity")]
public string FreeConvectionCapacity { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate")]
[JsonProperty("free_convection_nominal_capacity_sizing_factor")]
public System.Nullable<float> FreeConvectionNominalCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("Enter the tower\'s design inlet air dry-bulb temperature")]
[JsonProperty("design_inlet_air_dry_bulb_temperature")]
public System.Nullable<float> DesignInletAirDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("35", CultureInfo.InvariantCulture);
        

[Description("Enter the tower\'s design inlet air wet-bulb temperature")]
[JsonProperty("design_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> DesignInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25.6", CultureInfo.InvariantCulture);
        

[Description("Enter the approach temperature corresponding to the design inlet air wet-bulb tem" +
    "perature and design range temperature. Design approach temp = outlet water tempe" +
    "rature minus inlet air wet-bulb temperature at design conditions. Autosized to 3" +
    ".9 deltaC.")]
[JsonProperty("design_approach_temperature")]
public string DesignApproachTemperature { get; set; } = (System.String)"Autosize";
        

[Description("Enter the range temperature corresponding to the design inlet air wet-bulb temper" +
    "ature and design approach temperature. Design range = inlet water temperature mi" +
    "nus outlet water temperature at design conditions. Autosized to 5.5 deltaC.")]
[JsonProperty("design_range_temperature")]
public string DesignRangeTemperature { get; set; } = (System.String)"Autosize";
        

[Description("This heater maintains the basin water temperature at the basin heater setpoint te" +
    "mperature when the outdoor air temperature falls below the setpoint temperature." +
    " The basin heater only operates when water is not flowing through the tower.")]
[JsonProperty("basin_heater_capacity")]
public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the outdoor dry-bulb temperature when the basin heater turns on")]
[JsonProperty("basin_heater_setpoint_temperature")]
public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description(@"Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
[JsonProperty("basin_heater_operating_schedule_name")]
public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

[JsonProperty("evaporation_loss_mode")]
public CoolingTower_SingleSpeed_EvaporationLossMode EvaporationLossMode { get; set; } = (CoolingTower_SingleSpeed_EvaporationLossMode)Enum.Parse(typeof(CoolingTower_SingleSpeed_EvaporationLossMode), "LossFactor");
        

[Description(@"Rate of water evaporation from the cooling tower and lost to the outdoor air [%/K] Evaporation loss is calculated as percentage of the circulating condenser water rate Value entered here is percent-per-degree K of temperature drop in the condenser water Typical values are from 0.15 to 0.27 [%/K].")]
[JsonProperty("evaporation_loss_factor")]
public System.Nullable<float> EvaporationLossFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Rate of drift loss as a percentage of circulating condenser water flow rate Typic" +
    "al values are between 0.002 and 0.2% The default value is 0.008%")]
[JsonProperty("drift_loss_percent")]
public System.Nullable<float> DriftLossPercent { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty("blowdown_calculation_mode")]
public CoolingTower_SingleSpeed_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (CoolingTower_SingleSpeed_BlowdownCalculationMode)Enum.Parse(typeof(CoolingTower_SingleSpeed_BlowdownCalculationMode), "ConcentrationRatio");
        

[Description(@"Characterizes the rate of blowdown in the cooling tower. Blowdown is water intentionally drained from the tower in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Typical values for tower operation are 3 to 5. The default value is 3.")]
[JsonProperty("blowdown_concentration_ratio")]
public System.Nullable<float> BlowdownConcentrationRatio { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"Makeup water usage due to blowdown results from occasionally draining a small amount of water in the tower basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
[JsonProperty("blowdown_makeup_water_usage_schedule_name")]
public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[Description("Enter the name of an outdoor air node")]
[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("capacity_control")]
public CoolingTower_SingleSpeed_CapacityControl CapacityControl { get; set; } = (CoolingTower_SingleSpeed_CapacityControl)Enum.Parse(typeof(CoolingTower_SingleSpeed_CapacityControl), "FanCycling");
        

[JsonProperty("number_of_cells")]
public System.Nullable<float> NumberOfCells { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cell_control")]
public CoolingTower_SingleSpeed_CellControl CellControl { get; set; } = (CoolingTower_SingleSpeed_CellControl)Enum.Parse(typeof(CoolingTower_SingleSpeed_CellControl), "MinimalCell");
        

[Description("The allowable minimal fraction of the nominal flow rate per cell")]
[JsonProperty("cell_minimum_water_flow_rate_fraction")]
public System.Nullable<float> CellMinimumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.33", CultureInfo.InvariantCulture);
        

[Description("The allowable maximal fraction of the nominal flow rate per cell")]
[JsonProperty("cell_maximum_water_flow_rate_fraction")]
public System.Nullable<float> CellMaximumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

[Description("Multiplies the autosized capacity and flow rates")]
[JsonProperty("sizing_factor")]
public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum CoolingTower_SingleSpeed_PerformanceInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NominalCapacity")]
        NominalCapacity = 1,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
    
    public enum CoolingTower_SingleSpeed_EvaporationLossMode
    {
        
        [JsonProperty("LossFactor")]
        LossFactor = 0,
        
        [JsonProperty("SaturatedExit")]
        SaturatedExit = 1,
    }
    
    public enum CoolingTower_SingleSpeed_BlowdownCalculationMode
    {
        
        [JsonProperty("ConcentrationRatio")]
        ConcentrationRatio = 0,
        
        [JsonProperty("ScheduledRate")]
        ScheduledRate = 1,
    }
    
    public enum CoolingTower_SingleSpeed_CapacityControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FanCycling")]
        FanCycling = 1,
        
        [JsonProperty("FluidBypass")]
        FluidBypass = 2,
    }
    
    public enum CoolingTower_SingleSpeed_CellControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximalCell")]
        MaximalCell = 1,
        
        [JsonProperty("MinimalCell")]
        MinimalCell = 2,
    }
    
    [Description(@"This tower model is based on Merkel's theory, which is also the basis for the tower model in ASHRAE's HVAC1 Toolkit. The open wet cooling tower is modeled as a counter flow heat exchanger with a two-speed fan drawing air through the tower (induced-draft configuration). For a multi-cell tower, the capacity and air/water flow rate inputs are for the entire tower.")]
    [JsonObject("CoolingTower:TwoSpeed")]
    public class CoolingTower_TwoSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Name of tower Water Inlet Node")]
[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[Description("Name of tower Water Outlet Node")]
[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[Description("Leave field blank if Tower Performance Input Method is NominalCapacity")]
[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = "";
        

[JsonProperty("high_fan_speed_air_flow_rate")]
public string HighFanSpeedAirFlowRate { get; set; } = "";
        

[Description("This is the fan motor electric input power at high speed")]
[JsonProperty("high_fan_speed_fan_power")]
public string HighFanSpeedFanPower { get; set; } = "";
        

[Description("Leave field blank if Tower Performance Input Method is NominalCapacity")]
[JsonProperty("high_fan_speed_u_factor_times_area_value")]
public string HighFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

[Description("Low speed air flow rate must be less than high speed air flow rate Low speed air " +
    "flow rate must be greater than free convection air flow rate")]
[JsonProperty("low_fan_speed_air_flow_rate")]
public string LowFanSpeedAirFlowRate { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate.")]
[JsonProperty("low_fan_speed_air_flow_rate_sizing_factor")]
public System.Nullable<float> LowFanSpeedAirFlowRateSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("This is the fan motor electric input power at low speed")]
[JsonProperty("low_fan_speed_fan_power")]
public string LowFanSpeedFanPower { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate.")]
[JsonProperty("low_fan_speed_fan_power_sizing_factor")]
public System.Nullable<float> LowFanSpeedFanPowerSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.16", CultureInfo.InvariantCulture);
        

[Description("Leave field blank if tower Performance Input Method is NominalCapacity Low speed " +
    "tower UA must be less than high speed tower UA Low speed tower UA must be greate" +
    "r than free convection tower UA")]
[JsonProperty("low_fan_speed_u_factor_times_area_value")]
public string LowFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate and the Per" +
    "formance Input Method is UFactorTimesAreaAndDesignWaterFlowRate")]
[JsonProperty("low_fan_speed_u_factor_times_area_sizing_factor")]
public System.Nullable<float> LowFanSpeedUFactorTimesAreaSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.6", CultureInfo.InvariantCulture);
        

[JsonProperty("free_convection_regime_air_flow_rate")]
public string FreeConvectionRegimeAirFlowRate { get; set; } = (System.String)"0";
        

[Description("This field is only used if the previous field is set to autocalculate.")]
[JsonProperty("free_convection_regime_air_flow_rate_sizing_factor")]
public System.Nullable<float> FreeConvectionRegimeAirFlowRateSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("Leave field blank if Tower Performance Input Method is NominalCapacity")]
[JsonProperty("free_convection_regime_u_factor_times_area_value")]
public string FreeConvectionRegimeUFactorTimesAreaValue { get; set; } = (System.String)"0";
        

[Description("This field is only used if the previous field is set to autocalculate and the Per" +
    "formance Input Method is UFactorTimesAreaAndDesignWaterFlowRate")]
[JsonProperty("free_convection_u_factor_times_area_value_sizing_factor")]
public System.Nullable<float> FreeConvectionUFactorTimesAreaValueSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("User can define tower thermal performance by specifying the tower UA, the Design " +
    "Air Flow Rate and the Design Water Flow Rate, or by specifying the tower nominal" +
    " capacity")]
[JsonProperty("performance_input_method")]
public CoolingTower_TwoSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (CoolingTower_TwoSpeed_PerformanceInputMethod)Enum.Parse(typeof(CoolingTower_TwoSpeed_PerformanceInputMethod), "UFactorTimesAreaAndDesignWaterFlowRate");
        

[JsonProperty("heat_rejection_capacity_and_nominal_capacity_sizing_ratio")]
public System.Nullable<float> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature, with the tower fan operating at high speed. Design water flow rate assumed to be 5.382E-8 m3/s per watt(3 gpm/ton). Nominal tower capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty("high_speed_nominal_capacity")]
public System.Nullable<float> HighSpeedNominalCapacity { get; set; } = null;
        

[Description(@"Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature, with the tower fan operating at low speed. Design water flow rate assumed to be 5.382E-8 m3/s per watt of tower high-speed nominal capacity (3 gpm/ton). Nominal tower capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty("low_speed_nominal_capacity")]
public string LowSpeedNominalCapacity { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate")]
[JsonProperty("low_speed_nominal_capacity_sizing_factor")]
public System.Nullable<float> LowSpeedNominalCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description(@"Tower capacity in free convection regime with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt of tower high-speed nominal capacity (3 gpm/ton). Tower free convection capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25)  gives the actual tower heat rejection at these operating conditions")]
[JsonProperty("free_convection_nominal_capacity")]
public string FreeConvectionNominalCapacity { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate")]
[JsonProperty("free_convection_nominal_capacity_sizing_factor")]
public System.Nullable<float> FreeConvectionNominalCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("Enter the tower\'s design inlet air dry-bulb temperature")]
[JsonProperty("design_inlet_air_dry_bulb_temperature")]
public System.Nullable<float> DesignInletAirDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("35", CultureInfo.InvariantCulture);
        

[Description("Enter the tower\'s design inlet air wet-bulb temperature")]
[JsonProperty("design_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> DesignInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25.6", CultureInfo.InvariantCulture);
        

[Description("Enter the approach temperature corresponding to the design inlet air wet-bulb tem" +
    "perature and design range temperature. Design approach temp = outlet water tempe" +
    "rature minus inlet air wet-bulb temperature at design conditions. Autosized to 3" +
    ".9 deltaC.")]
[JsonProperty("design_approach_temperature")]
public string DesignApproachTemperature { get; set; } = (System.String)"Autosize";
        

[Description("Enter the range temperature corresponding to the design inlet air wet-bulb temper" +
    "ature and design approach temperature. Design range = inlet water temperature mi" +
    "nus outlet water temperature at design conditions. Autosized to 5.5 deltaC.")]
[JsonProperty("design_range_temperature")]
public string DesignRangeTemperature { get; set; } = (System.String)"Autosize";
        

[Description("This heater maintains the basin water temperature at the basin heater setpoint te" +
    "mperature when the outdoor air temperature falls below the setpoint temperature." +
    " The basin heater only operates when water is not flowing through the tower.")]
[JsonProperty("basin_heater_capacity")]
public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the outdoor dry-bulb temperature when the basin heater turns on")]
[JsonProperty("basin_heater_setpoint_temperature")]
public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description(@"Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
[JsonProperty("basin_heater_operating_schedule_name")]
public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

[JsonProperty("evaporation_loss_mode")]
public CoolingTower_TwoSpeed_EvaporationLossMode EvaporationLossMode { get; set; } = (CoolingTower_TwoSpeed_EvaporationLossMode)Enum.Parse(typeof(CoolingTower_TwoSpeed_EvaporationLossMode), "LossFactor");
        

[Description(@"Rate of water evaporated from the cooling tower and lost to the outdoor air [%/K] Evaporation loss is calculated as percentage of the circulating condenser water rate Value entered here is percent-per-degree K of temperature drop in the condenser water Typical values are from 0.15 to 0.27 [%/K].")]
[JsonProperty("evaporation_loss_factor")]
public System.Nullable<float> EvaporationLossFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Rate of drift loss as a percentage of circulating condenser water flow rate Typic" +
    "al values are between 0.002 and 0.2% The default value is 0.008%")]
[JsonProperty("drift_loss_percent")]
public System.Nullable<float> DriftLossPercent { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty("blowdown_calculation_mode")]
public CoolingTower_TwoSpeed_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (CoolingTower_TwoSpeed_BlowdownCalculationMode)Enum.Parse(typeof(CoolingTower_TwoSpeed_BlowdownCalculationMode), "ConcentrationRatio");
        

[Description(@"Characterizes the rate of blowdown in the cooling tower. Blowdown is water intentionally drained from the tower in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Typical values for tower operation are 3 to 5. The default value is 3.")]
[JsonProperty("blowdown_concentration_ratio")]
public System.Nullable<float> BlowdownConcentrationRatio { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"Makeup water usage due to blowdown results from occasionally draining some amount of water in the tower basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
[JsonProperty("blowdown_makeup_water_usage_schedule_name")]
public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[Description("Enter the name of an outdoor air node")]
[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("number_of_cells")]
public System.Nullable<float> NumberOfCells { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cell_control")]
public CoolingTower_TwoSpeed_CellControl CellControl { get; set; } = (CoolingTower_TwoSpeed_CellControl)Enum.Parse(typeof(CoolingTower_TwoSpeed_CellControl), "MinimalCell");
        

[Description("The allowable minimal fraction of the nominal flow rate per cell")]
[JsonProperty("cell_minimum_water_flow_rate_fraction")]
public System.Nullable<float> CellMinimumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.33", CultureInfo.InvariantCulture);
        

[Description("The allowable maximal fraction of the nominal flow rate per cell")]
[JsonProperty("cell_maximum_water_flow_rate_fraction")]
public System.Nullable<float> CellMaximumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

[Description("Multiplies the autosized capacity and flow rates")]
[JsonProperty("sizing_factor")]
public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum CoolingTower_TwoSpeed_PerformanceInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NominalCapacity")]
        NominalCapacity = 1,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
    
    public enum CoolingTower_TwoSpeed_EvaporationLossMode
    {
        
        [JsonProperty("LossFactor")]
        LossFactor = 0,
        
        [JsonProperty("SaturatedExit")]
        SaturatedExit = 1,
    }
    
    public enum CoolingTower_TwoSpeed_BlowdownCalculationMode
    {
        
        [JsonProperty("ConcentrationRatio")]
        ConcentrationRatio = 0,
        
        [JsonProperty("ScheduledRate")]
        ScheduledRate = 1,
    }
    
    public enum CoolingTower_TwoSpeed_CellControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximalCell")]
        MaximalCell = 1,
        
        [JsonProperty("MinimalCell")]
        MinimalCell = 2,
    }
    
    [Description(@"This tower model is based on Merkel's theory, which is also the basis for the tower model in ASHRAE's HVAC1 Toolkit. The open wet cooling tower is modeled as a counter flow heat exchanger with a variable-speed fan drawing air through the tower (induced-draft configuration). For a multi-cell tower, the capacity and air/water flow rate inputs are for the entire tower.")]
    [JsonObject("CoolingTower:VariableSpeed:Merkel")]
    public class CoolingTower_VariableSpeed_Merkel : BHoMObject, IEnergyPlusClass
    {
        

[Description("Name of tower water inlet node")]
[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[Description("Name of tower water outlet node")]
[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[Description("User can define tower thermal performance by specifying the tower UA, the Design " +
    "Air Flow Rate and the Design Water Flow Rate, or by specifying the tower nominal" +
    " capacity")]
[JsonProperty("performance_input_method")]
public CoolingTower_VariableSpeed_Merkel_PerformanceInputMethod PerformanceInputMethod { get; set; } = (CoolingTower_VariableSpeed_Merkel_PerformanceInputMethod)Enum.Parse(typeof(CoolingTower_VariableSpeed_Merkel_PerformanceInputMethod), "NominalCapacity");
        

[JsonProperty("heat_rejection_capacity_and_nominal_capacity_sizing_ratio")]
public System.Nullable<float> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature, with the tower fan operating at Design Air Flow Rate (full speed). Design water flow rate is as set in Design Water Flow Rate per Unit of Nominal Capacity. Nominal tower capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty("nominal_capacity")]
public string NominalCapacity { get; set; } = "";
        

[Description(@"required field when performance method is NominalCapacity Tower capacity in free convection regime with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate is as set in Design Water Flow Rate per Unit of Nominal Capacity. Tower free convection capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25)  gives the actual tower heat rejection at these operating conditions")]
[JsonProperty("free_convection_nominal_capacity")]
public string FreeConvectionNominalCapacity { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate")]
[JsonProperty("free_convection_nominal_capacity_sizing_factor")]
public System.Nullable<float> FreeConvectionNominalCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = "";
        

[Description("This field is only used if the previous is set to autocalculate and performance i" +
    "nput method is NominalCapacity")]
[JsonProperty("design_water_flow_rate_per_unit_of_nominal_capacity")]
public System.Nullable<float> DesignWaterFlowRatePerUnitOfNominalCapacity { get; set; } = (System.Nullable<float>)Single.Parse("5.382E-08", CultureInfo.InvariantCulture);
        

[Description("This is the air flow rate at full fan speed")]
[JsonProperty("design_air_flow_rate")]
public string DesignAirFlowRate { get; set; } = "";
        

[Description(@"This field is only used if the previous is set to autocalculate When field is left blank the default scaling factor is adjusted for elevation to increase volume flow at altitude When field has a value the scaling factor is used without adjusting for elevation")]
[JsonProperty("design_air_flow_rate_per_unit_of_nominal_capacity")]
public System.Nullable<float> DesignAirFlowRatePerUnitOfNominalCapacity { get; set; } = (System.Nullable<float>)Single.Parse("2.76316E-05", CultureInfo.InvariantCulture);
        

[Description("Enter the minimum air flow rate ratio. This is typically determined by the variab" +
    "le speed drive that controls the fan motor speed. Valid entries are from 0.1 to " +
    "0.5.")]
[JsonProperty("minimum_air_flow_rate_ratio")]
public System.Nullable<float> MinimumAirFlowRateRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("This is the fan motor electric input power at high speed")]
[JsonProperty("design_fan_power")]
public string DesignFanPower { get; set; } = "";
        

[Description("This field is only used if the previous is set to autocalculate [W/W] Watts of fa" +
    "n power per Watt of tower nominal capacity")]
[JsonProperty("design_fan_power_per_unit_of_nominal_capacity")]
public System.Nullable<float> DesignFanPowerPerUnitOfNominalCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0.0105", CultureInfo.InvariantCulture);
        

[Description("Any curve or table with one independent variable can be used cubic curve = a + b*" +
    "AFR + c*AFR**2 + d*AFR**3 quartic curve = a + b*AFR + c*AFR**2 + d*AFR**3 + e*AF" +
    "R**4 x = AFR = Ratio of current operating air flow rate to Design Air Flow Rate")]
[JsonProperty("fan_power_modifier_function_of_air_flow_rate_ratio_curve_name")]
public string FanPowerModifierFunctionOfAirFlowRateRatioCurveName { get; set; } = "";
        

[JsonProperty("free_convection_regime_air_flow_rate")]
public string FreeConvectionRegimeAirFlowRate { get; set; } = (System.String)"0";
        

[Description("This field is only used if the previous field is set to autocalculate.")]
[JsonProperty("free_convection_regime_air_flow_rate_sizing_factor")]
public System.Nullable<float> FreeConvectionRegimeAirFlowRateSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("required field when performance method is UFactorTimesAreaAndDesignWaterFlowRate " +
    "when performance method is NominalCapacity the program will solve for this UA")]
[JsonProperty("design_air_flow_rate_u_factor_times_area_value")]
public string DesignAirFlowRateUFactorTimesAreaValue { get; set; } = "";
        

[Description("required field when performance input method is UFactorTimesAreaAndDesignWaterFlo" +
    "wRate Leave field blank if performance input method is NominalCapacity")]
[JsonProperty("free_convection_regime_u_factor_times_area_value")]
public string FreeConvectionRegimeUFactorTimesAreaValue { get; set; } = (System.String)"0";
        

[Description("required field when performance input method is UFactorTimesAreaAndDesignWaterFlo" +
    "wRate This field is only used if the previous field is set to autocalculate and " +
    "the performance input method is UFactorTimesAreaAndDesignWaterFlowRate")]
[JsonProperty("free_convection_u_factor_times_area_value_sizing_factor")]
public System.Nullable<float> FreeConvectionUFactorTimesAreaValueSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description(@"This curve describes how tower's design UA changes with variable air flow rate Any curve or table with one independent variable can be used cubic curve = a + b*AFR + c*AFR**2 + d*AFR**3 quartic curve = a + b*AFR + c*AFR**2 + d*AFR**3 + e*AFR**4 x = AFR = Ratio of current operating air flow rate to Design Air Flow Rate")]
[JsonProperty("u_factor_times_area_modifier_function_of_air_flow_ratio_curve_name")]
public string UFactorTimesAreaModifierFunctionOfAirFlowRatioCurveName { get; set; } = "";
        

[Description(@"curve describes how tower UA changes with outdoor air wet-bulb temperature difference from design wet-bulb Any curve or table with one independent variable can be used cubic curve = a + b*DeltaWB + c*DeltaWB**2 + d*DeltaWB**3 quartic curve = a + b*DeltaWB + c*DeltaWB**2 + d*DeltaWB**3 + e*DeltaWB**4 x = DeltaWB = (design wet-bulb temperature in C - current wet-bulb temperature in C) where design wet-bulb temperature of entering air is 25.56C (78F)")]
[JsonProperty("u_factor_times_area_modifier_function_of_wetbulb_temperature_difference_curve_nam" +
    "e")]
public string UFactorTimesAreaModifierFunctionOfWetbulbTemperatureDifferenceCurveName { get; set; } = "";
        

[Description(@"curve describes how tower UA changes with the flow rate of condenser water through the tower Any curve or table with one independent variable can be used cubic curve = a + b*WFR + c*WFR**2 + d*WFR**3 quartic curve = a + b*WFR + c*WFR**2 + d*WFR**3 + e*WFR**4 x = WFR = Ratio of current operating water flow rate to Design Water Flow Rate")]
[JsonProperty("u_factor_times_area_modifier_function_of_water_flow_ratio_curve_name")]
public string UFactorTimesAreaModifierFunctionOfWaterFlowRatioCurveName { get; set; } = "";
        

[Description("Enter the tower\'s design inlet air dry-bulb temperature")]
[JsonProperty("design_inlet_air_dry_bulb_temperature")]
public System.Nullable<float> DesignInletAirDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("35", CultureInfo.InvariantCulture);
        

[Description("Enter the tower\'s design inlet air wet-bulb temperature")]
[JsonProperty("design_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> DesignInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25.6", CultureInfo.InvariantCulture);
        

[Description("Enter the approach temperature corresponding to the design inlet air wet-bulb tem" +
    "perature and design range temperature. Design approach temp = outlet water tempe" +
    "rature minus inlet air wet-bulb temperature at design conditions. Autosized to 3" +
    ".9 deltaC.")]
[JsonProperty("design_approach_temperature")]
public string DesignApproachTemperature { get; set; } = (System.String)"Autosize";
        

[Description("Enter the range temperature corresponding to the design inlet air wet-bulb temper" +
    "ature and design approach temperature. Design range = inlet water temperature mi" +
    "nus outlet water temperature at design conditions. Autosized to 5.5 deltaC.")]
[JsonProperty("design_range_temperature")]
public string DesignRangeTemperature { get; set; } = (System.String)"Autosize";
        

[Description("This heater maintains the basin water temperature at the basin heater setpoint te" +
    "mperature when the outdoor air temperature falls below the setpoint temperature." +
    " The basin heater only operates when water is not flowing through the tower.")]
[JsonProperty("basin_heater_capacity")]
public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the outdoor dry-bulb temperature when the basin heater turns on")]
[JsonProperty("basin_heater_setpoint_temperature")]
public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description(@"Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
[JsonProperty("basin_heater_operating_schedule_name")]
public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

[JsonProperty("evaporation_loss_mode")]
public CoolingTower_VariableSpeed_Merkel_EvaporationLossMode EvaporationLossMode { get; set; } = (CoolingTower_VariableSpeed_Merkel_EvaporationLossMode)Enum.Parse(typeof(CoolingTower_VariableSpeed_Merkel_EvaporationLossMode), "LossFactor");
        

[Description(@"Rate of water evaporated from the cooling tower and lost to the outdoor air [%/K] Evaporation loss is calculated as percentage of the circulating condenser water rate Value entered here is percent-per-degree K of temperature drop in the condenser water Typical values are from 0.15 to 0.27 [%/K].")]
[JsonProperty("evaporation_loss_factor")]
public System.Nullable<float> EvaporationLossFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Rate of drift loss as a percentage of circulating condenser water flow rate Typic" +
    "al values are between 0.002 and 0.2% The default value is 0.008%")]
[JsonProperty("drift_loss_percent")]
public System.Nullable<float> DriftLossPercent { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty("blowdown_calculation_mode")]
public CoolingTower_VariableSpeed_Merkel_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (CoolingTower_VariableSpeed_Merkel_BlowdownCalculationMode)Enum.Parse(typeof(CoolingTower_VariableSpeed_Merkel_BlowdownCalculationMode), "ConcentrationRatio");
        

[Description(@"Characterizes the rate of blowdown in the cooling tower. Blowdown is water intentionally drained from the tower in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Typical values for tower operation are 3 to 5. The default value is 3.")]
[JsonProperty("blowdown_concentration_ratio")]
public System.Nullable<float> BlowdownConcentrationRatio { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"Makeup water usage due to blowdown results from occasionally draining some amount of water in the tower basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
[JsonProperty("blowdown_makeup_water_usage_schedule_name")]
public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[Description("Enter the name of an outdoor air node")]
[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("number_of_cells")]
public System.Nullable<float> NumberOfCells { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cell_control")]
public CoolingTower_VariableSpeed_Merkel_CellControl CellControl { get; set; } = (CoolingTower_VariableSpeed_Merkel_CellControl)Enum.Parse(typeof(CoolingTower_VariableSpeed_Merkel_CellControl), "MinimalCell");
        

[Description("The allowable minimal fraction of the nominal flow rate per cell")]
[JsonProperty("cell_minimum_water_flow_rate_fraction")]
public System.Nullable<float> CellMinimumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.33", CultureInfo.InvariantCulture);
        

[Description("The allowable maximal fraction of the nominal flow rate per cell")]
[JsonProperty("cell_maximum_water_flow_rate_fraction")]
public System.Nullable<float> CellMaximumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

[Description("Multiplies the autosized capacity and flow rates")]
[JsonProperty("sizing_factor")]
public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum CoolingTower_VariableSpeed_Merkel_PerformanceInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NominalCapacity")]
        NominalCapacity = 1,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
    
    public enum CoolingTower_VariableSpeed_Merkel_EvaporationLossMode
    {
        
        [JsonProperty("LossFactor")]
        LossFactor = 0,
        
        [JsonProperty("SaturatedExit")]
        SaturatedExit = 1,
    }
    
    public enum CoolingTower_VariableSpeed_Merkel_BlowdownCalculationMode
    {
        
        [JsonProperty("ConcentrationRatio")]
        ConcentrationRatio = 0,
        
        [JsonProperty("ScheduledRate")]
        ScheduledRate = 1,
    }
    
    public enum CoolingTower_VariableSpeed_Merkel_CellControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximalCell")]
        MaximalCell = 1,
        
        [JsonProperty("MinimalCell")]
        MinimalCell = 2,
    }
    
    [Description(@"This open wet tower model is based on purely empirical algorithms derived from manufacturer's performance data or field measurements. The user can select from two existing algorithms (CoolTools or YorkCalc), or they can enter their own correlation for approach temperature by using a variable speed tower model coefficient object. For a multi-cell tower, the capacity and air/water flow rate inputs are for the entire tower.")]
    [JsonObject("CoolingTower:VariableSpeed")]
    public class CoolingTower_VariableSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Name of tower water inlet node")]
[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[Description("Name of tower water outlet node")]
[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[Description("Determines the coefficients and form of the equation for calculating approach tem" +
    "perature")]
[JsonProperty("model_type")]
public CoolingTower_VariableSpeed_ModelType ModelType { get; set; } = (CoolingTower_VariableSpeed_ModelType)Enum.Parse(typeof(CoolingTower_VariableSpeed_ModelType), "YorkCalc");
        

[Description("Name of the tower model coefficient object. Used only when tower Model Type is ei" +
    "ther CoolToolsUserDefined or YorkCalcUserDefined.")]
[JsonProperty("model_coefficient_name")]
public string ModelCoefficientName { get; set; } = "";
        

[Description("Enter the tower\'s design inlet air wet-bulb temperature")]
[JsonProperty("design_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> DesignInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25.6", CultureInfo.InvariantCulture);
        

[Description("Enter the approach temperature corresponding to the design inlet air wet-bulb tem" +
    "perature and design range temperature. Design approach temp = outlet water tempe" +
    "rature minus inlet air wet-bulb temperature at design conditions.")]
[JsonProperty("design_approach_temperature")]
public System.Nullable<float> DesignApproachTemperature { get; set; } = (System.Nullable<float>)Single.Parse("3.9", CultureInfo.InvariantCulture);
        

[Description("Enter the range temperature corresponding to the design inlet air wet-bulb temper" +
    "ature and design approach temperature. Design range = inlet water temperature mi" +
    "nus outlet water temperature at design conditions.")]
[JsonProperty("design_range_temperature")]
public System.Nullable<float> DesignRangeTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5.6", CultureInfo.InvariantCulture);
        

[Description("Water flow rate through the tower at design conditions")]
[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = "";
        

[Description("Design (maximum) air flow rate through the tower")]
[JsonProperty("design_air_flow_rate")]
public string DesignAirFlowRate { get; set; } = "";
        

[Description("Enter the fan motor electric input power at design (max) air flow through the tow" +
    "er Standard conversion for horsepower is 1 HP = 745.7 W")]
[JsonProperty("design_fan_power")]
public string DesignFanPower { get; set; } = "";
        

[Description("FPR = a + b*AFR + c*AFR**2 + d*AFR**3 FPR = fraction of the design fan power AFR " +
    "= fraction of the design air flow rate If left blank, then fan power is assumed " +
    "to be proportional to (air flow rate ratio)^3")]
[JsonProperty("fan_power_ratio_function_of_air_flow_rate_ratio_curve_name")]
public string FanPowerRatioFunctionOfAirFlowRateRatioCurveName { get; set; } = "";
        

[Description("Enter the minimum air flow rate ratio. This is typically determined by the variab" +
    "le speed drive that controls the fan motor speed. Valid entries are from 0.2 to " +
    "0.5.")]
[JsonProperty("minimum_air_flow_rate_ratio")]
public System.Nullable<float> MinimumAirFlowRateRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description(@"Enter the fraction of tower capacity in the free convection regime. This is the fraction of the tower capacity, at the current inlet air wet-bulb temperature, that is available when the tower fan is off. Manufacturers typically estimate the free convection capacity at approximately 10-15%. Values are entered as a fraction and can range from 0 to 0.2.")]
[JsonProperty("fraction_of_tower_capacity_in_free_convection_regime")]
public System.Nullable<float> FractionOfTowerCapacityInFreeConvectionRegime { get; set; } = (System.Nullable<float>)Single.Parse("0.125", CultureInfo.InvariantCulture);
        

[Description("This heater maintains the basin water temperature at the basin heater setpoint te" +
    "mperature when the outdoor air temperature falls below the setpoint temperature." +
    " The basin heater only operates when water is not flowing through the tower.")]
[JsonProperty("basin_heater_capacity")]
public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the outdoor dry-bulb temperature when the basin heater turns on")]
[JsonProperty("basin_heater_setpoint_temperature")]
public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description(@"Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
[JsonProperty("basin_heater_operating_schedule_name")]
public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

[JsonProperty("evaporation_loss_mode")]
public CoolingTower_VariableSpeed_EvaporationLossMode EvaporationLossMode { get; set; } = (CoolingTower_VariableSpeed_EvaporationLossMode)Enum.Parse(typeof(CoolingTower_VariableSpeed_EvaporationLossMode), "LossFactor");
        

[Description(@"Rate of water evaporated from the cooling tower and lost to the outdoor air [%/K] Evaporation loss is calculated as percentage of the circulating condenser water rate Value entered here is percent-per-degree K of temperature drop in the condenser water Typical values are from 0.15 to 0.27 [percent/K].")]
[JsonProperty("evaporation_loss_factor")]
public System.Nullable<float> EvaporationLossFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Rate of drift loss as a percentage of circulating condenser water flow rate Typic" +
    "al values are between 0.002 and 0.2% The default value is 0.008%")]
[JsonProperty("drift_loss_percent")]
public System.Nullable<float> DriftLossPercent { get; set; } = null;
        

[JsonProperty("blowdown_calculation_mode")]
public CoolingTower_VariableSpeed_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (CoolingTower_VariableSpeed_BlowdownCalculationMode)Enum.Parse(typeof(CoolingTower_VariableSpeed_BlowdownCalculationMode), "ConcentrationRatio");
        

[Description(@"Characterizes the rate of blowdown in the cooling tower. Blowdown is water intentionally drained from the tower in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Typical values for tower operation are 3 to 5. The default value is 3.")]
[JsonProperty("blowdown_concentration_ratio")]
public System.Nullable<float> BlowdownConcentrationRatio { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"Makeup water usage due to blowdown results from occasionally draining a small amount of water in the tower basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
[JsonProperty("blowdown_makeup_water_usage_schedule_name")]
public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[Description("Enter the name of an outdoor air node")]
[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("number_of_cells")]
public System.Nullable<float> NumberOfCells { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cell_control")]
public CoolingTower_VariableSpeed_CellControl CellControl { get; set; } = (CoolingTower_VariableSpeed_CellControl)Enum.Parse(typeof(CoolingTower_VariableSpeed_CellControl), "MinimalCell");
        

[Description("The allowable minimal fraction of the nominal flow rate per cell")]
[JsonProperty("cell_minimum_water_flow_rate_fraction")]
public System.Nullable<float> CellMinimumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.33", CultureInfo.InvariantCulture);
        

[Description("The allowable maximal fraction of the nominal flow rate per cell")]
[JsonProperty("cell_maximum_water_flow_rate_fraction")]
public System.Nullable<float> CellMaximumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

[Description("Multiplies the autosized capacity and flow rates")]
[JsonProperty("sizing_factor")]
public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum CoolingTower_VariableSpeed_ModelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolToolsCrossFlow")]
        CoolToolsCrossFlow = 1,
        
        [JsonProperty("CoolToolsUserDefined")]
        CoolToolsUserDefined = 2,
        
        [JsonProperty("YorkCalc")]
        YorkCalc = 3,
        
        [JsonProperty("YorkCalcUserDefined")]
        YorkCalcUserDefined = 4,
    }
    
    public enum CoolingTower_VariableSpeed_EvaporationLossMode
    {
        
        [JsonProperty("LossFactor")]
        LossFactor = 0,
        
        [JsonProperty("SaturatedExit")]
        SaturatedExit = 1,
    }
    
    public enum CoolingTower_VariableSpeed_BlowdownCalculationMode
    {
        
        [JsonProperty("ConcentrationRatio")]
        ConcentrationRatio = 0,
        
        [JsonProperty("ScheduledRate")]
        ScheduledRate = 1,
    }
    
    public enum CoolingTower_VariableSpeed_CellControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximalCell")]
        MaximalCell = 1,
        
        [JsonProperty("MinimalCell")]
        MinimalCell = 2,
    }
    
    [Description("This object is used to define coefficients for the approach temperature correlati" +
        "on for a variable speed cooling tower when tower Model Type is specified as Cool" +
        "ToolsUserDefined in the object CoolingTower:VariableSpeed.")]
    [JsonObject("CoolingTowerPerformance:CoolTools")]
    public class CoolingTowerPerformance_CoolTools : BHoMObject, IEnergyPlusClass
    {
        

[Description("Minimum valid inlet air wet-bulb temperature for this approach temperature correl" +
    "ation.")]
[JsonProperty("minimum_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> MinimumInletAirWetBulbTemperature { get; set; } = null;
        

[Description("Maximum valid inlet air wet-bulb temperature for this approach temperature correl" +
    "ation.")]
[JsonProperty("maximum_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> MaximumInletAirWetBulbTemperature { get; set; } = null;
        

[Description("Minimum valid range temperature for this approach temperature correlation.")]
[JsonProperty("minimum_range_temperature")]
public System.Nullable<float> MinimumRangeTemperature { get; set; } = null;
        

[Description("Maximum valid range temperature for this approach temperature correlation.")]
[JsonProperty("maximum_range_temperature")]
public System.Nullable<float> MaximumRangeTemperature { get; set; } = null;
        

[Description("Minimum valid approach temperature for this correlation.")]
[JsonProperty("minimum_approach_temperature")]
public System.Nullable<float> MinimumApproachTemperature { get; set; } = null;
        

[Description("Maximum valid approach temperature for this correlation.")]
[JsonProperty("maximum_approach_temperature")]
public System.Nullable<float> MaximumApproachTemperature { get; set; } = null;
        

[Description("Minimum valid water flow rate ratio for this approach temperature correlation.")]
[JsonProperty("minimum_water_flow_rate_ratio")]
public System.Nullable<float> MinimumWaterFlowRateRatio { get; set; } = null;
        

[Description("Maximum valid water flow rate ratio for this approach temperature correlation.")]
[JsonProperty("maximum_water_flow_rate_ratio")]
public System.Nullable<float> MaximumWaterFlowRateRatio { get; set; } = null;
        

[JsonProperty("coefficient_1")]
public System.Nullable<float> Coefficient1 { get; set; } = null;
        

[JsonProperty("coefficient_2")]
public System.Nullable<float> Coefficient2 { get; set; } = null;
        

[JsonProperty("coefficient_3")]
public System.Nullable<float> Coefficient3 { get; set; } = null;
        

[JsonProperty("coefficient_4")]
public System.Nullable<float> Coefficient4 { get; set; } = null;
        

[JsonProperty("coefficient_5")]
public System.Nullable<float> Coefficient5 { get; set; } = null;
        

[JsonProperty("coefficient_6")]
public System.Nullable<float> Coefficient6 { get; set; } = null;
        

[JsonProperty("coefficient_7")]
public System.Nullable<float> Coefficient7 { get; set; } = null;
        

[JsonProperty("coefficient_8")]
public System.Nullable<float> Coefficient8 { get; set; } = null;
        

[JsonProperty("coefficient_9")]
public System.Nullable<float> Coefficient9 { get; set; } = null;
        

[JsonProperty("coefficient_10")]
public System.Nullable<float> Coefficient10 { get; set; } = null;
        

[JsonProperty("coefficient_11")]
public System.Nullable<float> Coefficient11 { get; set; } = null;
        

[JsonProperty("coefficient_12")]
public System.Nullable<float> Coefficient12 { get; set; } = null;
        

[JsonProperty("coefficient_13")]
public System.Nullable<float> Coefficient13 { get; set; } = null;
        

[JsonProperty("coefficient_14")]
public System.Nullable<float> Coefficient14 { get; set; } = null;
        

[JsonProperty("coefficient_15")]
public System.Nullable<float> Coefficient15 { get; set; } = null;
        

[JsonProperty("coefficient_16")]
public System.Nullable<float> Coefficient16 { get; set; } = null;
        

[JsonProperty("coefficient_17")]
public System.Nullable<float> Coefficient17 { get; set; } = null;
        

[JsonProperty("coefficient_18")]
public System.Nullable<float> Coefficient18 { get; set; } = null;
        

[JsonProperty("coefficient_19")]
public System.Nullable<float> Coefficient19 { get; set; } = null;
        

[JsonProperty("coefficient_20")]
public System.Nullable<float> Coefficient20 { get; set; } = null;
        

[JsonProperty("coefficient_21")]
public System.Nullable<float> Coefficient21 { get; set; } = null;
        

[JsonProperty("coefficient_22")]
public System.Nullable<float> Coefficient22 { get; set; } = null;
        

[JsonProperty("coefficient_23")]
public System.Nullable<float> Coefficient23 { get; set; } = null;
        

[JsonProperty("coefficient_24")]
public System.Nullable<float> Coefficient24 { get; set; } = null;
        

[JsonProperty("coefficient_25")]
public System.Nullable<float> Coefficient25 { get; set; } = null;
        

[JsonProperty("coefficient_26")]
public System.Nullable<float> Coefficient26 { get; set; } = null;
        

[JsonProperty("coefficient_27")]
public System.Nullable<float> Coefficient27 { get; set; } = null;
        

[JsonProperty("coefficient_28")]
public System.Nullable<float> Coefficient28 { get; set; } = null;
        

[JsonProperty("coefficient_29")]
public System.Nullable<float> Coefficient29 { get; set; } = null;
        

[JsonProperty("coefficient_30")]
public System.Nullable<float> Coefficient30 { get; set; } = null;
        

[JsonProperty("coefficient_31")]
public System.Nullable<float> Coefficient31 { get; set; } = null;
        

[JsonProperty("coefficient_32")]
public System.Nullable<float> Coefficient32 { get; set; } = null;
        

[JsonProperty("coefficient_33")]
public System.Nullable<float> Coefficient33 { get; set; } = null;
        

[JsonProperty("coefficient_34")]
public System.Nullable<float> Coefficient34 { get; set; } = null;
        

[JsonProperty("coefficient_35")]
public System.Nullable<float> Coefficient35 { get; set; } = null;
    }
    
    [Description("This object is used to define coefficients for the approach temperature correlati" +
        "on for a variable speed cooling tower when tower Model Type is specified as York" +
        "CalcUserDefined in the object CoolingTower:VariableSpeed.")]
    [JsonObject("CoolingTowerPerformance:YorkCalc")]
    public class CoolingTowerPerformance_YorkCalc : BHoMObject, IEnergyPlusClass
    {
        

[Description("Minimum valid inlet air wet-bulb temperature for this approach temperature correl" +
    "ation.")]
[JsonProperty("minimum_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> MinimumInletAirWetBulbTemperature { get; set; } = null;
        

[Description("Maximum valid inlet air wet-bulb temperature for this approach temperature correl" +
    "ation.")]
[JsonProperty("maximum_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> MaximumInletAirWetBulbTemperature { get; set; } = null;
        

[Description("Minimum valid range temperature for this approach temperature correlation.")]
[JsonProperty("minimum_range_temperature")]
public System.Nullable<float> MinimumRangeTemperature { get; set; } = null;
        

[Description("Maximum valid range temperature for this approach temperature correlation.")]
[JsonProperty("maximum_range_temperature")]
public System.Nullable<float> MaximumRangeTemperature { get; set; } = null;
        

[Description("Minimum valid approach temperature for this correlation.")]
[JsonProperty("minimum_approach_temperature")]
public System.Nullable<float> MinimumApproachTemperature { get; set; } = null;
        

[Description("Maximum valid approach temperature for this correlation.")]
[JsonProperty("maximum_approach_temperature")]
public System.Nullable<float> MaximumApproachTemperature { get; set; } = null;
        

[Description("Minimum valid water flow rate ratio for this approach temperature correlation.")]
[JsonProperty("minimum_water_flow_rate_ratio")]
public System.Nullable<float> MinimumWaterFlowRateRatio { get; set; } = null;
        

[Description("Maximum valid water flow rate ratio for this approach temperature correlation.")]
[JsonProperty("maximum_water_flow_rate_ratio")]
public System.Nullable<float> MaximumWaterFlowRateRatio { get; set; } = null;
        

[Description("Maximum liquid (water) to gas (air) ratio for this approach temperature correlati" +
    "on.")]
[JsonProperty("maximum_liquid_to_gas_ratio")]
public System.Nullable<float> MaximumLiquidToGasRatio { get; set; } = null;
        

[JsonProperty("coefficient_1")]
public System.Nullable<float> Coefficient1 { get; set; } = null;
        

[JsonProperty("coefficient_2")]
public System.Nullable<float> Coefficient2 { get; set; } = null;
        

[JsonProperty("coefficient_3")]
public System.Nullable<float> Coefficient3 { get; set; } = null;
        

[JsonProperty("coefficient_4")]
public System.Nullable<float> Coefficient4 { get; set; } = null;
        

[JsonProperty("coefficient_5")]
public System.Nullable<float> Coefficient5 { get; set; } = null;
        

[JsonProperty("coefficient_6")]
public System.Nullable<float> Coefficient6 { get; set; } = null;
        

[JsonProperty("coefficient_7")]
public System.Nullable<float> Coefficient7 { get; set; } = null;
        

[JsonProperty("coefficient_8")]
public System.Nullable<float> Coefficient8 { get; set; } = null;
        

[JsonProperty("coefficient_9")]
public System.Nullable<float> Coefficient9 { get; set; } = null;
        

[JsonProperty("coefficient_10")]
public System.Nullable<float> Coefficient10 { get; set; } = null;
        

[JsonProperty("coefficient_11")]
public System.Nullable<float> Coefficient11 { get; set; } = null;
        

[JsonProperty("coefficient_12")]
public System.Nullable<float> Coefficient12 { get; set; } = null;
        

[JsonProperty("coefficient_13")]
public System.Nullable<float> Coefficient13 { get; set; } = null;
        

[JsonProperty("coefficient_14")]
public System.Nullable<float> Coefficient14 { get; set; } = null;
        

[JsonProperty("coefficient_15")]
public System.Nullable<float> Coefficient15 { get; set; } = null;
        

[JsonProperty("coefficient_16")]
public System.Nullable<float> Coefficient16 { get; set; } = null;
        

[JsonProperty("coefficient_17")]
public System.Nullable<float> Coefficient17 { get; set; } = null;
        

[JsonProperty("coefficient_18")]
public System.Nullable<float> Coefficient18 { get; set; } = null;
        

[JsonProperty("coefficient_19")]
public System.Nullable<float> Coefficient19 { get; set; } = null;
        

[JsonProperty("coefficient_20")]
public System.Nullable<float> Coefficient20 { get; set; } = null;
        

[JsonProperty("coefficient_21")]
public System.Nullable<float> Coefficient21 { get; set; } = null;
        

[JsonProperty("coefficient_22")]
public System.Nullable<float> Coefficient22 { get; set; } = null;
        

[JsonProperty("coefficient_23")]
public System.Nullable<float> Coefficient23 { get; set; } = null;
        

[JsonProperty("coefficient_24")]
public System.Nullable<float> Coefficient24 { get; set; } = null;
        

[JsonProperty("coefficient_25")]
public System.Nullable<float> Coefficient25 { get; set; } = null;
        

[JsonProperty("coefficient_26")]
public System.Nullable<float> Coefficient26 { get; set; } = null;
        

[JsonProperty("coefficient_27")]
public System.Nullable<float> Coefficient27 { get; set; } = null;
    }
    
    [Description("This model is based on Merkel\'s theory, which is also the basis for the cooling t" +
        "ower model in EnergyPlus. The Evaporative fluid cooler is modeled as a counter f" +
        "low heat exchanger.")]
    [JsonObject("EvaporativeFluidCooler:SingleSpeed")]
    public class EvaporativeFluidCooler_SingleSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Name of Fluid Cooler water inlet node")]
[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[Description("Name of Fluid Cooler water outlet node")]
[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("design_air_flow_rate")]
public string DesignAirFlowRate { get; set; } = "";
        

[Description("This is the fan motor electric input power")]
[JsonProperty("design_air_flow_rate_fan_power")]
public string DesignAirFlowRateFanPower { get; set; } = "";
        

[JsonProperty("design_spray_water_flow_rate")]
public System.Nullable<float> DesignSprayWaterFlowRate { get; set; } = null;
        

[Description("User can define fluid cooler thermal performance by specifying the fluid cooler U" +
    "A and the Design Water Flow Rate, or by specifying the fluid cooler Standard Des" +
    "ign Capacity or by specifying Design Capacity for Non standard conditions.")]
[JsonProperty("performance_input_method")]
public EvaporativeFluidCooler_SingleSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (EvaporativeFluidCooler_SingleSpeed_PerformanceInputMethod)Enum.Parse(typeof(EvaporativeFluidCooler_SingleSpeed_PerformanceInputMethod), "StandardDesignCapacity");
        

[Description("Enter the name of an outdoor air node")]
[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("heat_rejection_capacity_and_nominal_capacity_sizing_ratio")]
public System.Nullable<float> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"Standard design capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt (3 gpm/ton). Standard design capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual fluid cooler heat rejection at these operating conditions. Only used for Performance Input Method = StandardDesignCapacity; for other input methods, this field is ignored. The standard conditions mentioned above for Standard design capacity are already specified in the EnergyPlus. So the input fields such as design entering water temp., design entering air wet-bulb and dry-bulb temp. and design water flow rate, if provided in the input, will be ignored for the StandardDesignCapacity performance input method. Also, the standard conditions are for water as a fluid type so this performance input method can only be used with water as a fluid type (as specified in CondenserLoop object).")]
[JsonProperty("standard_design_capacity")]
public System.Nullable<float> StandardDesignCapacity { get; set; } = null;
        

[Description("Only used for Performance Input Method = UFactorTimesAreaAndDesignWaterFlowRate; " +
    "for other Performance Input Methods, this field is ignored.")]
[JsonProperty("design_air_flow_rate_u_factor_times_area_value")]
public string DesignAirFlowRateUFactorTimesAreaValue { get; set; } = "";
        

[Description("Input value is ignored if fluid cooler Performance Input Method= StandardDesignCa" +
    "pacity.")]
[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = "";
        

[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
    "erformance Input Methods, this field is ignored.")]
[JsonProperty("user_specified_design_capacity")]
public System.Nullable<float> UserSpecifiedDesignCapacity { get; set; } = null;
        

[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
    "erformance Input Methods, this field is ignored. Design Entering Water Temperatu" +
    "re must be greater than Design Entering Air Temperature.")]
[JsonProperty("design_entering_water_temperature")]
public System.Nullable<float> DesignEnteringWaterTemperature { get; set; } = null;
        

[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
    "erformance Input Methods, this field is ignored. Design Entering Air Temperature" +
    " must be greater than Design Entering Air Wet-bulb Temperature.")]
[JsonProperty("design_entering_air_temperature")]
public System.Nullable<float> DesignEnteringAirTemperature { get; set; } = null;
        

[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
    "erformance Input Methods, this field is ignored. Design Entering Air Wet-bulb Te" +
    "mperature must be less than Design Entering Air Temperature.")]
[JsonProperty("design_entering_air_wet_bulb_temperature")]
public System.Nullable<float> DesignEnteringAirWetBulbTemperature { get; set; } = null;
        

[JsonProperty("capacity_control")]
public EvaporativeFluidCooler_SingleSpeed_CapacityControl CapacityControl { get; set; } = (EvaporativeFluidCooler_SingleSpeed_CapacityControl)Enum.Parse(typeof(EvaporativeFluidCooler_SingleSpeed_CapacityControl), "FanCycling");
        

[Description("Multiplies the autosized capacity and flow rates")]
[JsonProperty("sizing_factor")]
public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("evaporation_loss_mode")]
public EvaporativeFluidCooler_SingleSpeed_EvaporationLossMode EvaporationLossMode { get; set; } = (EvaporativeFluidCooler_SingleSpeed_EvaporationLossMode)Enum.Parse(typeof(EvaporativeFluidCooler_SingleSpeed_EvaporationLossMode), "SaturatedExit");
        

[Description("Rate of water evaporation from the Fluid Cooler and lost to the outdoor air [%/K]" +
    " Empirical correlation is used to calculate default loss factor if it not explic" +
    "itly provided.")]
[JsonProperty("evaporation_loss_factor")]
public System.Nullable<float> EvaporationLossFactor { get; set; } = null;
        

[Description("Rate of drift loss as a percentage of circulating spray water flow rate Default v" +
    "alue for this field is under investigation. For now Cooling tower\'s drift loss p" +
    "ercent default value is taken here.")]
[JsonProperty("drift_loss_percent")]
public System.Nullable<float> DriftLossPercent { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty("blowdown_calculation_mode")]
public EvaporativeFluidCooler_SingleSpeed_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (EvaporativeFluidCooler_SingleSpeed_BlowdownCalculationMode)Enum.Parse(typeof(EvaporativeFluidCooler_SingleSpeed_BlowdownCalculationMode), "ConcentrationRatio");
        

[Description(@"Characterizes the rate of blowdown in the Evaporative Fluid Cooler. Blowdown is water intentionally drained from the basin in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Default value for this field is under investigation. For now Cooling tower's Blowdown Concentration Ratio percent default value is taken here.")]
[JsonProperty("blowdown_concentration_ratio")]
public System.Nullable<float> BlowdownConcentrationRatio { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"Makeup water usage due to blowdown results from occasionally draining a small amount of water in the Fluid Cooler basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
[JsonProperty("blowdown_makeup_water_usage_schedule_name")]
public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
    }
    
    public enum EvaporativeFluidCooler_SingleSpeed_PerformanceInputMethod
    {
        
        [JsonProperty("StandardDesignCapacity")]
        StandardDesignCapacity = 0,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 1,
        
        [JsonProperty("UserSpecifiedDesignCapacity")]
        UserSpecifiedDesignCapacity = 2,
    }
    
    public enum EvaporativeFluidCooler_SingleSpeed_CapacityControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FanCycling")]
        FanCycling = 1,
        
        [JsonProperty("FluidBypass")]
        FluidBypass = 2,
    }
    
    public enum EvaporativeFluidCooler_SingleSpeed_EvaporationLossMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LossFactor")]
        LossFactor = 1,
        
        [JsonProperty("SaturatedExit")]
        SaturatedExit = 2,
    }
    
    public enum EvaporativeFluidCooler_SingleSpeed_BlowdownCalculationMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConcentrationRatio")]
        ConcentrationRatio = 1,
        
        [JsonProperty("ScheduledRate")]
        ScheduledRate = 2,
    }
    
    [Description("This model is based on Merkel\'s theory, which is also the basis for the cooling t" +
        "ower model in EnergyPlus. The Evaporative fluid cooler is modeled as a counter f" +
        "low heat exchanger.")]
    [JsonObject("EvaporativeFluidCooler:TwoSpeed")]
    public class EvaporativeFluidCooler_TwoSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Name of fluid cooler water inlet node")]
[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[Description("Name of fluid cooler water outlet node")]
[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("high_fan_speed_air_flow_rate")]
public string HighFanSpeedAirFlowRate { get; set; } = "";
        

[Description("This is the fan motor electric input power at high speed")]
[JsonProperty("high_fan_speed_fan_power")]
public string HighFanSpeedFanPower { get; set; } = "";
        

[Description("Low speed air flow rate must be less than high speed air flow rate")]
[JsonProperty("low_fan_speed_air_flow_rate")]
public string LowFanSpeedAirFlowRate { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate")]
[JsonProperty("low_fan_speed_air_flow_rate_sizing_factor")]
public System.Nullable<float> LowFanSpeedAirFlowRateSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("This is the fan motor electric input power at low speed")]
[JsonProperty("low_fan_speed_fan_power")]
public string LowFanSpeedFanPower { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate.")]
[JsonProperty("low_fan_speed_fan_power_sizing_factor")]
public System.Nullable<float> LowFanSpeedFanPowerSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.16", CultureInfo.InvariantCulture);
        

[JsonProperty("design_spray_water_flow_rate")]
public System.Nullable<float> DesignSprayWaterFlowRate { get; set; } = null;
        

[Description("User can define fluid cooler thermal performance by specifying the fluid cooler U" +
    "A and the Design Water Flow Rate, or by specifying the fluid cooler Standard Des" +
    "ign Capacity or by specifying Design Capacity for Non standard conditions.")]
[JsonProperty("performance_input_method")]
public EvaporativeFluidCooler_TwoSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (EvaporativeFluidCooler_TwoSpeed_PerformanceInputMethod)Enum.Parse(typeof(EvaporativeFluidCooler_TwoSpeed_PerformanceInputMethod), "StandardDesignCapacity");
        

[Description("Enter the name of an outdoor air node")]
[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("heat_rejection_capacity_and_nominal_capacity_sizing_ratio")]
public System.Nullable<float> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"Standard design capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt (3 gpm/ton). Standard design capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual fluid cooler heat rejection at these operating conditions. Only used for Performance Input Method = StandardDesignCapacity; for other input methods, this field is ignored. The standard conditions mentioned above for Standard design capacity are already specified in the EnergyPlus. So the input fields such as design entering water temp., design entering air wet-bulb and dry-bulb temp. and design water flow rate, if provided in the input, will be ignored for the StandardDesignCapacity performance input method. Also, the standard conditions are for water as a fluid type so this performance input method can only be used with water as a fluid type (as specified in CondenserLoop object).")]
[JsonProperty("high_speed_standard_design_capacity")]
public System.Nullable<float> HighSpeedStandardDesignCapacity { get; set; } = null;
        

[Description(@"Standard design capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt (3 gpm/ton). Standard design capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual fluid cooler heat rejection at these operating conditions. Only used for Performance Input Method = StandardDesignCapacity; for other input methods, this field is ignored. The standard conditions mentioned above for Standard design capacity are already specified in the EnergyPlus. So the input fields such as design entering water temp., design entering air wet-bulb and dry-bulb temp. and design water flow rate, if provided in the input, will be ignored for the StandardDesignCapacity performance input method. Also, the standard conditions are for water as a fluid type so this performance input method can only be used with water as a fluid type (as specified in CondenserLoop object).")]
[JsonProperty("low_speed_standard_design_capacity")]
public string LowSpeedStandardDesignCapacity { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate")]
[JsonProperty("low_speed_standard_capacity_sizing_factor")]
public System.Nullable<float> LowSpeedStandardCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Only used for Performance Input Method = UFactorTimesAreaAndDesignWaterFlowRate; " +
    "for other Performance Input Methods, this field is ignored.")]
[JsonProperty("high_fan_speed_u_factor_times_area_value")]
public string HighFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

[Description("Only used for Performance Input Method = UFactorTimesAreaAndDesignWaterFlowRate; " +
    "for other input methods, this field is ignored. Low speed fluid cooler UA must b" +
    "e less than high speed fluid cooler UA")]
[JsonProperty("low_fan_speed_u_factor_times_area_value")]
public string LowFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate and the Per" +
    "formance Input Method is UFactorTimesAreaAndDesignWaterFlowRate")]
[JsonProperty("low_fan_speed_u_factor_times_area_sizing_factor")]
public System.Nullable<float> LowFanSpeedUFactorTimesAreaSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.6", CultureInfo.InvariantCulture);
        

[Description("Input value is ignored if fluid cooler Performance Input Method= StandardDesignCa" +
    "pacity")]
[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = "";
        

[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
    "erformance Input Methods, this field is ignored.")]
[JsonProperty("high_speed_user_specified_design_capacity")]
public System.Nullable<float> HighSpeedUserSpecifiedDesignCapacity { get; set; } = null;
        

[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
    "erformance Input Methods, this field is ignored.")]
[JsonProperty("low_speed_user_specified_design_capacity")]
public string LowSpeedUserSpecifiedDesignCapacity { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate")]
[JsonProperty("low_speed_user_specified_design_capacity_sizing_factor")]
public System.Nullable<float> LowSpeedUserSpecifiedDesignCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
    "erformance Input Methods, this field is ignored. Design Entering Water Temperatu" +
    "re must be greater than Design Entering Air Temperature.")]
[JsonProperty("design_entering_water_temperature")]
public System.Nullable<float> DesignEnteringWaterTemperature { get; set; } = null;
        

[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
    "erformance Input Methods, this field is ignored. Design Entering Air Temperature" +
    " must be greater than Design Entering Air Wet-bulb Temperature.")]
[JsonProperty("design_entering_air_temperature")]
public System.Nullable<float> DesignEnteringAirTemperature { get; set; } = null;
        

[Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
    "erformance Input Methods, this field is ignored. Design Entering Air Wet-bulb Te" +
    "mperature must be less than Design Entering Air Temperature.")]
[JsonProperty("design_entering_air_wet_bulb_temperature")]
public System.Nullable<float> DesignEnteringAirWetBulbTemperature { get; set; } = null;
        

[Description("Multiplies the autosized capacity and flow rates")]
[JsonProperty("high_speed_sizing_factor")]
public System.Nullable<float> HighSpeedSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("evaporation_loss_mode")]
public EvaporativeFluidCooler_TwoSpeed_EvaporationLossMode EvaporationLossMode { get; set; } = (EvaporativeFluidCooler_TwoSpeed_EvaporationLossMode)Enum.Parse(typeof(EvaporativeFluidCooler_TwoSpeed_EvaporationLossMode), "SaturatedExit");
        

[Description("Rate of water evaporation from the Fluid Cooler and lost to the outdoor air [%/K]" +
    " Empirical correlation is used to calculate default loss factor if it not explic" +
    "itly provided.")]
[JsonProperty("evaporation_loss_factor")]
public System.Nullable<float> EvaporationLossFactor { get; set; } = null;
        

[Description("Default value is under investigation. For now cooling tower\'s default value is ta" +
    "ken.")]
[JsonProperty("drift_loss_percent")]
public System.Nullable<float> DriftLossPercent { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty("blowdown_calculation_mode")]
public EvaporativeFluidCooler_TwoSpeed_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (EvaporativeFluidCooler_TwoSpeed_BlowdownCalculationMode)Enum.Parse(typeof(EvaporativeFluidCooler_TwoSpeed_BlowdownCalculationMode), "ConcentrationRatio");
        

[Description(@"Characterizes the rate of blowdown in the Evaporative Fluid Cooler. Blowdown is water intentionally drained from the Evaporative Fluid Cooler in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Default value is under investigation. For now cooling tower's default value is taken.")]
[JsonProperty("blowdown_concentration_ratio")]
public System.Nullable<float> BlowdownConcentrationRatio { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"Makeup water usage due to blowdown results from occasionally draining some amount of water in the Evaporative Fluid Cooler basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
[JsonProperty("blowdown_makeup_water_usage_schedule_name")]
public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
    }
    
    public enum EvaporativeFluidCooler_TwoSpeed_PerformanceInputMethod
    {
        
        [JsonProperty("StandardDesignCapacity")]
        StandardDesignCapacity = 0,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 1,
        
        [JsonProperty("UserSpecifiedDesignCapacity")]
        UserSpecifiedDesignCapacity = 2,
    }
    
    public enum EvaporativeFluidCooler_TwoSpeed_EvaporationLossMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LossFactor")]
        LossFactor = 1,
        
        [JsonProperty("SaturatedExit")]
        SaturatedExit = 2,
    }
    
    public enum EvaporativeFluidCooler_TwoSpeed_BlowdownCalculationMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConcentrationRatio")]
        ConcentrationRatio = 1,
        
        [JsonProperty("ScheduledRate")]
        ScheduledRate = 2,
    }
    
    [Description("The fluid cooler is modeled as a cross flow heat exchanger (both streams unmixed)" +
        " with single-speed fans (induced draft configuration).")]
    [JsonObject("FluidCooler:SingleSpeed")]
    public class FluidCooler_SingleSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Name of fluid cooler water inlet node")]
[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[Description("Name of fluid cooler water outlet node")]
[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[Description("User can define fluid cooler thermal performance by specifying the fluid cooler U" +
    "A and the Design Water Flow Rate, or by specifying the fluid cooler nominal capa" +
    "city")]
[JsonProperty("performance_input_method")]
public FluidCooler_SingleSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (FluidCooler_SingleSpeed_PerformanceInputMethod)Enum.Parse(typeof(FluidCooler_SingleSpeed_PerformanceInputMethod), "NominalCapacity");
        

[Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity")]
[JsonProperty("design_air_flow_rate_u_factor_times_area_value")]
public string DesignAirFlowRateUFactorTimesAreaValue { get; set; } = "";
        

[Description("Nominal fluid cooler capacity")]
[JsonProperty("nominal_capacity")]
public System.Nullable<float> NominalCapacity { get; set; } = null;
        

[Description("Design Entering Water Temperature must be specified for both the performance inpu" +
    "t methods and its value must be greater than Design Entering Air Temperature.")]
[JsonProperty("design_entering_water_temperature")]
public System.Nullable<float> DesignEnteringWaterTemperature { get; set; } = null;
        

[Description("Design Entering Air Temperature must be specified for both the performance input " +
    "methods and its value must be greater than Design Entering Air Wet-bulb Temperat" +
    "ure.")]
[JsonProperty("design_entering_air_temperature")]
public System.Nullable<float> DesignEnteringAirTemperature { get; set; } = null;
        

[Description("Design Entering Air Wet-bulb Temperature must be specified for both the performan" +
    "ce input methods and its value must be less than Design Entering Air Temperature" +
    ".")]
[JsonProperty("design_entering_air_wetbulb_temperature")]
public System.Nullable<float> DesignEnteringAirWetbulbTemperature { get; set; } = null;
        

[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = "";
        

[JsonProperty("design_air_flow_rate")]
public string DesignAirFlowRate { get; set; } = "";
        

[Description("This is the fan motor electric input power")]
[JsonProperty("design_air_flow_rate_fan_power")]
public string DesignAirFlowRateFanPower { get; set; } = "";
        

[Description("Enter the name of an outdoor air node")]
[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
    }
    
    public enum FluidCooler_SingleSpeed_PerformanceInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NominalCapacity")]
        NominalCapacity = 1,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
    
    [Description("The fluid cooler is modeled as a cross flow heat exchanger (both streams unmixed)" +
        " with two-speed fans (induced draft configuration).")]
    [JsonObject("FluidCooler:TwoSpeed")]
    public class FluidCooler_TwoSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Name of fluid cooler water inlet node")]
[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[Description("Name of fluid cooler water outlet node")]
[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[Description("User can define fluid cooler thermal performance by specifying the fluid cooler U" +
    "A and the Design Water Flow Rate, or by specifying the fluid cooler nominal capa" +
    "city")]
[JsonProperty("performance_input_method")]
public FluidCooler_TwoSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (FluidCooler_TwoSpeed_PerformanceInputMethod)Enum.Parse(typeof(FluidCooler_TwoSpeed_PerformanceInputMethod), "NominalCapacity");
        

[Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity")]
[JsonProperty("high_fan_speed_u_factor_times_area_value")]
public string HighFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

[Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity Low" +
    " speed fluid cooler UA must be less than high speed fluid cooler UA Low speed fl" +
    "uid cooler UA must be greater than free convection fluid cooler UA")]
[JsonProperty("low_fan_speed_u_factor_times_area_value")]
public string LowFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate and the Per" +
    "formance Input Method is UFactorTimesAreaAndDesignWaterFlowRate")]
[JsonProperty("low_fan_speed_u_factor_times_area_sizing_factor")]
public System.Nullable<float> LowFanSpeedUFactorTimesAreaSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.6", CultureInfo.InvariantCulture);
        

[Description("Nominal fluid cooler capacity at high fan speed")]
[JsonProperty("high_speed_nominal_capacity")]
public System.Nullable<float> HighSpeedNominalCapacity { get; set; } = null;
        

[Description("Nominal fluid cooler capacity at low fan speed")]
[JsonProperty("low_speed_nominal_capacity")]
public string LowSpeedNominalCapacity { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate and the Per" +
    "formance Input Method is NominalCapacity")]
[JsonProperty("low_speed_nominal_capacity_sizing_factor")]
public System.Nullable<float> LowSpeedNominalCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Design Entering Water Temperature must be specified for both the performance inpu" +
    "t methods and its value must be greater than Design Entering Air Temperature.")]
[JsonProperty("design_entering_water_temperature")]
public System.Nullable<float> DesignEnteringWaterTemperature { get; set; } = null;
        

[Description("Design Entering Air Temperature must be specified for both the performance input " +
    "methods and its value must be greater than Design Entering Air Wet-bulb Temperat" +
    "ure.")]
[JsonProperty("design_entering_air_temperature")]
public System.Nullable<float> DesignEnteringAirTemperature { get; set; } = null;
        

[Description("Design Entering Air Wet-bulb Temperature must be specified for both the performan" +
    "ce input methods and its value must be less than Design Entering Air Temperature" +
    ".")]
[JsonProperty("design_entering_air_wet_bulb_temperature")]
public System.Nullable<float> DesignEnteringAirWetBulbTemperature { get; set; } = null;
        

[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = "";
        

[Description("Air Flow Rate at High Fan Speed must be greater than Air Flow Rate at Low Fan Spe" +
    "ed")]
[JsonProperty("high_fan_speed_air_flow_rate")]
public string HighFanSpeedAirFlowRate { get; set; } = "";
        

[Description("This is the fan motor electric input power at high speed")]
[JsonProperty("high_fan_speed_fan_power")]
public string HighFanSpeedFanPower { get; set; } = "";
        

[Description("Air Flow Rate at Low Fan Speed must be less than Air Flow Rate at High Fan Speed")]
[JsonProperty("low_fan_speed_air_flow_rate")]
public string LowFanSpeedAirFlowRate { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate.")]
[JsonProperty("low_fan_speed_air_flow_rate_sizing_factor")]
public System.Nullable<float> LowFanSpeedAirFlowRateSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("This is the fan motor electric input power at low speed")]
[JsonProperty("low_fan_speed_fan_power")]
public string LowFanSpeedFanPower { get; set; } = "";
        

[Description("This field is only used if the previous field is set to autocalculate.")]
[JsonProperty("low_fan_speed_fan_power_sizing_factor")]
public System.Nullable<float> LowFanSpeedFanPowerSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.16", CultureInfo.InvariantCulture);
        

[JsonProperty("outdoor_air_inlet_node_name")]
public string OutdoorAirInletNodeName { get; set; } = "";
    }
    
    public enum FluidCooler_TwoSpeed_PerformanceInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NominalCapacity")]
        NominalCapacity = 1,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
    
    [Description("Models vertical ground heat exchangers systems using the response factor approach" +
        " developed by Eskilson. Response factors are calculated using a finite line sour" +
        "ce model assuming uniform heat flux at the borehole wall.")]
    [JsonObject("GroundHeatExchanger:System")]
    public class GroundHeatExchanger_System : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("design_flow_rate")]
public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

[JsonProperty("undisturbed_ground_temperature_model_type")]
public GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

[JsonProperty("undisturbed_ground_temperature_model_name")]
public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

[JsonProperty("ground_thermal_conductivity")]
public System.Nullable<float> GroundThermalConductivity { get; set; } = null;
        

[JsonProperty("ground_thermal_heat_capacity")]
public System.Nullable<float> GroundThermalHeatCapacity { get; set; } = null;
        

[JsonProperty("ghe_vertical_responsefactors_object_name")]
public string GheVerticalResponsefactorsObjectName { get; set; } = "";
        

[JsonProperty("ghe_vertical_array_object_name")]
public string GheVerticalArrayObjectName { get; set; } = "";
        

[JsonProperty("vertical_well_locations")]
public string VerticalWellLocations { get; set; } = "";
    }
    
    public enum GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType
    {
        
        [JsonProperty("Site:GroundTemperature:Undisturbed:FiniteDifference")]
        SiteGroundTemperatureUndisturbedFiniteDifference = 0,
        
        [JsonProperty("Site:GroundTemperature:Undisturbed:KusudaAchenbach")]
        SiteGroundTemperatureUndisturbedKusudaAchenbach = 1,
        
        [JsonProperty("Site:GroundTemperature:Undisturbed:Xing")]
        SiteGroundTemperatureUndisturbedXing = 2,
    }
    
    [Description("Properties for vertical ground heat exchanger systems")]
    [JsonObject("GroundHeatExchanger:Vertical:Properties")]
    public class GroundHeatExchanger_Vertical_Properties : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("depth_of_top_of_borehole")]
public System.Nullable<float> DepthOfTopOfBorehole { get; set; } = null;
        

[JsonProperty("borehole_length")]
public System.Nullable<float> BoreholeLength { get; set; } = null;
        

[JsonProperty("borehole_diameter")]
public System.Nullable<float> BoreholeDiameter { get; set; } = null;
        

[JsonProperty("grout_thermal_conductivity")]
public System.Nullable<float> GroutThermalConductivity { get; set; } = null;
        

[JsonProperty("grout_thermal_heat_capacity")]
public System.Nullable<float> GroutThermalHeatCapacity { get; set; } = null;
        

[JsonProperty("pipe_thermal_conductivity")]
public System.Nullable<float> PipeThermalConductivity { get; set; } = null;
        

[JsonProperty("pipe_thermal_heat_capacity")]
public System.Nullable<float> PipeThermalHeatCapacity { get; set; } = null;
        

[JsonProperty("pipe_outer_diameter")]
public System.Nullable<float> PipeOuterDiameter { get; set; } = null;
        

[JsonProperty("pipe_thickness")]
public System.Nullable<float> PipeThickness { get; set; } = null;
        

[JsonProperty("u_tube_distance")]
public System.Nullable<float> UTubeDistance { get; set; } = null;
    }
    
    [Description(null)]
    [JsonObject("GroundHeatExchanger:Vertical:Array")]
    public class GroundHeatExchanger_Vertical_Array : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("ghe_vertical_properties_object_name")]
public string GheVerticalPropertiesObjectName { get; set; } = "";
        

[JsonProperty("number_of_boreholes_in_x_direction")]
public System.Nullable<float> NumberOfBoreholesInXDirection { get; set; } = null;
        

[JsonProperty("number_of_boreholes_in_y_direction")]
public System.Nullable<float> NumberOfBoreholesInYDirection { get; set; } = null;
        

[JsonProperty("borehole_spacing")]
public System.Nullable<float> BoreholeSpacing { get; set; } = null;
    }
    
    [Description(null)]
    [JsonObject("GroundHeatExchanger:Vertical:Single")]
    public class GroundHeatExchanger_Vertical_Single : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("ghe_vertical_properties_object_name")]
public string GheVerticalPropertiesObjectName { get; set; } = "";
        

[JsonProperty("x_location")]
public System.Nullable<float> XLocation { get; set; } = null;
        

[JsonProperty("y_location")]
public System.Nullable<float> YLocation { get; set; } = null;
    }
    
    [Description("Response factor definitions from third-party tool, commonly referred to a \"g-func" +
        "tions\"")]
    [JsonObject("GroundHeatExchanger:ResponseFactors")]
    public class GroundHeatExchanger_ResponseFactors : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("ghe_vertical_properties_object_name")]
public string GheVerticalPropertiesObjectName { get; set; } = "";
        

[JsonProperty("number_of_boreholes")]
public System.Nullable<float> NumberOfBoreholes { get; set; } = null;
        

[JsonProperty("g_function_reference_ratio")]
public System.Nullable<float> GFunctionReferenceRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.0005", CultureInfo.InvariantCulture);
        

[JsonProperty("g_functions")]
public string GFunctions { get; set; } = "";
    }
    
    [Description("A model of a shallow pond with immersed pipe loops. Typically used in hybrid geot" +
        "hermal systems and included in the condenser loop. This component may also be us" +
        "ed as a simple solar collector.")]
    [JsonObject("GroundHeatExchanger:Pond")]
    public class GroundHeatExchanger_Pond : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("fluid_inlet_node_name")]
public string FluidInletNodeName { get; set; } = "";
        

[JsonProperty("fluid_outlet_node_name")]
public string FluidOutletNodeName { get; set; } = "";
        

[JsonProperty("pond_depth")]
public System.Nullable<float> PondDepth { get; set; } = null;
        

[JsonProperty("pond_area")]
public System.Nullable<float> PondArea { get; set; } = null;
        

[JsonProperty("hydronic_tubing_inside_diameter")]
public System.Nullable<float> HydronicTubingInsideDiameter { get; set; } = null;
        

[JsonProperty("hydronic_tubing_outside_diameter")]
public System.Nullable<float> HydronicTubingOutsideDiameter { get; set; } = null;
        

[JsonProperty("hydronic_tubing_thermal_conductivity")]
public System.Nullable<float> HydronicTubingThermalConductivity { get; set; } = null;
        

[JsonProperty("ground_thermal_conductivity")]
public System.Nullable<float> GroundThermalConductivity { get; set; } = null;
        

[JsonProperty("number_of_tubing_circuits")]
public System.Nullable<float> NumberOfTubingCircuits { get; set; } = null;
        

[JsonProperty("length_of_each_tubing_circuit")]
public System.Nullable<float> LengthOfEachTubingCircuit { get; set; } = null;
    }
    
    [Description(@"A hydronic surface/panel consisting of a multi-layer construction with embedded rows of tubes. Typically used in hybrid geothermal systems and included in the condenser loop. This component may also be used as a simple solar collector. The bottom surface may be defined as ground-coupled or exposed to wind (eg. bridge deck).")]
    [JsonObject("GroundHeatExchanger:Surface")]
    public class GroundHeatExchanger_Surface : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[JsonProperty("fluid_inlet_node_name")]
public string FluidInletNodeName { get; set; } = "";
        

[JsonProperty("fluid_outlet_node_name")]
public string FluidOutletNodeName { get; set; } = "";
        

[JsonProperty("hydronic_tubing_inside_diameter")]
public System.Nullable<float> HydronicTubingInsideDiameter { get; set; } = null;
        

[JsonProperty("number_of_tubing_circuits")]
public System.Nullable<float> NumberOfTubingCircuits { get; set; } = null;
        

[JsonProperty("hydronic_tube_spacing")]
public System.Nullable<float> HydronicTubeSpacing { get; set; } = null;
        

[JsonProperty("surface_length")]
public System.Nullable<float> SurfaceLength { get; set; } = null;
        

[JsonProperty("surface_width")]
public System.Nullable<float> SurfaceWidth { get; set; } = null;
        

[JsonProperty("lower_surface_environment")]
public GroundHeatExchanger_Surface_LowerSurfaceEnvironment LowerSurfaceEnvironment { get; set; } = (GroundHeatExchanger_Surface_LowerSurfaceEnvironment)Enum.Parse(typeof(GroundHeatExchanger_Surface_LowerSurfaceEnvironment), "Ground");
    }
    
    public enum GroundHeatExchanger_Surface_LowerSurfaceEnvironment
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Exposed")]
        Exposed = 1,
        
        [JsonProperty("Ground")]
        Ground = 2,
    }
    
    [Description("This models a horizontal heat exchanger placed in a series of trenches The model " +
        "uses the PipingSystem:Underground underlying algorithms, but provides a more usa" +
        "ble input interface.")]
    [JsonObject("GroundHeatExchanger:HorizontalTrench")]
    public class GroundHeatExchanger_HorizontalTrench : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("design_flow_rate")]
public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

[Description("This is the total pipe axial length of the heat exchanger If all pipe trenches ar" +
    "e parallel, this is the length of a single trench. If a single, long run of pipe" +
    " is used with one trench, this is the full length of the pipe run.")]
[JsonProperty("trench_length_in_pipe_axial_direction")]
public System.Nullable<float> TrenchLengthInPipeAxialDirection { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description("This is the number of horizontal legs that will be used in the entire heat exchan" +
    "ger, one pipe per trench")]
[JsonProperty("number_of_trenches")]
public System.Nullable<float> NumberOfTrenches { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This represents the average horizontal spacing between any two trenches for heat " +
    "exchangers that have multiple trenches")]
[JsonProperty("horizontal_spacing_between_pipes")]
public System.Nullable<float> HorizontalSpacingBetweenPipes { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_inner_diameter")]
public System.Nullable<float> PipeInnerDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.016", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_outer_diameter")]
public System.Nullable<float> PipeOuterDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.026", CultureInfo.InvariantCulture);
        

[Description("This is the burial depth of the pipes, or the trenches containing the pipes")]
[JsonProperty("burial_depth")]
public System.Nullable<float> BurialDepth { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_thermal_conductivity")]
public System.Nullable<float> SoilThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("1.08", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_density")]
public System.Nullable<float> SoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("962", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_specific_heat")]
public System.Nullable<float> SoilSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("2576", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_thermal_conductivity")]
public System.Nullable<float> PipeThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.3895", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_density")]
public System.Nullable<float> PipeDensity { get; set; } = (System.Nullable<float>)Single.Parse("641", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_specific_heat")]
public System.Nullable<float> PipeSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("2405", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_moisture_content_percent")]
public System.Nullable<float> SoilMoistureContentPercent { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_moisture_content_percent_at_saturation")]
public System.Nullable<float> SoilMoistureContentPercentAtSaturation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[JsonProperty("undisturbed_ground_temperature_model_type")]
public GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

[JsonProperty("undisturbed_ground_temperature_model_name")]
public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

[Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
[JsonProperty("evapotranspiration_ground_cover_parameter")]
public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
    }
    
    public enum GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType
    {
        
        [JsonProperty("Site:GroundTemperature:Undisturbed:FiniteDifference")]
        SiteGroundTemperatureUndisturbedFiniteDifference = 0,
        
        [JsonProperty("Site:GroundTemperature:Undisturbed:KusudaAchenbach")]
        SiteGroundTemperatureUndisturbedKusudaAchenbach = 1,
        
        [JsonProperty("Site:GroundTemperature:Undisturbed:Xing")]
        SiteGroundTemperatureUndisturbedXing = 2,
    }
    
    [Description(@"This models a slinky horizontal heat exchanger placed in a series of trenches The model uses the model developed by: Xiong, Z., D.E. Fisher, and J.D. Spitler. 2015. Development and Validation of a Slinky Ground Heat Exchanger Model. Applied Energy 141: 57-69.")]
    [JsonObject("GroundHeatExchanger:Slinky")]
    public class GroundHeatExchanger_Slinky : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("design_flow_rate")]
public System.Nullable<float> DesignFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0.002", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_thermal_conductivity")]
public System.Nullable<float> SoilThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("1.08", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_density")]
public System.Nullable<float> SoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("962", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_specific_heat")]
public System.Nullable<float> SoilSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("2576", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_thermal_conductivity")]
public System.Nullable<float> PipeThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_density")]
public System.Nullable<float> PipeDensity { get; set; } = (System.Nullable<float>)Single.Parse("641", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_specific_heat")]
public System.Nullable<float> PipeSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("2405", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_outer_diameter")]
public System.Nullable<float> PipeOuterDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.02667", CultureInfo.InvariantCulture);
        

[JsonProperty("pipe_thickness")]
public System.Nullable<float> PipeThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.002413", CultureInfo.InvariantCulture);
        

[Description("This is the orientation of the heat exchanger")]
[JsonProperty("heat_exchanger_configuration")]
public GroundHeatExchanger_Slinky_HeatExchangerConfiguration HeatExchangerConfiguration { get; set; } = (GroundHeatExchanger_Slinky_HeatExchangerConfiguration)Enum.Parse(typeof(GroundHeatExchanger_Slinky_HeatExchangerConfiguration), "Horizontal");
        

[Description("This is the diameter of the heat exchanger coil")]
[JsonProperty("coil_diameter")]
public System.Nullable<float> CoilDiameter { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This is the center-to-center distance between coils")]
[JsonProperty("coil_pitch")]
public System.Nullable<float> CoilPitch { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("This is the distance from the ground surface to the trench bottom")]
[JsonProperty("trench_depth")]
public System.Nullable<float> TrenchDepth { get; set; } = (System.Nullable<float>)Single.Parse("1.8", CultureInfo.InvariantCulture);
        

[Description("This is the total length of a single trench This assumes the heat exchanger runs " +
    "the full length of the trench")]
[JsonProperty("trench_length")]
public System.Nullable<float> TrenchLength { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("This is the number of parallel trenches that has a heat exchanger, one per trench" +
    "")]
[JsonProperty("number_of_trenches")]
public System.Nullable<float> NumberOfTrenches { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This represents the average horizontal spacing between any two trenches for heat " +
    "exchangers that have multiple trenches")]
[JsonProperty("horizontal_spacing_between_pipes")]
public System.Nullable<float> HorizontalSpacingBetweenPipes { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[JsonProperty("undisturbed_ground_temperature_model_type")]
public GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

[JsonProperty("undisturbed_ground_temperature_model_name")]
public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

[JsonProperty("maximum_length_of_simulation")]
public System.Nullable<float> MaximumLengthOfSimulation { get; set; } = null;
    }
    
    public enum GroundHeatExchanger_Slinky_HeatExchangerConfiguration
    {
        
        [JsonProperty("Horizontal")]
        Horizontal = 0,
        
        [JsonProperty("Vertical")]
        Vertical = 1,
    }
    
    public enum GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType
    {
        
        [JsonProperty("Site:GroundTemperature:Undisturbed:FiniteDifference")]
        SiteGroundTemperatureUndisturbedFiniteDifference = 0,
        
        [JsonProperty("Site:GroundTemperature:Undisturbed:KusudaAchenbach")]
        SiteGroundTemperatureUndisturbedKusudaAchenbach = 1,
        
        [JsonProperty("Site:GroundTemperature:Undisturbed:Xing")]
        SiteGroundTemperatureUndisturbedXing = 2,
    }
    
    [Description("A fluid/fluid heat exchanger designed to couple the supply side of one loop to th" +
        "e demand side of another loop Loops can be either plant or condenser loops but n" +
        "o air side connections are allowed")]
    [JsonObject("HeatExchanger:FluidToFluid")]
    public class HeatExchanger_FluidToFluid : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available. default is " +
    "that heat exchanger is on")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("This connection is to the demand side of a loop and is the inlet to the heat exch" +
    "anger")]
[JsonProperty("loop_demand_side_inlet_node_name")]
public string LoopDemandSideInletNodeName { get; set; } = "";
        

[Description("This connection is to the demand side of a loop")]
[JsonProperty("loop_demand_side_outlet_node_name")]
public string LoopDemandSideOutletNodeName { get; set; } = "";
        

[JsonProperty("loop_demand_side_design_flow_rate")]
public string LoopDemandSideDesignFlowRate { get; set; } = "";
        

[JsonProperty("loop_supply_side_inlet_node_name")]
public string LoopSupplySideInletNodeName { get; set; } = "";
        

[JsonProperty("loop_supply_side_outlet_node_name")]
public string LoopSupplySideOutletNodeName { get; set; } = "";
        

[JsonProperty("loop_supply_side_design_flow_rate")]
public string LoopSupplySideDesignFlowRate { get; set; } = "";
        

[JsonProperty("heat_exchange_model_type")]
public HeatExchanger_FluidToFluid_HeatExchangeModelType HeatExchangeModelType { get; set; } = (HeatExchanger_FluidToFluid_HeatExchangeModelType)Enum.Parse(typeof(HeatExchanger_FluidToFluid_HeatExchangeModelType), "Ideal");
        

[JsonProperty("heat_exchanger_u_factor_times_area_value")]
public string HeatExchangerUFactorTimesAreaValue { get; set; } = "";
        

[JsonProperty("control_type")]
public HeatExchanger_FluidToFluid_ControlType ControlType { get; set; } = (HeatExchanger_FluidToFluid_ControlType)Enum.Parse(typeof(HeatExchanger_FluidToFluid_ControlType), "UncontrolledOn");
        

[Description("Setpoint node is needed with any Control Type that is \"*Setpoint*\"")]
[JsonProperty("heat_exchanger_setpoint_node_name")]
public string HeatExchangerSetpointNodeName { get; set; } = "";
        

[Description("Tolerance between control temperatures used to determine if heat exchanger should" +
    " run.")]
[JsonProperty("minimum_temperature_difference_to_activate_heat_exchanger")]
public System.Nullable<float> MinimumTemperatureDifferenceToActivateHeatExchanger { get; set; } = (System.Nullable<float>)Single.Parse("0.01", CultureInfo.InvariantCulture);
        

[Description("This field controls end use reporting for heat transfer meters")]
[JsonProperty("heat_transfer_metering_end_use_type")]
public HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType HeatTransferMeteringEndUseType { get; set; } = (HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType)Enum.Parse(typeof(HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType), "LoopToLoop");
        

[Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithCompone" +
    "ntOverride")]
[JsonProperty("component_override_loop_supply_side_inlet_node_name")]
public string ComponentOverrideLoopSupplySideInletNodeName { get; set; } = "";
        

[Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithCompone" +
    "ntOverride")]
[JsonProperty("component_override_loop_demand_side_inlet_node_name")]
public string ComponentOverrideLoopDemandSideInletNodeName { get; set; } = "";
        

[Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithCompone" +
    "ntOverride")]
[JsonProperty("component_override_cooling_control_temperature_mode")]
public HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode ComponentOverrideCoolingControlTemperatureMode { get; set; } = (HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode)Enum.Parse(typeof(HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode), "Loop");
        

[Description("Multiplies the autosized flow rates for this device")]
[JsonProperty("sizing_factor")]
public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Lower limit on inlet temperatures, heat exchanger will not operate if either inle" +
    "t is below this limit")]
[JsonProperty("operation_minimum_temperature_limit")]
public System.Nullable<float> OperationMinimumTemperatureLimit { get; set; } = null;
        

[Description("Upper limit on inlet temperatures, heat exchanger will not operate if either inle" +
    "t is above this limit")]
[JsonProperty("operation_maximum_temperature_limit")]
public System.Nullable<float> OperationMaximumTemperatureLimit { get; set; } = null;
    }
    
    public enum HeatExchanger_FluidToFluid_HeatExchangeModelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CounterFlow")]
        CounterFlow = 1,
        
        [JsonProperty("CrossFlowBothMixed")]
        CrossFlowBothMixed = 2,
        
        [JsonProperty("CrossFlowBothUnMixed")]
        CrossFlowBothUnMixed = 3,
        
        [JsonProperty("CrossFlowSupplyMixedDemandUnMixed")]
        CrossFlowSupplyMixedDemandUnMixed = 4,
        
        [JsonProperty("CrossFlowSupplyUnMixedDemandMixed")]
        CrossFlowSupplyUnMixedDemandMixed = 5,
        
        [JsonProperty("Ideal")]
        Ideal = 6,
        
        [JsonProperty("ParallelFlow")]
        ParallelFlow = 7,
    }
    
    public enum HeatExchanger_FluidToFluid_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolingDifferentialOnOff")]
        CoolingDifferentialOnOff = 1,
        
        [JsonProperty("CoolingSetpointModulated")]
        CoolingSetpointModulated = 2,
        
        [JsonProperty("CoolingSetpointOnOff")]
        CoolingSetpointOnOff = 3,
        
        [JsonProperty("CoolingSetpointOnOffWithComponentOverride")]
        CoolingSetpointOnOffWithComponentOverride = 4,
        
        [JsonProperty("DualDeadbandSetpointModulated")]
        DualDeadbandSetpointModulated = 5,
        
        [JsonProperty("DualDeadbandSetpointOnOff")]
        DualDeadbandSetpointOnOff = 6,
        
        [JsonProperty("HeatingSetpointModulated")]
        HeatingSetpointModulated = 7,
        
        [JsonProperty("HeatingSetpointOnOff")]
        HeatingSetpointOnOff = 8,
        
        [JsonProperty("OperationSchemeModulated")]
        OperationSchemeModulated = 9,
        
        [JsonProperty("OperationSchemeOnOff")]
        OperationSchemeOnOff = 10,
        
        [JsonProperty("UncontrolledOn")]
        UncontrolledOn = 11,
    }
    
    public enum HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FreeCooling")]
        FreeCooling = 1,
        
        [JsonProperty("HeatRecovery")]
        HeatRecovery = 2,
        
        [JsonProperty("HeatRecoveryForCooling")]
        HeatRecoveryForCooling = 3,
        
        [JsonProperty("HeatRecoveryForHeating")]
        HeatRecoveryForHeating = 4,
        
        [JsonProperty("HeatRejection")]
        HeatRejection = 5,
        
        [JsonProperty("LoopToLoop")]
        LoopToLoop = 6,
    }
    
    public enum HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DryBulbTemperature")]
        DryBulbTemperature = 1,
        
        [JsonProperty("Loop")]
        Loop = 2,
        
        [JsonProperty("WetBulbTemperature")]
        WetBulbTemperature = 3,
    }
}
