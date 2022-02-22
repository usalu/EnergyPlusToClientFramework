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
}
