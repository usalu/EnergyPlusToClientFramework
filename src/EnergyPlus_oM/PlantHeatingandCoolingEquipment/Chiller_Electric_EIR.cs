using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("This chiller model is the empirical model from the DOE-2 building Energy simulati" +
                 "on program. Chiller performance at off-reference conditions is modeled using thr" +
                 "ee polynomial equations. Three curves objects are required.")]
    [JsonObject("Chiller:Electric:EIR")]
    public class Chiller_Electric_EIR : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("reference_capacity")]
        public string ReferenceCapacity { get; set; } = "";
        

        [Description("Efficiency of the chiller compressor (cooling output/compressor energy input). Co" +
                     "ndenser fan power should not be included here.")]
        [JsonProperty("reference_cop")]
        public System.Nullable<float> ReferenceCop { get; set; } = null;
        

        [JsonProperty("reference_leaving_chilled_water_temperature")]
        public System.Nullable<float> ReferenceLeavingChilledWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("6.67", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_entering_condenser_fluid_temperature")]
        public System.Nullable<float> ReferenceEnteringCondenserFluidTemperature { get; set; } = (System.Nullable<float>)Single.Parse("29.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_chilled_water_flow_rate")]
        public string ReferenceChilledWaterFlowRate { get; set; } = "";
        

        [Description("This field is only used for Condenser Type = AirCooled or EvaporativelyCooled whe" +
                     "n Heat Recovery is specified")]
        [JsonProperty("reference_condenser_fluid_flow_rate")]
        public string ReferenceCondenserFluidFlowRate { get; set; } = "";
        

        [Description("Cooling capacity as a function of CW supply temp and entering condenser temp curv" +
                     "e = a + b*CWS + c*CWS**2 + d*ECT + e*ECT**2 + f*CWS*ECT CWS = supply (leaving) c" +
                     "hilled water temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty("cooling_capacity_function_of_temperature_curve_name")]
        public string CoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Electric Input Ratio (EIR) as a function of temperature EIR = 1/COP curve = a + b" +
                     "*CWS + c*CWS**2 + d*ECT + e*ECT**2 + f*CWS*ECT CWS = supply (leaving) chilled wa" +
                     "ter temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty("electric_input_to_cooling_output_ratio_function_of_temperature_curve_name")]
        public string ElectricInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Electric Input Ratio (EIR) as a function of Part Load Ratio (PLR) EIR = 1/COP qua" +
                     "dratic curve = a + b*PLR + c*PLR**2 is typical, other univariate curves may be u" +
                     "sed PLR = part load ratio (cooling load/steady state capacity)")]
        [JsonProperty("electric_input_to_cooling_output_ratio_function_of_part_load_ratio_curve_name")]
        public string ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description("Part load ratio below which the chiller starts cycling on/off to meet the load. M" +
                     "ust be less than or equal to Maximum Part Load Ratio.")]
        [JsonProperty("minimum_part_load_ratio")]
        public System.Nullable<float> MinimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("Maximum allowable part load ratio. Must be greater than or equal to Minimum Part " +
                     "Load Ratio.")]
        [JsonProperty("maximum_part_load_ratio")]
        public System.Nullable<float> MaximumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Optimum part load ratio where the chiller is most efficient. Must be greater than" +
                     " or equal to the Minimum Part Load Ratio and less than or equal to the Maximum P" +
                     "art Load Ratio.")]
        [JsonProperty("optimum_part_load_ratio")]
        public System.Nullable<float> OptimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Part load ratio where the chiller can no longer unload and false loading begins. " +
                     "Minimum unloading ratio must be greater than or equal to the Minimum Part Load R" +
                     "atio and less than or equal to the Maximum Part Load Ratio.")]
        [JsonProperty("minimum_unloading_ratio")]
        public System.Nullable<float> MinimumUnloadingRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("chilled_water_inlet_node_name")]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("chilled_water_outlet_node_name")]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [Description("Not required if air-cooled or evaporatively-cooled")]
        [JsonProperty("condenser_inlet_node_name")]
        public string CondenserInletNodeName { get; set; } = "";
        

        [Description("Not required if air-cooled or evaporatively-cooled")]
        [JsonProperty("condenser_outlet_node_name")]
        public string CondenserOutletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_type")]
        public Chiller_Electric_EIR_CondenserType CondenserType { get; set; } = (Chiller_Electric_EIR_CondenserType)Enum.Parse(typeof(Chiller_Electric_EIR_CondenserType), "WaterCooled");
        

        [Description("Use for air-cooled or evaporatively-cooled condensers. Ratio of condenser fan pow" +
                     "er to reference chiller capacity")]
        [JsonProperty("condenser_fan_power_ratio")]
        public System.Nullable<float> CondenserFanPowerRatio { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Fraction of compressor electrical energy that must be rejected by the condenser. Enter a value of 1.0 when modeling hermetic chillers. For open chillers, enter the compressor motor efficiency. This value should be greater than 0.6 for practical applications.")]
        [JsonProperty("fraction_of_compressor_electric_consumption_rejected_by_condenser")]
        public System.Nullable<float> FractionOfCompressorElectricConsumptionRejectedByCondenser { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("leaving_chilled_water_lower_temperature_limit")]
        public System.Nullable<float> LeavingChilledWaterLowerTemperatureLimit { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"Select operating mode for fluid flow through the chiller. ""NotModulated"" is for either variable or constant pumping with flow controlled by the external plant system. ""ConstantFlow"" is for constant pumping with flow controlled by chiller to operate at full design flow rate. ""LeavingSetpointModulated"" is for variable pumping with flow controlled by chiller to vary flow to target a leaving temperature setpoint.")]
        [JsonProperty("chiller_flow_mode")]
        public Chiller_Electric_EIR_ChillerFlowMode ChillerFlowMode { get; set; } = (Chiller_Electric_EIR_ChillerFlowMode)Enum.Parse(typeof(Chiller_Electric_EIR_ChillerFlowMode), "NotModulated");
        

        [Description("If non-zero, then the heat recovery inlet and outlet node names must be entered. " +
                     "Heat recovery is only available with Condenser Type = WaterCooled.")]
        [JsonProperty("design_heat_recovery_water_flow_rate")]
        public string DesignHeatRecoveryWaterFlowRate { get; set; } = (System.String)"0";
        

        [JsonProperty("heat_recovery_inlet_node_name")]
        public string HeatRecoveryInletNodeName { get; set; } = "";
        

        [JsonProperty("heat_recovery_outlet_node_name")]
        public string HeatRecoveryOutletNodeName { get; set; } = "";
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the chiller is not operating.")]
        [JsonProperty("basin_heater_capacity")]
        public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty("basin_heater_setpoint_temperature")]
        public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty("basin_heater_operating_schedule_name")]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

        [Description("This optional field is the fraction of total rejected heat that can be recovered " +
                     "at full load")]
        [JsonProperty("condenser_heat_recovery_relative_capacity_fraction")]
        public System.Nullable<float> CondenserHeatRecoveryRelativeCapacityFraction { get; set; } = null;
        

        [Description("This optional schedule of temperatures will turn off heat recovery if inlet excee" +
                     "ds the value")]
        [JsonProperty("heat_recovery_inlet_high_temperature_limit_schedule_name")]
        public string HeatRecoveryInletHighTemperatureLimitScheduleName { get; set; } = "";
        

        [Description("This optional field provides control over the heat recovery Using this triggers a" +
                     " model more suited to series bundle and chillers with higher temperature heat re" +
                     "covery If this field is not used, the bundles are modeled as being in parallel")]
        [JsonProperty("heat_recovery_leaving_temperature_setpoint_node_name")]
        public string HeatRecoveryLeavingTemperatureSetpointNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}